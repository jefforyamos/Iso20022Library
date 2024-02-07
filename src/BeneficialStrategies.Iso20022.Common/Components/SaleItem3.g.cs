﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SaleItem3.  ISO2002 ID# _tJtrsSCAEey8XKHwKquEQw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Item purchased with the transaction
/// </summary>
public partial record SaleItem3
     : IIsoXmlSerilizable<SaleItem3>
{
    #nullable enable
    
    /// <summary>
    /// Contains the product type of the sale line item.
    /// </summary>
    public IsoMax35Text? ProductType { get; init; } 
    /// <summary>
    /// Product code of the item.
    /// </summary>
    public IsoMax70Text? ProductCode { get; init; } 
    /// <summary>
    /// Contains a list of codes used to identify a product.
    /// </summary>
    public ProductCodeType1Code? ProductCodeType { get; init; } 
    /// <summary>
    /// Additional code related to the product.
    /// </summary>
    public IsoMax70Text? AdditionalProductCode { get; init; } 
    /// <summary>
    /// Additional type of codification  used to identify a product.
    /// </summary>
    public IsoMax35Text? AdditionalProductCodeType { get; init; } 
    /// <summary>
    /// Code discriminator between a product code and its format to uniquely identify a specific product (for example, Item or pack of same items).
    /// </summary>
    public IsoDecimalNumber? ProductCodeModifier { get; init; } 
    /// <summary>
    /// Description of the product or item.
    /// </summary>
    public IsoMax140Text? ProductDescription { get; init; } 
    /// <summary>
    /// Unit of measure of the item purchased.
    /// </summary>
    public UnitOfMeasure1Code? UnitOfMeasure { get; init; } 
    /// <summary>
    /// Other unit of measure.
    /// </summary>
    public IsoMax35Text? OtherUnitOfMeasure { get; init; } 
    /// <summary>
    /// Quantity of product or item.
    /// </summary>
    public IsoDecimalNumber? ProductQuantity { get; init; } 
    /// <summary>
    /// Original, non-adjusted cost of one unit of the product or service before discounts and taxes.
    /// </summary>
    public IsoImpliedCurrencyAndAmount? NonAdjustedUnitPrice { get; init; } 
    /// <summary>
    /// Original, non-adjusted total cost of a product or service before discounts and taxes.
    /// </summary>
    public IsoImpliedCurrencyAndAmount? NonAdjustedTotalAmount { get; init; } 
    /// <summary>
    /// Adjustment made to the original price.
    /// </summary>
    public Adjustment10? Adjustment { get; init; } 
    /// <summary>
    /// Total cost of the line item amount, inclusive adjustments and exclusive of taxes.
    /// </summary>
    public IsoImpliedCurrencyAndAmount? AdjustedAmount { get; init; } 
    /// <summary>
    /// Indicates whether or not insurance was purchased. 
    /// </summary>
    public IsoTrueFalseIndicator? InsuranceIndicator { get; init; } 
    /// <summary>
    /// Cost of the insurance purchased.
    /// </summary>
    public IsoImpliedCurrencyAndAmount? InsuranceAmount { get; init; } 
    /// <summary>
    /// Taxes applying to the good or item.
    /// </summary>
    public Tax39? Tax { get; init; } 
    /// <summary>
    /// Total cost of the line item, inclusive of all applicable adjustments and taxes.
    /// </summary>
    public IsoImpliedCurrencyAndAmount? TotalAmount { get; init; } 
    
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
        if (ProductType is IsoMax35Text ProductTypeValue)
        {
            writer.WriteStartElement(null, "PdctTp", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ProductTypeValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (ProductCode is IsoMax70Text ProductCodeValue)
        {
            writer.WriteStartElement(null, "PdctCd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax70Text(ProductCodeValue)); // data type Max70Text System.String
            writer.WriteEndElement();
        }
        if (ProductCodeType is ProductCodeType1Code ProductCodeTypeValue)
        {
            writer.WriteStartElement(null, "PdctCdTp", xmlNamespace );
            writer.WriteValue(ProductCodeTypeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (AdditionalProductCode is IsoMax70Text AdditionalProductCodeValue)
        {
            writer.WriteStartElement(null, "AddtlPdctCd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax70Text(AdditionalProductCodeValue)); // data type Max70Text System.String
            writer.WriteEndElement();
        }
        if (AdditionalProductCodeType is IsoMax35Text AdditionalProductCodeTypeValue)
        {
            writer.WriteStartElement(null, "AddtlPdctCdTp", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(AdditionalProductCodeTypeValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (ProductCodeModifier is IsoDecimalNumber ProductCodeModifierValue)
        {
            writer.WriteStartElement(null, "PdctCdModfr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoDecimalNumber(ProductCodeModifierValue)); // data type DecimalNumber System.UInt64
            writer.WriteEndElement();
        }
        if (ProductDescription is IsoMax140Text ProductDescriptionValue)
        {
            writer.WriteStartElement(null, "PdctDesc", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax140Text(ProductDescriptionValue)); // data type Max140Text System.String
            writer.WriteEndElement();
        }
        if (UnitOfMeasure is UnitOfMeasure1Code UnitOfMeasureValue)
        {
            writer.WriteStartElement(null, "UnitOfMeasr", xmlNamespace );
            writer.WriteValue(UnitOfMeasureValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (OtherUnitOfMeasure is IsoMax35Text OtherUnitOfMeasureValue)
        {
            writer.WriteStartElement(null, "OthrUnitOfMeasr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(OtherUnitOfMeasureValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (ProductQuantity is IsoDecimalNumber ProductQuantityValue)
        {
            writer.WriteStartElement(null, "PdctQty", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoDecimalNumber(ProductQuantityValue)); // data type DecimalNumber System.UInt64
            writer.WriteEndElement();
        }
        if (NonAdjustedUnitPrice is IsoImpliedCurrencyAndAmount NonAdjustedUnitPriceValue)
        {
            writer.WriteStartElement(null, "NonAdjstdUnitPric", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoImpliedCurrencyAndAmount(NonAdjustedUnitPriceValue)); // data type ImpliedCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (NonAdjustedTotalAmount is IsoImpliedCurrencyAndAmount NonAdjustedTotalAmountValue)
        {
            writer.WriteStartElement(null, "NonAdjstdTtlAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoImpliedCurrencyAndAmount(NonAdjustedTotalAmountValue)); // data type ImpliedCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (Adjustment is Adjustment10 AdjustmentValue)
        {
            writer.WriteStartElement(null, "Adjstmnt", xmlNamespace );
            AdjustmentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AdjustedAmount is IsoImpliedCurrencyAndAmount AdjustedAmountValue)
        {
            writer.WriteStartElement(null, "AdjstdAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoImpliedCurrencyAndAmount(AdjustedAmountValue)); // data type ImpliedCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (InsuranceIndicator is IsoTrueFalseIndicator InsuranceIndicatorValue)
        {
            writer.WriteStartElement(null, "InsrncInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(InsuranceIndicatorValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
        if (InsuranceAmount is IsoImpliedCurrencyAndAmount InsuranceAmountValue)
        {
            writer.WriteStartElement(null, "InsrncAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoImpliedCurrencyAndAmount(InsuranceAmountValue)); // data type ImpliedCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (Tax is Tax39 TaxValue)
        {
            writer.WriteStartElement(null, "Tax", xmlNamespace );
            TaxValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TotalAmount is IsoImpliedCurrencyAndAmount TotalAmountValue)
        {
            writer.WriteStartElement(null, "TtlAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoImpliedCurrencyAndAmount(TotalAmountValue)); // data type ImpliedCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
    }
    public static SaleItem3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
