﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for MatchingStatus26Choice.  ISO2002 ID# _04bG4Tp4EeWVrPy0StzzSg.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format for the matching status.
/// </summary>
[KnownType(typeof(MatchingStatus26Choice.Matched))]
[KnownType(typeof(MatchingStatus26Choice.Unmatched))]
[KnownType(typeof(MatchingStatus26Choice.Proprietary))]
public abstract partial record MatchingStatus26Choice_ : IIsoXmlSerilizable<MatchingStatus26Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static MatchingStatus26Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Mtchd" => MatchingStatus26Choice.Matched.Deserialize(elementWithPayload),
             "Umtchd" => MatchingStatus26Choice.Unmatched.Deserialize(elementWithPayload),
             "Prtry" => MatchingStatus26Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid MatchingStatus26Choice choice.")
        };
    }
}
