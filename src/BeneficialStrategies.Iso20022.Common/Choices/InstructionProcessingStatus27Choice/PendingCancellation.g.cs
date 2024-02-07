﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PendingCancellation.  ISO2002 ID# _8VJIz5NLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus27Choice;

/// <summary>
/// Cancellation request from yourself for this instruction is pending waiting for further processing.
/// </summary>
public partial record PendingCancellation : InstructionProcessingStatus27Choice_
     , IIsoXmlSerilizable<PendingCancellation>
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
    public static new PendingCancellation Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
