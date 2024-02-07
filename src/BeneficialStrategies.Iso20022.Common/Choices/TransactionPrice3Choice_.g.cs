﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for TransactionPrice3Choice.  ISO2002 ID# _tp_6Q1kyEeGeoaLUQk__nA_-725028173.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Specifies the price information related to the underlying transaction.
/// </summary>
[KnownType(typeof(TransactionPrice3Choice.DealPrice))]
[KnownType(typeof(TransactionPrice3Choice.Proprietary))]
public abstract partial record TransactionPrice3Choice_ : IIsoXmlSerilizable<TransactionPrice3Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static TransactionPrice3Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "DealPric" => TransactionPrice3Choice.DealPrice.Deserialize(elementWithPayload),
             "Prtry" => TransactionPrice3Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid TransactionPrice3Choice choice.")
        };
    }
}
