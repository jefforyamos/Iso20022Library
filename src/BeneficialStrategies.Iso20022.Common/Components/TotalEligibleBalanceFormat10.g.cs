﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TotalEligibleBalanceFormat10.  ISO2002 ID# _KUd0HRuyEeyhRdHRjakS2w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Total eligible balance for the corporate action and full and part way period units.
/// </summary>
public partial record TotalEligibleBalanceFormat10
{
    #nullable enable
    
    /// <summary>
    /// Provides information about balance related to a corporate action.
    /// </summary>
    public IQuantity49Choice? Balance { get; init; } 
    /// <summary>
    /// Number of units of a fund that were purchased in a previous distribution period and/or held at the beginning of a distribution period, for example Group I Units in the UK.
    /// </summary>
    public SignedQuantityFormat10? FullPeriodUnits { get; init; } 
    /// <summary>
    /// Number of units of a fund that were purchased part way throughout a distribution period, for example Group II Units in the U.K.
    /// </summary>
    public SignedQuantityFormat10? PartWayPeriodUnits { get; init; } 
    
    #nullable disable
}
