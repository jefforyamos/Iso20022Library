﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PendingProcessing.  ISO2002 ID# _waWtlyAeEeuyDZ-ukt4YRg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus45Choice;

/// <summary>
/// Processing of the instruction/request is pending.
/// </summary>
public partial record PendingProcessing : InstructionProcessingStatus45Choice_
     , IIsoXmlSerilizable<PendingProcessing>
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
    public static new PendingProcessing Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
