﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Summary2.  ISO2002 ID# _Vzn7ygLrEeutW5-TpeYJhA.
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
/// Summary of a collateral valuation.
/// </summary>
[IsoId("_Vzn7ygLrEeutW5-TpeYJhA")]
[DisplayName("Summary")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Summary2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Summary2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Summary2( ExposureType8Code reqExposureType,System.Decimal reqTotalValueOfCollateral,System.DateTime reqValuationDateTime )
    {
        ExposureType = reqExposureType;
        TotalValueOfCollateral = reqTotalValueOfCollateral;
        ValuationDateTime = reqValuationDateTime;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Sum of the exposures of all transactions which are in the favour of party A. That is, all transactions which would have an amount payable by party B to party A if they were being terminated.
    /// </summary>
    [IsoId("_Vzn70QLrEeutW5-TpeYJhA")]
    [DisplayName("Exposed Amount Party A")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpsdAmtPtyA")]
    #endif
    [IsoXmlTag("XpsdAmtPtyA")]
    [IsoSimpleType(IsoSimpleType.ActiveCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? ExposedAmountPartyA { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? ExposedAmountPartyA { get; init; } 
    #else
    public System.Decimal? ExposedAmountPartyA { get; set; } 
    #endif
    
    /// <summary>
    /// Sum of the exposures of all transactions which are in the favour of party B. That is, all transactions which would have an amount payable by party A to party B if they were being terminated.
    /// </summary>
    [IsoId("_Vzn7zQLrEeutW5-TpeYJhA")]
    [DisplayName("Exposed Amount Party B")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpsdAmtPtyB")]
    #endif
    [IsoXmlTag("XpsdAmtPtyB")]
    [IsoSimpleType(IsoSimpleType.ActiveCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? ExposedAmountPartyB { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? ExposedAmountPartyB { get; init; } 
    #else
    public System.Decimal? ExposedAmountPartyB { get; set; } 
    #endif
    
    /// <summary>
    /// Underlying business area/type of trade that triggered the posting of collateral.
    /// </summary>
    [IsoId("_Vzn70wLrEeutW5-TpeYJhA")]
    [DisplayName("Exposure Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpsrTp")]
    #endif
    [IsoXmlTag("XpsrTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExposureType8Code ExposureType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExposureType8Code ExposureType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExposureType8Code ExposureType { get; init; } 
    #else
    public ExposureType8Code ExposureType { get; set; } 
    #endif
    
    /// <summary>
    /// Total value of the collateral (post-haircut) held by the exposed party.
    /// </summary>
    [IsoId("_Vzn7zwLrEeutW5-TpeYJhA")]
    [DisplayName("Total Value Of Collateral")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlValOfColl")]
    #endif
    [IsoXmlTag("TtlValOfColl")]
    [IsoSimpleType(IsoSimpleType.ActiveCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoActiveCurrencyAndAmount TotalValueOfCollateral { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Decimal TotalValueOfCollateral { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal TotalValueOfCollateral { get; init; } 
    #else
    public System.Decimal TotalValueOfCollateral { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of collateral in excess or deficit compared to the exposure.
    /// </summary>
    [IsoId("_Vzn7ywLrEeutW5-TpeYJhA")]
    [DisplayName("Net Excess Deficit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetXcssDfcit")]
    #endif
    [IsoXmlTag("NetXcssDfcit")]
    [IsoSimpleType(IsoSimpleType.ActiveCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? NetExcessDeficit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? NetExcessDeficit { get; init; } 
    #else
    public System.Decimal? NetExcessDeficit { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the collateral actually posted is a long or a short position.
    /// </summary>
    [IsoId("_Vzn70ALrEeutW5-TpeYJhA")]
    [DisplayName("Net Excess Deficit Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetXcssDfcitInd")]
    #endif
    [IsoXmlTag("NetXcssDfcitInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ShortLong1Code? NetExcessDeficitIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ShortLong1Code? NetExcessDeficitIndicator { get; init; } 
    #else
    public ShortLong1Code? NetExcessDeficitIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which the collateral was valued.
    /// </summary>
    [IsoId("_Vzn7zALrEeutW5-TpeYJhA")]
    [DisplayName("Valuation Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValtnDtTm")]
    #endif
    [IsoXmlTag("ValtnDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime ValuationDateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime ValuationDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime ValuationDateTime { get; init; } 
    #else
    public System.DateTime ValuationDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the instructing party requests settlement of the collateral to take place.
    /// </summary>
    [IsoId("_Vzn7zgLrEeutW5-TpeYJhA")]
    [DisplayName("Requested Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdSttlmDt")]
    #endif
    [IsoXmlTag("ReqdSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? RequestedSettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? RequestedSettlementDate { get; init; } 
    #else
    public System.DateOnly? RequestedSettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Additional details on the valuation of the collateral that is posted.
    /// </summary>
    [IsoId("_Vzn70gLrEeutW5-TpeYJhA")]
    [DisplayName("Summary Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SummryDtls")]
    #endif
    [IsoXmlTag("SummryDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SummaryAmounts2? SummaryDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SummaryAmounts2? SummaryDetails { get; init; } 
    #else
    public SummaryAmounts2? SummaryDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
