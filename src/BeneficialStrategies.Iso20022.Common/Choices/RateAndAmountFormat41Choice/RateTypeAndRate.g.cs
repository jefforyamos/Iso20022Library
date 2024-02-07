﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for RateTypeAndRate.  ISO2002 ID# _ACL0TUEJEeWVgfuHGaKtRQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.RateAndAmountFormat41Choice;

/// <summary>
/// Value is expressed as a rate type and a percentage rate.
/// </summary>
public partial record RateTypeAndRate : RateAndAmountFormat41Choice_
     , IIsoXmlSerilizable<RateTypeAndRate>
{
    #nullable enable
    
    /// <summary>
    /// Value expressed as a rate type.
    /// </summary>
    public required RateType42Choice_ RateType { get; init; } 
    /// <summary>
    /// Value expressed as a rate.
    /// </summary>
    public required IsoPercentageRate Rate { get; init; } 
    
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
        writer.WriteStartElement(null, "RateTp", xmlNamespace );
        RateType.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Rate", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoPercentageRate(Rate)); // data type PercentageRate System.Decimal
        writer.WriteEndElement();
    }
    public static new RateTypeAndRate Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
