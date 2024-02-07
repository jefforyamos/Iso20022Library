﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for MatchingStatus33Choice.  ISO2002 ID# _7lZ_IOB9Eei2UYJ62ws-Fw.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Provides the matching status of the instruction.
/// </summary>
[KnownType(typeof(MatchingStatus33Choice.Matched))]
[KnownType(typeof(MatchingStatus33Choice.Unmatched))]
[KnownType(typeof(MatchingStatus33Choice.Proprietary))]
public abstract partial record MatchingStatus33Choice_ : IIsoXmlSerilizable<MatchingStatus33Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static MatchingStatus33Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Mtchd" => MatchingStatus33Choice.Matched.Deserialize(elementWithPayload),
             "Umtchd" => MatchingStatus33Choice.Unmatched.Deserialize(elementWithPayload),
             "Prtry" => MatchingStatus33Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid MatchingStatus33Choice choice.")
        };
    }
}
