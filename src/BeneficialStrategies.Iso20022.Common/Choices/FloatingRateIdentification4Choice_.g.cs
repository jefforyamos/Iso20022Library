﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for FloatingRateIdentification4Choice.  ISO2002 ID# _LrWLESjFEeuKKc2MztSwPw.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Identifies various types of floating rates.
/// </summary>
[KnownType(typeof(FloatingRateIdentification4Choice.Code))]
[KnownType(typeof(FloatingRateIdentification4Choice.Proprietary))]
public abstract partial record FloatingRateIdentification4Choice_ : IIsoXmlSerilizable<FloatingRateIdentification4Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static FloatingRateIdentification4Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => FloatingRateIdentification4Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => FloatingRateIdentification4Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid FloatingRateIdentification4Choice choice.")
        };
    }
}
