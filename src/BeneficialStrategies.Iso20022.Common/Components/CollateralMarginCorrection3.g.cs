﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CollateralMarginCorrection3.  ISO2002 ID# _PcVkga4aEemB_csI4yyKLA.
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
/// Specifies details of the collateral margin data.
/// </summary>
[IsoId("_PcVkga4aEemB_csI4yyKLA")]
[DisplayName("Collateral Margin Correction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CollateralMarginCorrection3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CollateralMarginCorrection3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CollateralMarginCorrection3( System.DateTime reqReportingDateTime,System.DateOnly reqEventDate,Counterparty30 reqCounterparty,System.String reqCollateralPortfolioIdentification )
    {
        ReportingDateTime = reqReportingDateTime;
        EventDate = reqEventDate;
        Counterparty = reqCounterparty;
        CollateralPortfolioIdentification = reqCollateralPortfolioIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and status advice message.
    /// </summary>
    [IsoId("_PgqD0a4aEemB_csI4yyKLA")]
    [DisplayName("Technical Record Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TechRcrdId")]
    #endif
    [IsoXmlTag("TechRcrdId")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? TechnicalRecordIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TechnicalRecordIdentification { get; init; } 
    #else
    public System.String? TechnicalRecordIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time of submission of the report to the trade repository.
    /// </summary>
    [IsoId("_PgqD064aEemB_csI4yyKLA")]
    [DisplayName("Reporting Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptgDtTm")]
    #endif
    [IsoXmlTag("RptgDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime ReportingDateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime ReportingDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime ReportingDateTime { get; init; } 
    #else
    public System.DateTime ReportingDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the reportable event pertaining to the transaction and captured by the report took place.
    /// </summary>
    [IsoId("_PgqD1a4aEemB_csI4yyKLA")]
    [DisplayName("Event Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtDt")]
    #endif
    [IsoXmlTag("EvtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate EventDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly EventDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly EventDate { get; init; } 
    #else
    public System.DateOnly EventDate { get; set; } 
    #endif
    
    /// <summary>
    /// Data specific to counterparties of the reported transaction.
    /// </summary>
    [IsoId("_PgqD164aEemB_csI4yyKLA")]
    [DisplayName("Counterparty")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrPty")]
    #endif
    [IsoXmlTag("CtrPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Counterparty30 Counterparty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Counterparty30 Counterparty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Counterparty30 Counterparty { get; init; } 
    #else
    public Counterparty30 Counterparty { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identification of the collateral portfolio.
    /// </summary>
    [IsoId("_PgqD2a4aEemB_csI4yyKLA")]
    [DisplayName("Collateral Portfolio Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollPrtflId")]
    #endif
    [IsoXmlTag("CollPrtflId")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax52Text CollateralPortfolioIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String CollateralPortfolioIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String CollateralPortfolioIdentification { get; init; } 
    #else
    public System.String CollateralPortfolioIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Information on posted collateral and margin.
    /// </summary>
    [IsoId("_PgqD264aEemB_csI4yyKLA")]
    [DisplayName("Posted Margin Or Collateral")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PstdMrgnOrColl")]
    #endif
    [IsoXmlTag("PstdMrgnOrColl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PostedMarginOrCollateral3? PostedMarginOrCollateral { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PostedMarginOrCollateral3? PostedMarginOrCollateral { get; init; } 
    #else
    public PostedMarginOrCollateral3? PostedMarginOrCollateral { get; set; } 
    #endif
    
    /// <summary>
    /// Information on received collateral and margin.
    /// </summary>
    [IsoId("_PgqD3a4aEemB_csI4yyKLA")]
    [DisplayName("Received Margin Or Collateral")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcvdMrgnOrColl")]
    #endif
    [IsoXmlTag("RcvdMrgnOrColl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReceivedMarginOrCollateral3? ReceivedMarginOrCollateral { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReceivedMarginOrCollateral3? ReceivedMarginOrCollateral { get; init; } 
    #else
    public ReceivedMarginOrCollateral3? ReceivedMarginOrCollateral { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_PgqD364aEemB_csI4yyKLA")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
