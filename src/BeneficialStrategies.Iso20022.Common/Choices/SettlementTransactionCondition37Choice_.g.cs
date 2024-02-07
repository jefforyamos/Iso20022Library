﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SettlementTransactionCondition37Choice.  ISO2002 ID# _38PHjyAaEeu4a6pNulzZ4Q.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format for the settlement transaction conditions.
/// </summary>
[KnownType(typeof(SettlementTransactionCondition37Choice.Code))]
[KnownType(typeof(SettlementTransactionCondition37Choice.Proprietary))]
public abstract partial record SettlementTransactionCondition37Choice_ : IIsoXmlSerilizable<SettlementTransactionCondition37Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static SettlementTransactionCondition37Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => SettlementTransactionCondition37Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => SettlementTransactionCondition37Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid SettlementTransactionCondition37Choice choice.")
        };
    }
}
