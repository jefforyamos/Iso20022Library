﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NoCode.  ISO2002 ID# _fZtdoHixEeqKjIYaFgh_2g.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PortfolioCode1Choice;

/// <summary>
/// Collateralisation was performed on a transaction level basis or if the collateral portfolio code is not known at the time of reporting.
/// </summary>
public partial record NoCode : PortfolioCode1Choice_
{
    public required NotApplicable1Code Value { get; init; }
}
