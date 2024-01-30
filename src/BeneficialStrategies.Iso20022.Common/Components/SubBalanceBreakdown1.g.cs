﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SubBalanceBreakdown1.  ISO2002 ID# _u5lkhYjkEeONZKAAW4pOaQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Net position of a segregated holding of a single financial instrument within the overall position held in the securities account, for example, sub-balance per status.
/// </summary>
public partial record SubBalanceBreakdown1
{
    #nullable enable
    
    /// <summary>
    /// Reason for the sub-balance.
    /// </summary>
    public required ISubBalanceType9Choice SubBalanceType { get; init; } 
    /// <summary>
    /// Quantity of financial instrument in the sub-balance.
    /// </summary>
    public required ISubBalanceQuantity5Choice Quantity { get; init; } 
    
    #nullable disable
}
