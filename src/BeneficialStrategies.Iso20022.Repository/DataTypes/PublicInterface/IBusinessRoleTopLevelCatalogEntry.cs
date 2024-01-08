

namespace BeneficialStrategies.Iso20022.Repository.DataTypes.PublicInterface;

public interface IBusinessProcessTopLevelCatalogEntry : ITopLevelCatalogEntry
{
     IResolvedLookupSet<IBusinessRole> BusinessRoles { get; }
}
