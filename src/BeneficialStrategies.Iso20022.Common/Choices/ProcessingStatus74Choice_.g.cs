﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ProcessingStatus74Choice.  ISO2002 ID# _GLFV8dB7EeihG9bKfarOOA.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of formats for a processing status.
/// </summary>
[KnownType(typeof(ProcessingStatus74Choice.AcknowledgedAccepted))]
[KnownType(typeof(ProcessingStatus74Choice.PendingProcessing))]
[KnownType(typeof(ProcessingStatus74Choice.Rejected))]
[KnownType(typeof(ProcessingStatus74Choice.Repair))]
[KnownType(typeof(ProcessingStatus74Choice.Cancelled))]
[KnownType(typeof(ProcessingStatus74Choice.PendingCancellation))]
[KnownType(typeof(ProcessingStatus74Choice.Proprietary))]
[KnownType(typeof(ProcessingStatus74Choice.CancellationRequested))]
[KnownType(typeof(ProcessingStatus74Choice.ModificationRequested))]
public abstract partial record ProcessingStatus74Choice_ : IIsoXmlSerilizable<ProcessingStatus74Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static ProcessingStatus74Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "AckdAccptd" => ProcessingStatus74Choice.AcknowledgedAccepted.Deserialize(elementWithPayload),
             "PdgPrcg" => ProcessingStatus74Choice.PendingProcessing.Deserialize(elementWithPayload),
             "Rjctd" => ProcessingStatus74Choice.Rejected.Deserialize(elementWithPayload),
             "Rpr" => ProcessingStatus74Choice.Repair.Deserialize(elementWithPayload),
             "Canc" => ProcessingStatus74Choice.Cancelled.Deserialize(elementWithPayload),
             "PdgCxl" => ProcessingStatus74Choice.PendingCancellation.Deserialize(elementWithPayload),
             "Prtry" => ProcessingStatus74Choice.Proprietary.Deserialize(elementWithPayload),
             "CxlReqd" => ProcessingStatus74Choice.CancellationRequested.Deserialize(elementWithPayload),
             "ModReqd" => ProcessingStatus74Choice.ModificationRequested.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid ProcessingStatus74Choice choice.")
        };
    }
}
