﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DeviceInputResponse1.  ISO2002 ID# _h0YSAN7FEeiwsev40qZGEQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Input Response message.
/// </summary>
public partial record DeviceInputResponse1
     : IIsoXmlSerilizable<DeviceInputResponse1>
{
    #nullable enable
    
    /// <summary>
    /// Result of display request.
    /// </summary>
    public OutputResult1? OutputResult { get; init; } 
    /// <summary>
    /// Result of input request.
    /// </summary>
    public required InputResult1 InputResult { get; init; } 
    
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
        if (OutputResult is OutputResult1 OutputResultValue)
        {
            writer.WriteStartElement(null, "OutptRslt", xmlNamespace );
            OutputResultValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "InptRslt", xmlNamespace );
        InputResult.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static DeviceInputResponse1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
