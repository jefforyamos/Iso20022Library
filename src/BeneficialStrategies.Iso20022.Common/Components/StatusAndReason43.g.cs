﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for StatusAndReason43.  ISO2002 ID# _waWF5yAeEeuyDZ-ukt4YRg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status and reason of an instructed order.
/// </summary>
public partial record StatusAndReason43
{
    #nullable enable
    
    /// <summary>
    /// Status and reason for the transaction.
    /// </summary>
    public required Status33Choice_ StatusAndReason { get; init; } 
    /// <summary>
    /// Details of the transactions reported.
    /// </summary>
    public Transaction117[] Transaction { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
