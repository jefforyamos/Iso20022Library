﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RejectionStatus18Choice.  ISO2002 ID# _QpvlATq2EeWyoP0PbocV1Q.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Specifies whether the status is provided with a reason or not.
/// </summary>
[KnownType(typeof(RejectionStatus18Choice.NoSpecifiedReason))]
[KnownType(typeof(RejectionStatus18Choice.Reason))]
public abstract partial record RejectionStatus18Choice_ : IIsoXmlSerilizable<RejectionStatus18Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static RejectionStatus18Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "NoSpcfdRsn" => RejectionStatus18Choice.NoSpecifiedReason.Deserialize(elementWithPayload),
             "Rsn" => RejectionStatus18Choice.Reason.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid RejectionStatus18Choice choice.")
        };
    }
}
