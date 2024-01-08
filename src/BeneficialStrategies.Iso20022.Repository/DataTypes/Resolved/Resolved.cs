


using BeneficialStrategies.Iso20022.Repository.DataTypes.PublicInterface;

namespace BeneficialStrategies.Iso20022.Repository.DataTypes.Resolved;

/// <summary>
/// Provides the underlayment for an item that does not have a logical parent.
/// </summary>
/// <typeparam name="TSelf"></typeparam>
/// <typeparam name="TUnresolved"></typeparam>
public abstract class Resolved<TSelf, TUnresolved> : IResolved<TSelf, TUnresolved>, IHaveId, IHaveName
    where TSelf : IResolved<TSelf, TUnresolved>, PublicInterface.IResolved
    where TUnresolved : Unresolved.IUnresolved
{
    /// <summary>
    /// Contains the strongly-typed unresolved data that we will extract information from.
    /// </summary>
    public abstract TUnresolved UnResolved { get; init; }

    public string Id => UnResolved.Id;

    public string Name => UnResolved.Name;
}

/// <summary>
/// This overload of the class extends Resolved to include the parent declaration.
/// </summary>
/// <typeparam name="TSelf"></typeparam>
/// <typeparam name="TUnresolved"></typeparam>
/// <typeparam name="TParent"></typeparam>
public abstract class Resolved<TSelf, TUnresolved, TParent> : Resolved<TSelf, TUnresolved>, PublicInterface.IHaveResolvedParent<TParent>
    where TSelf : IResolved<TSelf, TUnresolved>, PublicInterface.IResolved
    where TUnresolved : Unresolved.IUnresolved
    where TParent : PublicInterface.IResolved
{
    public required TParent Parent { get; init; }

    public override required TUnresolved UnResolved { get; init; }
}

