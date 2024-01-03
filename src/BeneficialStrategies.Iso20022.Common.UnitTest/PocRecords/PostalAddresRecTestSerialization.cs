using Xunit.Abstractions;

namespace BeneficialStrategies.Iso20022.Common.PocRecords;

public class PostalAddresRecTestSerialization : TestSerialization<PostalAddresRec>
{
    public PostalAddresRecTestSerialization(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
    {
    }
    protected override PostalAddresRec Sample => new PostalAddresRec
    {
        StreetName = "Virginia Lane",
        BuildingNumber = "36",
        PostalCode = "NJ 07311",
        TownName = "Jersey City",
        Country = "US"
    };

    protected override string ExpectedSampleXml => @"
	<PstlAdr>
		<StrtNm>Virginia Lane</StrtNm>
		<BldgNb>36</BldgNb>
		<PstCd>NJ 07311</PstCd>
		<TwnNm>Jersey City</TwnNm>
		<Ctry>US</Ctry>
	</PstlAdr>
";
}

