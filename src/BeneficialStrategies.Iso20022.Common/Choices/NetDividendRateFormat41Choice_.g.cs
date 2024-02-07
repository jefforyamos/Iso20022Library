﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for NetDividendRateFormat41Choice.  ISO2002 ID# _-lkh7AVSEeqjd8n6wD9JVw.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between an amount or an unspecified rate.
/// </summary>
[KnownType(typeof(NetDividendRateFormat41Choice.Amount))]
[KnownType(typeof(NetDividendRateFormat41Choice.AmountAndRateStatus))]
[KnownType(typeof(NetDividendRateFormat41Choice.RateTypeAndAmountAndRateStatus))]
public abstract partial record NetDividendRateFormat41Choice_ : IIsoXmlSerilizable<NetDividendRateFormat41Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static NetDividendRateFormat41Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Amt" => NetDividendRateFormat41Choice.Amount.Deserialize(elementWithPayload),
             "AmtAndRateSts" => NetDividendRateFormat41Choice.AmountAndRateStatus.Deserialize(elementWithPayload),
             "RateTpAndAmtAndRateSts" => NetDividendRateFormat41Choice.RateTypeAndAmountAndRateStatus.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid NetDividendRateFormat41Choice choice.")
        };
    }
}
