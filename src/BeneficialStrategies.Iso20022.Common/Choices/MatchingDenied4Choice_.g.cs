﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for MatchingDenied4Choice.  ISO2002 ID# _6GWWDZNLEeWGlc8L7oPDIg.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Specifies the matching processing change requested.
/// </summary>
[KnownType(typeof(MatchingDenied4Choice.Code))]
[KnownType(typeof(MatchingDenied4Choice.Proprietary))]
public abstract partial record MatchingDenied4Choice_ : IIsoXmlSerilizable<MatchingDenied4Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static MatchingDenied4Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => MatchingDenied4Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => MatchingDenied4Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid MatchingDenied4Choice choice.")
        };
    }
}
