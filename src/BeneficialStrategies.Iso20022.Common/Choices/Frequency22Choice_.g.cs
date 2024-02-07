﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for Frequency22Choice.  ISO2002 ID# _Zg-Akf3-EeS5i-mwuUyZxw.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format for a frequency, for example, the frequency of delivery of a statement.
/// </summary>
[KnownType(typeof(Frequency22Choice.Code))]
[KnownType(typeof(Frequency22Choice.Proprietary))]
public abstract partial record Frequency22Choice_ : IIsoXmlSerilizable<Frequency22Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static Frequency22Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => Frequency22Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => Frequency22Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid Frequency22Choice choice.")
        };
    }
}
