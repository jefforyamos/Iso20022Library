﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Failing.  ISO2002 ID# _z2Uwuzp4EeWVrPy0StzzSg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.SettlementStatus16Choice;

/// <summary>
/// Instruction is failing. Settlement at the instructed settlement date is no longer possible.
/// </summary>
public partial record Failing : SettlementStatus16Choice_
     , IIsoXmlSerilizable<Failing>
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
    public static new Failing Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
