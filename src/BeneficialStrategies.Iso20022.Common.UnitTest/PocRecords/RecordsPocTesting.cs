﻿using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using Xunit.Abstractions;
using System.Xml.Schema;
using System.Xml.Linq;
using System.Reflection;
using Microsoft.VisualBasic;
using BeneficialStrategies.Iso20022.SchemaValidation;
using System.Runtime.Serialization.DataContracts;
using Xunit.Sdk;
using System.Xml.Serialization;
using System.Numerics;
using System.Globalization;
using System.Diagnostics.CodeAnalysis;

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

    public RecordsPocTesting(ITestOutputHelper testOutputHelper)
    {
        _output = testOutputHelper;
    }
    
    [Fact]
    public void FiddleWithXmlSchema()
    {
        // /Users/jeff/Downloads/archive_payments_initiation_13_8f7df3aca7/pain.001.001.11.xsd
        // src/BeneficialStrategies.Iso20022.Common.UnitTest/Schema/pain.001.001.11.xsd

        var schemaNamespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.11";

        var schemas = new Iso20022SchemaSet();

        schemas.AssertNoIsoValidateErrors(schemaNamespace, CstmrCdtTrfInitnText, _output);

        // Assert.True(schemas.NameTable.Get(schemaNamespace) != null, $"The namespace {0} is not contained here.");

        // var doc = XDocument.Parse(@$"
        // <Document xmlns=""{schemaNamespace}"">
        //     {CstmrCdtTrfInitnText}
        // </Document>");
        // bool valid = true;
        // doc.Validate(schemas, (o, e) => {
        //     _output.WriteLine($"{e.Severity} : {e.Message}");
        //     valid = false;
        // });
        // if ( !valid ) Assert.Fail("Validation failed");
    }

    [Fact]
    public void InstanceSchemaSet()
    {
        var ss = new Iso20022SchemaSet();
        ss.Compile();
        Assert.True(ss.IsCompiled, "Must be compiled");
        Assert.True(ss.Schemas().Count >= 4);
    }

   	// <topLevelDictionaryEntry xsi:type="iso20022:ChoiceComponent" xmi:id="_rQn0cJBrEeaGiLsfv6g8MA" name="DateFormat42Choice" definition="Choice of formats for a date." registrationStatus="Registered">
    //   <messageElement xsi:type="iso20022:MessageAttribute" xmi:id="_xXmZwpBrEeaGiLsfv6g8MA" name="YearMonth" definition="Year and month." registrationStatus="Provisionally Registered" maxOccurs="1" minOccurs="1" xmlTag="YrMnth" businessElementTrace="_FiqwYMTGEeChad0JzLk7QA_-260170499" isDerived="false" simpleType="_YYU64tp-Ed-ak6NoX_4Aeg_-1824134999"/>
    //   <messageElement xsi:type="iso20022:MessageAttribute" xmi:id="_xXmZw5BrEeaGiLsfv6g8MA" name="YearMonthDay" definition="Year, month and day." registrationStatus="Provisionally Registered" maxOccurs="1" minOccurs="1" xmlTag="YrMnthDay" businessElementTrace="_FiqwYMTGEeChad0JzLk7QA_-260170499" isDerived="false" simpleType="_YXSZFtp-Ed-ak6NoX_4Aeg_2032498111"/>
    // </topLevelDictionaryEntry>
 
	// [DataContract]
	// [Serializable]
	private struct YearMonth : IXmlSerializable
    {

        [DataMember]
		public required UInt16 Year { get; init;}

		[DataMember]
		public required byte Month { get; init;}

        // private UInt32 Value 
        // {
        // 	get
        // 	{
        // 		return (UInt32) Year * 100 + Month;
        // 	}
        // }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }

        public XmlSchema? GetSchema()
        {
            throw new NotImplementedException();
        }

        public void ReadXml(XmlReader reader)
        {
            throw new NotImplementedException();
        }

        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            throw new NotImplementedException();
        }

        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
   }

	[Fact]
	public void ShouldSerializeMyStruct()
	{
		DataContractSerializer ser = new DataContractSerializer(typeof(YearMonth));
		var original = new YearMonth{ Year = 2023, Month = 11};
		var memoryStream = new MemoryStream();
		ser.WriteObject(memoryStream, original);
		memoryStream.Position = 0;
		var stringReader = new StreamReader( memoryStream);
		var contents = stringReader.ReadToEnd();
		memoryStream.Position = 0;
		var copyObj = ser.ReadObject(memoryStream) ?? throw new InvalidCastException("Failed to deserialize");
		YearMonth copy = (YearMonth) copyObj;
		Assert.Equal( original.Year, copy.Year);
		Assert.Equal(original.Month, copy.Month);
	}
}
