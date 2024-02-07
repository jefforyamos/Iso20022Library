﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for DigitalTokenUnit.  ISO2002 ID# _peY07Ti7Eeydid5dcNPKvg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity36Choice;

/// <summary>
/// Quantity of digital tokens expressed as a number, for example, a number of blockchain tokens.
/// </summary>
public partial record DigitalTokenUnit : FinancialInstrumentQuantity36Choice_
     , IIsoXmlSerilizable<DigitalTokenUnit>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Number of objects represented as a decimal number, for example 0.75 or 45.6 with a maximum of 30 digits and 29 fraction digits.
    /// </summary>
    public required IsoMax30DecimalNumber Value { get; init; } 
    
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
        writer.WriteStartElement(null, "DgtlTknUnit", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax30DecimalNumber(Value)); // data type Max30DecimalNumber System.UInt64
        writer.WriteEndElement();
    }
    public static new DigitalTokenUnit Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
