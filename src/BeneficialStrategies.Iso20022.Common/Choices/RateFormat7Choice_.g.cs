﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RateFormat7Choice.  ISO2002 ID# _8_swAfmaEeCgTOP8zvX1cw.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between a rate or an unspecified rate.
/// </summary>
[KnownType(typeof(RateFormat7Choice.Rate))]
[KnownType(typeof(RateFormat7Choice.NotSpecifiedRate))]
public abstract partial record RateFormat7Choice_ : IIsoXmlSerilizable<RateFormat7Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static RateFormat7Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Rate" => RateFormat7Choice.Rate.Deserialize(elementWithPayload),
             "NotSpcfdRate" => RateFormat7Choice.NotSpecifiedRate.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid RateFormat7Choice choice.")
        };
    }
}
