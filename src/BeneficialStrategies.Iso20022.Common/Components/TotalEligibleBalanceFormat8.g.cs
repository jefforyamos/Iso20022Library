﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TotalEligibleBalanceFormat8.  ISO2002 ID# _LZFc6zq5EeWQ1Y7f8kds2A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Total eligible balance for the corporate action and full and part way period units.
/// </summary>
public partial record TotalEligibleBalanceFormat8
{
    #nullable enable
    
    /// <summary>
    /// Provides information about balance related to a corporate action.
    /// </summary>
    public IQuantity17Choice? Balance { get; init; } 
    /// <summary>
    /// Number of units of a fund that were purchased in a previous distribution period and/or held at the beginning of a distribution period, for example Group I Units in the UK.
    /// </summary>
    public SignedQuantityFormat6? FullPeriodUnits { get; init; } 
    /// <summary>
    /// Number of units of a fund that were purchased part way throughout a distribution period, for example Group II Units in the U.K.
    /// </summary>
    public SignedQuantityFormat6? PartWayPeriodUnits { get; init; } 
    
    #nullable disable
}
