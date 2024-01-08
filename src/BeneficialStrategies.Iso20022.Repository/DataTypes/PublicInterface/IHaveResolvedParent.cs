


namespace BeneficialStrategies.Iso20022.Repository.DataTypes.PublicInterface;

/// <summary>
/// Must be implemented by classes that need a reference back to their parent.
/// </summary>
/// <typeparam name="TParent">The resolved data parent.</typeparam>
public interface IHaveResolvedParent<TParent> : IResolved
    where TParent : IResolved
{
    TParent Parent { get; init;}
}

