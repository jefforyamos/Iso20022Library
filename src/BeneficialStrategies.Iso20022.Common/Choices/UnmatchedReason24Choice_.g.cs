﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for UnmatchedReason24Choice.  ISO2002 ID# _DFsb-Tw8EeW3QqUkIQtIUA.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format for the securities financing unmatched reason.
/// </summary>
[KnownType(typeof(UnmatchedReason24Choice.Code))]
[KnownType(typeof(UnmatchedReason24Choice.Proprietary))]
public abstract partial record UnmatchedReason24Choice_ : IIsoXmlSerilizable<UnmatchedReason24Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static UnmatchedReason24Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => UnmatchedReason24Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => UnmatchedReason24Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid UnmatchedReason24Choice choice.")
        };
    }
}
