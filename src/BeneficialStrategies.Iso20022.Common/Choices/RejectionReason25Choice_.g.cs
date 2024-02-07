﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RejectionReason25Choice.  ISO2002 ID# _ecZ5BTt5EeW638lNyHKv7A.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format for the rejection reason.
/// </summary>
[KnownType(typeof(RejectionReason25Choice.Code))]
[KnownType(typeof(RejectionReason25Choice.Proprietary))]
public abstract partial record RejectionReason25Choice_ : IIsoXmlSerilizable<RejectionReason25Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static RejectionReason25Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => RejectionReason25Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => RejectionReason25Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid RejectionReason25Choice choice.")
        };
    }
}
