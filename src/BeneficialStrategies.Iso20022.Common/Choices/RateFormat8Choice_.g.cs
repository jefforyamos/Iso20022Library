﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RateFormat8Choice.  ISO2002 ID# _VA1AzhLtEeKJ5uSjVyVvug.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between a rate or an unspecified rate.
/// </summary>
[KnownType(typeof(RateFormat8Choice.Rate))]
[KnownType(typeof(RateFormat8Choice.Amount))]
[KnownType(typeof(RateFormat8Choice.NotSpecifiedRate))]
public abstract partial record RateFormat8Choice_ : IIsoXmlSerilizable<RateFormat8Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static RateFormat8Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Rate" => RateFormat8Choice.Rate.Deserialize(elementWithPayload),
             "Amt" => RateFormat8Choice.Amount.Deserialize(elementWithPayload),
             "NotSpcfdRate" => RateFormat8Choice.NotSpecifiedRate.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid RateFormat8Choice choice.")
        };
    }
}
