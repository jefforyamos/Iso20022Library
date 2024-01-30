﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentContext6.  ISO2002 ID# _kD_C8TG7EeOH78pE3LSlGw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Context in which the transaction is performed (payment and sale).
/// </summary>
public partial record CardPaymentContext6
{
    #nullable enable
    
    /// <summary>
    /// Context of the card payment transaction.
    /// </summary>
    public required PaymentContext6 PaymentContext { get; init; } 
    /// <summary>
    /// Context of the sale involving the card payment transaction.
    /// </summary>
    public SaleContext1? SaleContext { get; init; } 
    
    #nullable disable
}
