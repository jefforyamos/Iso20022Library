﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RejectedReason16Choice.  ISO2002 ID# _u7hOkWOAEeWwOJYz8znDIw.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of formats for the specification of the rejected reason.
/// </summary>
[KnownType(typeof(RejectedReason16Choice.Code))]
[KnownType(typeof(RejectedReason16Choice.Proprietary))]
public abstract partial record RejectedReason16Choice_ : IIsoXmlSerilizable<RejectedReason16Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static RejectedReason16Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => RejectedReason16Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => RejectedReason16Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid RejectedReason16Choice choice.")
        };
    }
}
