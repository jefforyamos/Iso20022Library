﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PendingCancellationReason8Choice.  ISO2002 ID# _0q2Z0RUOEeuYppTwWp55gA.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between a standard code or a proprietary code to specify the reason why a cancellation request sent for the related instruction is pending.
/// </summary>
[KnownType(typeof(PendingCancellationReason8Choice.Code))]
[KnownType(typeof(PendingCancellationReason8Choice.Proprietary))]
public abstract partial record PendingCancellationReason8Choice_ : IIsoXmlSerilizable<PendingCancellationReason8Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static PendingCancellationReason8Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => PendingCancellationReason8Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => PendingCancellationReason8Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid PendingCancellationReason8Choice choice.")
        };
    }
}
