﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NotSpecifiedRate.  ISO2002 ID# _vc05n0EKEeWVgfuHGaKtRQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.RatioFormat17Choice;

/// <summary>
/// Value of the ratio not specified.
/// </summary>
public partial record NotSpecifiedRate : RatioFormat17Choice_
     , IIsoXmlSerilizable<NotSpecifiedRate>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies the value of a rate.
    /// </summary>
    public required RateValueType7Code Value { get; init; } 
    
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
        writer.WriteStartElement(null, "NotSpcfdRate", xmlNamespace );
        writer.WriteValue(Value.ToString()); // Enum value
        writer.WriteEndElement();
    }
    public static new NotSpecifiedRate Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
