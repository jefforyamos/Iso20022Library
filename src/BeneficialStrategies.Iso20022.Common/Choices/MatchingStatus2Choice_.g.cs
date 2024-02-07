﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for MatchingStatus2Choice.  ISO2002 ID# _UaHY6Np-Ed-ak6NoX_4Aeg_-283039310.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format for the matching status.
/// </summary>
[KnownType(typeof(MatchingStatus2Choice.Matched))]
[KnownType(typeof(MatchingStatus2Choice.Unmatched))]
[KnownType(typeof(MatchingStatus2Choice.Proprietary))]
public abstract partial record MatchingStatus2Choice_ : IIsoXmlSerilizable<MatchingStatus2Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static MatchingStatus2Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Mtchd" => MatchingStatus2Choice.Matched.Deserialize(elementWithPayload),
             "Umtchd" => MatchingStatus2Choice.Unmatched.Deserialize(elementWithPayload),
             "Prtry" => MatchingStatus2Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid MatchingStatus2Choice choice.")
        };
    }
}
