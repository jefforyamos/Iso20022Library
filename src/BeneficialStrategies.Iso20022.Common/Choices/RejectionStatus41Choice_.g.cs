﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RejectionStatus41Choice.  ISO2002 ID# _dszBJji8Eeydid5dcNPKvg.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Specifies whether the status is provided with a reason or not.
/// </summary>
[KnownType(typeof(RejectionStatus41Choice.NoSpecifiedReason))]
[KnownType(typeof(RejectionStatus41Choice.Reason))]
public abstract partial record RejectionStatus41Choice_ : IIsoXmlSerilizable<RejectionStatus41Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static RejectionStatus41Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "NoSpcfdRsn" => RejectionStatus41Choice.NoSpecifiedReason.Deserialize(elementWithPayload),
             "Rsn" => RejectionStatus41Choice.Reason.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid RejectionStatus41Choice choice.")
        };
    }
}
