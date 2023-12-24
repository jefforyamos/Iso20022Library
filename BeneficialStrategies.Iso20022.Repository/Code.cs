using System.Xml.Linq;
using System.Diagnostics;

namespace BeneficialStrategies.Iso20022.Repository;

public class Code : IsoRepoElement
{
    public Code(XElement xElement) : base(xElement)
    {
        // Definition = xElement?.Attribute(IsoXmlAttributes.Default.Definition)?.Value ?? string.Empty;
        RegistrationStatus = xElement?.Attribute(IsoXmlAttributes.Default.RegistrationStatus)?.Value ?? string.Empty;
        CodeName = xElement?.Attribute(IsoXmlAttributes.Default.CodeName)?.Value ?? string.Empty;
        LegalCodeName = (string.IsNullOrWhiteSpace(CodeName))
            ? base.Name
            : CodeName;
        LegalCodeName = LegalCodeName.Replace('-', '_');
        if (char.IsDigit(LegalCodeName[0])) LegalCodeName = string.Concat("_", LegalCodeName);
        // if (string.IsNullOrWhiteSpace(CodeName)) Debug.Fail(xElement.ToString());
    }

    // public string Definition { get; }

    public string RegistrationStatus { get; }

    public string CodeName { get; }

    public string LegalCodeName { get; }
}

