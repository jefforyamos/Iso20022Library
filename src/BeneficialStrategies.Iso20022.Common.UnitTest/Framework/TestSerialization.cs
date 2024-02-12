using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.pain;
using Xunit.Abstractions;

namespace BeneficialStrategies.Iso20022.Framework;

public abstract class TestSerialization<T>
    where T : Iso20022Certified<T>
{
    /// <summary>
    /// Use this to write test output rather than Console.
    /// </summary>
    protected ITestOutputHelper? Output;

    public TestSerialization(ITestOutputHelper? testOutputHelper = null)
    {
        Output = testOutputHelper;
    }

    /// <summary>
    /// This example is used for input to most tests.
    /// </summary>
    protected abstract T Sample { get; }

    /// <summary>
    /// String value matching XML that should be rendered by the <seealso cref="Sample"/>.
    /// </summary>
    protected abstract string ExpectedSampleXml { get; }

    [Fact(DisplayName = "_Test fixture naming")]
    public void TestFixtureNaming()
    {
        var expectedName = $"{typeof(T).Name}TestSerialization";
        Assert.Equal(expectedName, GetType().Name);
    }

    // [Fact(DisplayName = "ISO Serialize")]
    // public async Task IsoSerialize()
    // {
    //     await Sample.AssertSerializationMatchesArtifact(ExpectedSampleXml, Output);
    // }

    // [Fact(DisplayName = "ISO Round-Trip")]
    // public async Task IsoRoundTrip()
    // {
    //     await Sample.AssertSerializationRoundTripWorks(Output);
    // }

    [Fact(DisplayName = "JsonSerializer Round-Trip (System.Text.Json)")]
    public async Task SystemTextJsonRoundTrip()
    {
        await Sample.AssertJsonSerializationRoundTrip(Output);
    }

    [Fact(DisplayName = "BinaryFormatter dangerous, disabled")]
    public void BinaryFormatterRoundTrip()
    {
        Assert.Throws<NotSupportedException>(() =>  
            Sample.AssertBinaryFormatterRoundTrip(Output) 
        );
    }

    [Fact(DisplayName = "DataContractSerializer Round-Trip")]
    public void DataContractSerializerRoundTrip()
    {
        Sample.AssertDataContractSerializerRoundTrip(Output);
    }

    [Fact(DisplayName = "DataContractSerializer ISO20022 Deserialize")]
    public void DataContractSerializerIso20022Deserialize()
    {
        Sample.AssertDataContractSerializerDeserializesValidISO20022(ExpectedSampleXml, Output);
    }

    [Fact(DisplayName = "XmlSerializer Round-Trip")]
    public void XmlSerializerRoundTrip()
    {
        Sample.AssertXmlSerializerRoundTrip(Output);
    }

    [Fact(DisplayName = "XmlSerializer ISO20022 Deserialize")]
    public void XmlSerializerIso20022Deserialize()
    {
        Sample.AssertXmlSerializerDeserializesValidIso20022(ExpectedSampleXml, Output);
    }
}

public interface IBeneficialXmlWriter<TValue>
{
    Task WriteAsync(XmlWriter writer, TValue value, string isoNamespace);
}

// public interface IMemberDataStateXmlWriter<TMember> 
// {
//     Task WriteAsync(XmlWriter writer, TMember member);
// }

public class MemberWriter<TParent, TMember> : IBeneficialXmlWriter<TParent>
{
    private readonly string elementName;
    private readonly IBeneficialXmlWriter<TMember> dataStateWriter;
    private readonly Func<TParent, TMember?> propertyGetter;

    public MemberWriter(string elementName, IBeneficialXmlWriter<TMember> dataStateWriter, Func<TParent,TMember?> propertyGetter)
    {
        this.elementName = elementName;
        this.dataStateWriter = dataStateWriter;
        this.propertyGetter = propertyGetter;
    }

    public async Task WriteAsync(XmlWriter writer, TParent parent, string isoNamespace)
    {
        var optionalValue = propertyGetter(parent);
        if ( optionalValue is TMember nonNullValue)
        {
            await writer.WriteStartElementAsync(null, this.elementName,isoNamespace);
            await dataStateWriter.WriteAsync(writer, nonNullValue, isoNamespace);
            await writer.WriteEndElementAsync();
        }
    }
}


public abstract class ContainerWriter<TParent> : IBeneficialXmlWriter<TParent>
{
    private readonly IBeneficialXmlWriter<TParent>[] memberWriters;

    protected ContainerWriter(params IBeneficialXmlWriter<TParent>[] memberWriters)
    {
        this.memberWriters = memberWriters;
    }

    public async Task WriteAsync(XmlWriter writer, TParent value, string isoNamespace)
    {
        foreach( var memberWriter in memberWriters) await memberWriter.WriteAsync(writer,value,isoNamespace);
    }
}


public class CustomerCreditTransferInitiationV11Serializer : ContainerWriter<CustomerCreditTransferInitiationV11>
{
    public CustomerCreditTransferInitiationV11Serializer(
        // Dependency injection of subordinate writers
        IBeneficialXmlWriter<GroupHeader95> groupHeader95writer,
        IBeneficialXmlWriter<PaymentInstruction40> paymentInstructionWriter,
        IBeneficialXmlWriter<SupplementaryData1> supplementalWriter
    )
    : base( 
        new MemberWriter<CustomerCreditTransferInitiationV11, GroupHeader95>
        ( 
                "Gphdr", 
                groupHeader95writer,
                parent => parent.GroupHeader
        ),
        new MemberWriter<CustomerCreditTransferInitiationV11,PaymentInstruction40>
        (
                "PmtInstr",
                paymentInstructionWriter,
                parent => parent.PaymentInformation
        ),
        new MemberWriter<CustomerCreditTransferInitiationV11,SupplementaryData1>
        (
            "Supp",
            supplementalWriter,
            parent => parent.SupplementaryData
        )
    )
    {
    }
}

public class NullableIsoXmlWriter<T> : IBeneficialXmlWriter<T?>
    where T : struct
{
    private readonly IBeneficialXmlWriter<T> nonNullableWriter;

    public NullableIsoXmlWriter(IBeneficialXmlWriter<T> nonNullableWriter)
    {
        this.nonNullableWriter = nonNullableWriter;
    }

    public async Task WriteAsync(XmlWriter writer, T? value, string isoNamespace)
    {
        if ( value is T populatedValue) await this.nonNullableWriter.WriteAsync(writer,populatedValue,isoNamespace);
    }
}

// Need SimpleMemberWriter, NullableMemberWriter


