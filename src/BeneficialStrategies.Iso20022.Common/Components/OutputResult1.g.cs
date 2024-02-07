﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OutputResult1.  ISO2002 ID# _3CNXIN7EEeiwsev40qZGEQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the result the output (display, print, input).
/// </summary>
public partial record OutputResult1
     : IIsoXmlSerilizable<OutputResult1>
{
    #nullable enable
    
    /// <summary>
    /// Logical device located on a Sale Terminal or a POI Terminal, in term of class of information to output.
    /// </summary>
    public required UserInterface4Code DeviceType { get; init; } 
    /// <summary>
    /// Qualification of the information to sent to an output logical device.
    /// </summary>
    public required InformationQualify1Code InformationQualifier { get; init; } 
    /// <summary>
    /// Gives response for each peripheral.
    /// </summary>
    public required ResponseType9 Response { get; init; } 
    
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
        writer.WriteStartElement(null, "DvcTp", xmlNamespace );
        writer.WriteValue(DeviceType.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "InfQlfr", xmlNamespace );
        writer.WriteValue(InformationQualifier.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Rspn", xmlNamespace );
        Response.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static OutputResult1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
