﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RejectedStatus20Choice.  ISO2002 ID# _ce_gRZKQEeWHWpTQn1FFVg.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between a reason or no reason for the corporate action instruction processing rejected status.
/// </summary>
[KnownType(typeof(RejectedStatus20Choice.NoSpecifiedReason))]
[KnownType(typeof(RejectedStatus20Choice.Reason))]
public abstract partial record RejectedStatus20Choice_ : IIsoXmlSerilizable<RejectedStatus20Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static RejectedStatus20Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "NoSpcfdRsn" => RejectedStatus20Choice.NoSpecifiedReason.Deserialize(elementWithPayload),
             "Rsn" => RejectedStatus20Choice.Reason.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid RejectedStatus20Choice choice.")
        };
    }
}
