﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _6BKT15NLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.PendingReason38Choice;

/// <summary>
/// Specifies the reason why the instruction has a pending status.
/// </summary>
public partial record Code : PendingReason38Choice_
     , IIsoXmlSerilizable<Code>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies the reason the transaction/instruction is pending settlement. Settlement on the instructed settlement date is still possible.
    /// </summary>
    public required PendingReason1Code Value { get; init; } 
    
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
        writer.WriteStartElement(null, "Cd", xmlNamespace );
        writer.WriteValue(Value.ToString()); // Enum value
        writer.WriteEndElement();
    }
    public static new Code Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
