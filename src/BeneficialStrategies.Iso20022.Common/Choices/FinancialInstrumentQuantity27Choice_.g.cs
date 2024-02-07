﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for FinancialInstrumentQuantity27Choice.  ISO2002 ID# _RoyRsDhSEeaRwdGFv45qTQ.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between formats for the specification of the number of units or amount of money.
/// </summary>
[KnownType(typeof(FinancialInstrumentQuantity27Choice.UnitsNumber))]
[KnownType(typeof(FinancialInstrumentQuantity27Choice.GrossAmount))]
[KnownType(typeof(FinancialInstrumentQuantity27Choice.NetAmount))]
public abstract partial record FinancialInstrumentQuantity27Choice_ : IIsoXmlSerilizable<FinancialInstrumentQuantity27Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static FinancialInstrumentQuantity27Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "UnitsNb" => FinancialInstrumentQuantity27Choice.UnitsNumber.Deserialize(elementWithPayload),
             "GrssAmt" => FinancialInstrumentQuantity27Choice.GrossAmount.Deserialize(elementWithPayload),
             "NetAmt" => FinancialInstrumentQuantity27Choice.NetAmount.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid FinancialInstrumentQuantity27Choice choice.")
        };
    }
}
