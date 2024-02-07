﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for MatchingDenied3Choice.  ISO2002 ID# _ZYK_kTt4EeW638lNyHKv7A.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Specifies the matching processing change requested.
/// </summary>
[KnownType(typeof(MatchingDenied3Choice.Code))]
[KnownType(typeof(MatchingDenied3Choice.Proprietary))]
public abstract partial record MatchingDenied3Choice_ : IIsoXmlSerilizable<MatchingDenied3Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static MatchingDenied3Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => MatchingDenied3Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => MatchingDenied3Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid MatchingDenied3Choice choice.")
        };
    }
}
