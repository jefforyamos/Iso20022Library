﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for FailingStatus11Choice.  ISO2002 ID# _5SGOr5NLEeWGlc8L7oPDIg.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of failing status.
/// </summary>
[KnownType(typeof(FailingStatus11Choice.NoSpecifiedReason))]
[KnownType(typeof(FailingStatus11Choice.Reason))]
public abstract partial record FailingStatus11Choice_ : IIsoXmlSerilizable<FailingStatus11Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static FailingStatus11Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "NoSpcfdRsn" => FailingStatus11Choice.NoSpecifiedReason.Deserialize(elementWithPayload),
             "Rsn" => FailingStatus11Choice.Reason.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid FailingStatus11Choice choice.")
        };
    }
}
