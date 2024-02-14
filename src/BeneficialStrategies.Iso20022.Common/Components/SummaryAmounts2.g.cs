﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SummaryAmounts2.  ISO2002 ID# _taYAHgLqEeutW5-TpeYJhA.
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
/// Provides amounts taken in to account to calculate the collateral position.
/// </summary>
[IsoId("_taYAHgLqEeutW5-TpeYJhA")]
[DisplayName("Summary Amounts")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SummaryAmounts2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Amount of unsecured exposure a counterparty will accept before issuing a margin call in the base currency.
    /// </summary>
    [IsoId("_taYAJwLqEeutW5-TpeYJhA")]
    [DisplayName("Threshold Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ThrshldAmt")]
    #endif
    [IsoXmlTag("ThrshldAmt")]
    [IsoSimpleType(IsoSimpleType.ActiveCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? ThresholdAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? ThresholdAmount { get; init; } 
    #else
    public System.Decimal? ThresholdAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies if the threshold amount is secured or unsecured.
    /// </summary>
    [IsoId("_taYAKALqEeutW5-TpeYJhA")]
    [DisplayName("Threshold Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ThrshldTp")]
    #endif
    [IsoXmlTag("ThrshldTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ThresholdType1Code? ThresholdType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ThresholdType1Code? ThresholdType { get; init; } 
    #else
    public ThresholdType1Code? ThresholdType { get; set; } 
    #endif
    
    /// <summary>
    /// Total value of posted collateral (pre-haircut) held by the taker.
    /// </summary>
    [IsoId("_taYAIgLqEeutW5-TpeYJhA")]
    [DisplayName("Pre Haircut Collateral Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PreHrcutCollVal")]
    #endif
    [IsoXmlTag("PreHrcutCollVal")]
    [IsoSimpleType(IsoSimpleType.ActiveCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? PreHaircutCollateralValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? PreHaircutCollateralValue { get; init; } 
    #else
    public System.Decimal? PreHaircutCollateralValue { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount of collateral required (unrounded).
    /// </summary>
    [IsoId("_taYAJALqEeutW5-TpeYJhA")]
    [DisplayName("Adjusted Exposure")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AdjstdXpsr")]
    #endif
    [IsoXmlTag("AdjstdXpsr")]
    [IsoSimpleType(IsoSimpleType.ActiveCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? AdjustedExposure { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? AdjustedExposure { get; init; } 
    #else
    public System.Decimal? AdjustedExposure { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount of collateral required (rounded).
    /// </summary>
    [IsoId("_taYAHwLqEeutW5-TpeYJhA")]
    [DisplayName("Collateral Required")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollReqrd")]
    #endif
    [IsoXmlTag("CollReqrd")]
    [IsoSimpleType(IsoSimpleType.ActiveCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? CollateralRequired { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? CollateralRequired { get; init; } 
    #else
    public System.Decimal? CollateralRequired { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if excess cash collateral in the currency is automatically returned as per the collateral provider’s Excess Cash Margin Instruction (colr.017).
    /// </summary>
    [IsoId("_5F0TgALqEeutW5-TpeYJhA")]
    [DisplayName("Return Excess Cash And Collateral Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RtrXcssCshAndCollCcy")]
    #endif
    [IsoXmlTag("RtrXcssCshAndCollCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReturnExcessCash1? ReturnExcessCashAndCollateralCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReturnExcessCash1? ReturnExcessCashAndCollateralCurrency { get; init; } 
    #else
    public ReturnExcessCash1? ReturnExcessCashAndCollateralCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Minimum amount to pay/receive as specified in the agreement in the base currency (to avoid the need to transfer an inconveniently small amount of collateral).
    /// </summary>
    [IsoId("_taYAJgLqEeutW5-TpeYJhA")]
    [DisplayName("Minimum Transfer Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinTrfAmt")]
    #endif
    [IsoXmlTag("MinTrfAmt")]
    [IsoSimpleType(IsoSimpleType.ActiveCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? MinimumTransferAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? MinimumTransferAmount { get; init; } 
    #else
    public System.Decimal? MinimumTransferAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount specified to avoid the need to transfer uneven amounts of collateral.
    /// </summary>
    [IsoId("_taYAJQLqEeutW5-TpeYJhA")]
    [DisplayName("Rounding Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RndgAmt")]
    #endif
    [IsoXmlTag("RndgAmt")]
    [IsoSimpleType(IsoSimpleType.ActiveCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? RoundingAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? RoundingAmount { get; init; } 
    #else
    public System.Decimal? RoundingAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Exposure value at previous valuation.
    /// </summary>
    [IsoId("_taYAIQLqEeutW5-TpeYJhA")]
    [DisplayName("Previous Exposure Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsXpsrVal")]
    #endif
    [IsoXmlTag("PrvsXpsrVal")]
    [IsoSimpleType(IsoSimpleType.ActiveCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? PreviousExposureValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? PreviousExposureValue { get; init; } 
    #else
    public System.Decimal? PreviousExposureValue { get; set; } 
    #endif
    
    /// <summary>
    /// Value of collateral at previous valuation.
    /// </summary>
    [IsoId("_taYAKgLqEeutW5-TpeYJhA")]
    [DisplayName("Previous Collateral Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsCollVal")]
    #endif
    [IsoXmlTag("PrvsCollVal")]
    [IsoSimpleType(IsoSimpleType.ActiveCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? PreviousCollateralValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? PreviousCollateralValue { get; init; } 
    #else
    public System.Decimal? PreviousCollateralValue { get; set; } 
    #endif
    
    /// <summary>
    /// Value of incoming collateral, to be settled.
    /// </summary>
    [IsoId("_taYAKQLqEeutW5-TpeYJhA")]
    [DisplayName("Total Pending Incoming Collateral")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlPdgIncmgColl")]
    #endif
    [IsoXmlTag("TtlPdgIncmgColl")]
    [IsoSimpleType(IsoSimpleType.ActiveCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? TotalPendingIncomingCollateral { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? TotalPendingIncomingCollateral { get; init; } 
    #else
    public System.Decimal? TotalPendingIncomingCollateral { get; set; } 
    #endif
    
    /// <summary>
    /// Value of outgoing collateral, to be settled.
    /// </summary>
    [IsoId("_taYAKwLqEeutW5-TpeYJhA")]
    [DisplayName("Total Pending Outgoing Collateral")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlPdgOutgngColl")]
    #endif
    [IsoXmlTag("TtlPdgOutgngColl")]
    [IsoSimpleType(IsoSimpleType.ActiveCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? TotalPendingOutgoingCollateral { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? TotalPendingOutgoingCollateral { get; init; } 
    #else
    public System.Decimal? TotalPendingOutgoingCollateral { get; set; } 
    #endif
    
    /// <summary>
    /// Sum of accrued interest.
    /// </summary>
    [IsoId("_taYAIALqEeutW5-TpeYJhA")]
    [DisplayName("Total Accrued Interest Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlAcrdIntrstAmt")]
    #endif
    [IsoXmlTag("TtlAcrdIntrstAmt")]
    [IsoSimpleType(IsoSimpleType.ActiveCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? TotalAccruedInterestAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? TotalAccruedInterestAmount { get; init; } 
    #else
    public System.Decimal? TotalAccruedInterestAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Sum of fees/commissions.
    /// </summary>
    [IsoId("_taYAIwLqEeutW5-TpeYJhA")]
    [DisplayName("Total Fees")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlFees")]
    #endif
    [IsoXmlTag("TtlFees")]
    [IsoSimpleType(IsoSimpleType.ActiveCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? TotalFees { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? TotalFees { get; init; } 
    #else
    public System.Decimal? TotalFees { get; set; } 
    #endif
    
    
    #nullable disable
    
}
