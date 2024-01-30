﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for OtherCollateral.  ISO2002 ID# _aPU1wZgAEeSfnc-VXAEapg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecuredCollateral1Choice;

/// <summary>
/// Identifies the collateral when the asset class pledged as collateral does not correspond to an ISIN.
/// </summary>
public partial record OtherCollateral : ISecuredCollateral1Choice
{
    #nullable enable
    /// <summary>
    /// Specifies whether the collateral is a pool collateral or not.
    /// </summary>
    public required CollateralPool1Code PoolStatus { get; init; } 
    /// <summary>
    /// Identifies the asset class pledged as collateral, expressed as an ISO 10962 Classification of Financial Instrument (CFI).
    /// </summary>
    public required IsoCFIIdentifier Type { get; init; } 
    /// <summary>
    /// Provides the institutional sector, such as central government, central bank, etc. of the issuer of collateral.
    /// </summary>
    public required IsoSNA2008SectorIdentifier Sector { get; init; } 
    /// <summary>
    /// Nominal amount of money of the security pledged as collateral, when the collateral cannot be identified through an individual or basket ISIN.
    /// </summary>
    public IsoActiveCurrencyAndAmount? NominalAmount { get; init; } 
    #nullable disable
}
