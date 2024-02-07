﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for References1Choice.  ISO2002 ID# _USg8Fdp-Ed-ak6NoX_4Aeg_-441351742.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of reference.
/// </summary>
[KnownType(typeof(References1Choice.SecuritiesSettlementTransactionIdentification))]
[KnownType(typeof(References1Choice.PoolIdentification))]
[KnownType(typeof(References1Choice.IntraPositionMovementIdentification))]
[KnownType(typeof(References1Choice.AccountServicerTransactionIdentification))]
[KnownType(typeof(References1Choice.OtherTransactionIdentification))]
public abstract partial record References1Choice_ : IIsoXmlSerilizable<References1Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static References1Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "SctiesSttlmTxId" => References1Choice.SecuritiesSettlementTransactionIdentification.Deserialize(elementWithPayload),
             "PoolId" => References1Choice.PoolIdentification.Deserialize(elementWithPayload),
             "IntraPosMvmntId" => References1Choice.IntraPositionMovementIdentification.Deserialize(elementWithPayload),
             "AcctSvcrTxId" => References1Choice.AccountServicerTransactionIdentification.Deserialize(elementWithPayload),
             "OthrTxId" => References1Choice.OtherTransactionIdentification.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid References1Choice choice.")
        };
    }
}
