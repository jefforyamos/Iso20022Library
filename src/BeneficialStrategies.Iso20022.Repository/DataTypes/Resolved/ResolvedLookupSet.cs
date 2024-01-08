using System.Collections.Frozen;
using System.Collections.Immutable;
using BeneficialStrategies.Iso20022.Repository.DataTypes.Resolved;

namespace BeneficialStrategies.Iso20022.Repository.DataTypes.Resolved;

/// <summary>
/// Contains necessary mechanisms to enumerate or lookup values of a specific type.  Intended to be exposed at the most outer layer of the repository.
/// </summary>
/// <typeparam name="T">Data type may be resolved or unresolved.</typeparam>
public class ResolvedLookupSet<T> :PublicInterface.IResolvedLookupSet<T>
    where T : PublicInterface.IHaveId
{
    public ResolvedLookupSet(IEnumerable<T> recordsOrQuery)    
     {
        Items = recordsOrQuery.ToFrozenSet();
        ById = Items.ToFrozenDictionary(item => item.Id);
    }

    public IReadOnlySet<T> Items { get; private set; }

    public IReadOnlyDictionary<string, T> ById { get; private set; }
}
