﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransactionReport6.  ISO2002 ID# _dksd0dcZEeqRFcf2R4bPBw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the payment transactions.
/// </summary>
public partial record TransactionReport6
{
    #nullable enable
    
    /// <summary>
    /// Reference to the instruction related to the payment for which information is requested.
    /// </summary>
    public required IPaymentIdentification6Choice PaymentIdentification { get; init; } 
    /// <summary>
    /// Requested information on the payment transaction when information has not been found.
    /// </summary>
    public required ITransactionOrError5Choice TransactionOrError { get; init; } 
    
    #nullable disable
}
