﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for FinancialInstrumentQuantity5Choice.  ISO2002 ID# _Soaxwdp-Ed-ak6NoX_4Aeg_1036643949.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between ways to express the quantity of the financial instrument to be redeemed.
/// </summary>
[KnownType(typeof(FinancialInstrumentQuantity5Choice.UnitsNumber))]
[KnownType(typeof(FinancialInstrumentQuantity5Choice.PercentageOfTotalSubscriptionAmount))]
[KnownType(typeof(FinancialInstrumentQuantity5Choice.NetAmount))]
[KnownType(typeof(FinancialInstrumentQuantity5Choice.GrossAmount))]
[KnownType(typeof(FinancialInstrumentQuantity5Choice.HoldingsRedemptionRate))]
public abstract partial record FinancialInstrumentQuantity5Choice_ : IIsoXmlSerilizable<FinancialInstrumentQuantity5Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static FinancialInstrumentQuantity5Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "UnitsNb" => FinancialInstrumentQuantity5Choice.UnitsNumber.Deserialize(elementWithPayload),
             "PctgOfTtlSbcptAmt" => FinancialInstrumentQuantity5Choice.PercentageOfTotalSubscriptionAmount.Deserialize(elementWithPayload),
             "NetAmt" => FinancialInstrumentQuantity5Choice.NetAmount.Deserialize(elementWithPayload),
             "GrssAmt" => FinancialInstrumentQuantity5Choice.GrossAmount.Deserialize(elementWithPayload),
             "HldgsRedRate" => FinancialInstrumentQuantity5Choice.HoldingsRedemptionRate.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid FinancialInstrumentQuantity5Choice choice.")
        };
    }
}
