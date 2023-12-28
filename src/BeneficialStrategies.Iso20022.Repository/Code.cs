using System.Xml.Linq;
using System.Diagnostics;

namespace BeneficialStrategies.Iso20022.Repository;

public class Code : IsoRepoElement
{
    public Code(XElement xElement, HashSet<string> duplicateDetection) : base(xElement)
    {
        // Definition = xElement?.Attribute(IsoXmlAttributes.Default.Definition)?.Value ?? string.Empty;
        RegistrationStatus = xElement?.Attribute(IsoXmlAttributes.Default.RegistrationStatus)?.Value ?? string.Empty;
        CodeName = xElement?.Attribute(IsoXmlAttributes.Default.CodeName)?.Value ?? string.Empty;
        LegalCodeName = (string.IsNullOrWhiteSpace(CodeName))
            ? base.Name
            : CodeName;
        LegalCodeName = LegalCodeName.Replace('-', '_');
        if (char.IsDigit(LegalCodeName[0])) LegalCodeName = string.Concat("_", LegalCodeName);
        OriginalLegalNameCode = LegalCodeName;
        if (duplicateDetection.Contains(LegalCodeName))
        {
            LegalNameCodeWasChangedBecauseNameWasDuplicated = true;
            var count = 2;
            while (duplicateDetection.Contains(LegalCodeName)) LegalCodeName = $"{OriginalLegalNameCode}{count++}";
        }
        duplicateDetection.Add(LegalCodeName);
        EnumMemberName = Name.Replace("-", "_").Replace(".", "");
    }

    /// <summary>
    /// The name of the actual member that is generated for this record.
    /// </summary>
    public string EnumMemberName { get; }

    public string RegistrationStatus { get; }

    /// <summary>
    /// The code used to serialize/deserialize.
    /// </summary>
    public string CodeName { get; }

    /// <summary>
    /// The C# friendly name for this code.  
    /// </summary>
    public string LegalCodeName { get; }

    /// <summary>
    /// The legal name prior to duplication detection changes. (and thus, the name of the duplicated value)
    /// </summary>
    public string OriginalLegalNameCode { get; }

    /// <summary>
    /// True if the name had to be changed because two codes existed with the same names.
    /// </summary>
    public bool LegalNameCodeWasChangedBecauseNameWasDuplicated { get; }
}

