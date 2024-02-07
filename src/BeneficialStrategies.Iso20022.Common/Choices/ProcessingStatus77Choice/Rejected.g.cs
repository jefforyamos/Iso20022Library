﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Rejected.  ISO2002 ID# _AYE5lffZEeiNZp_PtLohLw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus77Choice;

/// <summary>
/// Instruction/request has been rejected for further processing.
/// </summary>
public partial record Rejected : ProcessingStatus77Choice_
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
