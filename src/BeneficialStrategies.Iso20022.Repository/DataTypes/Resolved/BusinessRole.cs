

namespace BeneficialStrategies.Iso20022.Repository.DataTypes.Resolved;

/// <summary>
/// Adds whatever pointers that can only be resolved after the other structures are built.
/// </summary>
public class BusinessRole : Resolved<BusinessRole, Unresolved.BusinessRole, PublicInterface.IRepository>, PublicInterface.IBusinessRole
{
    // Todo: the parent is not really the repository, fix this
    public string Type => throw new NotImplementedException();

    public string RegistrationStatus => throw new NotImplementedException();
}
