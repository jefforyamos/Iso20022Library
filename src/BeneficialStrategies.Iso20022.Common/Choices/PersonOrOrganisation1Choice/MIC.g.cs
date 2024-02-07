﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for MIC.  ISO2002 ID# _gOV-kwkiEeWGouz230Xp5Q.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.PersonOrOrganisation1Choice;

/// <summary>
/// Market identifier code of the party.
/// </summary>
public partial record MIC : PersonOrOrganisation1Choice_
     , IIsoXmlSerilizable<MIC>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Market Identifier Code. The identification of a financial market, as stipulated in the norm ISO 10383 'Codes for exchanges and market identifications'.
    /// </summary>
    public required IsoMICIdentifier Value { get; init; } 
    
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
        writer.WriteStartElement(null, "MIC", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMICIdentifier(Value)); // data type MICIdentifier System.String
        writer.WriteEndElement();
    }
    public static new MIC Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
