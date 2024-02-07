﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PaymentScheduleType1Choice.  ISO2002 ID# _1ggIwAqPEeWqX7rjSIiMuQ.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice for payment schedule type.
/// </summary>
[KnownType(typeof(PaymentScheduleType1Choice.Code))]
[KnownType(typeof(PaymentScheduleType1Choice.Proprietary))]
public abstract partial record PaymentScheduleType1Choice_ : IIsoXmlSerilizable<PaymentScheduleType1Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static PaymentScheduleType1Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => PaymentScheduleType1Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => PaymentScheduleType1Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid PaymentScheduleType1Choice choice.")
        };
    }
}
