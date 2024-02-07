﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ProcessingStatus68Choice.  ISO2002 ID# _TDntl-FWEeWIA4E9cYSxxQ.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format for the processing status.
/// </summary>
[KnownType(typeof(ProcessingStatus68Choice.Code))]
[KnownType(typeof(ProcessingStatus68Choice.Proprietary))]
public abstract partial record ProcessingStatus68Choice_ : IIsoXmlSerilizable<ProcessingStatus68Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static ProcessingStatus68Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => ProcessingStatus68Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => ProcessingStatus68Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid ProcessingStatus68Choice choice.")
        };
    }
}
