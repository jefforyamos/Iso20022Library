﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for IdentificationNotAvailable.  ISO2002 ID# _idD07Vo2Ee23K4GXSpBSeg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification41Choice;

/// <summary>
/// Indicates that underlying identification is not available.
/// </summary>
public partial record IdentificationNotAvailable : SecurityIdentification41Choice_
     , IIsoXmlSerilizable<IdentificationNotAvailable>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies the type of the underlying identification.
    /// </summary>
    public required UnderlyingIdentification1Code Value { get; init; } 
    
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
        writer.WriteStartElement(null, "IdNotAvlbl", xmlNamespace );
        writer.WriteValue(Value.ToString()); // Enum value
        writer.WriteEndElement();
    }
    public static new IdentificationNotAvailable Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
