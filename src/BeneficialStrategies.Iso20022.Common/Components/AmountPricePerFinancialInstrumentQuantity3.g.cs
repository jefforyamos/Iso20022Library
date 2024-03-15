﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AmountPricePerFinancialInstrumentQuantity3.  ISO2002 ID# _QaQ4INp-Ed-ak6NoX_4Aeg_98846700.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies a ratio: amount price per financial instrument quantity.
/// </summary>
[IsoId("_QaQ4INp-Ed-ak6NoX_4Aeg_98846700")]
[DisplayName("Amount Price Per Financial Instrument Quantity")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AmountPricePerFinancialInstrumentQuantity3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AmountPricePerFinancialInstrumentQuantity3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AmountPricePerFinancialInstrumentQuantity3( AmountPriceType1Code reqAmountPriceType,System.Decimal reqPriceValue,FinancialInstrumentQuantity1Choice_ reqFinancialInstrumentQuantity )
    {
        AmountPriceType = reqAmountPriceType;
        PriceValue = reqPriceValue;
        FinancialInstrumentQuantity = reqFinancialInstrumentQuantity;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of amount price.
    /// </summary>
    [IsoId("_QaQ4Idp-Ed-ak6NoX_4Aeg_539368946")]
    [DisplayName("Amount Price Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmtPricTp")]
    #endif
    [IsoXmlTag("AmtPricTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountPriceType1Code AmountPriceType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountPriceType1Code AmountPriceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountPriceType1Code AmountPriceType { get; init; } 
    #else
    public AmountPriceType1Code AmountPriceType { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the price.
    /// </summary>
    [IsoId("_QaQ4Itp-Ed-ak6NoX_4Aeg_570765997")]
    [DisplayName("Price Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricVal")]
    #endif
    [IsoXmlTag("PricVal")]
    [IsoSimpleType(IsoSimpleType.ActiveCurrencyAnd13DecimalAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoActiveCurrencyAnd13DecimalAmount PriceValue { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Decimal PriceValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal PriceValue { get; init; } 
    #else
    public System.Decimal PriceValue { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of financial instrument.
    /// </summary>
    [IsoId("_QaQ4I9p-Ed-ak6NoX_4Aeg_-1521602945")]
    [DisplayName("Financial Instrument Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmQty")]
    #endif
    [IsoXmlTag("FinInstrmQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrumentQuantity1Choice_ FinancialInstrumentQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrumentQuantity1Choice_ FinancialInstrumentQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1Choice_ FinancialInstrumentQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity1Choice_ FinancialInstrumentQuantity { get; set; } 
    #endif
    
    
    #nullable disable
    
}
