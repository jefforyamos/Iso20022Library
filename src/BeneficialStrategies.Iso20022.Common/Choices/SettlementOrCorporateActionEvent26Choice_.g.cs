﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SettlementOrCorporateActionEvent26Choice.  ISO2002 ID# _eA1Q7dEfEeiO-eodGv5iKQ.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between transaction type, corporate action event and settlement transaction.
/// </summary>
[KnownType(typeof(SettlementOrCorporateActionEvent26Choice.SecuritiesTransactionType))]
[KnownType(typeof(SettlementOrCorporateActionEvent26Choice.CorporateActionEventType))]
public abstract partial record SettlementOrCorporateActionEvent26Choice_ : IIsoXmlSerilizable<SettlementOrCorporateActionEvent26Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static SettlementOrCorporateActionEvent26Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "SctiesTxTp" => SettlementOrCorporateActionEvent26Choice.SecuritiesTransactionType.Deserialize(elementWithPayload),
             "CorpActnEvtTp" => SettlementOrCorporateActionEvent26Choice.CorporateActionEventType.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid SettlementOrCorporateActionEvent26Choice choice.")
        };
    }
}
