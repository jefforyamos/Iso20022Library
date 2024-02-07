﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for NetDividendRateFormat31Choice.  ISO2002 ID# _SR2f4Zb9Eee8S7xwGG7Veg.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between an amount or an unspecified rate.
/// </summary>
[KnownType(typeof(NetDividendRateFormat31Choice.Amount))]
[KnownType(typeof(NetDividendRateFormat31Choice.AmountAndRateStatus))]
[KnownType(typeof(NetDividendRateFormat31Choice.RateTypeAndAmountAndRateStatus))]
[KnownType(typeof(NetDividendRateFormat31Choice.NotSpecifiedRate))]
public abstract partial record NetDividendRateFormat31Choice_ : IIsoXmlSerilizable<NetDividendRateFormat31Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static NetDividendRateFormat31Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Amt" => NetDividendRateFormat31Choice.Amount.Deserialize(elementWithPayload),
             "AmtAndRateSts" => NetDividendRateFormat31Choice.AmountAndRateStatus.Deserialize(elementWithPayload),
             "RateTpAndAmtAndRateSts" => NetDividendRateFormat31Choice.RateTypeAndAmountAndRateStatus.Deserialize(elementWithPayload),
             "NotSpcfdRate" => NetDividendRateFormat31Choice.NotSpecifiedRate.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid NetDividendRateFormat31Choice choice.")
        };
    }
}
