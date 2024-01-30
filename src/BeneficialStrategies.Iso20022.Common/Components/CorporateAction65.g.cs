﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateAction65.  ISO2002 ID# _ptF_bzi7Eeydid5dcNPKvg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the corporate action event.
/// </summary>
public partial record CorporateAction65
{
    #nullable enable
    
    /// <summary>
    /// Provides information about the dates related to a corporate action event.
    /// </summary>
    public CorporateActionDate70? DateDetails { get; init; } 
    /// <summary>
    /// Provides information about securities quantity linked to a corporate action.
    /// </summary>
    public CorporateActionQuantity13? SecuritiesQuantity { get; init; } 
    /// <summary>
    /// Stage in the corporate action event life cycle.
    /// </summary>
    public ICorporateActionEventStageFormat15Choice? EventStage { get; init; } 
    /// <summary>
    /// Indicates whether the message is related to a claim on the associated corporate action event.
    /// </summary>
    public IAdditionalBusinessProcessFormat21Choice? AdditionalBusinessProcessIndicator { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies the type of intermediates securities distribution.
    /// </summary>
    public IIntermediateSecuritiesDistributionTypeFormat18Choice? IntermediateSecuritiesDistributionType { get; init; } 
    /// <summary>
    /// Specifies the type of lottery announced.
    /// </summary>
    public ILotteryTypeFormat5Choice? LotteryType { get; init; } 
    
    #nullable disable
}
