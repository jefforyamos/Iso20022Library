﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PriceRateOrAmountOrUnknownChoice.  ISO2002 ID# _QaaCFNp-Ed-ak6NoX_4Aeg_974375674.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of formats for the price.
/// </summary>
[KnownType(typeof(PriceRateOrAmountOrUnknownChoice.Rate))]
[KnownType(typeof(PriceRateOrAmountOrUnknownChoice.Amount))]
[KnownType(typeof(PriceRateOrAmountOrUnknownChoice.UnknownIndicator))]
public abstract partial record PriceRateOrAmountOrUnknownChoice_ : IIsoXmlSerilizable<PriceRateOrAmountOrUnknownChoice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static PriceRateOrAmountOrUnknownChoice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Rate" => PriceRateOrAmountOrUnknownChoice.Rate.Deserialize(elementWithPayload),
             "Amt" => PriceRateOrAmountOrUnknownChoice.Amount.Deserialize(elementWithPayload),
             "UknwnInd" => PriceRateOrAmountOrUnknownChoice.UnknownIndicator.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid PriceRateOrAmountOrUnknownChoice choice.")
        };
    }
}
