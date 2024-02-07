﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Percentage.  ISO2002 ID# _Rp-zktp-Ed-ak6NoX_4Aeg_-171033889.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.RateType4Choice;

/// <summary>
/// Ratio of the amount of interest paid during a certain period of time compared to the principal amount of the interest bearing financial instrument.
/// </summary>
public partial record Percentage : RateType4Choice_
     , IIsoXmlSerilizable<Percentage>
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
        writer.WriteStartElement(null, "Pctg", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoPercentageRate(Value)); // data type PercentageRate System.Decimal
        writer.WriteEndElement();
    }
    public static new Percentage Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
