﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for FailingStatus12Choice.  ISO2002 ID# _6BKT-ZNLEeWGlc8L7oPDIg.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of failing status.
/// </summary>
[KnownType(typeof(FailingStatus12Choice.NoSpecifiedReason))]
[KnownType(typeof(FailingStatus12Choice.Reason))]
public abstract partial record FailingStatus12Choice_ : IIsoXmlSerilizable<FailingStatus12Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static FailingStatus12Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "NoSpcfdRsn" => FailingStatus12Choice.NoSpecifiedReason.Deserialize(elementWithPayload),
             "Rsn" => FailingStatus12Choice.Reason.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid FailingStatus12Choice choice.")
        };
    }
}
