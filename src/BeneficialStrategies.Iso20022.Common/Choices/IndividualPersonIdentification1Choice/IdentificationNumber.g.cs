﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for IdentificationNumber.  ISO2002 ID# _g3i8ISFWEeWgV9SQSyaAog.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.IndividualPersonIdentification1Choice;

/// <summary>
/// Identification of the person that owns the account.
/// </summary>
public partial record IdentificationNumber : IndividualPersonIdentification1Choice_
     , IIsoXmlSerilizable<IdentificationNumber>
{
    #nullable enable
    
    /// <summary>
    /// Identification of a party, such as a tax or social security identifier.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Type of identification.
    /// </summary>
    public required OtherIdentification3Choice_ IdentificationType { get; init; } 
    
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
        writer.WriteStartElement(null, "IdTp", xmlNamespace );
        IdentificationType.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static new IdentificationNumber Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
