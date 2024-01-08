


namespace BeneficialStrategies.Iso20022.Repository.DataTypes.Resolved;

public class BusinessProcessCatalogue : IResolved<BusinessProcessCatalogue,Unresolved.BusinessProcessCatalogue>, PublicInterface.IHaveResolvedParent<Repository>
{
    public required Repository Parent { get; init; }
    public required Unresolved.BusinessProcessCatalogue UnResolved { get; init; }

    public string Key => UnResolved.Id;
}

