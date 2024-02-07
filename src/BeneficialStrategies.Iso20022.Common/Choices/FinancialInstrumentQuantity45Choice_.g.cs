﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for FinancialInstrumentQuantity45Choice.  ISO2002 ID# _wn3tETQ_Ee2id-MjcNoBdw.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between formats for the quantity of security.
/// </summary>
[KnownType(typeof(FinancialInstrumentQuantity45Choice.Unit))]
[KnownType(typeof(FinancialInstrumentQuantity45Choice.FaceAmount))]
[KnownType(typeof(FinancialInstrumentQuantity45Choice.DigitalTokenUnit))]
public abstract partial record FinancialInstrumentQuantity45Choice_ : IIsoXmlSerilizable<FinancialInstrumentQuantity45Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static FinancialInstrumentQuantity45Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Unit" => FinancialInstrumentQuantity45Choice.Unit.Deserialize(elementWithPayload),
             "FaceAmt" => FinancialInstrumentQuantity45Choice.FaceAmount.Deserialize(elementWithPayload),
             "DgtlTknUnit" => FinancialInstrumentQuantity45Choice.DigitalTokenUnit.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid FinancialInstrumentQuantity45Choice choice.")
        };
    }
}
