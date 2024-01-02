using System.Xml;
using System.Xml.Linq;
using Helper = BeneficialStrategies.Iso20022.Common.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.Common.InitiatingPartyRec>;

namespace BeneficialStrategies.Iso20022.Common;

public record InitiatingPartyRec
	: IIsoXmlSerilizable<InitiatingPartyRec>
{
    public required string Name { get; init; }

    public required PostalAddresRec PostalAddress { get; init; }

	public required ContactDetailsRec ContactDetails { get; init; }

    public static XName RootElement => Helper.CreateXName("InitgPty");

    public static class MemberNames
    {
        public static XName Name = Helper.CreateXName( "Nm");
        public static XName PostalAddress = Helper.CreateXName("PstlAdr");
        public static XName ContactDetails = Helper.CreateXName("CtctDtls");
    }

    public static async Task<InitiatingPartyRec> DeserializeAsync(XmlReader reader)
    {
        // XElement root = await XElement.LoadAsync(reader, new LoadOptions { }, CancellationToken.None);
        // return Deserialize(root);
        return await Helper.DeserializeAsync(reader);
    }

    public async Task SerializeAsync(XmlWriter writer)
    {
        await writer.WriteStartElementAsync(null, RootElement.LocalName, null);
        await writer.WriteElementStringAsync(null, MemberNames.Name.LocalName, null, Name);
        await PostalAddress.SerializeAsync(writer);
        await ContactDetails.SerializeAsync(writer);
        await writer.WriteEndElementAsync();
    }

    public static InitiatingPartyRec Deserialize(XElement element)
    {
        return new InitiatingPartyRec
        {
            Name = element.Element(MemberNames.Name)?.Value
                ?? throw new IsoDeserializationMissingElementException(typeof(ContactDetailsRec), MemberNames.Name.LocalName),

            PostalAddress = PostalAddresRec.Deserialize(element.Element(MemberNames.PostalAddress)
                ?? throw new IsoDeserializationMissingElementException(typeof(ContactDetailsRec), MemberNames.PostalAddress.LocalName)),

            ContactDetails = ContactDetailsRec.Deserialize(element.Element(MemberNames.ContactDetails)
                ?? throw new IsoDeserializationMissingElementException(typeof(ContactDetailsRec), MemberNames.ContactDetails.LocalName))

        };
    }
}

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
