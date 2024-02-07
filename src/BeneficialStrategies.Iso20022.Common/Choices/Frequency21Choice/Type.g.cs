﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Type.  ISO2002 ID# _6GkgAR7yEeSxevWRRWxNAg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.Frequency21Choice;

/// <summary>
/// Frequency expressed as an ISO 20022 code.
/// </summary>
public partial record Type : Frequency21Choice_
     , IIsoXmlSerilizable<Type>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies the regularity of an event.
    /// </summary>
    public required Frequency6Code Value { get; init; } 
    
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
