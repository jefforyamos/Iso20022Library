﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AdditionalBalanceInformation19.  ISO2002 ID# _uLgAh_fVEeiNZp_PtLohLw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Subbalances providing additional information on a specific position but that is not to be accounted for in the building of the aggregate balance, for example, registered.
/// </summary>
public partial record AdditionalBalanceInformation19
{
    #nullable enable
    
    /// <summary>
    /// Reason for the sub-balance.
    /// </summary>
    public required SubBalanceType14Choice_ SubBalanceType { get; init; } 
    /// <summary>
    /// Quantity of securities in the sub-balance.
    /// </summary>
    public required Balance13 Quantity { get; init; } 
    /// <summary>
    /// Provides additional sub-balance information.
    /// </summary>
    public IsoRestrictedFINXMax140Text? SubBalanceAdditionalDetails { get; init; } 
    /// <summary>
    /// Breakdown of the aggregate quantity reported into significant lots, for example, tax lots.
    /// </summary>
    public QuantityBreakdown56[] QuantityBreakdown { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
