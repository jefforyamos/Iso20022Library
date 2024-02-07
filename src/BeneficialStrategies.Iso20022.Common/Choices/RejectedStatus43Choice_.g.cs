﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RejectedStatus43Choice.  ISO2002 ID# _KVKx-xn1EeyroI8qKgB7Mg.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between a reason and no reason for the corporate action instruction processing rejected status.
/// </summary>
[KnownType(typeof(RejectedStatus43Choice.NoSpecifiedReason))]
[KnownType(typeof(RejectedStatus43Choice.Reason))]
public abstract partial record RejectedStatus43Choice_ : IIsoXmlSerilizable<RejectedStatus43Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static RejectedStatus43Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "NoSpcfdRsn" => RejectedStatus43Choice.NoSpecifiedReason.Deserialize(elementWithPayload),
             "Rsn" => RejectedStatus43Choice.Reason.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid RejectedStatus43Choice choice.")
        };
    }
}
