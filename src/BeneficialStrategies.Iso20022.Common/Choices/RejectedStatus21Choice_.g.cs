﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RejectedStatus21Choice.  ISO2002 ID# _cgn4Q5KQEeWHWpTQn1FFVg.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between a reason or no reason for the corporate action instruction processing rejected status.
/// </summary>
[KnownType(typeof(RejectedStatus21Choice.NoSpecifiedReason))]
[KnownType(typeof(RejectedStatus21Choice.Reason))]
public abstract partial record RejectedStatus21Choice_ : IIsoXmlSerilizable<RejectedStatus21Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static RejectedStatus21Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "NoSpcfdRsn" => RejectedStatus21Choice.NoSpecifiedReason.Deserialize(elementWithPayload),
             "Rsn" => RejectedStatus21Choice.Reason.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid RejectedStatus21Choice choice.")
        };
    }
}
