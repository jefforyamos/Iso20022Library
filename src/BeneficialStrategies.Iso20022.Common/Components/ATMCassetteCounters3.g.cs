﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ATMCassetteCounters3.  ISO2002 ID# _k0cdIa4MEeWZgJQOa6iKCQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// ATM cassette counter per unit value or globally.
/// </summary>
public partial record ATMCassetteCounters3
{
    #nullable enable
    
    /// <summary>
    /// Amount of one media unit, if the media type is valued.
    /// </summary>
    public IsoImpliedCurrencyAndAmount? UnitValue { get; init; } 
    /// <summary>
    /// Currency of the media, if the media type is valued and different from the currency of the requested amount.
    /// </summary>
    public ActiveCurrencyCode? Currency { get; init; } 
    /// <summary>
    /// Category of media items.
    /// </summary>
    public ATMMediaType3Code? MediaCategory { get; init; } 
    /// <summary>
    /// Current number of media present in the cassette.
    /// </summary>
    public required IsoNumber CurrentNumber { get; init; } 
    /// <summary>
    /// Current amount in the cassette.
    /// </summary>
    public IsoImpliedCurrencyAndAmount? CurrentAmount { get; init; } 
    /// <summary>
    /// Counters of media inside the cassette.
    /// </summary>
    public ATMCassetteCounters4? FlowTotals { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
