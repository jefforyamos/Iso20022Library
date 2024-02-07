﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AcquirerHostConfiguration2.  ISO2002 ID# _LFhAYCmlEeKIjpr--01h3Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Acquirer configuration parameters for a host.
/// </summary>
public partial record AcquirerHostConfiguration2
     : IIsoXmlSerilizable<AcquirerHostConfiguration2>
{
    #nullable enable
    
    /// <summary>
    /// Identification of a host.
    /// </summary>
    public required IsoMax35Text HostIdentification { get; init; } 
    /// <summary>
    /// Types of message to sent to this host.
    /// </summary>
    public MessageFunction3Code? MessageToSend { get; init; } 
    
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
        writer.WriteStartElement(null, "HstId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(HostIdentification)); // data type Max35Text System.String
        writer.WriteEndElement();
        if (MessageToSend is MessageFunction3Code MessageToSendValue)
        {
            writer.WriteStartElement(null, "MsgToSnd", xmlNamespace );
            writer.WriteValue(MessageToSendValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
    }
    public static AcquirerHostConfiguration2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
