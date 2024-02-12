﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for UnitPrice10.  ISO2002 ID# _QfLNW9p-Ed-ak6NoX_4Aeg_617785517.
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
/// Amount of money for which goods or services are offered, sold, or bought.
/// </summary>
[IsoId("_QfLNW9p-Ed-ak6NoX_4Aeg_617785517")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Unit Price")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record UnitPrice10
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a UnitPrice10 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public UnitPrice10( TypeOfPrice10Code reqType,System.String reqExtendedType,PriceValue1 reqValue )
    {
        Type = reqType;
        ExtendedType = reqExtendedType;
        Value = reqValue;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type and information about a price.
    /// </summary>
    [IsoId("_QfLNXNp-Ed-ak6NoX_4Aeg_617785904")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TypeOfPrice10Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public TypeOfPrice10Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TypeOfPrice10Code Type { get; init; } 
    #else
    public TypeOfPrice10Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Type and information about a price.
    /// </summary>
    [IsoId("_QfU-UNp-Ed-ak6NoX_4Aeg_1776540150")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Extended Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoExtended350Code ExtendedType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String ExtendedType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ExtendedType { get; init; } 
    #else
    public System.String ExtendedType { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the price, eg, as a currency and value.
    /// </summary>
    [IsoId("_QfU-Udp-Ed-ak6NoX_4Aeg_617785980")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Value")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PriceValue1 Value { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public PriceValue1 Value { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceValue1 Value { get; init; } 
    #else
    public PriceValue1 Value { get; set; } 
    #endif
    
    /// <summary>
    /// Type of pricing calculation method.
    /// </summary>
    [IsoId("_QfU-Utp-Ed-ak6NoX_4Aeg_617786033")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Price Method")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceMethod1Code? PriceMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceMethod1Code? PriceMethod { get; init; } 
    #else
    public PriceMethod1Code? PriceMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the number of days used for calculating the accrued interest amount.
    /// </summary>
    [IsoId("_QfU-U9p-Ed-ak6NoX_4Aeg_617786335")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Number Of Days Accrued")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? NumberOfDaysAccrued { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? NumberOfDaysAccrued { get; init; } 
    #else
    public System.UInt64? NumberOfDaysAccrued { get; set; } 
    #endif
    
    /// <summary>
    /// Amount included in the NAV that corresponds to gains directly or indirectly derived from interest payment in the scope of the European Directive on taxation of savings income in the form of interest payments.
    /// </summary>
    [IsoId("_QfU-VNp-Ed-ak6NoX_4Aeg_617786465")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Taxable Income Per Share")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAnd13DecimalAmount? TaxableIncomePerShare { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? TaxableIncomePerShare { get; init; } 
    #else
    public System.Decimal? TaxableIncomePerShare { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the fund calculates a taxable interest per share (TIS).
    /// </summary>
    [IsoId("_QfU-Vdp-Ed-ak6NoX_4Aeg_617786808")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Taxable Income Per Share Calculated")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxableIncomePerShareCalculated2Code? TaxableIncomePerShareCalculated { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxableIncomePerShareCalculated2Code? TaxableIncomePerShareCalculated { get; init; } 
    #else
    public TaxableIncomePerShareCalculated2Code? TaxableIncomePerShareCalculated { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the fund calculates a taxable interest per share (TIS).
    /// </summary>
    [IsoId("_QfU-Vtp-Ed-ak6NoX_4Aeg_-1416668608")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Extended Taxable Income Per Share Calculated")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExtended350Code? ExtendedTaxableIncomePerShareCalculated { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ExtendedTaxableIncomePerShareCalculated { get; init; } 
    #else
    public System.String? ExtendedTaxableIncomePerShareCalculated { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the reason why the price is different from the current market price.
    /// </summary>
    [IsoId("_QfU-V9p-Ed-ak6NoX_4Aeg_-513409188")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Price Difference Reason")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? PriceDifferenceReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PriceDifferenceReason { get; init; } 
    #else
    public System.String? PriceDifferenceReason { get; set; } 
    #endif
    
    
    #nullable disable
    
}
