﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for FailingReason.  ISO2002 ID# _8NNHIStXEeyhipY4f42fZQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.Reason19Choice;

/// <summary>
/// Specifies the reason why the instruction has a failing settlement status.
/// </summary>
public partial record FailingReason : Reason19Choice_
     , IIsoXmlSerilizable<FailingReason>
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
    public static new FailingReason Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
