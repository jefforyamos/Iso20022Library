﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for References47Choice.  ISO2002 ID# _JqlFATzbEeWeNtT0s2RbkQ.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of reference.
/// </summary>
[KnownType(typeof(References47Choice.SecuritiesSettlementTransactionIdentification))]
[KnownType(typeof(References47Choice.PoolIdentification))]
[KnownType(typeof(References47Choice.IntraPositionMovementIdentification))]
[KnownType(typeof(References47Choice.AccountServicerTransactionIdentification))]
[KnownType(typeof(References47Choice.OtherTransactionIdentification))]
public abstract partial record References47Choice_ : IIsoXmlSerilizable<References47Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static References47Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "SctiesSttlmTxId" => References47Choice.SecuritiesSettlementTransactionIdentification.Deserialize(elementWithPayload),
             "PoolId" => References47Choice.PoolIdentification.Deserialize(elementWithPayload),
             "IntraPosMvmntId" => References47Choice.IntraPositionMovementIdentification.Deserialize(elementWithPayload),
             "AcctSvcrTxId" => References47Choice.AccountServicerTransactionIdentification.Deserialize(elementWithPayload),
             "OthrTxId" => References47Choice.OtherTransactionIdentification.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid References47Choice choice.")
        };
    }
}
