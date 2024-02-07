﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for DebtorActivationCancellationReason1Choice.  ISO2002 ID# _bjMUfPGAEemQ7oqCO5NTQw.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Specifies the reason for the cancellation request of a creditor enrolment.
/// </summary>
[KnownType(typeof(DebtorActivationCancellationReason1Choice.Code))]
[KnownType(typeof(DebtorActivationCancellationReason1Choice.Proprietary))]
public abstract partial record DebtorActivationCancellationReason1Choice_ : IIsoXmlSerilizable<DebtorActivationCancellationReason1Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static DebtorActivationCancellationReason1Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => DebtorActivationCancellationReason1Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => DebtorActivationCancellationReason1Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid DebtorActivationCancellationReason1Choice choice.")
        };
    }
}
