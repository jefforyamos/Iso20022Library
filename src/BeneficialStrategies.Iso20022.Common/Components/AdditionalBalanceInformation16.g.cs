﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AdditionalBalanceInformation16.  ISO2002 ID# _5W52Z5NLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Sub-balances providing additional information on a specific position but that is not to be accounted for in the building of the aggregate balance, for example, registered.
/// </summary>
public partial record AdditionalBalanceInformation16
{
    #nullable enable
    
    /// <summary>
    /// Reason for the sub-balance.
    /// </summary>
    public required SubBalanceType14Choice_ SubBalanceType { get; init; } 
    /// <summary>
    /// Quantity of securities in the sub-balance.
    /// </summary>
    public required SubBalanceQuantity7Choice_ Quantity { get; init; } 
    /// <summary>
    /// Provides additional subbalance information.
    /// </summary>
    public IsoRestrictedFINXMax140Text? SubBalanceAdditionalDetails { get; init; } 
    
    #nullable disable
}
