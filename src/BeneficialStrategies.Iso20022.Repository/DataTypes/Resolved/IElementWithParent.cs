
namespace BeneficialStrategies.Iso20022.Repository.DataTypes.Resolved;

/// <summary>
/// Must be implemented by classes that need a reference back to their parent.
/// </summary>
/// <typeparam name="TParent">The resolved data parent.</typeparam>
public interface IElementWithParent<TParent> : PublicInterface.IResolved
    where TParent : PublicInterface.IResolved
{
    TParent Parent { get; init;}
}

