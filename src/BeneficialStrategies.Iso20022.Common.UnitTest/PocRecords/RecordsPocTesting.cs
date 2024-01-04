using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using Xunit.Abstractions;
using System.Xml.Schema;
using System.Xml.Linq;
using System.Reflection;
using Microsoft.VisualBasic;

namespace BeneficialStrategies.Iso20022.Common.PocRecords;

//<InitgPty>
//	<Nm>Virgay</Nm>
//	<PstlAdr>
//		<StrtNm>Virginia Lane</StrtNm>
//		<BldgNb>36</BldgNb>
//		<PstCd>NJ 07311</PstCd>
//		<TwnNm>Jersey City</TwnNm>
//		<Ctry>US</Ctry>
//	</PstlAdr>
//	<CtctDtls>
//		<Nm>J.Thompson</Nm>
//		<EmailAdr>Thompson @virgay.com</EmailAdr>
//	</CtctDtls>
//</InitgPty>

public class RecordsPocTesting
{
    private readonly ITestOutputHelper _output;

    private readonly InitiatingPartyRec SampleRec = new InitiatingPartyRec
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

    private string CstmrCdtTrfInitnText = @"
    <CstmrCdtTrfInitn>
	<GrpHdr>
		<MsgId>ABC/120928/CCT001</MsgId>
		<CreDtTm>2012-09-28T14:07:00</CreDtTm>
		<NbOfTxs>3</NbOfTxs>
		<CtrlSum>11500000</CtrlSum>
		<InitgPty>
			<Nm>ABC Corporation</Nm>
			<PstlAdr>
				<StrtNm>Times Square</StrtNm>
				<BldgNb>7</BldgNb>
				<PstCd>NY 10036</PstCd>
				<TwnNm>New York</TwnNm>
				<Ctry>US</Ctry>
			</PstlAdr>
		</InitgPty>
	</GrpHdr>
	<PmtInf>
		<PmtInfId>ABC/086</PmtInfId>
		<PmtMtd>TRF</PmtMtd>
		<BtchBookg>false</BtchBookg>
		<ReqdExctnDt>
			<Dt>2012-09-29</Dt>
		</ReqdExctnDt>
		<Dbtr>
			<Nm>ABC Corporation</Nm>
			<PstlAdr>
				<StrtNm>Times Square</StrtNm>
				<BldgNb>7</BldgNb>
				<PstCd>NY 10036</PstCd>
				<TwnNm>New York</TwnNm>
				<Ctry>US</Ctry>
			</PstlAdr>
		</Dbtr>
		<DbtrAcct>
			<Id>
				<Othr>
					<Id>00125574999</Id>
				</Othr>
			</Id>
		</DbtrAcct>
		<DbtrAgt>
			<FinInstnId>
				<BICFI>BBBBUS33</BICFI>
			</FinInstnId>
		</DbtrAgt>
		<CdtTrfTxInf>
			<PmtId>
				<InstrId>ABC/120928/CCT001/01</InstrId>
				<EndToEndId>ABC/4562/2012-09-08</EndToEndId>
			</PmtId>
			<Amt>
				<InstdAmt Ccy=""JPY"">10000000</InstdAmt>
			</Amt>
			<ChrgBr>SHAR</ChrgBr>
			<CdtrAgt>
				<FinInstnId>
					<BICFI>AAAAGB2L</BICFI>
				</FinInstnId>
			</CdtrAgt>
			<Cdtr>
				<Nm>DEF Electronics</Nm>
				<PstlAdr>
					<AdrLine>Corn Exchange 5th Floor</AdrLine>
					<AdrLine>Mark Lane 55</AdrLine>
					<AdrLine>EC3R7NE London</AdrLine>
					<AdrLine>GB</AdrLine>
				</PstlAdr>
			</Cdtr>
			<CdtrAcct>
				<Id>
					<Othr>
						<Id>23683707994125</Id>
					</Othr>
				</Id>
			</CdtrAcct>
			<Purp>
				<Cd>GDDS</Cd>
			</Purp>
			<RmtInf>
				<Strd>
					<RfrdDocInf>
						<Tp>
							<CdOrPrtry>
								<Cd>CINV</Cd>
							</CdOrPrtry>
						</Tp>
						<Nb>4562</Nb>
						<RltdDt>2012-09-08</RltdDt>
					</RfrdDocInf>
				</Strd>
			</RmtInf>
		</CdtTrfTxInf>
		<CdtTrfTxInf>
			<PmtId>
				<InstrId>ABC/120928/CCT001/2</InstrId>
				<EndToEndId>ABC/ABC-13679/2012-09-15</EndToEndId>
			</PmtId>
			<Amt>
				<InstdAmt Ccy=""EUR"">500000</InstdAmt>
			</Amt>
			<ChrgBr>CRED</ChrgBr>
			<CdtrAgt>
				<FinInstnId>
					<BICFI>DDDDBEBB</BICFI>
				</FinInstnId>
			</CdtrAgt>
			<Cdtr>
				<Nm>GHI Semiconductors</Nm>
				<PstlAdr>
					<StrtNm>Avenue Brugmann</StrtNm>
					<BldgNb>415</BldgNb>
					<PstCd>1180</PstCd>
					<TwnNm>Brussels</TwnNm>
					<Ctry>BE</Ctry>
				</PstlAdr>
			</Cdtr>
			<CdtrAcct>
				<Id>
					<IBAN>BE30001216371411</IBAN>
				</Id>
			</CdtrAcct>
			<InstrForCdtrAgt>
				<Cd>PHOB</Cd>
				<InstrInf>+32/2/2222222</InstrInf>
			</InstrForCdtrAgt>
			<Purp>
				<Cd>GDDS</Cd>
			</Purp>
			<RmtInf>
				<Strd>
					<RfrdDocInf>
						<Tp>
							<CdOrPrtry>
								<Cd>CINV</Cd>
							</CdOrPrtry>
						</Tp>
						<Nb>ABC-13679</Nb>
						<RltdDt>2012-09-15</RltdDt>
					</RfrdDocInf>
				</Strd>
			</RmtInf>
		</CdtTrfTxInf>
		<CdtTrfTxInf>
			<PmtId>
				<InstrId>ABC/120928/CCT001/3</InstrId>
				<EndToEndId>ABC/987-AC/2012-09-27</EndToEndId>
			</PmtId>
			<Amt>
				<InstdAmt Ccy=""USD"">1000000</InstdAmt>
			</Amt>
			<ChrgBr>SHAR</ChrgBr>
			<CdtrAgt>
				<FinInstnId>
					<BICFI>BBBBUS66</BICFI>
				</FinInstnId>
			</CdtrAgt>
			<Cdtr>
				<Nm>ABC Corporation</Nm>
				<PstlAdr>
					<Dept>Treasury department</Dept>
					<StrtNm>Bush Street</StrtNm>
					<BldgNb>13</BldgNb>
					<PstCd>CA 94108</PstCd>
					<TwnNm>San Francisco</TwnNm>
					<Ctry>US</Ctry>
				</PstlAdr>
			</Cdtr>
			<CdtrAcct>
				<Id>
					<Othr>
						<Id>4895623</Id>
					</Othr>
				</Id>
			</CdtrAcct>
			<Purp>
				<Cd>INTC</Cd>
			</Purp>
			<RmtInf>
				<Strd>
					<RfrdDocInf>
						<Tp>
							<CdOrPrtry>
								<Cd>CINV</Cd>
							</CdOrPrtry>
						</Tp>
						<Nb>987-AC</Nb>
						<RltdDt>2012-09-27</RltdDt>
					</RfrdDocInf>
				</Strd>
			</RmtInf>
		</CdtTrfTxInf>
	</PmtInf>
</CstmrCdtTrfInitn>
    ";
//     private readonly string SampleRecText = @"
//         <InitgPty>
// 	        <Nm>Virgay</Nm>
// 	        <PstlAdr>
// 		        <StrtNm>Virginia Lane</StrtNm>
// 		        <BldgNb>36</BldgNb>
// 		        <PstCd>NJ 07311</PstCd>
// 		        <TwnNm>Jersey City</TwnNm>
// 		        <Ctry>US</Ctry>
// 	        </PstlAdr>
// 	        <CtctDtls>
// 		        <Nm>J.Thompson</Nm>
// 		        <EmailAdr>Thompson@virgay.com</EmailAdr>
// 	        </CtctDtls>
//         </InitgPty>
// ";

