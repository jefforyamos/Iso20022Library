﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Type.  ISO2002 ID# _yW81UBrdEeOVR9VN6fAMUg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.ChargesType1Choice;

/// <summary>
/// Type of service for which a charge is asked or paid.
/// </summary>
public partial record Type : ChargesType1Choice_
     , IIsoXmlSerilizable<Type>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Identifies charges linked to the conveyance of goods.
    /// </summary>
    public required ChargeType8Code Value { get; init; } 
    
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
        writer.WriteStartElement(null, "Tp", xmlNamespace );
        writer.WriteValue(Value.ToString()); // Enum value
        writer.WriteEndElement();
    }
    public static new Type Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
