using System.Collections.Immutable;
using System.Xml.Linq;
using Unresolved = BeneficialStrategies.Iso20022.Repository.DataTypes.Unresolved;
using Resolved = BeneficialStrategies.Iso20022.Repository.DataTypes.Resolved;
using BeneficialStrategies.Iso20022.Repository.DataTypes;

namespace BeneficialStrategies.Iso20022.Repository;

public class LinqTesting
{
    private readonly ITestOutputHelper _output;

    public LinqTesting(ITestOutputHelper testOutputHelper)
    {
        _output = testOutputHelper; 
    }

    [Fact]
    public void Test()
    {
        // businessProcessCatalogue
        var x = LoadedRepository.Instance.LoadedXDocument;
        XElement root = x.Root 
            ?? throw new KeyNotFoundException("Root not found, is document loaded?");
        _output.WriteLine($"Repo loaded ");

        var newUnresolvedRepo = new Unresolved.Repository { ElementValue = root  };

        var newRoles = newUnresolvedRepo.BusinessProcessCatalog.BusinessProcess.BusinessRoles.ToArray();

        var newResolvedRepo = new Resolved.Repository(newUnresolvedRepo);

        var newResolvedRoles = newResolvedRepo.BusinessRoles;

        var lookAtThis = newRoles.Where( r => r.Name == "CentralCounterparty").First();

        XElement businessProcessCatalog = root.Element(IsoXmlElements.Default.BusinessProcessCatalogue) 
            ?? throw new KeyNotFoundException($"{IsoXmlElements.Default.BusinessProcessCatalogue} not found.");

        var rolesQuery = from topLevelEntry in businessProcessCatalog.Elements()
            where topLevelEntry.Attribute(IsoXmlAttributes.Xsi.Type)?.Value == "iso20022:BusinessProcess"
            from businessRole in topLevelEntry.Elements()
            select new Unresolved.BusinessRole{ ElementValue = businessRole };
        
        var roles = new LookupSet<Unresolved.BusinessRole>(rolesQuery);

    }
}

