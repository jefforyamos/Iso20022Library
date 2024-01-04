using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Linq;
using Helper = BeneficialStrategies.Iso20022.Common.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.Common.PocRecords.ContactDetailsRec>;

//	<CtctDtls>
//		<Nm>J.Thompson</Nm>
//		<EmailAdr>Thompson @virgay.com</EmailAdr>
//	</CtctDtls>

namespace BeneficialStrategies.Iso20022.Common.PocRecords;

[DataContract(Name = "CtctDtls", Namespace ="")]
public record ContactDetailsRec : IIsoXmlSerilizable<ContactDetailsRec>
{
    [DataMember(Name = "Nm", Order = 0)]
    public required string Name { get; init; }

    [DataMember(Name = "EmailAdr", Order = 1)]
    public required string Email { get; init; }

    public static XName RootElement => Helper.CreateXName("CtctDtls");

    public static class MemberNames
    {
        public static XName Name = Helper.CreateXName("Nm");
        public static XName Email = Helper.CreateXName("EmailAdr");
    }

    public virtual async Task SerializeAsync(XmlWriter writer)
    {
        await Helper.WriteStartElementAsync(writer, RootElement);
        await Helper.WriteElementStringAsync(writer, MemberNames.Name, Name);
        await Helper.WriteElementStringAsync(writer, MemberNames.Email, Email);
        await Helper.WriteEndElementAsync(writer);
    }

    public static async Task<ContactDetailsRec> DeserializeAsync(XmlReader reader)
    {
        return await Helper.DeserializeAsync(reader);
    }

    public static ContactDetailsRec Deserialize(XElement element)
    {
        return new ContactDetailsRec
        {
            Name = Helper.GetStringValue(element, MemberNames.Name),
            Email = Helper.GetStringValue(element, MemberNames.Email)
        };
    }
}

