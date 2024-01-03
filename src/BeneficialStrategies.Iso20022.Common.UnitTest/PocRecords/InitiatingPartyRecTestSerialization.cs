namespace BeneficialStrategies.Iso20022.Common.PocRecords;

public class InitiatingPartyRecTestSerialization : TestSerialization<InitiatingPartyRec>
{
    protected override InitiatingPartyRec Sample => new InitiatingPartyRec
    {
        Name = "Virgay",
        PostalAddress = new PostalAddresRec
        {
            StreetName = "Virginia Lane",
            BuildingNumber = "36",
            PostalCode = "NJ 07311",
            TownName = "Jersey City",
            Country = "US"
        },
        ContactDetails = new ContactDetailsRec
        {
            Name = "J.Thompson",
            Email = "Thompson@virgay.com"
        }
    };

    protected override string ExpectedSampleXml => @"
        <InitgPty>
	        <Nm>Virgay</Nm>
	        <PstlAdr>
		        <StrtNm>Virginia Lane</StrtNm>
		        <BldgNb>36</BldgNb>
		        <PstCd>NJ 07311</PstCd>
		        <TwnNm>Jersey City</TwnNm>
		        <Ctry>US</Ctry>
	        </PstlAdr>
	        <CtctDtls>
		        <Nm>J.Thompson</Nm>
		        <EmailAdr>Thompson@virgay.com</EmailAdr>
	        </CtctDtls>
        </InitgPty>
";
}

