﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DeviceInputNotification4.  ISO2002 ID# _zP5loVE6EeyApZmLzm74zA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Input notification message.
/// </summary>
public partial record DeviceInputNotification4
     : IIsoXmlSerilizable<DeviceInputNotification4>
{
    #nullable enable
    
    /// <summary>
    /// Message main identifier.
    /// </summary>
    public required IsoMax35Text ExchangeIdentification { get; init; } 
    /// <summary>
    /// Updated content of the message to display before input.
    /// </summary>
    public required ActionMessage9 OutputContent { get; init; } 
    
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
        writer.WriteStartElement(null, "XchgId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(ExchangeIdentification)); // data type Max35Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "OutptCntt", xmlNamespace );
        OutputContent.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static DeviceInputNotification4 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
