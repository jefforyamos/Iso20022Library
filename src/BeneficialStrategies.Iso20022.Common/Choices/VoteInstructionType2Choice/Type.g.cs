﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Type.  ISO2002 ID# _YC3j8fNoEeqRfth943bvEA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.VoteInstructionType2Choice;

/// <summary>
/// Vote option expressed as a code.
/// </summary>
public partial record Type : VoteInstructionType2Choice_
     , IIsoXmlSerilizable<Type>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies a type of voting instructions.
    /// </summary>
    public required VoteInstruction7Code Value { get; init; } 
    
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
        writer.WriteStartElement(null, "Tp", xmlNamespace );
        writer.WriteValue(Value.ToString()); // Enum value
        writer.WriteEndElement();
    }
    public static new Type Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
