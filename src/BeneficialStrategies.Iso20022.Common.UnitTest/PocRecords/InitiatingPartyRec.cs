using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Serialization;

namespace BeneficialStrategies.Iso20022.PocRecords;

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


[DataContract(Name = "InitgPty", Namespace ="")]
[XmlRoot(ElementName ="InitgPty", Namespace = "")]
public record InitiatingPartyRec
    : Iso20022Certified<InitiatingPartyRec>
{
    [DataMember(Name = "Nm", Order = 0)]
    [XmlElement(ElementName = "Nm", Order = 0)]
    public required string Name { get; init; }

    [DataMember(Name = "PstlAdr", Order = 1)]
    [XmlElement(ElementName ="PstlAdr", Order = 1)]
    public required PostalAddresRec PostalAddress { get; init; }

    [DataMember(Name = "CtctDtls", Order = 2)]
    [XmlElement(ElementName ="CtctDtls", Order =2 )]
    public required ContactDetailsRec ContactDetails { get; init; }
}

