﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for FinancialInstrumentQuantity20Choice.  ISO2002 ID# _pPlzMQFIEeGhYJiRaPcH8g.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between formats for the quantity of security.
/// </summary>
[KnownType(typeof(FinancialInstrumentQuantity20Choice.Unit))]
[KnownType(typeof(FinancialInstrumentQuantity20Choice.FaceAmount))]
[KnownType(typeof(FinancialInstrumentQuantity20Choice.AmortisedValue))]
[KnownType(typeof(FinancialInstrumentQuantity20Choice.Code))]
public abstract partial record FinancialInstrumentQuantity20Choice_ : IIsoXmlSerilizable<FinancialInstrumentQuantity20Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static FinancialInstrumentQuantity20Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Unit" => FinancialInstrumentQuantity20Choice.Unit.Deserialize(elementWithPayload),
             "FaceAmt" => FinancialInstrumentQuantity20Choice.FaceAmount.Deserialize(elementWithPayload),
             "AmtsdVal" => FinancialInstrumentQuantity20Choice.AmortisedValue.Deserialize(elementWithPayload),
             "Cd" => FinancialInstrumentQuantity20Choice.Code.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid FinancialInstrumentQuantity20Choice choice.")
        };
    }
}
