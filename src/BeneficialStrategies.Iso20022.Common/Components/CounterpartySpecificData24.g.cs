﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CounterpartySpecificData24.  ISO2002 ID# _j2M0YZQJEeiILOjNP8ro1w.
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
/// Data related specifically to counterparties.
/// </summary>
[IsoId("_j2M0YZQJEeiILOjNP8ro1w")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Counterparty Specific Data")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CounterpartySpecificData24
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CounterpartySpecificData24 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CounterpartySpecificData24( TradeCounterpartyReport10 reqCounterparty,System.DateTime reqReportingDateTime )
    {
        Counterparty = reqCounterparty;
        ReportingDateTime = reqReportingDateTime;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Data specific to counterparties of the reported transaction/position.
    /// </summary>
    [IsoId("_kD5SIZQJEeiILOjNP8ro1w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Counterparty")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradeCounterpartyReport10 Counterparty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public TradeCounterpartyReport10 Counterparty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeCounterpartyReport10 Counterparty { get; init; } 
    #else
    public TradeCounterpartyReport10 Counterparty { get; set; } 
    #endif
    
    /// <summary>
    /// Data specific to the valuation of the transaction.
    /// </summary>
    [IsoId("_kD5SI5QJEeiILOjNP8ro1w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Valuation")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContractValuationData3? Valuation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContractValuationData3? Valuation { get; init; } 
    #else
    public ContractValuationData3? Valuation { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to collateral agreement existing between counterparties.
    /// </summary>
    [IsoId("_kD5SJZQJEeiILOjNP8ro1w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Collateral")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeCollateralReport2? Collateral { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeCollateralReport2? Collateral { get; init; } 
    #else
    public TradeCollateralReport2? Collateral { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time of reporting to the trade repository as required by regulation.
    /// </summary>
    [IsoId("_kD5SJ5QJEeiILOjNP8ro1w")]
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
    
    
    #nullable disable
    
}
