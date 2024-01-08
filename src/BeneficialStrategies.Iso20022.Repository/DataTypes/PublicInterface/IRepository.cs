namespace BeneficialStrategies.Iso20022.Repository.DataTypes.PublicInterface;

public interface IRepository : IResolved, IHaveId
{
    IResolvedLookupSet<IBusinessRole> BusinessRoles { get; }

}