//   <businessRole xmi:id="_PTe2R9p-Ed-ak6NoX_4Aeg_993089105" name="CentralCounterparty" definition="Infrastructure that is very often a component of a clearinghouse, and facilitates clearing and settlement for its members by standing between the buyer and the seller of a trade. It may net transactions, and substitutes itself as a settlement counterparty to each position." registrationStatus="Registered">
//     <semanticMarkup xmi:id="_ho9JdQ5lEeO42pgjaJ50lw" type="BUSINESSCOMMENT">
//       <elements xmi:id="_ho9Jdg5lEeO42pgjaJ50lw" name="comment" value="Controls the Custody activities for one market."/>
//     </semanticMarkup>
//     <semanticMarkup xmi:id="_ho9Jdw5lEeO42pgjaJ50lw" type="ADMINCOMMENT">
//       <elements xmi:id="_ho9JeA5lEeO42pgjaJ50lw" name="comment" value="Controls the Custody activities for one market."/>
//     </semanticMarkup>
//   </businessRole>

using System.Diagnostics;

namespace BeneficialStrategies.Iso20022.Repository.DataTypes.Unresolved;

[DebuggerDisplay("{DebuggerDisplay}")]
public abstract class Element : IUnresolved
{
    public required XElement ElementValue { get; init; }

    public string Id  => ElementValue.Attribute(IsoXmlAttributes.Xmi.Id)?.Value ?? string.Empty;

    public string Definition => ElementValue.Attribute(IsoXmlAttributes.Default.Definition)?.Value ?? string.Empty;

    public string Name => ElementValue.Attribute(IsoXmlAttributes.Default.Name)?.Value ?? string.Empty;

    public string RegistrationStatus => ElementValue.Attribute(IsoXmlAttributes.Default.RegistrationStatus)?.Value ?? string.Empty;

    protected virtual string DebuggerDisplay => $"{GetType().Name} {Name}";

    protected T RequiredChildElement<T>(XName selector, Func<XElement,T> createFunc, Func<XElement, bool>? additionalSelector = null)
        where T : Element
    {
        var selectedElement = additionalSelector is null
            ? ElementValue.Element(selector)
            : ElementValue.Elements(selector).Where(additionalSelector).First();
        XElement nonNull = selectedElement ?? throw new KeyNotFoundException($"Required element {selector} not found");
        return createFunc.Invoke(nonNull);
    }
}

