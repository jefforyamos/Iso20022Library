﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reason.  ISO2002 ID# _AjSxcZPuEey0rJ3Gl6WZVA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.ClearingExceptionOrExemption3Choice;

/// <summary>
/// No reason to report or no reason available to report.
/// </summary>
public partial record Reason : ClearingExceptionOrExemption3Choice_
     , IIsoXmlSerilizable<Reason>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies that there is no reason available.
    /// </summary>
    public required NoReasonCode Value { get; init; } 
    
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
        writer.WriteStartElement(null, "Rsn", xmlNamespace );
        writer.WriteValue(Value.ToString()); // Enum value
        writer.WriteEndElement();
    }
    public static new Reason Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
