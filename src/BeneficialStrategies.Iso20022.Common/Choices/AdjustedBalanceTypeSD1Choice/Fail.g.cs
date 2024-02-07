﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Fail.  ISO2002 ID# _1hOp4DL3EeKU9IrkkToqcw_792720376.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.AdjustedBalanceTypeSD1Choice;

/// <summary>
/// Securities undelivered (FAIL) transaction position. FAIL occurs due to the failure of selling clients to deliver the securities to their brokers so the latter can deliver them to the buying brokers.  .
/// </summary>
public partial record Fail : AdjustedBalanceTypeSD1Choice_
     , IIsoXmlSerilizable<Fail>
{
    #nullable enable
    
    /// <summary>
    /// Sign of the quantity of security.
    /// </summary>
    public required ShortLong1Code ShortLongPosition { get; init; } 
    /// <summary>
    /// Quantity of security.
    /// </summary>
    public required FinancialInstrumentQuantity15Choice_ Quantity { get; init; } 
    
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
        writer.WriteStartElement(null, "ShrtLngPos", xmlNamespace );
        writer.WriteValue(ShortLongPosition.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Qty", xmlNamespace );
        Quantity.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static new Fail Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
