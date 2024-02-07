﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RejectedReason15Choice.  ISO2002 ID# _GV8iMSY3EeW_ZNn8gbfY7Q.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of formats for the specification of the rejected reason.
/// </summary>
[KnownType(typeof(RejectedReason15Choice.Code))]
[KnownType(typeof(RejectedReason15Choice.Proprietary))]
public abstract partial record RejectedReason15Choice_ : IIsoXmlSerilizable<RejectedReason15Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static RejectedReason15Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => RejectedReason15Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => RejectedReason15Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid RejectedReason15Choice choice.")
        };
    }
}
