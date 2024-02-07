﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for TransactionPrice4Choice.  ISO2002 ID# _-KxXQbTUEee_k7HqaUKERA.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Specifies the price information related to the underlying transaction.
/// </summary>
[KnownType(typeof(TransactionPrice4Choice.DealPrice))]
[KnownType(typeof(TransactionPrice4Choice.Proprietary))]
public abstract partial record TransactionPrice4Choice_ : IIsoXmlSerilizable<TransactionPrice4Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static TransactionPrice4Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "DealPric" => TransactionPrice4Choice.DealPrice.Deserialize(elementWithPayload),
             "Prtry" => TransactionPrice4Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid TransactionPrice4Choice choice.")
        };
    }
}
