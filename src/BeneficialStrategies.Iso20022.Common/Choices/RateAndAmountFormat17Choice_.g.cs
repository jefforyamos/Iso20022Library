﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RateAndAmountFormat17Choice.  ISO2002 ID# _fq6xMggYEeCVlvYcV4HKqQ.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between an amount or an unspecified rate.
/// </summary>
[KnownType(typeof(RateAndAmountFormat17Choice.Amount))]
[KnownType(typeof(RateAndAmountFormat17Choice.NotSpecifiedRate))]
public abstract partial record RateAndAmountFormat17Choice_ : IIsoXmlSerilizable<RateAndAmountFormat17Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static RateAndAmountFormat17Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Amt" => RateAndAmountFormat17Choice.Amount.Deserialize(elementWithPayload),
             "NotSpcfdRate" => RateAndAmountFormat17Choice.NotSpecifiedRate.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid RateAndAmountFormat17Choice choice.")
        };
    }
}
