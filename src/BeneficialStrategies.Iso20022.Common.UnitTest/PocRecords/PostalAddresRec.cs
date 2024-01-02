﻿using System.Xml;
using System.Xml.Linq;
using Helper = BeneficialStrategies.Iso20022.Common.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.Common.PostalAddresRec>;


namespace BeneficialStrategies.Iso20022.Common;

//	<PstlAdr>
//		<StrtNm>Virginia Lane</StrtNm>
//		<BldgNb>36</BldgNb>
//		<PstCd>NJ 07311</PstCd>
//		<TwnNm>Jersey City</TwnNm>
//		<Ctry>US</Ctry>
//	</PstlAdr>

public record PostalAddresRec() : IIsoXmlSerilizable<PostalAddresRec>
{
    public required string StreetName;
    public required string BuildingNumber;
    public required string PostalCode;
    public required string TownName;
    public required string Country;

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
        await writer.WriteStartElementAsync(null, RootElement.LocalName, null);
        await Helper.WriteElementStringAsync(writer, MemberNames.StreetName, StreetName);
        await Helper.WriteElementStringAsync(writer, MemberNames.BuildingNumber, BuildingNumber);
        await Helper.WriteElementStringAsync(writer, MemberNames.PostalCode, PostalCode);
        await Helper.WriteElementStringAsync(writer, MemberNames.TownName, TownName);
        await Helper.WriteElementStringAsync(writer, MemberNames.Country, Country);
        await writer.WriteEndElementAsync();
    }
}

