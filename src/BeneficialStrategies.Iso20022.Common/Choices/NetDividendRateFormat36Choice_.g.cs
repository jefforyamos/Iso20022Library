﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for NetDividendRateFormat36Choice.  ISO2002 ID# _k9xM083xEee5nJBZsW8MFQ.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between an amount or an unspecified rate.
/// </summary>
[KnownType(typeof(NetDividendRateFormat36Choice.Amount))]
[KnownType(typeof(NetDividendRateFormat36Choice.AmountAndRateStatus))]
[KnownType(typeof(NetDividendRateFormat36Choice.RateTypeAndAmountAndRateStatus))]
[KnownType(typeof(NetDividendRateFormat36Choice.NotSpecifiedRate))]
public abstract partial record NetDividendRateFormat36Choice_ : IIsoXmlSerilizable<NetDividendRateFormat36Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static NetDividendRateFormat36Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Amt" => NetDividendRateFormat36Choice.Amount.Deserialize(elementWithPayload),
             "AmtAndRateSts" => NetDividendRateFormat36Choice.AmountAndRateStatus.Deserialize(elementWithPayload),
             "RateTpAndAmtAndRateSts" => NetDividendRateFormat36Choice.RateTypeAndAmountAndRateStatus.Deserialize(elementWithPayload),
             "NotSpcfdRate" => NetDividendRateFormat36Choice.NotSpecifiedRate.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid NetDividendRateFormat36Choice choice.")
        };
    }
}
