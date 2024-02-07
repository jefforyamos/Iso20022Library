﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for Status38Choice.  ISO2002 ID# _cOdm5SW-EeygjNFjAlVoPA.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between statuses.
/// </summary>
[KnownType(typeof(Status38Choice.Proprietary))]
[KnownType(typeof(Status38Choice.MatchingStatus))]
[KnownType(typeof(Status38Choice.InferredMatchingStatus))]
[KnownType(typeof(Status38Choice.SettlementStatus))]
[KnownType(typeof(Status38Choice.InstructionProcessingStatus))]
public abstract partial record Status38Choice_ : IIsoXmlSerilizable<Status38Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static Status38Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Prtry" => Status38Choice.Proprietary.Deserialize(elementWithPayload),
             "MtchgSts" => Status38Choice.MatchingStatus.Deserialize(elementWithPayload),
             "IfrrdMtchgSts" => Status38Choice.InferredMatchingStatus.Deserialize(elementWithPayload),
             "SttlmSts" => Status38Choice.SettlementStatus.Deserialize(elementWithPayload),
             "InstrPrcgSts" => Status38Choice.InstructionProcessingStatus.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid Status38Choice choice.")
        };
    }
}
