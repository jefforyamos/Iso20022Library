﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for InstructionProcessingStatus27Choice.  ISO2002 ID# _8VJItZNLEeWGlc8L7oPDIg.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format for the instruction processing status.
/// </summary>
[KnownType(typeof(InstructionProcessingStatus27Choice.PendingProcessing))]
[KnownType(typeof(InstructionProcessingStatus27Choice.CancellationRequested))]
[KnownType(typeof(InstructionProcessingStatus27Choice.AcknowledgedAccepted))]
[KnownType(typeof(InstructionProcessingStatus27Choice.Cancelled))]
[KnownType(typeof(InstructionProcessingStatus27Choice.Generated))]
[KnownType(typeof(InstructionProcessingStatus27Choice.Repair))]
[KnownType(typeof(InstructionProcessingStatus27Choice.PendingCancellation))]
[KnownType(typeof(InstructionProcessingStatus27Choice.ModificationRequested))]
public abstract partial record InstructionProcessingStatus27Choice_ : IIsoXmlSerilizable<InstructionProcessingStatus27Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static InstructionProcessingStatus27Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "PdgPrcg" => InstructionProcessingStatus27Choice.PendingProcessing.Deserialize(elementWithPayload),
             "CxlReqd" => InstructionProcessingStatus27Choice.CancellationRequested.Deserialize(elementWithPayload),
             "AckdAccptd" => InstructionProcessingStatus27Choice.AcknowledgedAccepted.Deserialize(elementWithPayload),
             "Canc" => InstructionProcessingStatus27Choice.Cancelled.Deserialize(elementWithPayload),
             "Gnrtd" => InstructionProcessingStatus27Choice.Generated.Deserialize(elementWithPayload),
             "Rpr" => InstructionProcessingStatus27Choice.Repair.Deserialize(elementWithPayload),
             "PdgCxl" => InstructionProcessingStatus27Choice.PendingCancellation.Deserialize(elementWithPayload),
             "ModReqd" => InstructionProcessingStatus27Choice.ModificationRequested.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid InstructionProcessingStatus27Choice choice.")
        };
    }
}
