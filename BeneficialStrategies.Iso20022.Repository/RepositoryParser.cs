using System.Diagnostics;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Repository;

public class RepositoryParser
{
    public const string CurrentlySupportedRepoFile = "20230719_ISO20022_2013_eRepository.iso20022";

    public IsoRepository Repository { get;}

    public RepositoryParser(string fileName = CurrentlySupportedRepoFile)
    {
        var stopWatch = new Stopwatch();
        stopWatch.Start();
        XDocument xDocument = XDocument.Load(fileName);

        Console.WriteLine($"Loaded {fileName} after {stopWatch.Elapsed.TotalSeconds} seconds. ");

        var repo = xDocument.Elements().First();
        Repository = new IsoRepository(repo);
        stopWatch.Stop();
        Console.WriteLine($"Finished iterations after {stopWatch.Elapsed.TotalSeconds} seconds.");
    }

    public static void DeleteThis(string fileName = CurrentlySupportedRepoFile)
    {

        //var repoId = repo.Attribute(IsoXmlAttributes.Xmi.Id);

        //Console.WriteLine($"Repo ID = [{repoId?.Value}] ");

        //Debug.Assert(repo.Elements().Count() == 2);
        //var levelOneElements = repo.Elements().ToArray();
        //var dataDict = levelOneElements[0];
        //var businessProcessCatalog = levelOneElements[1];
        //Console.WriteLine($"Second element is {businessProcessCatalog.Name}");
        //Console.WriteLine(dataDict.Name);

        //var  businessComponents = new List<BusinessComponent>();
        //var codeSets = new List<CodeSet>();

        //foreach (var node in dataDict.Elements())
        //{
        //    if (node is null) continue;
        //    var topLevelEntryType = node?.Attribute(IsoXmlAttributes.Xsi.Type)?.Value;
        //    switch (topLevelEntryType)
        //    {
        //        case "iso20022:BusinessComponent":
        //            businessComponents.Add(new BusinessComponent(node));
        //            break;
        //        case "iso20022:MessageComponent":
        //            break;
        //        case "iso20022:ChoiceComponent":
        //            break;
        //        case "iso20022:UserDefined":
        //            break;
        //        case "iso20022:ExternalSchema":
        //            break;
        //        case "iso20022:Text":
        //            break;
        //        case "iso20022:DateTime":
        //            break;
        //        case "iso20022:Date":
        //            break;
        //        case "iso20022:IdentifierSet":
        //            break;
        //        case "iso20022:CodeSet":
        //            codeSets.Add(new CodeSet(node));
        //            break;
        //        case "iso20022:Indicator":
        //            break;
        //        case "iso20022:Quantity":
        //            break;
        //        case "iso20022:Amount":
        //            break;
        //        case "iso20022:Time":
        //            break;
        //        case "iso20022:Rate":
        //            break;
        //        case "iso20022:YearMonth":
        //            break;
        //        case "iso20022:Year":
        //            break;
        //        case "iso20022:Binary":
        //            break;
        //        case "iso20022:SchemaType":
        //            break;
        //        case "iso20022:Month":
        //            break;
        //        default:
        //            foreach (var att in node.Attributes())
        //            {
        //                Console.WriteLine($"  - {att.Name} : ({att.Value})");
        //            }
        //            Debug.Fail($"What is this: {topLevelEntryType}");

        //            break;
        //    }
        //    Debug.Assert(node.Name == "topLevelDictionaryEntry");
            // var entry = new TopLevelDictionaryEntry(node);
            // Console.WriteLine(entry);
        // }
        //foreach (var procElement in businessProcessCatalog.Elements())
        //{
        //    Console.WriteLine($"Business Process: {procElement.Name}");
        //}
    }
}
