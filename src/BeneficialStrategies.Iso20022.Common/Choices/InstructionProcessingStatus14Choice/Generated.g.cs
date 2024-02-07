﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Generated.  ISO2002 ID# _EsWwASRhEeO8sskhVI3IDA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus14Choice;

/// <summary>
/// The transaction was created by the account servicer or a third party. It was not instructed directly by the account owner.
/// </summary>
public partial record Generated : InstructionProcessingStatus14Choice_
     , IIsoXmlSerilizable<Generated>
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
    public static new Generated Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
