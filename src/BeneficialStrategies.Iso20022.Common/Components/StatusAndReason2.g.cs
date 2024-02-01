﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for StatusAndReason2.  ISO2002 ID# _UaaT1tp-Ed-ak6NoX_4Aeg_-595941310.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status and reason of an instructed order.
/// </summary>
public partial record StatusAndReason2
{
    #nullable enable
    
    /// <summary>
    /// Status and reason for the transaction.
    /// </summary>
    public required Status2Choice_ StatusAndReason { get; init; } 
    
    #nullable disable
}
