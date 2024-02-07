﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for Status29Choice.  ISO2002 ID# _IYQ_QdB7EeihG9bKfarOOA.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between statuses.
/// </summary>
[KnownType(typeof(Status29Choice.Proprietary))]
[KnownType(typeof(Status29Choice.MatchingStatus))]
[KnownType(typeof(Status29Choice.InferredMatchingStatus))]
[KnownType(typeof(Status29Choice.SettlementStatus))]
[KnownType(typeof(Status29Choice.InstructionProcessingStatus))]
public abstract partial record Status29Choice_ : IIsoXmlSerilizable<Status29Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static Status29Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Prtry" => Status29Choice.Proprietary.Deserialize(elementWithPayload),
             "MtchgSts" => Status29Choice.MatchingStatus.Deserialize(elementWithPayload),
             "IfrrdMtchgSts" => Status29Choice.InferredMatchingStatus.Deserialize(elementWithPayload),
             "SttlmSts" => Status29Choice.SettlementStatus.Deserialize(elementWithPayload),
             "InstrPrcgSts" => Status29Choice.InstructionProcessingStatus.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid Status29Choice choice.")
        };
    }
}
