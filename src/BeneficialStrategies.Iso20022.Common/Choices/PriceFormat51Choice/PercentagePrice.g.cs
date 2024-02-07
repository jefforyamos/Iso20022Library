﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PercentagePrice.  ISO2002 ID# _XAPfY0GNEeWqy4niLuXETA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.PriceFormat51Choice;

/// <summary>
/// Price expressed as a percentage.
/// </summary>
public partial record PercentagePrice : PriceFormat51Choice_
     , IIsoXmlSerilizable<PercentagePrice>
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of percentage price.
    /// </summary>
    public required PriceRateType3Code PercentagePriceType { get; init; } 
    /// <summary>
    /// Specifies the value of price.
    /// </summary>
    public required IsoPercentageRate PriceValue { get; init; } 
    
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
        writer.WriteStartElement(null, "PctgPricTp", xmlNamespace );
        writer.WriteValue(PercentagePriceType.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "PricVal", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoPercentageRate(PriceValue)); // data type PercentageRate System.Decimal
        writer.WriteEndElement();
    }
    public static new PercentagePrice Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
