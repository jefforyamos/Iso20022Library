﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateAction74.  ISO2002 ID# _MJKijV99Ee262vCSVgjImg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the corporate action event.
/// </summary>
public partial record CorporateAction74
{
    #nullable enable
    
    /// <summary>
    /// Provides information about the dates related to a corporate action event.
    /// </summary>
    public CorporateActionDate89? DateDetails { get; init; } 
    /// <summary>
    /// Stage in the corporate action event life cycle.
    /// </summary>
    public CorporateActionEventStageFormat15Choice_? EventStage { get; init; } 
    /// <summary>
    /// Specifies the type of the additional business process linked to a corporate action event such as a claim compensation or tax refund.
    /// </summary>
    public AdditionalBusinessProcessFormat16Choice_[] AdditionalBusinessProcessIndicator { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies the type of lottery announced.
    /// </summary>
    public LotteryTypeFormat5Choice_? LotteryType { get; init; } 
    
    #nullable disable
}
