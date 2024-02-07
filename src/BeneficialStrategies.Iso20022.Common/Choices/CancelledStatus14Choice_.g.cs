﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CancelledStatus14Choice.  ISO2002 ID# _ce-515KQEeWHWpTQn1FFVg.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between a reason or no reason for the corporate action instruction or instruction cancellation cancelled/cancellation completed status.
/// </summary>
[KnownType(typeof(CancelledStatus14Choice.NoSpecifiedReason))]
[KnownType(typeof(CancelledStatus14Choice.Reason))]
public abstract partial record CancelledStatus14Choice_ : IIsoXmlSerilizable<CancelledStatus14Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static CancelledStatus14Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "NoSpcfdRsn" => CancelledStatus14Choice.NoSpecifiedReason.Deserialize(elementWithPayload),
             "Rsn" => CancelledStatus14Choice.Reason.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid CancelledStatus14Choice choice.")
        };
    }
}
