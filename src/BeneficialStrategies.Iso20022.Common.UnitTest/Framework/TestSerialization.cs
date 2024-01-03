using Xunit.Abstractions;

namespace BeneficialStrategies.Iso20022.Common.Framework;

public abstract class TestSerialization<T>
    where T : IIsoXmlSerilizable<T>
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

    [Fact(DisplayName = "Test fixture naming")]
    public void TestFixtureNaming()
    {
        var expectedName = $"{typeof(T).Name}TestSerialization";
        Assert.Equal(expectedName, GetType().Name);
    }

    [Fact(DisplayName = "Serialization ISO Serialize")]
    public async Task SerializeIsoSerialize()
    {
        await Sample.AssertSerializationMatchesArtifact(ExpectedSampleXml, Output);
    }

    [Fact(DisplayName = "Serialization ISO Round-Trip")]
    public async Task SerializeIsoRoundTrip()
    {
        await Sample.AssertSerializationRoundTripWorks(Output);
    }

    [Fact(DisplayName = "Serialization JsonSerializer Round-Trip (System.Text.Json)")]
    public async Task SerializeSystemTextJsonRoundTrip()
    {
        await Sample.AssertJsonSerializationRoundTrip(Output);
    }
}

