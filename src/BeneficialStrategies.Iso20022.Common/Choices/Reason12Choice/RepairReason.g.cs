﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for RepairReason.  ISO2002 ID# _C2YFxyRhEeO8sskhVI3IDA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.Reason12Choice;

/// <summary>
/// Specifies the reason why the instruction is in repair.
/// </summary>
public partial record RepairReason : Reason12Choice_
     , IIsoXmlSerilizable<RepairReason>
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
    public static new RepairReason Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
