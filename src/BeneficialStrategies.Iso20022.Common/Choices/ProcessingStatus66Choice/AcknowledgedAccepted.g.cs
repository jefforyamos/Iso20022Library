﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AcknowledgedAccepted.  ISO2002 ID# _BvN4ceFUEeWIA4E9cYSxxQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus66Choice;

/// <summary>
/// Instruction has been acknowledged by the account servicer.
/// </summary>
public partial record AcknowledgedAccepted : ProcessingStatus66Choice_
     , IIsoXmlSerilizable<AcknowledgedAccepted>
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
    public static new AcknowledgedAccepted Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
