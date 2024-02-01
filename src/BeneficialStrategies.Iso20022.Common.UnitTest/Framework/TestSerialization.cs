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

