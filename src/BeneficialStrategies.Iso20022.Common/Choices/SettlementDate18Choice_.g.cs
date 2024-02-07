﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SettlementDate18Choice.  ISO2002 ID# _dJt0MbPvEeelzbgsFa3sqQ.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format for the settlement date.
/// </summary>
[KnownType(typeof(SettlementDate18Choice.Date))]
[KnownType(typeof(SettlementDate18Choice.DateCode))]
public abstract partial record SettlementDate18Choice_ : IIsoXmlSerilizable<SettlementDate18Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static SettlementDate18Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Dt" => SettlementDate18Choice.Date.Deserialize(elementWithPayload),
             "DtCd" => SettlementDate18Choice.DateCode.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid SettlementDate18Choice choice.")
        };
    }
}