    public RecordsPocTesting(ITestOutputHelper testOutputHelper)
    {
        _output = testOutputHelper;
    }
    
    [Fact]
    public void FiddleWithXmlSchema()
    {
        // /Users/jeff/Downloads/archive_payments_initiation_13_8f7df3aca7/pain.001.001.11.xsd
        // src/BeneficialStrategies.Iso20022.Common.UnitTest/Schema/pain.001.001.11.xsd

        //var schemaLocation = "/Users/jeff/dev/dotnet/iso20022/src/BeneficialStrategies.Iso20022.Common.UnitTest/Schema/pain.001.001.11.xsd";
        var schemaNamespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.11";

        var schemas = new Iso20022SchemaSet();
        // schemas.Add(null, schemaLocation);
        
        var doc = XDocument.Parse(@$"
        <Document xmlns=""{schemaNamespace}"">
            {CstmrCdtTrfInitnText}
        </Document>");
        bool valid = true;
        doc.Validate(schemas, (o, e) => {
            _output.WriteLine($"{e.Severity} : {e.Message}");
            valid = false;
        });
        if ( !valid ) Assert.Fail("Validation failed");
    }

    [Fact(DisplayName = "Get embedded Resource data", Timeout = 2000)]
    public void GetEmbeddedResource()
    {
        // Assembly assembly = this.GetType().Assembly ?? throw new InvalidOperationException("Could not get a reference to the executing assembly");
        // var fileName = "pain.001.001.11.xsd";
        // var relativePath = "Schema";
        // var namespacePrefixOnPath = assembly?.EntryPoint?.DeclaringType?.Namespace ?? "BeneficialStrategies.Iso20022.Common";
        // var resourceName = $"{namespacePrefixOnPath}.{relativePath}.{fileName}";
        // var resourceStream = assembly.GetManifestResourceStream(resourceName);
        // var xsdResources = Assembly.GetExecutingAssembly().GetManifestResourceNames().Where( n => n.ToLowerInvariant().EndsWith(".xsd"));
        // Assert.True(xsdResources.Count() > 0, "Count should be >0");
        // foreach(var resource in System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceNames())
        //     _output.WriteLine($"{resource}\r\n");
        // _output.WriteLine($"{resourceName}  <<-----");
        // Assert.NotNull(resourceStream);
    }

    [Fact]
    public void InstanceSchemaSet()
    {
        var ss = new Iso20022SchemaSet();
        Assert.True(ss.Schemas().Count == 4);
    }
   

    // [Fact]
    // public async Task BasicSerialization()
    // {
    //     var party = SampleRec with { Name = "Virgay2" };

    //     _output.WriteLine(party.ToString());

    //     var sb = new StringBuilder();
    //     using (var xmlWriter = XmlWriter.Create(sb, new XmlWriterSettings { Indent = true, OmitXmlDeclaration = true, Async = true }))
    //     {
    //         await party.SerializeAsync(xmlWriter);
    //         xmlWriter.Flush();
    //     }
    //     _output.WriteLine(sb.ToString());

    //     await SampleRec.AssertSerializationMatchesArtifact(SampleRecText, _output);

    //     // Now for Deserialization

    //     // using (var XmlReader = new XmlReader())
    // }

    // [Fact]
    // public async Task RoundtripMustWork()
    // {
    //     await SampleRec.AssertSerializationRoundTripWorks(_output);
    // }

    // [Fact]
    // public async Task BasicDeserialization()
    // {
    //     using var stringReader = new StringReader(SampleRecText);
    //     using var xmlReader = XmlReader.Create(stringReader, new XmlReaderSettings { Async = true });
    //     var copy = await InitiatingPartyRec.DeserializeAsync(xmlReader);
    //     Assert.Equal("Virgay", copy.Name);
    //     Assert.Equal("J.Thompson", copy.ContactDetails.Name);
    //     Assert.Equal("Thompson@virgay.com", copy.ContactDetails.Email);
    //     Assert.Equal("Virginia Lane", copy.PostalAddress.StreetName);
    //     Assert.Equal(SampleRec, copy);
    // }
}

public class Iso20022XmlNameTable : NameTable
{
    public Iso20022XmlNameTable() : base()
    {
    } 
}

public class Iso20022SchemaSet : XmlSchemaSet
{
    public Iso20022SchemaSet() : base(new Iso20022XmlNameTable())
    {
        var assembly = Assembly.GetExecutingAssembly();
        var xsdResources = assembly.GetManifestResourceNames().Where( n => n.ToLowerInvariant().EndsWith(".xsd"));
        foreach(var resourceName in xsdResources)
        {
            using Stream stream = assembly.GetManifestResourceStream(resourceName) ?? throw new FileNotFoundException(resourceName);
            using var schemaReader = XmlReader.Create(stream);
            Add(null, schemaReader);
        }
    }
}
