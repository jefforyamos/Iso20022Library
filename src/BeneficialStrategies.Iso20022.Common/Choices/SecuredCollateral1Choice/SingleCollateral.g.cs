﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for SingleCollateral.  ISO2002 ID# _fvQpMJgAEeSfnc-VXAEapg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecuredCollateral1Choice;

/// <summary>
/// Identifies the security pledged via a single ISIN.
/// </summary>
public partial record SingleCollateral : SecuredCollateral1Choice_
{
    #nullable enable
    /// <summary>
    /// Nominal amount of the security pledged as collateral. Except for tri-party repos and any other transaction in which the security pledged is not identified via a single ISIN.
    /// </summary>
    public IsoActiveCurrencyAndAmount? NominalAmount { get; init; } 
    /// <summary>
    /// International Securities Identification Number (ISIN). A numbering system designed by the United Nation's International Organisation for Standardisation (ISO). The ISIN is composed of a 2-character prefix representing the country of issue, followed by the national security number (if one exists), and a check digit. Each country has a national numbering agency that assigns ISIN numbers for securities in that country.
    /// </summary>
    public required IsoISINIdentifier ISIN { get; init; } 
    #nullable disable
}
