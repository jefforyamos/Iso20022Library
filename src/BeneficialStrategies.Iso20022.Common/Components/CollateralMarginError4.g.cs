﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CollateralMarginError4.  ISO2002 ID# _aP7Lkcg2EeuGrNSsxk3B0A.
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
/// Specifies the details of the collateral margin data.
/// </summary>
[IsoId("_aP7Lkcg2EeuGrNSsxk3B0A")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Collateral Margin Error")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CollateralMarginError4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CollateralMarginError4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CollateralMarginError4( System.DateTime reqReportingDateTime,Counterparty39 reqCounterparty,System.String reqCollateralPortfolioIdentification )
    {
        ReportingDateTime = reqReportingDateTime;
        Counterparty = reqCounterparty;
        CollateralPortfolioIdentification = reqCollateralPortfolioIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and status advice message.
    /// </summary>
    [IsoId("_aRqQ8cg2EeuGrNSsxk3B0A")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Technical Record Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #endif
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
    [IsoId("_aRqQ88g2EeuGrNSsxk3B0A")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Reporting Date Time")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime ReportingDateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.DateTime ReportingDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime ReportingDateTime { get; init; } 
    #else
    public System.DateTime ReportingDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Data specific to counterparties of the reported transaction.
    /// </summary>
    [IsoId("_aRqQ9cg2EeuGrNSsxk3B0A")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Counterparty")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Counterparty39 Counterparty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public Counterparty39 Counterparty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Counterparty39 Counterparty { get; init; } 
    #else
    public Counterparty39 Counterparty { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identification of the collateral portfolio.
    /// </summary>
    [IsoId("_aRqQ98g2EeuGrNSsxk3B0A")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Collateral Portfolio Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 52 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax52Text CollateralPortfolioIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String CollateralPortfolioIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String CollateralPortfolioIdentification { get; init; } 
    #else
    public System.String CollateralPortfolioIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_aRqQ-cg2EeuGrNSsxk3B0A")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Supplementary Data")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
