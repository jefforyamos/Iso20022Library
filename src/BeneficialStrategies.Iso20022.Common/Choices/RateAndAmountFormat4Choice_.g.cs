﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RateAndAmountFormat4Choice.  ISO2002 ID# _UO8Dq9p-Ed-ak6NoX_4Aeg_-1134635736.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between an amount or an unspecified rate.
/// </summary>
[KnownType(typeof(RateAndAmountFormat4Choice.Amount))]
[KnownType(typeof(RateAndAmountFormat4Choice.NotSpecifiedRate))]
public abstract partial record RateAndAmountFormat4Choice_ : IIsoXmlSerilizable<RateAndAmountFormat4Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static RateAndAmountFormat4Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Amt" => RateAndAmountFormat4Choice.Amount.Deserialize(elementWithPayload),
             "NotSpcfdRate" => RateAndAmountFormat4Choice.NotSpecifiedRate.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid RateAndAmountFormat4Choice choice.")
        };
    }
}
