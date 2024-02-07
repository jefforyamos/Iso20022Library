﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AmountAndQuantityRatio1.  ISO2002 ID# _UH8Dxtp-Ed-ak6NoX_4Aeg_1587658520.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Ratio expressed as amount per quantity.
/// </summary>
public partial record AmountAndQuantityRatio1
     : IIsoXmlSerilizable<AmountAndQuantityRatio1>
{
    #nullable enable
    
    /// <summary>
    /// Cash amount.
    /// </summary>
    public required IsoActiveCurrencyAndAmount Amount { get; init; } 
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
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "Amt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(Amount)); // data type ActiveCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Qty", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoDecimalNumber(Quantity)); // data type DecimalNumber System.UInt64
        writer.WriteEndElement();
    }
    public static AmountAndQuantityRatio1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
