﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AcknowledgementReason15Choice.  ISO2002 ID# _Pea6ETq5EeWyoP0PbocV1Q.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format for the acknowledgement reason.
/// </summary>
[KnownType(typeof(AcknowledgementReason15Choice.Code))]
[KnownType(typeof(AcknowledgementReason15Choice.Proprietary))]
public abstract partial record AcknowledgementReason15Choice_ : IIsoXmlSerilizable<AcknowledgementReason15Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static AcknowledgementReason15Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => AcknowledgementReason15Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => AcknowledgementReason15Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid AcknowledgementReason15Choice choice.")
        };
    }
}
