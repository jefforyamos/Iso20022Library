﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for TonsOrCurrency2Choice.  ISO2002 ID# _Z5jxEWlSEeaLAKoEUNsD9g.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Specifies the commodity quantity in tons or the amount and currency used (for example carbone dioxide).
/// </summary>
[KnownType(typeof(TonsOrCurrency2Choice.Number))]
[KnownType(typeof(TonsOrCurrency2Choice.Amount))]
public abstract partial record TonsOrCurrency2Choice_ : IIsoXmlSerilizable<TonsOrCurrency2Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static TonsOrCurrency2Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Nb" => TonsOrCurrency2Choice.Number.Deserialize(elementWithPayload),
             "Amt" => TonsOrCurrency2Choice.Amount.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid TonsOrCurrency2Choice choice.")
        };
    }
}
