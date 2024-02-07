﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Cancelled.  ISO2002 ID# _7X_7HQpJEeup4r-PFG2T5Q.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus42Choice;

/// <summary>
/// Instruction has been cancelled.
/// </summary>
public partial record Cancelled : InstructionProcessingStatus42Choice_
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
