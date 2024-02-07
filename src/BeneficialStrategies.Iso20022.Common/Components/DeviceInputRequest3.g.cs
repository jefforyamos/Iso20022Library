﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DeviceInputRequest3.  ISO2002 ID# _N15HMS9AEeu125Ip9zFcsQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Input Request message.
/// </summary>
public partial record DeviceInputRequest3
     : IIsoXmlSerilizable<DeviceInputRequest3>
{
    #nullable enable
    
    /// <summary>
    /// Information to display before input.
    /// </summary>
    public ActionMessage8? DisplayOutput { get; init; } 
    /// <summary>
    /// Information related to an Input request.
    /// </summary>
    public required InputData3 InputData { get; init; } 
    
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
        if (DisplayOutput is ActionMessage8 DisplayOutputValue)
        {
            writer.WriteStartElement(null, "DispOutpt", xmlNamespace );
            DisplayOutputValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "InptData", xmlNamespace );
        InputData.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static DeviceInputRequest3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
