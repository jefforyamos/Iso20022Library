﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ShipmentSchedule1Choice.  ISO2002 ID# _Rb-Mytp-Ed-ak6NoX_4Aeg_-786797544.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between earliest/latest shipment date and a shipment schedule per sub quantity of line item quantity.
/// </summary>
[KnownType(typeof(ShipmentSchedule1Choice.ShipmentDateRange))]
[KnownType(typeof(ShipmentSchedule1Choice.ShipmentSubSchedule))]
public abstract partial record ShipmentSchedule1Choice_ : IIsoXmlSerilizable<ShipmentSchedule1Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static ShipmentSchedule1Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "ShipmntDtRg" => ShipmentSchedule1Choice.ShipmentDateRange.Deserialize(elementWithPayload),
             "ShipmntSubSchdl" => ShipmentSchedule1Choice.ShipmentSubSchedule.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid ShipmentSchedule1Choice choice.")
        };
    }
}
