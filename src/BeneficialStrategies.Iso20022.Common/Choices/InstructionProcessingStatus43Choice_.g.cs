﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for InstructionProcessingStatus43Choice.  ISO2002 ID# _pUH1qR9QEeuFz_FaCzCLgQ.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between different instruction processing statuses.
/// </summary>
[KnownType(typeof(InstructionProcessingStatus43Choice.Accepted))]
[KnownType(typeof(InstructionProcessingStatus43Choice.Cancelled))]
[KnownType(typeof(InstructionProcessingStatus43Choice.AcceptedForFurtherProcessing))]
[KnownType(typeof(InstructionProcessingStatus43Choice.Rejected))]
[KnownType(typeof(InstructionProcessingStatus43Choice.Pending))]
[KnownType(typeof(InstructionProcessingStatus43Choice.PendingCancellation))]
[KnownType(typeof(InstructionProcessingStatus43Choice.Covered))]
[KnownType(typeof(InstructionProcessingStatus43Choice.Uncovered))]
public abstract partial record InstructionProcessingStatus43Choice_ : IIsoXmlSerilizable<InstructionProcessingStatus43Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static InstructionProcessingStatus43Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Accptd" => InstructionProcessingStatus43Choice.Accepted.Deserialize(elementWithPayload),
             "Canc" => InstructionProcessingStatus43Choice.Cancelled.Deserialize(elementWithPayload),
             "AccptdForFrthrPrcg" => InstructionProcessingStatus43Choice.AcceptedForFurtherProcessing.Deserialize(elementWithPayload),
             "Rjctd" => InstructionProcessingStatus43Choice.Rejected.Deserialize(elementWithPayload),
             "Pdg" => InstructionProcessingStatus43Choice.Pending.Deserialize(elementWithPayload),
             "PdgCxl" => InstructionProcessingStatus43Choice.PendingCancellation.Deserialize(elementWithPayload),
             "Cvrd" => InstructionProcessingStatus43Choice.Covered.Deserialize(elementWithPayload),
             "Ucvrd" => InstructionProcessingStatus43Choice.Uncovered.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid InstructionProcessingStatus43Choice choice.")
        };
    }
}
