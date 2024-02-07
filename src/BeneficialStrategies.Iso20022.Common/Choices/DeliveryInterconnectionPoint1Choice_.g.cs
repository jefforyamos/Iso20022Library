﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for DeliveryInterconnectionPoint1Choice.  ISO2002 ID# _pRKJ0IOrEeWqmeP8QNJBew.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Identification of the delivery point(s) of market area(s) or the interconnection point of a transportation contract.
/// </summary>
[KnownType(typeof(DeliveryInterconnectionPoint1Choice.Code))]
[KnownType(typeof(DeliveryInterconnectionPoint1Choice.Proprietary))]
public abstract partial record DeliveryInterconnectionPoint1Choice_ : IIsoXmlSerilizable<DeliveryInterconnectionPoint1Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static DeliveryInterconnectionPoint1Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Cd" => DeliveryInterconnectionPoint1Choice.Code.Deserialize(elementWithPayload),
             "Prtry" => DeliveryInterconnectionPoint1Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid DeliveryInterconnectionPoint1Choice choice.")
        };
    }
}
