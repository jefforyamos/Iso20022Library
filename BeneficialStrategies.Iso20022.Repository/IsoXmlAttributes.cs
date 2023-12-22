using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Repository;

public static class IsoXmlAttributes
{
    public static class Xmi
    {
        public static readonly XName Id = XName.Get("id", IsoXmlNamespaces.Xmi);
        public static readonly XName Version = XName.Get("version", IsoXmlNamespaces.Xmi);
    }
    public static class Xsi
    {
        public static readonly XName Type = XName.Get("type", IsoXmlNamespaces.Xsi);
    }
    public static class Default
    {
        public static readonly XName Name = XName.Get("name", IsoXmlNamespaces.Default);
        public static readonly XName Definition = XName.Get("definition", IsoXmlNamespaces.Default);
        public static readonly XName RegistrationStatus = XName.Get("registrationStatus", IsoXmlNamespaces.Default);
        public static readonly XName CodeName = XName.Get("codeName", IsoXmlNamespaces.Default);
        public static readonly XName SubType = XName.Get("subType", IsoXmlNamespaces.Default);
    }
}

public static class IsoXmlElements
{
    public static class Default
    {
        public static readonly XName Example = XName.Get("example", IsoXmlNamespaces.Default);
        public static readonly XName Code = XName.Get("code", IsoXmlNamespaces.Default);
    }
}