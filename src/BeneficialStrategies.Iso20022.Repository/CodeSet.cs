using System.Diagnostics;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Repository;

public class CodeSet : TopLevelDictionaryEntry
{
    public CodeSet(XElement xElement) : base(xElement)
    {
        var specifiedDerivationItems = xElement.Attribute(IsoXmlAttributes.Default.Derivation)?.Value;
        if (!String.IsNullOrWhiteSpace(specifiedDerivationItems))
        {
            DerivationItems = specifiedDerivationItems.Split(" ");
        }
        else DerivationItems = Array.Empty<string>();
        Derivations = new CodeSet[] { }; // Set later after we can resolve them all by ID

        Example = xElement.Element(IsoXmlElements.Default.Example)?.Value ?? string.Empty;
        var duplicateDetection = new HashSet<string>();
        Codes = xElement.Elements(IsoXmlElements.Default.Code)
            .Select(e => new Code(e, duplicateDetection))
            .ToArray();
        if (this.Id == "_XWoxEI9EEeqMo4JxiuZGSw" || this.Id == "_mDriYI9GEeqMo4JxiuZGSw")
        {
            var firstCode = xElement.Elements().First();
            Debug.Assert(firstCode?.Name.LocalName == IsoXmlElements.Default.Code.LocalName);
            Debug.Assert(firstCode?.Name.Namespace == IsoXmlElements.Default.Code.Namespace);
            // Debug.Fail("What is wrong??");
        }
    }

    public string Example { get; }

    public bool IsExternal => Codes.Length == 0;

    internal string[] DerivationItems { get; }

    /// <summary>
    /// References to other codesets that are derived from this one.
    /// </summary>
    public CodeSet[] Derivations { get; internal set; }

    /// <summary>
    /// References the codeset (if any) that this was derived from.
    /// </summary>
    public CodeSet? DerivedFrom { get; internal set; }

    public Code[] Codes { get; }
}

