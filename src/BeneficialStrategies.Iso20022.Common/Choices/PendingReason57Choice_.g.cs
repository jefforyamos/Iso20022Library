﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PendingReason57Choice.  ISO2002 ID# _FxTUU-6KEeqc-LCjwLsUVg.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between a standard code and a proprietary code to specify the reason why the instruction/event has a pending status.
/// </summary>
[KnownType(typeof(PendingReason57Choice.Code))]
[KnownType(typeof(PendingReason57Choice.Proprietary))]
public abstract partial record PendingReason57Choice_ : IIsoXmlSerilizable<PendingReason57Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static PendingReason57Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => PendingReason57Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => PendingReason57Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid PendingReason57Choice choice.")
        };
    }
}
