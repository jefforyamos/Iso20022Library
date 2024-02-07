﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for UnknownIndicator.  ISO2002 ID# _LlJ2pbQCEee1Ke-6rZgsrA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.PriceRateOrAmountOrUnknown2Choice;

/// <summary>
/// Indicates whether the market price is unknown.
/// </summary>
public partial record UnknownIndicator : PriceRateOrAmountOrUnknown2Choice_
     , IIsoXmlSerilizable<UnknownIndicator>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Indicates a "Yes" or "No" type of answer for an element.
    /// </summary>
    public required IsoYesNoIndicator Value { get; init; } 
    
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
        writer.WriteStartElement(null, "UknwnInd", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(Value)); // data type YesNoIndicator System.String
        writer.WriteEndElement();
    }
    public static new UnknownIndicator Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
