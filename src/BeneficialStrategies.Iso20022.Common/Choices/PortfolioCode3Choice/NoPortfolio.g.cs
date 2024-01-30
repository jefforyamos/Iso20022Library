﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NoPortfolio.  ISO2002 ID# _WOwWc1zGEeyTL-yEabFeNg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PortfolioCode3Choice;

/// <summary>
/// Collateralisation was performed on a transaction level basis or if the collateral portfolio code is not known at the time of reporting.
/// </summary>
public partial record NoPortfolio : IPortfolioCode3Choice
{
    public required NotApplicable1Code Value { get; init; }
}
