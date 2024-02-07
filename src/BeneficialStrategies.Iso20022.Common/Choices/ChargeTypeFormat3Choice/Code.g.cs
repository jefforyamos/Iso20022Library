﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _SumZGQEcEeCQm6a_G2yO_w_-437463895.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.ChargeTypeFormat3Choice;

/// <summary>
/// Standard code to specify the type of charge.
/// </summary>
public partial record Code : ChargeTypeFormat3Choice_
     , IIsoXmlSerilizable<Code>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Type of service for which a charge is asked or paid.
    /// </summary>
    public required ChargeType17Code Value { get; init; } 
    
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
