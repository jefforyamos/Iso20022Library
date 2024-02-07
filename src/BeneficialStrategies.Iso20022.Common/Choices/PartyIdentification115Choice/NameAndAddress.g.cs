﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NameAndAddress.  ISO2002 ID# _SmxZe5jcEeWn2ur3BXxtdg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification115Choice;

/// <summary>
/// Name and address of a party.
/// </summary>
public partial record NameAndAddress : PartyIdentification115Choice_
     , IIsoXmlSerilizable<NameAndAddress>
{
    #nullable enable
    
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    public required IsoRestrictedFINXMax140Text Name { get; init; } 
    
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
        writer.WriteStartElement(null, "Nm", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax140Text(Name)); // data type RestrictedFINXMax140Text System.String
        writer.WriteEndElement();
    }
    public static new NameAndAddress Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
