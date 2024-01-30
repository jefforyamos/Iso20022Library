﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AgentType1.  ISO2002 ID# _4zG7sKHHEeagRbKvRt3LnA.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies one or more agents involved in a transaction, with their role.
/// </summary>
public partial record AgentType1
{
    #nullable enable
    
    /// <summary>
    /// Code allocated to a financial or non-financial institution by the ISO 9362 Registration Authority, as described in ISO 9362 "Banking - Banking telecommunication messages - Business identifier code (BIC)".
    /// </summary>
    public IsoAnyBICIdentifier? AnyBIC { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies the role of the party in the payment chain.
    /// </summary>
    public required PaymentsPartyType1Code Role { get; init; } 
    
    #nullable disable
}
