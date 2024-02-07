﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for MatchingStatus23Choice.  ISO2002 ID# _0pUxkWXREeOWzsrIp2keDA.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of status for the matching.
/// </summary>
[KnownType(typeof(MatchingStatus23Choice.Matched))]
[KnownType(typeof(MatchingStatus23Choice.MatchedWithTolerance))]
[KnownType(typeof(MatchingStatus23Choice.MatchingAlleged))]
[KnownType(typeof(MatchingStatus23Choice.Unmatched))]
[KnownType(typeof(MatchingStatus23Choice.ProprietaryStatus))]
public abstract partial record MatchingStatus23Choice_ : IIsoXmlSerilizable<MatchingStatus23Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static MatchingStatus23Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Mtchd" => MatchingStatus23Choice.Matched.Deserialize(elementWithPayload),
             "MtchdWthTlrnce" => MatchingStatus23Choice.MatchedWithTolerance.Deserialize(elementWithPayload),
             "MtchgAllgd" => MatchingStatus23Choice.MatchingAlleged.Deserialize(elementWithPayload),
             "Umtchd" => MatchingStatus23Choice.Unmatched.Deserialize(elementWithPayload),
             "PrtrySts" => MatchingStatus23Choice.ProprietaryStatus.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid MatchingStatus23Choice choice.")
        };
    }
}
