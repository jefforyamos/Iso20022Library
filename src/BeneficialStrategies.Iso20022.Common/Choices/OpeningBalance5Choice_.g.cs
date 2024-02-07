﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for OpeningBalance5Choice.  ISO2002 ID# _8bhdbZNLEeWGlc8L7oPDIg.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of opening balance.
/// </summary>
[KnownType(typeof(OpeningBalance5Choice.First))]
[KnownType(typeof(OpeningBalance5Choice.Intermediary))]
public abstract partial record OpeningBalance5Choice_ : IIsoXmlSerilizable<OpeningBalance5Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static OpeningBalance5Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Frst" => OpeningBalance5Choice.First.Deserialize(elementWithPayload),
             "Intrmy" => OpeningBalance5Choice.Intermediary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid OpeningBalance5Choice choice.")
        };
    }
}
