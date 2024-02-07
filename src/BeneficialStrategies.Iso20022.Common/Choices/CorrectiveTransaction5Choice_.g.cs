﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CorrectiveTransaction5Choice.  ISO2002 ID# _tNTsINizEeq5MfBBxQig1Q.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Specifies the corrective transaction on which the investigation is processed.
/// </summary>
[KnownType(typeof(CorrectiveTransaction5Choice.Initiation))]
[KnownType(typeof(CorrectiveTransaction5Choice.Interbank))]
public abstract partial record CorrectiveTransaction5Choice_ : IIsoXmlSerilizable<CorrectiveTransaction5Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static CorrectiveTransaction5Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Initn" => CorrectiveTransaction5Choice.Initiation.Deserialize(elementWithPayload),
             "IntrBk" => CorrectiveTransaction5Choice.Interbank.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid CorrectiveTransaction5Choice choice.")
        };
    }
}
