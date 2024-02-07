﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Rejected.  ISO2002 ID# _lrrtg-XyEemEj48jhmlA0Q.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus38Choice;

/// <summary>
/// Provides status information related to an instruction request rejected for further processing due to system reasons.
/// </summary>
public partial record Rejected : InstructionProcessingStatus38Choice_
     , IIsoXmlSerilizable<Rejected>
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
    public static new Rejected Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
