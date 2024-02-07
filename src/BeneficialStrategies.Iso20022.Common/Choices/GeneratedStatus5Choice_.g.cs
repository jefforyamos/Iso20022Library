﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for GeneratedStatus5Choice.  ISO2002 ID# _EsWwGyRhEeO8sskhVI3IDA.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of generated status.
/// </summary>
[KnownType(typeof(GeneratedStatus5Choice.NoSpecifiedReason))]
[KnownType(typeof(GeneratedStatus5Choice.Reason))]
public abstract partial record GeneratedStatus5Choice_ : IIsoXmlSerilizable<GeneratedStatus5Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static GeneratedStatus5Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "NoSpcfdRsn" => GeneratedStatus5Choice.NoSpecifiedReason.Deserialize(elementWithPayload),
             "Rsn" => GeneratedStatus5Choice.Reason.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid GeneratedStatus5Choice choice.")
        };
    }
}
