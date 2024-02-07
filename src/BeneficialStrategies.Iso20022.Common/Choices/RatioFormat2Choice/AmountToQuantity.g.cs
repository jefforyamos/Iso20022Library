﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AmountToQuantity.  ISO2002 ID# _Rj3khtp-Ed-ak6NoX_4Aeg_1444513832.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.RatioFormat2Choice;

/// <summary>
/// The ratio is expressed as an amount per quantity.
/// </summary>
public partial record AmountToQuantity : RatioFormat2Choice_
     , IIsoXmlSerilizable<AmountToQuantity>
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
    public override void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "Amt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(Amount)); // data type ActiveCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Qty", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoDecimalNumber(Quantity)); // data type DecimalNumber System.UInt64
        writer.WriteEndElement();
    }
    public static new AmountToQuantity Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
