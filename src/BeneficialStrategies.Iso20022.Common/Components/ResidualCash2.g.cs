﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ResidualCash2.  ISO2002 ID# _s2vtoJP7EemyZbjY08A1Vw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies how the cash in the account that is awaiting investment is to be dealt with.
/// </summary>
public partial record ResidualCash2
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the cash in the account awaiting investment is to be transferred.
    /// </summary>
    public required IsoYesNoIndicator Indicator { get; init; } 
    /// <summary>
    /// Currency of the cash.
    /// </summary>
    public ActiveCurrencyCode? Currency { get; init; } 
    
    #nullable disable
}
