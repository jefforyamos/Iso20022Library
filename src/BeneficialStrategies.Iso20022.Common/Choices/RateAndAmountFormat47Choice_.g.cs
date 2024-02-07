﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RateAndAmountFormat47Choice.  ISO2002 ID# _cteocZKQEeWHWpTQn1FFVg.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format between a rate or a rate type and rate or an amount or a unspecified rate.
/// </summary>
[KnownType(typeof(RateAndAmountFormat47Choice.Rate))]
[KnownType(typeof(RateAndAmountFormat47Choice.NotSpecifiedRate))]
[KnownType(typeof(RateAndAmountFormat47Choice.Amount))]
[KnownType(typeof(RateAndAmountFormat47Choice.RateTypeAndRate))]
public abstract partial record RateAndAmountFormat47Choice_ : IIsoXmlSerilizable<RateAndAmountFormat47Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static RateAndAmountFormat47Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Rate" => RateAndAmountFormat47Choice.Rate.Deserialize(elementWithPayload),
             "NotSpcfdRate" => RateAndAmountFormat47Choice.NotSpecifiedRate.Deserialize(elementWithPayload),
             "Amt" => RateAndAmountFormat47Choice.Amount.Deserialize(elementWithPayload),
             "RateTpAndRate" => RateAndAmountFormat47Choice.RateTypeAndRate.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid RateAndAmountFormat47Choice choice.")
        };
    }
}
