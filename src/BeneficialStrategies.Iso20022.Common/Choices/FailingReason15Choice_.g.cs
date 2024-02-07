﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for FailingReason15Choice.  ISO2002 ID# _8Qdc15NLEeWGlc8L7oPDIg.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format for the failing reason.
/// </summary>
[KnownType(typeof(FailingReason15Choice.Code))]
[KnownType(typeof(FailingReason15Choice.Proprietary))]
public abstract partial record FailingReason15Choice_ : IIsoXmlSerilizable<FailingReason15Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static FailingReason15Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => FailingReason15Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => FailingReason15Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid FailingReason15Choice choice.")
        };
    }
}
