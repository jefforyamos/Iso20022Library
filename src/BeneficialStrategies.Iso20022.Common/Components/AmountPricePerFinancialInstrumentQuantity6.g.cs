﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AmountPricePerFinancialInstrumentQuantity6.  ISO2002 ID# _pVBYl0ELEeWVgfuHGaKtRQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies a ratio: amount price per financial instrument quantity.
/// </summary>
public partial record AmountPricePerFinancialInstrumentQuantity6
     : IIsoXmlSerilizable<AmountPricePerFinancialInstrumentQuantity6>
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
    public void Serialize(XmlWriter writer, string xmlNamespace)
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
    public static AmountPricePerFinancialInstrumentQuantity6 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
