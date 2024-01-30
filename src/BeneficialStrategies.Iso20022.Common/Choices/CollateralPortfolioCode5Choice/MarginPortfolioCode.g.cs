﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for MarginPortfolioCode.  ISO2002 ID# _YxDO0zIDEe2fXedS_ucFOA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CollateralPortfolioCode5Choice;

/// <summary>
/// Specifies the unique code assigned by the reporting counterparty to the margin portfolio if the collateral is posted on a margin portfolio basis.
/// </summary>
public partial record MarginPortfolioCode : ICollateralPortfolioCode5Choice
{
    #nullable enable
    /// <summary>
    /// Specifies the unique code assigned by the reporting counterparty to the portfolio if the collateral is posted on a portfolio basis.
    /// Usage:
    /// NoCode is reported if the collateralisation was performed on a transaction level basis, or if there is no collateral agreement or if no collateral is posted or received.
    /// </summary>
    public required IPortfolioCode5Choice InitialMarginPortfolioCode { get; init; } 
    /// <summary>
    /// Specifies the unique code assigned by the reporting counterparty to the portfolio if the collateral is posted on a portfolio basis.
    /// Usage:
    /// NoCode is reported if the collateralisation was performed on a transaction level basis, or if there is no collateral agreement or if no collateral is posted or received.
    /// </summary>
    public IPortfolioCode5Choice? VariationMarginPortfolioCode { get; init; } 
    #nullable disable
}
