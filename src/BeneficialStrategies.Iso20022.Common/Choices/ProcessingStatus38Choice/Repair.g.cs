﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Repair.  ISO2002 ID# _thdrYSwvEeOEV5XHD-BKpw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus38Choice;

/// <summary>
/// Instruction/Request is accepted but in repair.
/// </summary>
public partial record Repair : ProcessingStatus38Choice_
     , IIsoXmlSerilizable<Repair>
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
    public static new Repair Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
