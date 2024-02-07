﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for InstructionCancellationRequestStatus12Choice.  ISO2002 ID# _86aSnZwtEeazcsnODTksnQ.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between different instruction cancellation request statuses.
/// </summary>
[KnownType(typeof(InstructionCancellationRequestStatus12Choice.CancellationCompleted))]
[KnownType(typeof(InstructionCancellationRequestStatus12Choice.Accepted))]
[KnownType(typeof(InstructionCancellationRequestStatus12Choice.Rejected))]
[KnownType(typeof(InstructionCancellationRequestStatus12Choice.PendingCancellation))]
[KnownType(typeof(InstructionCancellationRequestStatus12Choice.ProprietaryStatus))]
public abstract partial record InstructionCancellationRequestStatus12Choice_ : IIsoXmlSerilizable<InstructionCancellationRequestStatus12Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static InstructionCancellationRequestStatus12Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "CxlCmpltd" => InstructionCancellationRequestStatus12Choice.CancellationCompleted.Deserialize(elementWithPayload),
             "Accptd" => InstructionCancellationRequestStatus12Choice.Accepted.Deserialize(elementWithPayload),
             "Rjctd" => InstructionCancellationRequestStatus12Choice.Rejected.Deserialize(elementWithPayload),
             "PdgCxl" => InstructionCancellationRequestStatus12Choice.PendingCancellation.Deserialize(elementWithPayload),
             "PrtrySts" => InstructionCancellationRequestStatus12Choice.ProprietaryStatus.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid InstructionCancellationRequestStatus12Choice choice.")
        };
    }
}
