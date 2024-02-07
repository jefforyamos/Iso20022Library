﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for TypeAndIdentification.  ISO2002 ID# _XqXF8bXEEeiTob_PrFFUxA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.SafekeepingPlaceFormat29Choice;

/// <summary>
/// Place of safekeeping expressed with a type and identification.
/// </summary>
public partial record TypeAndIdentification : SafekeepingPlaceFormat29Choice_
     , IIsoXmlSerilizable<TypeAndIdentification>
{
    #nullable enable
    
    /// <summary>
    /// Place of safekeeping as a code.
    /// </summary>
    public required SafekeepingPlace1Code SafekeepingPlaceType { get; init; } 
    /// <summary>
    /// Place of safekeeping.
    /// </summary>
    public required IsoAnyBICDec2014Identifier Identification { get; init; } 
    
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
        writer.WriteStartElement(null, "SfkpgPlcTp", xmlNamespace );
        writer.WriteValue(SafekeepingPlaceType.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Id", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoAnyBICDec2014Identifier(Identification)); // data type AnyBICDec2014Identifier System.String
        writer.WriteEndElement();
    }
    public static new TypeAndIdentification Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
