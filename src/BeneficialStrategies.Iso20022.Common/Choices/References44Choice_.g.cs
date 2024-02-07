﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for References44Choice.  ISO2002 ID# _Hoo5QTqoEeWyoP0PbocV1Q.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of reference.
/// </summary>
[KnownType(typeof(References44Choice.OtherTransactionIdentification))]
[KnownType(typeof(References44Choice.SecuritiesFinancingTransactionIdentification))]
[KnownType(typeof(References44Choice.SecuritiesSettlementTransactionIdentification))]
[KnownType(typeof(References44Choice.IntraPositionMovementIdentification))]
public abstract partial record References44Choice_ : IIsoXmlSerilizable<References44Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static References44Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "OthrTxId" => References44Choice.OtherTransactionIdentification.Deserialize(elementWithPayload),
             "SctiesFincgTxId" => References44Choice.SecuritiesFinancingTransactionIdentification.Deserialize(elementWithPayload),
             "SctiesSttlmTxId" => References44Choice.SecuritiesSettlementTransactionIdentification.Deserialize(elementWithPayload),
             "IntraPosMvmntId" => References44Choice.IntraPositionMovementIdentification.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid References44Choice choice.")
        };
    }
}
