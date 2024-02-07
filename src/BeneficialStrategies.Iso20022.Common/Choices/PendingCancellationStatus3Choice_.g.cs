﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PendingCancellationStatus3Choice.  ISO2002 ID# _lFW2jQFnEeG2HcWTGfYeDQ.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between a reason or no reason for the corporate action instruction cancellation pending cancellation status.
/// </summary>
[KnownType(typeof(PendingCancellationStatus3Choice.NotSpecifiedReason))]
[KnownType(typeof(PendingCancellationStatus3Choice.Reason))]
public abstract partial record PendingCancellationStatus3Choice_ : IIsoXmlSerilizable<PendingCancellationStatus3Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static PendingCancellationStatus3Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "NotSpcfdRsn" => PendingCancellationStatus3Choice.NotSpecifiedReason.Deserialize(elementWithPayload),
             "Rsn" => PendingCancellationStatus3Choice.Reason.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid PendingCancellationStatus3Choice choice.")
        };
    }
}
