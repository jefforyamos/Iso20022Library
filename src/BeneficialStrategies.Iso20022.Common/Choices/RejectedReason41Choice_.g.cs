﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RejectedReason41Choice.  ISO2002 ID# _ec6qoxnyEeyroI8qKgB7Mg.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between a standard code and proprietary code to specify the reason why the instruction or cancellation request has a rejected status.
/// </summary>
[KnownType(typeof(RejectedReason41Choice.Code))]
[KnownType(typeof(RejectedReason41Choice.Proprietary))]
public abstract partial record RejectedReason41Choice_ : IIsoXmlSerilizable<RejectedReason41Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static RejectedReason41Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => RejectedReason41Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => RejectedReason41Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid RejectedReason41Choice choice.")
        };
    }
}
