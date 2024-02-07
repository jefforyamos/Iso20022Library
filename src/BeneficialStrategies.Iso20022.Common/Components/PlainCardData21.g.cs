﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PlainCardData21.  ISO2002 ID# _VZbFQSFPEey8XKHwKquEQw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Sensitive data associated with a payment card.
/// </summary>
public partial record PlainCardData21
     : IIsoXmlSerilizable<PlainCardData21>
{
    #nullable enable
    
    /// <summary>
    /// Identification of the driver or vehicle.
    /// </summary>
    public IsoMax20Text? DriverOrVehicleIdentification { get; init; } 
    /// <summary>
    /// Additional card specific data.
    /// </summary>
    public AdditionalData1? AdditionalCardData { get; init; } 
    
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
        if (DriverOrVehicleIdentification is IsoMax20Text DriverOrVehicleIdentificationValue)
        {
            writer.WriteStartElement(null, "DrvrOrVhclId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax20Text(DriverOrVehicleIdentificationValue)); // data type Max20Text System.String
            writer.WriteEndElement();
        }
        if (AdditionalCardData is AdditionalData1 AdditionalCardDataValue)
        {
            writer.WriteStartElement(null, "AddtlCardData", xmlNamespace );
            AdditionalCardDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static PlainCardData21 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
