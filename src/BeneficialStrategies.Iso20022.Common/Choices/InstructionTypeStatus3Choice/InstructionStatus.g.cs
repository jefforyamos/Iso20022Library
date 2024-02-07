﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for InstructionStatus.  ISO2002 ID# _8GFSoa-nEemJ1NnLPsTFaw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.InstructionTypeStatus3Choice;

/// <summary>
/// Status of the meeting instruction message or of the individual meeting instruction(s). The message is identified in InstructionType/InstructionIdentification.
/// </summary>
public partial record InstructionStatus : InstructionTypeStatus3Choice_
     , IIsoXmlSerilizable<InstructionStatus>
{
    #nullable enable
    
    
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
    }
    public static new InstructionStatus Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
