﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AlternateIdentification.  ISO2002 ID# _VcIPgNp-Ed-ak6NoX_4Aeg_-1748201304.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification1Choice;

/// <summary>
/// Proprietary identification of a security assigned by an institution or organisation.
/// </summary>
public partial record AlternateIdentification : SecurityIdentification1Choice_
     , IIsoXmlSerilizable<AlternateIdentification>
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier of a security.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Country of the proprietary identification scheme.
    /// </summary>
    public required CountryCode DomesticIdentificationSource { get; init; } 
    /// <summary>
    /// Entity that issues the proprietary identification.
    /// </summary>
    public required IsoMax35Text ProprietaryIdentificationSource { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public override void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "Id", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(Identification)); // data type Max35Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "DmstIdSrc", xmlNamespace );
        writer.WriteValue(DomesticIdentificationSource.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "PrtryIdSrc", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(ProprietaryIdentificationSource)); // data type Max35Text System.String
        writer.WriteEndElement();
    }
    public static new AlternateIdentification Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
