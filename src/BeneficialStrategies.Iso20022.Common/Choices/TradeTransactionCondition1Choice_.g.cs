﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for TradeTransactionCondition1Choice.  ISO2002 ID# _QtCDINp-Ed-ak6NoX_4Aeg_-1725642447.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format for the trade transaction condition.
/// </summary>
[KnownType(typeof(TradeTransactionCondition1Choice.Code))]
[KnownType(typeof(TradeTransactionCondition1Choice.Proprietary))]
public abstract partial record TradeTransactionCondition1Choice_ : IIsoXmlSerilizable<TradeTransactionCondition1Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static TradeTransactionCondition1Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => TradeTransactionCondition1Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => TradeTransactionCondition1Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid TradeTransactionCondition1Choice choice.")
        };
    }
}
