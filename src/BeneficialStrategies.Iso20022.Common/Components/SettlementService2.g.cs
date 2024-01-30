﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementService2.  ISO2002 ID# _9FG4MUNJEeiut6dbx3wnBg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Attributes of a settlement service.
/// </summary>
public partial record SettlementService2
{
    #nullable enable
    
    /// <summary>
    /// Settlement service actually applied to the transaction.
    /// </summary>
    public SettlementServiceMode1? SettlementServiceApplied { get; init; } 
    /// <summary>
    /// Dates related to the settlement service related to the transaction.
    /// </summary>
    public SettlementServiceDate1? SettlementServiceDates { get; init; } 
    /// <summary>
    /// Entity in charge of the settlement reporting service.
    /// </summary>
    public SettlementReportingEntity1? SettlementReportingEntity { get; init; } 
    
    #nullable disable
}
