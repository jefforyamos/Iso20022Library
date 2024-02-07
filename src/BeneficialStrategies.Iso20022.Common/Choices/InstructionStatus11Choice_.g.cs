﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for InstructionStatus11Choice.  ISO2002 ID# _hY-q3RrpEeyhRdHRjakS2w.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Status applying globally to the instruction received.
/// </summary>
[KnownType(typeof(InstructionStatus11Choice.ProcessingStatus))]
[KnownType(typeof(InstructionStatus11Choice.Rejected))]
[KnownType(typeof(InstructionStatus11Choice.Pending))]
public abstract partial record InstructionStatus11Choice_ : IIsoXmlSerilizable<InstructionStatus11Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static InstructionStatus11Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "PrcgSts" => InstructionStatus11Choice.ProcessingStatus.Deserialize(elementWithPayload),
             "Rjctd" => InstructionStatus11Choice.Rejected.Deserialize(elementWithPayload),
             "Pdg" => InstructionStatus11Choice.Pending.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid InstructionStatus11Choice choice.")
        };
    }
}
