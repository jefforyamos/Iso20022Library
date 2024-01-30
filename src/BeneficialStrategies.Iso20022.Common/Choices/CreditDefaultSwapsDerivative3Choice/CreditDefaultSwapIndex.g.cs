﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CreditDefaultSwapIndex.  ISO2002 ID# _xfbL035eEea2k7EBUopqxw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CreditDefaultSwapsDerivative3Choice;

/// <summary>
/// A credit default swap on an index.
/// </summary>
public partial record CreditDefaultSwapIndex : ICreditDefaultSwapsDerivative3Choice
{
    #nullable enable
    /// <summary>
    /// Series number of the composition of the index if applicable.
    /// </summary>
    public IsoNumber? Series { get; init; } 
    /// <summary>
    /// New version of a series is issued if one of the constituents defaults and the index has to be re-weighted to account for the new number of total constituents within the index.
    /// </summary>
    public IsoNumber? Version { get; init; } 
    /// <summary>
    /// All months when the roll is expected as established by the index provider for a given year. Field should be repeated for each month in the roll.
    /// </summary>
    // public IReadOnlyCollection<IsoRestrictedMonthExact2Number> RollMonth { get; init; }
    /// <summary>
    /// To be populated in the case of a CDS Index or a derivative CDS Index with the next roll date of the index as established by the index provider.
    /// </summary>
    public IsoISODate? NextRollDate { get; init; } 
    /// <summary>
    /// Currency in which the notional is denominated.
    /// </summary>
    public required ActiveOrHistoricCurrencyCode NotionalCurrency { get; init; } 
    #nullable disable
}
