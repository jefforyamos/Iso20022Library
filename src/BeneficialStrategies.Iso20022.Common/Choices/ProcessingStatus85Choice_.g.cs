﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ProcessingStatus85Choice.  ISO2002 ID# _nnJUAytVEeyhipY4f42fZQ.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format for the processing status.
/// </summary>
[KnownType(typeof(ProcessingStatus85Choice.AcknowledgedAccepted))]
[KnownType(typeof(ProcessingStatus85Choice.Rejected))]
[KnownType(typeof(ProcessingStatus85Choice.Completed))]
[KnownType(typeof(ProcessingStatus85Choice.Denied))]
[KnownType(typeof(ProcessingStatus85Choice.Pending))]
[KnownType(typeof(ProcessingStatus85Choice.Proprietary))]
public abstract partial record ProcessingStatus85Choice_ : IIsoXmlSerilizable<ProcessingStatus85Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static ProcessingStatus85Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "AckdAccptd" => ProcessingStatus85Choice.AcknowledgedAccepted.Deserialize(elementWithPayload),
             "Rjctd" => ProcessingStatus85Choice.Rejected.Deserialize(elementWithPayload),
             "Cmpltd" => ProcessingStatus85Choice.Completed.Deserialize(elementWithPayload),
             "Dnd" => ProcessingStatus85Choice.Denied.Deserialize(elementWithPayload),
             "Pdg" => ProcessingStatus85Choice.Pending.Deserialize(elementWithPayload),
             "Prtry" => ProcessingStatus85Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid ProcessingStatus85Choice choice.")
        };
    }
}
