﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Accepted.  ISO2002 ID# _vzbp0IjYEeeDW7_wB-eK_g.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ClaimNonReceipt1Choice;

/// <summary>
/// Claim non-receipt is accepted and processed by the agent.
/// </summary>
public partial record Accepted : IClaimNonReceipt1Choice
{
    #nullable enable
    /// <summary>
    /// Specifies the date the original payment instruction was processed.
    /// </summary>
    public required IsoISODate DateProcessed { get; init; } 
    /// <summary>
    /// Specifies the next party the original payment instruction was sent to.
    /// </summary>
    public required BranchAndFinancialInstitutionIdentification5 OriginalNextAgent { get; init; } 
    #nullable disable
}
