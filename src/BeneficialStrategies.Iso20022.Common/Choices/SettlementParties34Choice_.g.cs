﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SettlementParties34Choice.  ISO2002 ID# _vgeGIcg4Eeu4ecZgAYuz5w.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Identifies the parties settling the contract.
/// </summary>
[KnownType(typeof(SettlementParties34Choice.CentralSecuritiesDepositoryParticipant))]
[KnownType(typeof(SettlementParties34Choice.IndirectParticipant))]
public abstract partial record SettlementParties34Choice_ : IIsoXmlSerilizable<SettlementParties34Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static SettlementParties34Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "CntrlSctiesDpstryPtcpt" => SettlementParties34Choice.CentralSecuritiesDepositoryParticipant.Deserialize(elementWithPayload),
             "IndrctPtcpt" => SettlementParties34Choice.IndirectParticipant.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid SettlementParties34Choice choice.")
        };
    }
}
