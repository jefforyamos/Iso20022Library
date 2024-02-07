﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for TaxableIncomePerShareCalculatedFormat3Choice.  ISO2002 ID# _RaMwQUEGEeWVgfuHGaKtRQ.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between a standard code or proprietary code to specify whether the taxable income per share or per dividend is calculated.
/// </summary>
[KnownType(typeof(TaxableIncomePerShareCalculatedFormat3Choice.Code))]
[KnownType(typeof(TaxableIncomePerShareCalculatedFormat3Choice.Proprietary))]
public abstract partial record TaxableIncomePerShareCalculatedFormat3Choice_ : IIsoXmlSerilizable<TaxableIncomePerShareCalculatedFormat3Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static TaxableIncomePerShareCalculatedFormat3Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => TaxableIncomePerShareCalculatedFormat3Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => TaxableIncomePerShareCalculatedFormat3Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid TaxableIncomePerShareCalculatedFormat3Choice choice.")
        };
    }
}
