﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for InstructionCancellationRequestStatus14Choice.  ISO2002 ID# _peWYkzi7Eeydid5dcNPKvg.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between different instruction cancellation request statuses.
/// </summary>
[KnownType(typeof(InstructionCancellationRequestStatus14Choice.CancellationCompleted))]
[KnownType(typeof(InstructionCancellationRequestStatus14Choice.Accepted))]
[KnownType(typeof(InstructionCancellationRequestStatus14Choice.Rejected))]
[KnownType(typeof(InstructionCancellationRequestStatus14Choice.PendingCancellation))]
[KnownType(typeof(InstructionCancellationRequestStatus14Choice.ProprietaryStatus))]
public abstract partial record InstructionCancellationRequestStatus14Choice_ : IIsoXmlSerilizable<InstructionCancellationRequestStatus14Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static InstructionCancellationRequestStatus14Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "CxlCmpltd" => InstructionCancellationRequestStatus14Choice.CancellationCompleted.Deserialize(elementWithPayload),
             "Accptd" => InstructionCancellationRequestStatus14Choice.Accepted.Deserialize(elementWithPayload),
             "Rjctd" => InstructionCancellationRequestStatus14Choice.Rejected.Deserialize(elementWithPayload),
             "PdgCxl" => InstructionCancellationRequestStatus14Choice.PendingCancellation.Deserialize(elementWithPayload),
             "PrtrySts" => InstructionCancellationRequestStatus14Choice.ProprietaryStatus.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid InstructionCancellationRequestStatus14Choice choice.")
        };
    }
}
