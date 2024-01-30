﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for MultipleCollateral.  ISO2002 ID# _iZO6A6idEeWHO_l3hf2rlA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecuredCollateral2Choice;

/// <summary>
/// Identifies all securities pledged when the transaction is collateralised with more than one security. 
/// Usage:
/// In case of multi-collateral repo, the nominal amount of each collateralised security must be provided.
/// </summary>
public partial record MultipleCollateral : ISecuredCollateral2Choice
{
    #nullable enable
    /// <summary>
    /// Nominal amount of the security pledged as collateral. Except for tri-party repos and any other transaction in which the security pledged is not identified via a single ISIN.
    /// </summary>
    public IsoActiveCurrencyAndAmount? NominalAmount { get; init; } 
    /// <summary>
    /// International Securities Identification Number (ISIN). A numbering system designed by the United Nation's International Organisation for Standardisation (ISO). The ISIN is composed of a 2-character prefix representing the country of issue, followed by the national security number (if one exists), and a check digit. Each country has a national numbering agency that assigns ISIN numbers for securities in that country.
    /// </summary>
    public required IsoISINOct2015Identifier ISIN { get; init; } 
    #nullable disable
}
