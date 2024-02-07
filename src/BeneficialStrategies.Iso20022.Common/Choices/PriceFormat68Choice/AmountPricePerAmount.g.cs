﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AmountPricePerAmount.  ISO2002 ID# _plY1jzi7Eeydid5dcNPKvg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.PriceFormat68Choice;

/// <summary>
/// Price expressed as a ratio: amount price per amount.
/// </summary>
public partial record AmountPricePerAmount : PriceFormat68Choice_
     , IIsoXmlSerilizable<AmountPricePerAmount>
{
    #nullable enable
    
    /// <summary>
    /// Type of amount price.
    /// </summary>
    public required AmountPriceType1Code AmountPriceType { get; init; } 
    /// <summary>
    /// Value of the price.
    /// </summary>
    public required IsoRestrictedFINActiveCurrencyAnd13DecimalAmount PriceValue { get; init; } 
    /// <summary>
    /// The amount on which the price is based.
    /// </summary>
    public required IsoRestrictedFINActiveCurrencyAnd13DecimalAmount Amount { get; init; } 
    
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
        writer.WriteStartElement(null, "AmtPricTp", xmlNamespace );
        writer.WriteValue(AmountPriceType.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "PricVal", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoRestrictedFINActiveCurrencyAnd13DecimalAmount(PriceValue)); // data type RestrictedFINActiveCurrencyAnd13DecimalAmount System.Decimal
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Amt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoRestrictedFINActiveCurrencyAnd13DecimalAmount(Amount)); // data type RestrictedFINActiveCurrencyAnd13DecimalAmount System.Decimal
        writer.WriteEndElement();
    }
    public static new AmountPricePerAmount Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
