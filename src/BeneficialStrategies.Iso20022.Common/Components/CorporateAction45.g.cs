﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateAction45.  ISO2002 ID# _Kk3R07QXEeeKRKrD60ELBQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the corporate action event.
/// </summary>
public partial record CorporateAction45
{
    #nullable enable
    
    /// <summary>
    /// Provides information about the dates related to a corporate action event.
    /// </summary>
    public CorporateActionDate59? DateDetails { get; init; } 
    /// <summary>
    /// Stage in the corporate action event life cycle.
    /// </summary>
    public CorporateActionEventStageFormat14Choice_? EventStage { get; init; } 
    /// <summary>
    /// Specifies the type of lottery announced.
    /// </summary>
    public LotteryTypeFormat4Choice_? LotteryType { get; init; } 
    
    #nullable disable
}
