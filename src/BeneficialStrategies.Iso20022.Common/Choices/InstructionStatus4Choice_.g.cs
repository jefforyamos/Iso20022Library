﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for InstructionStatus4Choice.  ISO2002 ID# _RCpGxdp-Ed-ak6NoX_4Aeg_-1718693015.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Status applying globally to the instruction received.
/// </summary>
[KnownType(typeof(InstructionStatus4Choice.ProcessingStatus))]
[KnownType(typeof(InstructionStatus4Choice.RejectionStatus))]
public abstract partial record InstructionStatus4Choice_ : IIsoXmlSerilizable<InstructionStatus4Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static InstructionStatus4Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "PrcgSts" => InstructionStatus4Choice.ProcessingStatus.Deserialize(elementWithPayload),
             "RjctnSts" => InstructionStatus4Choice.RejectionStatus.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid InstructionStatus4Choice choice.")
        };
    }
}
