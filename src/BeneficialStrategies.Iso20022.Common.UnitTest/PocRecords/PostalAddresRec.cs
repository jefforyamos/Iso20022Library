using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using BeneficialStrategies.Iso20222.Common;


namespace BeneficialStrategies.Iso20022.Common.PocRecords;

// https://www.iso20022.org/standardsrepository/type/PostalAddress1

// From an example found in an analysis document.  
//	<PstlAdr>
//		<StrtNm>Virginia Lane</StrtNm>
//		<BldgNb>36</BldgNb>
//		<PstCd>NJ 07311</PstCd>
//		<TwnNm>Jersey City</TwnNm>
//		<Ctry>US</Ctry>
//	</PstlAdr>

[DataContract(Name = "PstlAdr", Namespace ="")]
[XmlRoot(ElementName = "PstlAdr", Namespace = "")]
public record PostalAddresRec() : Iso20022Certified<PostalAddresRec>
{
    [DataMember(Name ="AdrTp", Order = 0)]
    [XmlElement(ElementName = "AdrTp", Order = 0)]
    public AddressType2Code? AddressType { get; init; }

    [DataMember(Name ="AdrLine", Order = 1)]
    [XmlElement(ElementName = "AdrLine", Order = 1)]
    public Max70Text? AddressLine { get; init; }

    [DataMember(Name = "StrtNm", Order = 2)]
    [XmlElement(ElementName = "StrtNm", Order = 2)]
    public required Max70Text? StreetName { get; init; }

    [DataMember(Name = "BldgNb", Order = 3)]
    [XmlElement(ElementName = "BldgNb", Order =3)]
    public required Max16Text? BuildingNumber { get; init; }

    [DataMember(Name = "PstCd", Order = 4)]
    [XmlElement(ElementName = "PstCd", Order = 4)]
    public required Max16Text? PostalCode { get; init; }

    [DataMember(Name ="TwnNm", Order = 5)]
    [XmlElement(ElementName = "TwnNm", Order = 5)]
    public required Max35Text? TownName { get; init; }

    [DataMember(Name ="TwnLctnNm", Order = 6)]
    [XmlElement(ElementName = "TwnLctnNm", Order = 6)]
    public Max35Text? CountrySubDivision { get; init; }

    [DataMember(Name = "Ctry", Order = 7)]
    [XmlElement(ElementName = "Ctry", Order = 7)]
    public required CountryCode Country { get; init; }
}

