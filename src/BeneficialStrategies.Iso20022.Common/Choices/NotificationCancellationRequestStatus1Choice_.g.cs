﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for NotificationCancellationRequestStatus1Choice.  ISO2002 ID# _RiYWw9p-Ed-ak6NoX_4Aeg_-987032957.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between various statuses.
/// </summary>
[KnownType(typeof(NotificationCancellationRequestStatus1Choice.ProcessedStatus))]
[KnownType(typeof(NotificationCancellationRequestStatus1Choice.RejectedStatus))]
public abstract partial record NotificationCancellationRequestStatus1Choice_ : IIsoXmlSerilizable<NotificationCancellationRequestStatus1Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static NotificationCancellationRequestStatus1Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "PrcdSts" => NotificationCancellationRequestStatus1Choice.ProcessedStatus.Deserialize(elementWithPayload),
             "RjctdSts" => NotificationCancellationRequestStatus1Choice.RejectedStatus.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid NotificationCancellationRequestStatus1Choice choice.")
        };
    }
}
