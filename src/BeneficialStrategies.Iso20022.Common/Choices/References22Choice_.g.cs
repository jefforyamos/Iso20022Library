﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for References22Choice.  ISO2002 ID# _H4smNk-2EeCKyoyCaiI0rw.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of reference.
/// </summary>
[KnownType(typeof(References22Choice.OtherTransactionIdentification))]
[KnownType(typeof(References22Choice.SecuritiesFinancingTransactionIdentification))]
[KnownType(typeof(References22Choice.SecuritiesSettlementTransactionIdentification))]
[KnownType(typeof(References22Choice.IntraPositionMovementIdentification))]
public abstract partial record References22Choice_ : IIsoXmlSerilizable<References22Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static References22Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "OthrTxId" => References22Choice.OtherTransactionIdentification.Deserialize(elementWithPayload),
             "SctiesFincgTxId" => References22Choice.SecuritiesFinancingTransactionIdentification.Deserialize(elementWithPayload),
             "SctiesSttlmTxId" => References22Choice.SecuritiesSettlementTransactionIdentification.Deserialize(elementWithPayload),
             "IntraPosMvmntId" => References22Choice.IntraPositionMovementIdentification.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid References22Choice choice.")
        };
    }
}
