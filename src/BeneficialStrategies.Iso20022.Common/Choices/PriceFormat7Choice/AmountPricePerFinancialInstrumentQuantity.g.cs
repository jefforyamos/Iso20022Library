﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AmountPricePerFinancialInstrumentQuantity.  ISO2002 ID# _Q4qEU9p-Ed-ak6NoX_4Aeg_-1885731192.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.PriceFormat7Choice;

/// <summary>
/// Price expressed as a ratio: amount price per financial instrument quantity.
/// </summary>
public partial record AmountPricePerFinancialInstrumentQuantity : PriceFormat7Choice_
     , IIsoXmlSerilizable<AmountPricePerFinancialInstrumentQuantity>
{
    #nullable enable
    
    /// <summary>
    /// Type of amount price.
    /// </summary>
    public required AmountPriceType1Code AmountPriceType { get; init; } 
    /// <summary>
    /// Value of the price.
    /// </summary>
    public required IsoActiveCurrencyAnd13DecimalAmount PriceValue { get; init; } 
    /// <summary>
    /// Quantity of financial instrument.
    /// </summary>
    public required FinancialInstrumentQuantity1Choice_ FinancialInstrumentQuantity { get; init; } 
    
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
        writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAnd13DecimalAmount(PriceValue)); // data type ActiveCurrencyAnd13DecimalAmount System.Decimal
        writer.WriteEndElement();
        writer.WriteStartElement(null, "FinInstrmQty", xmlNamespace );
        FinancialInstrumentQuantity.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static new AmountPricePerFinancialInstrumentQuantity Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
