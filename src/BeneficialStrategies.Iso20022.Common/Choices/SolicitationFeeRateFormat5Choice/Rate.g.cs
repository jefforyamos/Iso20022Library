﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Rate.  ISO2002 ID# _RbJwERLsEeKJ5uSjVyVvug.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.SolicitationFeeRateFormat5Choice;

/// <summary>
/// Value is expressed as a rate.
/// </summary>
public partial record Rate : SolicitationFeeRateFormat5Choice_
     , IIsoXmlSerilizable<Rate>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Rate expressed as a percentage, that is, in hundredths, for example, 0.7 is 7/10 of a percent, and 7.0 is 7%.
    /// </summary>
    public required IsoPercentageRate Value { get; init; } 
    
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
        writer.WriteStartElement(null, "Rate", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoPercentageRate(Value)); // data type PercentageRate System.Decimal
        writer.WriteEndElement();
    }
    public static new Rate Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
