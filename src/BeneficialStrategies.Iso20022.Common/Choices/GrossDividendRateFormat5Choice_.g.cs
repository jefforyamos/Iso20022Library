﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for GrossDividendRateFormat5Choice.  ISO2002 ID# _e26LIeEREd-1Ktb5rVaajw.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between an amount or an unspecified rate.
/// </summary>
[KnownType(typeof(GrossDividendRateFormat5Choice.Amount))]
[KnownType(typeof(GrossDividendRateFormat5Choice.RateTypeAndAmountAndRateStatus))]
[KnownType(typeof(GrossDividendRateFormat5Choice.NotSpecifiedRate))]
public abstract partial record GrossDividendRateFormat5Choice_ : IIsoXmlSerilizable<GrossDividendRateFormat5Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static GrossDividendRateFormat5Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Amt" => GrossDividendRateFormat5Choice.Amount.Deserialize(elementWithPayload),
             "RateTpAndAmtAndRateSts" => GrossDividendRateFormat5Choice.RateTypeAndAmountAndRateStatus.Deserialize(elementWithPayload),
             "NotSpcfdRate" => GrossDividendRateFormat5Choice.NotSpecifiedRate.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid GrossDividendRateFormat5Choice choice.")
        };
    }
}
