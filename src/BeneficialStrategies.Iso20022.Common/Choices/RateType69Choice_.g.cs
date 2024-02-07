﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RateType69Choice.  ISO2002 ID# _AFujLZb8Eee8S7xwGG7Veg.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between a standard code or proprietary code to specify a rate type.
/// </summary>
[KnownType(typeof(RateType69Choice.Code))]
[KnownType(typeof(RateType69Choice.Proprietary))]
public abstract partial record RateType69Choice_ : IIsoXmlSerilizable<RateType69Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static RateType69Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => RateType69Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => RateType69Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid RateType69Choice choice.")
        };
    }
}
