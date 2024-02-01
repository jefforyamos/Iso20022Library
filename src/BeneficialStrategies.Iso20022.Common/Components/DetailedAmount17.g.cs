﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DetailedAmount17.  ISO2002 ID# _pgqcMa4uEeWLdt0vLARX2Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the transfer transaction amounts.
/// </summary>
public partial record DetailedAmount17
{
    #nullable enable
    
    /// <summary>
    /// Amount to be transferred from the source account to the destination account.
    /// </summary>
    public required IsoImpliedCurrencyAndAmount AmountToTransfer { get; init; } 
    /// <summary>
    /// Currency of the amount to be transferred.
    /// </summary>
    public ActiveCurrencyCode? Currency { get; init; } 
    /// <summary>
    /// Transfer fees, accepted by the customer.
    /// </summary>
    public DetailedAmount18[] Fees { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Amount of the donation.
    /// </summary>
    public DetailedAmount18[] Donation { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
