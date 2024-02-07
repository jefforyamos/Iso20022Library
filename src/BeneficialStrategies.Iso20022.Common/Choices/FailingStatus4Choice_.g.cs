﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for FailingStatus4Choice.  ISO2002 ID# _Fe4Y0f7rEeCvPoRGOxRobQ.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of failing status.
/// </summary>
[KnownType(typeof(FailingStatus4Choice.NoSpecifiedReason))]
[KnownType(typeof(FailingStatus4Choice.Reason))]
public abstract partial record FailingStatus4Choice_ : IIsoXmlSerilizable<FailingStatus4Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static FailingStatus4Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "NoSpcfdRsn" => FailingStatus4Choice.NoSpecifiedReason.Deserialize(elementWithPayload),
             "Rsn" => FailingStatus4Choice.Reason.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid FailingStatus4Choice choice.")
        };
    }
}
