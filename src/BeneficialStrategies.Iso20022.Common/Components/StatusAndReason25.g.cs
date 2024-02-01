﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for StatusAndReason25.  ISO2002 ID# _RmsswU32EeSGA7fXFuKIIQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status and reason of an instructed order.
/// </summary>
public partial record StatusAndReason25
{
    #nullable enable
    
    /// <summary>
    /// Status and reason for the transaction.
    /// </summary>
    public required Status15Choice_ StatusAndReason { get; init; } 
    /// <summary>
    /// Details of the transactions reported.
    /// </summary>
    public Transaction40[] Transaction { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
