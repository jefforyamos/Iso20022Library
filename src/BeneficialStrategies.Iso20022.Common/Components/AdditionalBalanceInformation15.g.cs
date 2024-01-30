﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AdditionalBalanceInformation15.  ISO2002 ID# _OFLavznGEeWV5sr121Fc8A.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Subbalances providing additional information on a specific position but that is not to be accounted for in the building of the aggregate balance, for example, registered.
/// </summary>
public partial record AdditionalBalanceInformation15
{
    #nullable enable
    
    /// <summary>
    /// Reason for the sub-balance.
    /// </summary>
    public required ISubBalanceType12Choice SubBalanceType { get; init; } 
    /// <summary>
    /// Quantity of securities in the sub-balance.
    /// </summary>
    public required Balance9 Quantity { get; init; } 
    /// <summary>
    /// Provides additional sub-balance information.
    /// </summary>
    public IsoMax140Text? SubBalanceAdditionalDetails { get; init; } 
    /// <summary>
    /// Breakdown of the aggregate quantity reported into significant lots, for example, tax lots.
    /// </summary>
    public QuantityBreakdown27? QuantityBreakdown { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
