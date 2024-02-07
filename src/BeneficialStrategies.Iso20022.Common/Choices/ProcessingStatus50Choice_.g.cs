﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ProcessingStatus50Choice.  ISO2002 ID# _iSz08TnvEeWfSKvvZlhRKg.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format for the processing status.
/// </summary>
[KnownType(typeof(ProcessingStatus50Choice.AcknowledgedAccepted))]
[KnownType(typeof(ProcessingStatus50Choice.Rejected))]
[KnownType(typeof(ProcessingStatus50Choice.Completed))]
[KnownType(typeof(ProcessingStatus50Choice.Denied))]
[KnownType(typeof(ProcessingStatus50Choice.Pending))]
[KnownType(typeof(ProcessingStatus50Choice.Proprietary))]
public abstract partial record ProcessingStatus50Choice_ : IIsoXmlSerilizable<ProcessingStatus50Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static ProcessingStatus50Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "AckdAccptd" => ProcessingStatus50Choice.AcknowledgedAccepted.Deserialize(elementWithPayload),
             "Rjctd" => ProcessingStatus50Choice.Rejected.Deserialize(elementWithPayload),
             "Cmpltd" => ProcessingStatus50Choice.Completed.Deserialize(elementWithPayload),
             "Dnd" => ProcessingStatus50Choice.Denied.Deserialize(elementWithPayload),
             "Pdg" => ProcessingStatus50Choice.Pending.Deserialize(elementWithPayload),
             "Prtry" => ProcessingStatus50Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid ProcessingStatus50Choice choice.")
        };
    }
}
