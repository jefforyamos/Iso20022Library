﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for FailingStatus14Choice.  ISO2002 ID# _f99yAzi8Eeydid5dcNPKvg.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of failing status.
/// </summary>
[KnownType(typeof(FailingStatus14Choice.NoSpecifiedReason))]
[KnownType(typeof(FailingStatus14Choice.Reason))]
public abstract partial record FailingStatus14Choice_ : IIsoXmlSerilizable<FailingStatus14Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static FailingStatus14Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "NoSpcfdRsn" => FailingStatus14Choice.NoSpecifiedReason.Deserialize(elementWithPayload),
             "Rsn" => FailingStatus14Choice.Reason.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid FailingStatus14Choice choice.")
        };
    }
}
