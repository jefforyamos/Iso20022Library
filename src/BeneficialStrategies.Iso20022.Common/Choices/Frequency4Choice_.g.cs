﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for Frequency4Choice.  ISO2002 ID# _QxXJitp-Ed-ak6NoX_4Aeg_-163463652.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format for a frequency, for example, the frequency of delivery of a statement.
/// </summary>
[KnownType(typeof(Frequency4Choice.Code))]
[KnownType(typeof(Frequency4Choice.Proprietary))]
public abstract partial record Frequency4Choice_ : IIsoXmlSerilizable<Frequency4Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static Frequency4Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => Frequency4Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => Frequency4Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid Frequency4Choice choice.")
        };
    }
}
