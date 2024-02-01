﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountLinkStatus1.  ISO2002 ID# _3L62cXHeEeG8t-w1mFnmhg_-127584604.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Business status of the party for processing in the system.
/// </summary>
public partial record AccountLinkStatus1
{
    #nullable enable
    
    /// <summary>
    /// Status of the account link instruction.
    /// </summary>
    public required Status6Code Status { get; init; } 
    /// <summary>
    /// Underlying reason related to the creation of a transaction.
    /// </summary>
    public StatusReasonInformation10[] StatusReason { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
