﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AdditionalBalanceInformation22.  ISO2002 ID# _lMvTxSp8EeyR9JrVGfaMKw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Sub-balances providing additional information on a specific position but that is not to be accounted for in the building of the aggregate balance, for example, registered.
/// </summary>
public partial record AdditionalBalanceInformation22
{
    #nullable enable
    
    /// <summary>
    /// Reason for the sub-balance.
    /// </summary>
    public required SubBalanceType12Choice_ SubBalanceType { get; init; } 
    /// <summary>
    /// Quantity of securities in the sub-balance.
    /// </summary>
    public required SubBalanceQuantity8Choice_ Quantity { get; init; } 
    /// <summary>
    /// Provides additional subbalance information.
    /// </summary>
    public IsoMax140Text? SubBalanceAdditionalDetails { get; init; } 
    
    #nullable disable
}
