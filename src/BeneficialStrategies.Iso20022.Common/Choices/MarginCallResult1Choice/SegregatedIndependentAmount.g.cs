﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for SegregatedIndependentAmount.  ISO2002 ID# _QmevN9p-Ed-ak6NoX_4Aeg_-1985134634.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.MarginCallResult1Choice;

/// <summary>
/// Provides the summation of the call amounts for the segregated independent amount only.
/// </summary>
public partial record SegregatedIndependentAmount : IMarginCallResult1Choice
{
    #nullable enable
    /// <summary>
    /// Amount payable by party B to party A.
    /// </summary>
    public IsoActiveCurrencyAndAmount? DueToPartyA { get; init; } 
    /// <summary>
    /// Amount payable by party A to party B.
    /// </summary>
    public IsoActiveCurrencyAndAmount? DueToPartyB { get; init; } 
    /// <summary>
    /// Provides additional information related to the collateral that may be requested.
    /// </summary>
    public IsoMax210Text? AdditionalInformation { get; init; } 
    #nullable disable
}
