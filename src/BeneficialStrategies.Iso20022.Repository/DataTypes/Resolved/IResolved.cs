


namespace BeneficialStrategies.Iso20022.Repository.DataTypes.Resolved;

/// <summary>
/// Extends <seealso cref="IResolved"/> to specify the type we are resolving from and to.
/// Requires a property that contains the unresolved data we are using as our basis.
/// </summary>
/// <typeparam name="TSelf"></typeparam>
/// <typeparam name="TUnresolved">The type with the unresolved data that we are hiding from the interface.</typeparam>
public interface IResolved<TSelf, TUnresolved> : PublicInterface.IResolved
    where TSelf : IResolved<TSelf, TUnresolved>
    where TUnresolved : Unresolved.IUnresolved
{
    /// <summary>
    /// References the unresolved data obtained directly from the XML data.
    /// </summary>
    TUnresolved UnResolved { get; init; }
}
