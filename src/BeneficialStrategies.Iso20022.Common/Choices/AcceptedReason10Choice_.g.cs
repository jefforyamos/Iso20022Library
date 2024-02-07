﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AcceptedReason10Choice.  ISO2002 ID# _41TRM0GUEeWqy4niLuXETA.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between a standard code or proprietary code to specify the reason why the instruction or cancellation request has a accepted status.
/// </summary>
[KnownType(typeof(AcceptedReason10Choice.Code))]
[KnownType(typeof(AcceptedReason10Choice.Proprietary))]
public abstract partial record AcceptedReason10Choice_ : IIsoXmlSerilizable<AcceptedReason10Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static AcceptedReason10Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => AcceptedReason10Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => AcceptedReason10Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid AcceptedReason10Choice choice.")
        };
    }
}
