﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for TransactionActivity4Choice.  ISO2002 ID# _8VKXSZNLEeWGlc8L7oPDIg.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format for the transaction activity identification.
/// </summary>
[KnownType(typeof(TransactionActivity4Choice.Code))]
[KnownType(typeof(TransactionActivity4Choice.Proprietary))]
public abstract partial record TransactionActivity4Choice_ : IIsoXmlSerilizable<TransactionActivity4Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static TransactionActivity4Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => TransactionActivity4Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => TransactionActivity4Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid TransactionActivity4Choice choice.")
        };
    }
}
