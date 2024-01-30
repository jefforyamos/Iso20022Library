﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentTransactionDetails6.  ISO2002 ID# _TEDrvQEcEeCQm6a_G2yO_w_-370572216.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the transaction in the cancellation response.
/// </summary>
public partial record CardPaymentTransactionDetails6
{
    #nullable enable
    
    /// <summary>
    /// Currency associated with the transaction.
    /// </summary>
    public required CurrencyCode Currency { get; init; } 
    /// <summary>
    /// Total amount of the transaction.
    /// </summary>
    public required IsoImpliedCurrencyAndAmount TotalAmount { get; init; } 
    
    #nullable disable
}
