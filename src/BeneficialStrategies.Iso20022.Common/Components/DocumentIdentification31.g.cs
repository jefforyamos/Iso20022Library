﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DocumentIdentification31.  ISO2002 ID# _e22_UTnXEeWLJsP1cO-amg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a document and type of link.
/// </summary>
public partial record DocumentIdentification31
     : IIsoXmlSerilizable<DocumentIdentification31>
{
    #nullable enable
    
    /// <summary>
    /// Identifies the document.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Specifies when this document is to be processed relative to another referred document.
    /// </summary>
    public ProcessingPosition7Choice_? LinkageType { get; init; } 
    
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
        writer.WriteStartElement(null, "Id", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(Identification)); // data type Max35Text System.String
        writer.WriteEndElement();
        if (LinkageType is ProcessingPosition7Choice_ LinkageTypeValue)
        {
            writer.WriteStartElement(null, "LkgTp", xmlNamespace );
            LinkageTypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static DocumentIdentification31 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
