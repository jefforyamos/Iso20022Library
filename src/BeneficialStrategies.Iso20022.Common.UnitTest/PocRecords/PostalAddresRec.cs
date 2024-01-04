using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using Helper = BeneficialStrategies.Iso20022.Common.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.Common.PocRecords.PostalAddresRec>;


namespace BeneficialStrategies.Iso20022.Common.PocRecords;

//	<PstlAdr>
//		<StrtNm>Virginia Lane</StrtNm>
//		<BldgNb>36</BldgNb>
//		<PstCd>NJ 07311</PstCd>
//		<TwnNm>Jersey City</TwnNm>
//		<Ctry>US</Ctry>
//	</PstlAdr>

[DataContract(Name = "PstlAdr", Namespace ="")]
[XmlRoot(ElementName = "PstlAdr", Namespace = "")]
public record PostalAddresRec() : IIsoXmlSerilizable<PostalAddresRec>
{
    [DataMember(Name = "StrtNm", Order = 0)]
    [XmlElement(ElementName = "StrtNm", Order = 0)]
    public required string StreetName { get; init; }

    [DataMember(Name = "BldgNb", Order = 1)]
    [XmlElement(ElementName = "BldgNb", Order =1)]
    public required string BuildingNumber { get; init; }

    [DataMember(Name = "PstCd", Order = 2)]
    [XmlElement(ElementName = "PstCd", Order = 2)]
    public required string PostalCode { get; init; }

    [DataMember(Name ="TwnNm", Order = 3)]
    [XmlElement(ElementName = "TwnNm", Order = 3)]
    public required string TownName { get; init; }

    [DataMember(Name = "Ctry", Order = 4)]
    [XmlElement(ElementName = "Ctry", Order = 4)]
    public required string Country { get; init; }

    public static XName RootElement => Helper.CreateXName("PstlAdr");

    public static class MemberNames
    {
        public static readonly XName StreetName = Helper.CreateXName("StrtNm");
        public static readonly XName BuildingNumber = Helper.CreateXName("BldgNb");
        public static readonly XName PostalCode = Helper.CreateXName("PstCd");
        public static readonly XName TownName = Helper.CreateXName("TwnNm");
        public static readonly XName Country = Helper.CreateXName("Ctry");
    }

    public static PostalAddresRec Deserialize(XElement element)
    {
        return new PostalAddresRec()
        {
            StreetName = Helper.GetStringValue(element, MemberNames.StreetName),
            BuildingNumber = Helper.GetStringValue(element, MemberNames.BuildingNumber),
            PostalCode = Helper.GetStringValue(element, MemberNames.PostalCode),
            TownName = Helper.GetStringValue(element, MemberNames.TownName),
            Country = Helper.GetStringValue(element, MemberNames.Country),
        };
    }

    public static async Task<PostalAddresRec> DeserializeAsync(XmlReader reader)
    {
        return await Helper.DeserializeAsync(reader);
    }

    public async Task SerializeAsync(XmlWriter writer)
    {
        await Helper.WriteStartElementAsync(writer, RootElement);
        await Helper.WriteElementStringAsync(writer, MemberNames.StreetName, StreetName);
        await Helper.WriteElementStringAsync(writer, MemberNames.BuildingNumber, BuildingNumber);
        await Helper.WriteElementStringAsync(writer, MemberNames.PostalCode, PostalCode);
        await Helper.WriteElementStringAsync(writer, MemberNames.TownName, TownName);
        await Helper.WriteElementStringAsync(writer, MemberNames.Country, Country);
        await Helper.WriteEndElementAsync(writer);
    }
}

