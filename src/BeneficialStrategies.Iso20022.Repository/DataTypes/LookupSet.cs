
//   <businessRole xmi:id="_PTe2R9p-Ed-ak6NoX_4Aeg_993089105" name="CentralCounterparty" definition="Infrastructure that is very often a component of a clearinghouse, and facilitates clearing and settlement for its members by standing between the buyer and the seller of a trade. It may net transactions, and substitutes itself as a settlement counterparty to each position." registrationStatus="Registered">
//     <semanticMarkup xmi:id="_ho9JdQ5lEeO42pgjaJ50lw" type="BUSINESSCOMMENT">
//       <elements xmi:id="_ho9Jdg5lEeO42pgjaJ50lw" name="comment" value="Controls the Custody activities for one market."/>
//     </semanticMarkup>
//     <semanticMarkup xmi:id="_ho9Jdw5lEeO42pgjaJ50lw" type="ADMINCOMMENT">
//       <elements xmi:id="_ho9JeA5lEeO42pgjaJ50lw" name="comment" value="Controls the Custody activities for one market."/>
//     </semanticMarkup>
//   </businessRole>

using System.Collections.Immutable;

namespace BeneficialStrategies.Iso20022.Repository.DataTypes;

/// <summary>
/// Contains necessary mechanisms to enumerate or lookup values of a specific type.  Intended to be exposed at the most outer layer of the repository.
/// </summary>
/// <typeparam name="T">Data type may be resolved or unresolved.</typeparam>
public class LookupSet<T> 
    where T : Unresolved.Element 
{
    public LookupSet(IEnumerable<T> recordsOrQuery)
    {
        Items = recordsOrQuery.ToImmutableArray();
        ById = Items.ToImmutableDictionary(item => item.Id);
    }

    public ImmutableArray<T> Items { get; private set; }

    public ImmutableDictionary<string,T> ById { get; private set; }
}



