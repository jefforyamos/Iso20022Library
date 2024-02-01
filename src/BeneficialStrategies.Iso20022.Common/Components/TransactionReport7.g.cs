﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransactionReport7.  ISO2002 ID# _8WqD8QKxEe2rHs6fbn9-0A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the payment transactions.
/// </summary>
public partial record TransactionReport7
{
    #nullable enable
    
    /// <summary>
    /// Reference to the instruction related to the payment for which information is requested.
    /// </summary>
    public required PaymentIdentification7Choice_ PaymentIdentification { get; init; } 
    /// <summary>
    /// Requested information on the payment transaction when information has not been found.
    /// </summary>
    public required TransactionOrError5Choice_ TransactionOrError { get; init; } 
    
    #nullable disable
}
