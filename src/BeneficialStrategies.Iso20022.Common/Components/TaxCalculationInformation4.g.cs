﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TaxCalculationInformation4.  ISO2002 ID# _SlvRNtp-Ed-ak6NoX_4Aeg_-1975400876.
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
/// Information used to calculate the tax.
/// </summary>
[IsoId("_SlvRNtp-Ed-ak6NoX_4Aeg_-1975400876")]
[DisplayName("Tax Calculation Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TaxCalculationInformation4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies whether capital gain is in the scope of the European directive on taxation of savings income in the form of interest payments (Council Directive 2003/48/EC 3 June), or an income realised upon sale, a refund or redemption of shares and units, etc.
    /// </summary>
    [IsoId("_SlvRN9p-Ed-ak6NoX_4Aeg_-1975400840")]
    [DisplayName("EU Capital Gain")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EUCptlGn")]
    #endif
    [IsoXmlTag("EUCptlGn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public EUCapitalGain2Code? EUCapitalGain { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EUCapitalGain2Code? EUCapitalGain { get; init; } 
    #else
    public EUCapitalGain2Code? EUCapitalGain { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether capital gain is in the scope of the European directive on taxation of savings income in the form of interest payments (Council Directive 2003/48/EC 3 June), or an income realised upon sale, a refund or redemption of shares and units, etc.
    /// </summary>
    [IsoId("_SlvRONp-Ed-ak6NoX_4Aeg_-1153836760")]
    [DisplayName("Extended EU Capital Gain")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtndedEUCptlGn")]
    #endif
    [IsoXmlTag("XtndedEUCptlGn")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExtended350Code? ExtendedEUCapitalGain { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ExtendedEUCapitalGain { get; init; } 
    #else
    public System.String? ExtendedEUCapitalGain { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage of the underlying assets of the funds that represents a debt and is in the scope of the European directive on taxation of savings income in the form of interest payments (Council Directive 2003/48/EC 3 June).
    /// </summary>
    [IsoId("_SlvROdp-Ed-ak6NoX_4Aeg_-1975400668")]
    [DisplayName("Percentage Of Debt Claim")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PctgOfDebtClm")]
    #endif
    [IsoXmlTag("PctgOfDebtClm")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? PercentageOfDebtClaim { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? PercentageOfDebtClaim { get; init; } 
    #else
    public System.Decimal? PercentageOfDebtClaim { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage of grandfathered debt claim.
    /// </summary>
    [IsoId("_SlvROtp-Ed-ak6NoX_4Aeg_-1975400608")]
    [DisplayName("Percentage Grandfathered Debt")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PctgGrdfthdDebt")]
    #endif
    [IsoXmlTag("PctgGrdfthdDebt")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? PercentageGrandfatheredDebt { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? PercentageGrandfatheredDebt { get; init; } 
    #else
    public System.Decimal? PercentageGrandfatheredDebt { get; set; } 
    #endif
    
    /// <summary>
    /// Amount included in the dividend that corresponds to gains directly or indirectly derived from interest payment in the scope of the European Directive on taxation of savings income in the form of interest payments.
    /// </summary>
    [IsoId("_Sl4bINp-Ed-ak6NoX_4Aeg_-962659901")]
    [DisplayName("Taxable Income Per Dividend")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxblIncmPerDvdd")]
    #endif
    [IsoXmlTag("TaxblIncmPerDvdd")]
    [IsoSimpleType(IsoSimpleType.ActiveOrHistoricCurrencyAnd13DecimalAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveOrHistoricCurrencyAnd13DecimalAmount? TaxableIncomePerDividend { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? TaxableIncomePerDividend { get; init; } 
    #else
    public System.Decimal? TaxableIncomePerDividend { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether dividend is in the scope of the European directive on taxation of savings income in the form of interest payments (Council Directive 2003/48/EC 3 June), or an income realised upon sale, a refund or redemption of shares and units, etc.
    /// </summary>
    [IsoId("_Sl4bIdp-Ed-ak6NoX_4Aeg_-962659764")]
    [DisplayName("EU Dividend Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EUDvddSts")]
    #endif
    [IsoXmlTag("EUDvddSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public EUDividendStatus1Code? EUDividendStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EUDividendStatus1Code? EUDividendStatus { get; init; } 
    #else
    public EUDividendStatus1Code? EUDividendStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether dividend is in the scope of the European directive on taxation of savings income in the form of interest payments (Council Directive 2003/48/EC 3 June), or an income realised upon sale, a refund or redemption of shares and units, etc.
    /// </summary>
    [IsoId("_Sl4bItp-Ed-ak6NoX_4Aeg_-962659408")]
    [DisplayName("Extended EU Dividend Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtndedEUDvddSts")]
    #endif
    [IsoXmlTag("XtndedEUDvddSts")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExtended350Code? ExtendedEUDividendStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ExtendedEUDividendStatus { get; init; } 
    #else
    public System.String? ExtendedEUDividendStatus { get; set; } 
    #endif
    
    
    #nullable disable
    
}
