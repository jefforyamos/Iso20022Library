﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for TaxCreditRateFormat8Choice.  ISO2002 ID# _W5KBb0EIEeWVgfuHGaKtRQ.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between an amount or a rate or an unspecified rate.
/// </summary>
[KnownType(typeof(TaxCreditRateFormat8Choice.Rate))]
[KnownType(typeof(TaxCreditRateFormat8Choice.Amount))]
[KnownType(typeof(TaxCreditRateFormat8Choice.RateTypeAndAmountAndRateStatus))]
[KnownType(typeof(TaxCreditRateFormat8Choice.NotSpecifiedRate))]
public abstract partial record TaxCreditRateFormat8Choice_ : IIsoXmlSerilizable<TaxCreditRateFormat8Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static TaxCreditRateFormat8Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Rate" => TaxCreditRateFormat8Choice.Rate.Deserialize(elementWithPayload),
             "Amt" => TaxCreditRateFormat8Choice.Amount.Deserialize(elementWithPayload),
             "RateTpAndAmtAndRateSts" => TaxCreditRateFormat8Choice.RateTypeAndAmountAndRateStatus.Deserialize(elementWithPayload),
             "NotSpcfdRate" => TaxCreditRateFormat8Choice.NotSpecifiedRate.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid TaxCreditRateFormat8Choice choice.")
        };
    }
}
