﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for FinancialInstrumentQuantity22Choice.  ISO2002 ID# _N-fhSQU-EeGZxNLgzisRtw.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between formats for the quantity of security.
/// </summary>
[KnownType(typeof(FinancialInstrumentQuantity22Choice.Unit))]
[KnownType(typeof(FinancialInstrumentQuantity22Choice.FaceAmount))]
[KnownType(typeof(FinancialInstrumentQuantity22Choice.AmortisedValue))]
[KnownType(typeof(FinancialInstrumentQuantity22Choice.Code))]
public abstract partial record FinancialInstrumentQuantity22Choice_ : IIsoXmlSerilizable<FinancialInstrumentQuantity22Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static FinancialInstrumentQuantity22Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Unit" => FinancialInstrumentQuantity22Choice.Unit.Deserialize(elementWithPayload),
             "FaceAmt" => FinancialInstrumentQuantity22Choice.FaceAmount.Deserialize(elementWithPayload),
             "AmtsdVal" => FinancialInstrumentQuantity22Choice.AmortisedValue.Deserialize(elementWithPayload),
             "Cd" => FinancialInstrumentQuantity22Choice.Code.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid FinancialInstrumentQuantity22Choice choice.")
        };
    }
}
