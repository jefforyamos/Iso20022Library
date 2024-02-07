﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DeviceIdentification1.  ISO2002 ID# _w1Pa4JfLEeuqNYk2TG3bTg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the device.
/// </summary>
public partial record DeviceIdentification1
     : IIsoXmlSerilizable<DeviceIdentification1>
{
    #nullable enable
    
    /// <summary>
    /// Type of device.
    /// </summary>
    public DeviceIdentificationType1Code? Type { get; init; } 
    /// <summary>
    /// Other type of identification.
    /// </summary>
    public IsoMax35Text? OtherType { get; init; } 
    /// <summary>
    /// Identifier of the device.
    /// </summary>
    public IsoMax70Text? Identification { get; init; } 
    /// <summary>
    /// Entity that assigned the identification.
    /// </summary>
    public IsoMax70Text? Assigner { get; init; } 
    
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
        if (Type is DeviceIdentificationType1Code TypeValue)
        {
            writer.WriteStartElement(null, "Tp", xmlNamespace );
            writer.WriteValue(TypeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (OtherType is IsoMax35Text OtherTypeValue)
        {
            writer.WriteStartElement(null, "OthrTp", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(OtherTypeValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (Identification is IsoMax70Text IdentificationValue)
        {
            writer.WriteStartElement(null, "Id", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax70Text(IdentificationValue)); // data type Max70Text System.String
            writer.WriteEndElement();
        }
        if (Assigner is IsoMax70Text AssignerValue)
        {
            writer.WriteStartElement(null, "Assgnr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax70Text(AssignerValue)); // data type Max70Text System.String
            writer.WriteEndElement();
        }
    }
    public static DeviceIdentification1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
