﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ExchangeConfiguration2.  ISO2002 ID# _epY-UR3hEeKWfegf-2AeBQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Configuration parameters of data exchanges.
/// </summary>
public partial record ExchangeConfiguration2
{
    #nullable enable
    
    /// <summary>
    /// Exchange policy between parties.
    /// </summary>
    public ExchangePolicy1Code[] ExchangePolicy { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Maximum number of transactions without exchange.
    /// </summary>
    public IsoNumber? MaximumNumber { get; init; } 
    /// <summary>
    /// Maximum cumulative amount of the transactions without exchange.
    /// </summary>
    public IsoImpliedCurrencyAndAmount? MaximumAmount { get; init; } 
    /// <summary>
    /// Timing condition for periodic exchanges.
    /// </summary>
    public ProcessTiming2? TimeCondition { get; init; } 
    
    #nullable disable
}
