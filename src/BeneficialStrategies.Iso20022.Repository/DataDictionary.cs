using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Repository;

public class DataDictionary : IsoRepoElement
{
    public DataDictionary([NotNull] XElement xElement) : base(xElement)
    {
        var businessComponents = new List<BusinessComponent>();
        var codeSets = new List<CodeSet>();

        foreach (var node in xElement.Elements())
        {
            if (node == null) throw new NullReferenceException("Null returned from collection");
            var topLevelEntryType = node?.Attribute(IsoXmlAttributes.Xsi.Type)?.Value;
            switch (topLevelEntryType)
            {
                case "iso20022:BusinessComponent":
                    businessComponents.Add(new BusinessComponent(node));
                    break;
                case "iso20022:MessageComponent":
                    break;
                case "iso20022:ChoiceComponent":
                    break;
                case "iso20022:UserDefined":
                    break;
                case "iso20022:ExternalSchema":
                    break;
                case "iso20022:Text":
                    break;
                case "iso20022:DateTime":
                    break;
                case "iso20022:Date":
                    break;
                case "iso20022:IdentifierSet":
                    break;
                case "iso20022:CodeSet":
                    codeSets.Add(new CodeSet(node));
                    break;
                case "iso20022:Indicator":
                    break;
                case "iso20022:Quantity":
                    break;
                case "iso20022:Amount":
                    break;
                case "iso20022:Time":
                    break;
                case "iso20022:Rate":
                    break;
                case "iso20022:YearMonth":
                    break;
                case "iso20022:Year":
                    break;
                case "iso20022:Binary":
                    break;
                case "iso20022:SchemaType":
                    break;
                case "iso20022:Month":
                    break;
                default:
                    foreach (var att in node.Attributes())
                    {
                        Console.WriteLine($"  - {att.Name} : ({att.Value})");
                    }
                    Debug.Fail($"What is this: {topLevelEntryType}");

                    break;
            }
        }
        CodeSets = codeSets.ToArray();
    }

    public CodeSet[] CodeSets { get; }
}
