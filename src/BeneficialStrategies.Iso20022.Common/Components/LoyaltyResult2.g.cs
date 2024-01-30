﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for LoyaltyResult2.  ISO2002 ID# _fk10wQ0zEeqUVL7sB4m7NA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to the result of a processed loyalty transaction.
/// </summary>
public partial record LoyaltyResult2
{
    #nullable enable
    
    /// <summary>
    /// Account managing the Loyalty.
    /// </summary>
    public required LoyaltyAccount2 Account { get; init; } 
    /// <summary>
    /// Amount.
    /// </summary>
    public LoyaltyAmount1? Amount { get; init; } 
    /// <summary>
    /// Data sent by the Loyalty server.
    /// </summary>
    public LoyaltyServerData1? ServerData { get; init; } 
    /// <summary>
    /// Rebate information.
    /// </summary>
    public LoyaltyRebates1? Rebates { get; init; } 
    
    #nullable disable
}
