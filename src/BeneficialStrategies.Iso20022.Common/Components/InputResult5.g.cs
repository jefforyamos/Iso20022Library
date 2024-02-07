﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InputResult5.  ISO2002 ID# _WmjeoXGoEe2TbaNWBpRZpQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the result the input.
/// </summary>
public partial record InputResult5
     : IIsoXmlSerilizable<InputResult5>
{
    #nullable enable
    
    /// <summary>
    /// Type of Input device.
    /// </summary>
    public required SaleCapabilities2Code DeviceType { get; init; } 
    /// <summary>
    /// Qualifies the type of given information.
    /// </summary>
    public required InformationQualify1Code InformationQualifier { get; init; } 
    /// <summary>
    /// Data resulting of input after POI or Sale processing.
    /// </summary>
    public required InputResultData5 InputResultData { get; init; } 
    
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
        writer.WriteStartElement(null, "InptRsltData", xmlNamespace );
        InputResultData.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static InputResult5 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
