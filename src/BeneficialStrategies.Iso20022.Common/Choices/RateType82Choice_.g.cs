﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RateType82Choice.  ISO2002 ID# _-lv7cwVSEeqjd8n6wD9JVw.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between a standard code or proprietary code to specify a rate type.
/// </summary>
[KnownType(typeof(RateType82Choice.Code))]
[KnownType(typeof(RateType82Choice.Proprietary))]
public abstract partial record RateType82Choice_ : IIsoXmlSerilizable<RateType82Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static RateType82Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => RateType82Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => RateType82Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid RateType82Choice choice.")
        };
    }
}
