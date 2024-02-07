﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ContentInformationType36.  ISO2002 ID# _WAiXsXJ9Ee299ZbWCkdR_w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// General cryptographic message syntax (CMS) containing authenticated data.
/// </summary>
public partial record ContentInformationType36
     : IIsoXmlSerilizable<ContentInformationType36>
{
    #nullable enable
    
    /// <summary>
    /// Type of data protection.
    /// </summary>
    public required ContentType2Code ContentType { get; init; } 
    /// <summary>
    /// Data protection by a message authentication code (MAC).
    /// </summary>
    public required AuthenticatedData9 AuthenticatedData { get; init; } 
    
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
        writer.WriteStartElement(null, "CnttTp", xmlNamespace );
        writer.WriteValue(ContentType.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "AuthntcdData", xmlNamespace );
        AuthenticatedData.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static ContentInformationType36 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
