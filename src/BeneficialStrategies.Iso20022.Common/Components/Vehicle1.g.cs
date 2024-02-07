﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Vehicle1.  ISO2002 ID# _KI-4wJXyEeWMQt4mOczoDw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to a vehicle used during a transaction.
/// </summary>
public partial record Vehicle1
     : IIsoXmlSerilizable<Vehicle1>
{
    #nullable enable
    
    /// <summary>
    /// Number assigned to the vehicle for identification.
    /// </summary>
    public IsoMax35NumericText? VehicleNumber { get; init; } 
    /// <summary>
    /// Number assigned to the vehicle trailer for identification.
    /// </summary>
    public IsoMax35NumericText? TrailerNumber { get; init; } 
    /// <summary>
    /// Registration tag of the vehicle.
    /// </summary>
    public IsoMax35Text? VehicleTag { get; init; } 
    /// <summary>
    /// Entry mode of the registration tag.
    /// </summary>
    public CardDataReading5Code? VehicleTagEntryMode { get; init; } 
    /// <summary>
    /// Identification of the vehicle in the fleet.
    /// </summary>
    public IsoMax35NumericText? UnitNumber { get; init; } 
    /// <summary>
    /// True if the car is a replacement car.
    /// </summary>
    public IsoTrueFalseIndicator? ReplacementCar { get; init; } 
    /// <summary>
    /// Odometer reading value indicating the distance travelled by the vehicle.
    /// </summary>
    public IsoDecimalNumber? Odometer { get; init; } 
    /// <summary>
    /// Hubometer reading value indicating the distance travelled by the trailer.
    /// </summary>
    public IsoDecimalNumber? Hubometer { get; init; } 
    /// <summary>
    /// Number of hours the trailer has been in operation.
    /// </summary>
    public IsoMax35Text? TrailerHours { get; init; } 
    /// <summary>
    /// Number of hours the refer unit has been in operation.
    /// </summary>
    public IsoMax35Text? ReferHours { get; init; } 
    /// <summary>
    /// Identification assigned to the vehicle related to maintenance.
    /// </summary>
    public IsoMax35Text? MaintenanceIdentification { get; init; } 
    /// <summary>
    /// Second card presented for the payment transaction.
    /// </summary>
    public PlainCardData17? DriverOrVehicleCard { get; init; } 
    /// <summary>
    /// Additional information related to the vehicle.
    /// </summary>
    public Vehicle2? AdditionalVehicleData { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        if (VehicleNumber is IsoMax35NumericText VehicleNumberValue)
        {
            writer.WriteStartElement(null, "VhclNb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35NumericText(VehicleNumberValue)); // data type Max35NumericText System.String
            writer.WriteEndElement();
        }
        if (TrailerNumber is IsoMax35NumericText TrailerNumberValue)
        {
            writer.WriteStartElement(null, "TrlrNb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35NumericText(TrailerNumberValue)); // data type Max35NumericText System.String
            writer.WriteEndElement();
        }
        if (VehicleTag is IsoMax35Text VehicleTagValue)
        {
            writer.WriteStartElement(null, "VhclTag", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(VehicleTagValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (VehicleTagEntryMode is CardDataReading5Code VehicleTagEntryModeValue)
        {
            writer.WriteStartElement(null, "VhclTagNtryMd", xmlNamespace );
            writer.WriteValue(VehicleTagEntryModeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (UnitNumber is IsoMax35NumericText UnitNumberValue)
        {
            writer.WriteStartElement(null, "UnitNb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35NumericText(UnitNumberValue)); // data type Max35NumericText System.String
            writer.WriteEndElement();
        }
        if (ReplacementCar is IsoTrueFalseIndicator ReplacementCarValue)
        {
            writer.WriteStartElement(null, "RplcmntCar", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(ReplacementCarValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
        if (Odometer is IsoDecimalNumber OdometerValue)
        {
            writer.WriteStartElement(null, "Odmtr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoDecimalNumber(OdometerValue)); // data type DecimalNumber System.UInt64
            writer.WriteEndElement();
        }
        if (Hubometer is IsoDecimalNumber HubometerValue)
        {
            writer.WriteStartElement(null, "Hbmtr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoDecimalNumber(HubometerValue)); // data type DecimalNumber System.UInt64
            writer.WriteEndElement();
        }
        if (TrailerHours is IsoMax35Text TrailerHoursValue)
        {
            writer.WriteStartElement(null, "TrlrHrs", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(TrailerHoursValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (ReferHours is IsoMax35Text ReferHoursValue)
        {
            writer.WriteStartElement(null, "RefrHrs", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ReferHoursValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (MaintenanceIdentification is IsoMax35Text MaintenanceIdentificationValue)
        {
            writer.WriteStartElement(null, "MntncId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(MaintenanceIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (DriverOrVehicleCard is PlainCardData17 DriverOrVehicleCardValue)
        {
            writer.WriteStartElement(null, "DrvrOrVhclCard", xmlNamespace );
            DriverOrVehicleCardValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AdditionalVehicleData is Vehicle2 AdditionalVehicleDataValue)
        {
            writer.WriteStartElement(null, "AddtlVhclData", xmlNamespace );
            AdditionalVehicleDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static Vehicle1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
