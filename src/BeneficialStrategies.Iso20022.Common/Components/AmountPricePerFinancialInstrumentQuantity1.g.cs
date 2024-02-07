﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AmountPricePerFinancialInstrumentQuantity1.  ISO2002 ID# _QbAfBtp-Ed-ak6NoX_4Aeg_-1640515139.
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
public partial record AmountPricePerFinancialInstrumentQuantity1
     : IIsoXmlSerilizable<AmountPricePerFinancialInstrumentQuantity1>
{
    #nullable enable
    
    /// <summary>
    /// Type of amount price.
    /// </summary>
    public required AmountPriceType1FormatChoice_ AmountPriceType { get; init; } 
    /// <summary>
    /// Value of the price.
    /// </summary>
    public required IsoActiveCurrencyAnd13DecimalAmount PriceValue { get; init; } 
    /// <summary>
    /// Quantity of financial instrument.
    /// </summary>
    public required UnitOrFaceAmount1Choice_ FinancialInstrumentQuantity { get; init; } 
    
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
        AmountPriceType.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "PricVal", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAnd13DecimalAmount(PriceValue)); // data type ActiveCurrencyAnd13DecimalAmount System.Decimal
        writer.WriteEndElement();
        writer.WriteStartElement(null, "FinInstrmQty", xmlNamespace );
        FinancialInstrumentQuantity.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static AmountPricePerFinancialInstrumentQuantity1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
