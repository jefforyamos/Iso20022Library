﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for StatusAndReason16.  ISO2002 ID# _9aRywQ31EeKRyJSEMMwa2w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status and reason of an instructed order.
/// </summary>
public partial record StatusAndReason16
{
    #nullable enable
    
    /// <summary>
    /// Status and reason for the transaction.
    /// </summary>
    public required IStatus9Choice StatusAndReason { get; init; } 
    /// <summary>
    /// Details of the transactions reported.
    /// </summary>
    public Transaction28? Transaction { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
