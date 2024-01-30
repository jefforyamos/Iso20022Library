﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Result1.  ISO2002 ID# _UlvaEtp-Ed-ak6NoX_4Aeg_1884281908.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Summation of the call amounts either due to A or due to B.
/// </summary>
public partial record Result1
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
