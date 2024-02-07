﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for InstructionProcessingStatus12Choice.  ISO2002 ID# _lg96YRN-EeKyONjZVQUqzg.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between different instruction processing statuses.
/// </summary>
[KnownType(typeof(InstructionProcessingStatus12Choice.Cancelled))]
[KnownType(typeof(InstructionProcessingStatus12Choice.AcceptedForFurtherProcessing))]
[KnownType(typeof(InstructionProcessingStatus12Choice.Rejected))]
[KnownType(typeof(InstructionProcessingStatus12Choice.Pending))]
[KnownType(typeof(InstructionProcessingStatus12Choice.DefaultAction))]
[KnownType(typeof(InstructionProcessingStatus12Choice.StandingInstruction))]
[KnownType(typeof(InstructionProcessingStatus12Choice.ProprietaryStatus))]
public abstract partial record InstructionProcessingStatus12Choice_ : IIsoXmlSerilizable<InstructionProcessingStatus12Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static InstructionProcessingStatus12Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Canc" => InstructionProcessingStatus12Choice.Cancelled.Deserialize(elementWithPayload),
             "AccptdForFrthrPrcg" => InstructionProcessingStatus12Choice.AcceptedForFurtherProcessing.Deserialize(elementWithPayload),
             "Rjctd" => InstructionProcessingStatus12Choice.Rejected.Deserialize(elementWithPayload),
             "Pdg" => InstructionProcessingStatus12Choice.Pending.Deserialize(elementWithPayload),
             "DfltActn" => InstructionProcessingStatus12Choice.DefaultAction.Deserialize(elementWithPayload),
             "StgInstr" => InstructionProcessingStatus12Choice.StandingInstruction.Deserialize(elementWithPayload),
             "PrtrySts" => InstructionProcessingStatus12Choice.ProprietaryStatus.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid InstructionProcessingStatus12Choice choice.")
        };
    }
}
