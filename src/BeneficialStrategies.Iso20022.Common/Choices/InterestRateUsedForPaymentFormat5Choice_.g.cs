﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for InterestRateUsedForPaymentFormat5Choice.  ISO2002 ID# _iS_3geEREd-1Ktb5rVaajw.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between an amount or a rate or an unspecified rate.
/// </summary>
[KnownType(typeof(InterestRateUsedForPaymentFormat5Choice.Rate))]
[KnownType(typeof(InterestRateUsedForPaymentFormat5Choice.Amount))]
[KnownType(typeof(InterestRateUsedForPaymentFormat5Choice.RateTypeAndAmountAndRateStatus))]
[KnownType(typeof(InterestRateUsedForPaymentFormat5Choice.NotSpecifiedRate))]
public abstract partial record InterestRateUsedForPaymentFormat5Choice_ : IIsoXmlSerilizable<InterestRateUsedForPaymentFormat5Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static InterestRateUsedForPaymentFormat5Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Rate" => InterestRateUsedForPaymentFormat5Choice.Rate.Deserialize(elementWithPayload),
             "Amt" => InterestRateUsedForPaymentFormat5Choice.Amount.Deserialize(elementWithPayload),
             "RateTpAndAmtAndRateSts" => InterestRateUsedForPaymentFormat5Choice.RateTypeAndAmountAndRateStatus.Deserialize(elementWithPayload),
             "NotSpcfdRate" => InterestRateUsedForPaymentFormat5Choice.NotSpecifiedRate.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid InterestRateUsedForPaymentFormat5Choice choice.")
        };
    }
}
