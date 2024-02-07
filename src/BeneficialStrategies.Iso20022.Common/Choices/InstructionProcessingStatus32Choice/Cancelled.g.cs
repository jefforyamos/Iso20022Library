﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Cancelled.  ISO2002 ID# _BfFOBbtTEeilsanBGAzy4A.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus32Choice;

/// <summary>
/// Instruction cancelled by client cancellation instruction.
/// </summary>
public partial record Cancelled : InstructionProcessingStatus32Choice_
     , IIsoXmlSerilizable<Cancelled>
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
    public static new Cancelled Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
