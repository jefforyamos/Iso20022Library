﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for BackTestingMethodology1.  ISO2002 ID# _4TLUQLC2EeaSl6vJk5Bd8w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the characteristics of a backtesting methodology used to test the performance of a risk model.
/// </summary>
public partial record BackTestingMethodology1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the core model type, excluding any modifications for pro-cyclicality.
    /// </summary>
    public required IModelType1Choice RiskModelType { get; init; } 
    /// <summary>
    /// Specifies the confidence interval used on a daily basis to assess the performance of the model.
    /// </summary>
    public required IsoBaseOneRate ModelConfidenceLevel { get; init; } 
    /// <summary>
    /// Indicates whether the CCP model calculates mark-to-market changes on fixed portfolios when backtesting.
    /// </summary>
    public required IsoTrueFalseIndicator VariationMarginCleanIndicator { get; init; } 
    /// <summary>
    /// Description of backtesting methodology.
    /// </summary>
    public IsoMax2000Text? Description { get; init; } 
    
    #nullable disable
}
