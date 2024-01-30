﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementDailyFailureReason3.  ISO2002 ID# _MQiA0TOmEeqX8uoQQ3KffQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the settlement failure reason as defined in the relevant regulation.
/// </summary>
public partial record SettlementDailyFailureReason3
{
    #nullable enable
    
    /// <summary>
    /// Fails due to lack of securities.
    /// </summary>
    public required ISettlementTotalData1Choice FailedSecurities { get; init; } 
    /// <summary>
    /// Fails due to lack of cash.
    /// </summary>
    public required ISettlementTotalData1Choice FailedCash { get; init; } 
    
    #nullable disable
}
