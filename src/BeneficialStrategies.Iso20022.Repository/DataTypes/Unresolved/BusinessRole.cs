
//   <businessRole xmi:id="_PTe2R9p-Ed-ak6NoX_4Aeg_993089105" name="CentralCounterparty" definition="Infrastructure that is very often a component of a clearinghouse, and facilitates clearing and settlement for its members by standing between the buyer and the seller of a trade. It may net transactions, and substitutes itself as a settlement counterparty to each position." registrationStatus="Registered">
//     <semanticMarkup xmi:id="_ho9JdQ5lEeO42pgjaJ50lw" type="BUSINESSCOMMENT">
//       <elements xmi:id="_ho9Jdg5lEeO42pgjaJ50lw" name="comment" value="Controls the Custody activities for one market."/>
//     </semanticMarkup>
//     <semanticMarkup xmi:id="_ho9Jdw5lEeO42pgjaJ50lw" type="ADMINCOMMENT">
//       <elements xmi:id="_ho9JeA5lEeO42pgjaJ50lw" name="comment" value="Controls the Custody activities for one market."/>
//     </semanticMarkup>
//   </businessRole>

using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

namespace BeneficialStrategies.Iso20022.Repository.DataTypes.Unresolved;

public class BusinessRole : TopLevelCatalogueElement
{
    public IEnumerable<SymanticMarkup> SymanticMarkups => ElementValue.Elements(IsoXmlElements.Default.SymanticMarkup)?.Select( e => new SymanticMarkup{ ElementValue = e }) 
        ?? Array.Empty<SymanticMarkup>();

    public class SymanticMarkup : Element
    {
        public IEnumerable<Comment> Comments => ElementValue.Elements().Select( e => new Comment{ ElementValue = e } );
        public class Comment : Element
        {
            public string CommentValue => ElementValue.Attribute(IsoXmlAttributes.Default.Value)?.Value ?? string.Empty;
        }
    }
}

public class Repository : Element
{
    // Todo: attributes to look up version, current namespace and such.

    public BusinessProcessCatalogue BusinessProcessCatalog => 
        RequiredChildElement(IsoXmlElements.Default.BusinessProcessCatalogue, 
                childElement => new BusinessProcessCatalogue { ElementValue = childElement} );

    public DataDictionary DataDictionary => RequiredChildElement(IsoXmlElements.Default.DataDictionary, 
        childElement => new DataDictionary{ ElementValue = childElement });

}


public class DataDictionary : Element
{
    // Todo: Move exising logic to here
}

public class BusinessProcessCatalogue : Element 
{
    //  from topLevelEntry in businessProcessCatalog.Elements()
    //         where topLevelEntry.Attribute(IsoXmlAttributes.Xsi.Type)?.Value == "iso20022:BusinessProcess"
    //         from businessRole in topLevelEntry.Elements()
    //         select new Unresolved.BusinessRole{ ElementValue = businessRole }
    public BusinessProcess BusinessProcess => TopLevelCatalogueElements
        .Where( i => i.Type == "iso20022:BusinessProcess" )
        .Select( i => new BusinessProcess { ElementValue = i.ElementValue })
        .First();

    public IEnumerable<TopLevelCatalogueElement> TopLevelCatalogueElements => 
        ElementValue.Elements(IsoXmlElements.Default.TopLevelCatalogueEntry).Select( e => new TopLevelCatalogueElement { ElementValue = e} );

}


