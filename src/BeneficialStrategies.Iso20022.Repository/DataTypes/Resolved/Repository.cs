
using System.Reflection.Metadata.Ecma335;
using BeneficialStrategies.Iso20022.Repository.DataTypes.PublicInterface;

namespace BeneficialStrategies.Iso20022.Repository.DataTypes.Resolved;

public class Repository : PublicInterface.IRepository
{ 
    public Repository(Unresolved.Repository unresolved)
    {
        var roles = unresolved.BusinessProcessCatalog.BusinessProcess.BusinessRoles.Select( role => new BusinessRole
        {
            UnResolved = role,
            Parent = this,
        });
        BusinessRoles = new ResolvedLookupSet<PublicInterface.IBusinessRole>(roles);
    }
    public IResolvedLookupSet<IBusinessRole> BusinessRoles { get; }
    public Unresolved.Repository UnResolved { get => throw new NotImplementedException(); init => throw new NotImplementedException(); }
    public string Id => UnResolved.Id;

    IResolvedLookupSet<IBusinessRole> IRepository.BusinessRoles => throw new NotImplementedException();
}

