//   <businessRole xmi:id="_PTe2R9p-Ed-ak6NoX_4Aeg_993089105" name="CentralCounterparty" definition="Infrastructure that is very often a component of a clearinghouse, and facilitates clearing and settlement for its members by standing between the buyer and the seller of a trade. It may net transactions, and substitutes itself as a settlement counterparty to each position." registrationStatus="Registered">
//     <semanticMarkup xmi:id="_ho9JdQ5lEeO42pgjaJ50lw" type="BUSINESSCOMMENT">
//       <elements xmi:id="_ho9Jdg5lEeO42pgjaJ50lw" name="comment" value="Controls the Custody activities for one market."/>
//     </semanticMarkup>
//     <semanticMarkup xmi:id="_ho9Jdw5lEeO42pgjaJ50lw" type="ADMINCOMMENT">
//       <elements xmi:id="_ho9JeA5lEeO42pgjaJ50lw" name="comment" value="Controls the Custody activities for one market."/>
//     </semanticMarkup>
//   </businessRole>

namespace BeneficialStrategies.Iso20022.Repository.DataTypes.Unresolved;

public interface IUnresolved 
{
    string Id { get; }

    string Name { get; }
}

