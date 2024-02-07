﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RateAndAmountFormat54Choice.  ISO2002 ID# _TTFAsdEDEeetfps_dpxRmg.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format between a rate or a deemed rate type and rate or an amount or a unspecified rate.
/// </summary>
[KnownType(typeof(RateAndAmountFormat54Choice.Rate))]
[KnownType(typeof(RateAndAmountFormat54Choice.Amount))]
[KnownType(typeof(RateAndAmountFormat54Choice.RateTypeAndAmountAndRateStatus))]
[KnownType(typeof(RateAndAmountFormat54Choice.RateTypeAndRate))]
public abstract partial record RateAndAmountFormat54Choice_ : IIsoXmlSerilizable<RateAndAmountFormat54Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static RateAndAmountFormat54Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Rate" => RateAndAmountFormat54Choice.Rate.Deserialize(elementWithPayload),
             "Amt" => RateAndAmountFormat54Choice.Amount.Deserialize(elementWithPayload),
             "RateTpAndAmtAndRateSts" => RateAndAmountFormat54Choice.RateTypeAndAmountAndRateStatus.Deserialize(elementWithPayload),
             "RateTpAndRate" => RateAndAmountFormat54Choice.RateTypeAndRate.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid RateAndAmountFormat54Choice choice.")
        };
    }
}
