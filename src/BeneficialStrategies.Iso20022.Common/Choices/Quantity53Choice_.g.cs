﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for Quantity53Choice.  ISO2002 ID# _peY01Ti7Eeydid5dcNPKvg.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between different quantity of security formats.
/// </summary>
[KnownType(typeof(Quantity53Choice.Quantity))]
[KnownType(typeof(Quantity53Choice.ProprietaryQuantity))]
public abstract partial record Quantity53Choice_ : IIsoXmlSerilizable<Quantity53Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static Quantity53Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Qty" => Quantity53Choice.Quantity.Deserialize(elementWithPayload),
             "PrtryQty" => Quantity53Choice.ProprietaryQuantity.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid Quantity53Choice choice.")
        };
    }
}
