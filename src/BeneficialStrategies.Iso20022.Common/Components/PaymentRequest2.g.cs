﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentRequest2.  ISO2002 ID# _iaHBoQ1HEeqjM-rxn3HuXQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data required to request a Payment.
/// </summary>
public partial record PaymentRequest2
{
    #nullable enable
    
    /// <summary>
    /// Data associated with the Transaction.
    /// </summary>
    public CardPaymentTransaction100? PaymentTransaction { get; init; } 
    /// <summary>
    /// Data linked to card loyalty during payment.
    /// </summary>
    public LoyaltyRequestData2? LoyaltyData { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
