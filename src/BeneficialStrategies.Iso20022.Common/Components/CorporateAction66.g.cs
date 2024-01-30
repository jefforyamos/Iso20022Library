﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateAction66.  ISO2002 ID# _p3Aw8zi7Eeydid5dcNPKvg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the corporate action event.
/// </summary>
public partial record CorporateAction66
{
    #nullable enable
    
    /// <summary>
    /// Provides information about the dates related to a corporate action event.
    /// </summary>
    public CorporateActionDate66? DateDetails { get; init; } 
    /// <summary>
    /// Stage in the corporate action event life cycle.
    /// </summary>
    public ICorporateActionEventStageFormat15Choice? EventStage { get; init; } 
    /// <summary>
    /// Indicates that the additional business process relates to a claim on the associated corporate action event.
    /// </summary>
    public IAdditionalBusinessProcessFormat14Choice? AdditionalBusinessProcessIndicator { get; init; } 
    /// <summary>
    /// Type of intermediates securities distribution.
    /// </summary>
    public IIntermediateSecuritiesDistributionTypeFormat18Choice? IntermediateSecuritiesDistributionType { get; init; } 
    /// <summary>
    /// Specifies the type of lottery announced.
    /// </summary>
    public ILotteryTypeFormat5Choice? LotteryType { get; init; } 
    
    #nullable disable
}
