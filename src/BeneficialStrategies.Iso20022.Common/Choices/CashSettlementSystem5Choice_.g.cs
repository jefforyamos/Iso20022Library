﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CashSettlementSystem5Choice.  ISO2002 ID# _5m6BBZNLEeWGlc8L7oPDIg.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format for the cash settlement system.
/// </summary>
[KnownType(typeof(CashSettlementSystem5Choice.Code))]
[KnownType(typeof(CashSettlementSystem5Choice.Proprietary))]
public abstract partial record CashSettlementSystem5Choice_ : IIsoXmlSerilizable<CashSettlementSystem5Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static CashSettlementSystem5Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => CashSettlementSystem5Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => CashSettlementSystem5Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid CashSettlementSystem5Choice choice.")
        };
    }
}
