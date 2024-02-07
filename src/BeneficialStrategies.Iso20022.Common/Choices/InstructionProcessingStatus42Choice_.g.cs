﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for InstructionProcessingStatus42Choice.  ISO2002 ID# _7KKTcQpJEeup4r-PFG2T5Q.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of formats for an instruction processing status.
/// </summary>
[KnownType(typeof(InstructionProcessingStatus42Choice.PendingProcessing))]
[KnownType(typeof(InstructionProcessingStatus42Choice.CancellationRequested))]
[KnownType(typeof(InstructionProcessingStatus42Choice.AcknowledgedAccepted))]
[KnownType(typeof(InstructionProcessingStatus42Choice.Cancelled))]
[KnownType(typeof(InstructionProcessingStatus42Choice.Generated))]
[KnownType(typeof(InstructionProcessingStatus42Choice.Repair))]
[KnownType(typeof(InstructionProcessingStatus42Choice.PendingCancellation))]
[KnownType(typeof(InstructionProcessingStatus42Choice.ModificationRequested))]
public abstract partial record InstructionProcessingStatus42Choice_ : IIsoXmlSerilizable<InstructionProcessingStatus42Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static InstructionProcessingStatus42Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "PdgPrcg" => InstructionProcessingStatus42Choice.PendingProcessing.Deserialize(elementWithPayload),
             "CxlReqd" => InstructionProcessingStatus42Choice.CancellationRequested.Deserialize(elementWithPayload),
             "AckdAccptd" => InstructionProcessingStatus42Choice.AcknowledgedAccepted.Deserialize(elementWithPayload),
             "Canc" => InstructionProcessingStatus42Choice.Cancelled.Deserialize(elementWithPayload),
             "Gnrtd" => InstructionProcessingStatus42Choice.Generated.Deserialize(elementWithPayload),
             "Rpr" => InstructionProcessingStatus42Choice.Repair.Deserialize(elementWithPayload),
             "PdgCxl" => InstructionProcessingStatus42Choice.PendingCancellation.Deserialize(elementWithPayload),
             "ModReqd" => InstructionProcessingStatus42Choice.ModificationRequested.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid InstructionProcessingStatus42Choice choice.")
        };
    }
}
