﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for Counterparty14Choice.  ISO2002 ID# _6slmIffVEeiNZp_PtLohLw.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between buyer and seller.
/// </summary>
[KnownType(typeof(Counterparty14Choice.Seller))]
[KnownType(typeof(Counterparty14Choice.Buyer))]
public abstract partial record Counterparty14Choice_ : IIsoXmlSerilizable<Counterparty14Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static Counterparty14Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Sellr" => Counterparty14Choice.Seller.Deserialize(elementWithPayload),
             "Buyr" => Counterparty14Choice.Buyer.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid Counterparty14Choice choice.")
        };
    }
}
