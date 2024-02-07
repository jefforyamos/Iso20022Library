﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SolicitationFeeRateFormat7Choice.  ISO2002 ID# _7y0l9UEKEeWVgfuHGaKtRQ.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between a rate or an unspecified rate.
/// </summary>
[KnownType(typeof(SolicitationFeeRateFormat7Choice.Rate))]
[KnownType(typeof(SolicitationFeeRateFormat7Choice.AmountToQuantity))]
[KnownType(typeof(SolicitationFeeRateFormat7Choice.Amount))]
[KnownType(typeof(SolicitationFeeRateFormat7Choice.NotSpecifiedRate))]
public abstract partial record SolicitationFeeRateFormat7Choice_ : IIsoXmlSerilizable<SolicitationFeeRateFormat7Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static SolicitationFeeRateFormat7Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Rate" => SolicitationFeeRateFormat7Choice.Rate.Deserialize(elementWithPayload),
             "AmtToQty" => SolicitationFeeRateFormat7Choice.AmountToQuantity.Deserialize(elementWithPayload),
             "Amt" => SolicitationFeeRateFormat7Choice.Amount.Deserialize(elementWithPayload),
             "NotSpcfdRate" => SolicitationFeeRateFormat7Choice.NotSpecifiedRate.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid SolicitationFeeRateFormat7Choice choice.")
        };
    }
}
