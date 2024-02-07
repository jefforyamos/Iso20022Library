﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for QuantityToAmount.  ISO2002 ID# _g3oehewOEd-sn-FiNtktcA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.RatioFormat12Choice;

/// <summary>
/// Ratio expressed as a quantity to amount ratio.
/// </summary>
public partial record QuantityToAmount : RatioFormat12Choice_
     , IIsoXmlSerilizable<QuantityToAmount>
{
    #nullable enable
    
    /// <summary>
    /// Cash amount.
    /// </summary>
    public required IsoActiveCurrencyAnd13DecimalAmount Amount { get; init; } 
    /// <summary>
    /// Quantity expressed as number.
    /// </summary>
    public required IsoDecimalNumber Quantity { get; init; } 
    
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
        writer.WriteStartElement(null, "Amt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAnd13DecimalAmount(Amount)); // data type ActiveCurrencyAnd13DecimalAmount System.Decimal
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Qty", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoDecimalNumber(Quantity)); // data type DecimalNumber System.UInt64
        writer.WriteEndElement();
    }
    public static new QuantityToAmount Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
