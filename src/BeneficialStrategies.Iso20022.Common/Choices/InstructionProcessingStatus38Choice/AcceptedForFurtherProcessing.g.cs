﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AcceptedForFurtherProcessing.  ISO2002 ID# _lrrte-XyEemEj48jhmlA0Q.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus38Choice;

/// <summary>
/// Provides status information related to an instruction request that is accepted. This means that the instruction has been received, is processable and has been validated for further processing.
/// </summary>
public partial record AcceptedForFurtherProcessing : InstructionProcessingStatus38Choice_
     , IIsoXmlSerilizable<AcceptedForFurtherProcessing>
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
    public static new AcceptedForFurtherProcessing Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
