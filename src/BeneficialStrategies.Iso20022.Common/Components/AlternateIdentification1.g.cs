﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AlternateIdentification1.  ISO2002 ID# _TBTL0tp-Ed-ak6NoX_4Aeg_1536045465.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Alternate identification of a security.
/// </summary>
public partial record AlternateIdentification1
     : IIsoXmlSerilizable<AlternateIdentification1>
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier of a security.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Source of the security identification.
    /// </summary>
    public required IdentificationSource1Choice_ IdentificationSource { get; init; } 
    
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
        writer.WriteStartElement(null, "IdSrc", xmlNamespace );
        IdentificationSource.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static AlternateIdentification1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
