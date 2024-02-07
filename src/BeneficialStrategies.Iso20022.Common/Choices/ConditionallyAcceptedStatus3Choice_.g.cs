﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ConditionallyAcceptedStatus3Choice.  ISO2002 ID# _scSIAUHXEeamVPoS58KxXA.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Reason for a conditionally accepted status.
/// </summary>
[KnownType(typeof(ConditionallyAcceptedStatus3Choice.NoSpecifiedReason))]
[KnownType(typeof(ConditionallyAcceptedStatus3Choice.ReasonDetails))]
public abstract partial record ConditionallyAcceptedStatus3Choice_ : IIsoXmlSerilizable<ConditionallyAcceptedStatus3Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static ConditionallyAcceptedStatus3Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "NoSpcfdRsn" => ConditionallyAcceptedStatus3Choice.NoSpecifiedReason.Deserialize(elementWithPayload),
             "RsnDtls" => ConditionallyAcceptedStatus3Choice.ReasonDetails.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid ConditionallyAcceptedStatus3Choice choice.")
        };
    }
}
