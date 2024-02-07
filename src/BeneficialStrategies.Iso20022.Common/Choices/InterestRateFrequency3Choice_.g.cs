﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for InterestRateFrequency3Choice.  ISO2002 ID# _61uTH1fREeqqKf65rDYWYw.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Describes frequency of payments for interest rates, either using term notation or a proprietary notation.
/// </summary>
[KnownType(typeof(InterestRateFrequency3Choice.Term))]
[KnownType(typeof(InterestRateFrequency3Choice.Proprietary))]
public abstract partial record InterestRateFrequency3Choice_ : IIsoXmlSerilizable<InterestRateFrequency3Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static InterestRateFrequency3Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Term" => InterestRateFrequency3Choice.Term.Deserialize(elementWithPayload),
             "Prtry" => InterestRateFrequency3Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid InterestRateFrequency3Choice choice.")
        };
    }
}
