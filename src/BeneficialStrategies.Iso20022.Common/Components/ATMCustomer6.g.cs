﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ATMCustomer6.  ISO2002 ID# _YMFgYa4KEeWZgJQOa6iKCQ.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Customer involved in a withdrawal transaction.
/// </summary>
public partial record ATMCustomer6
{
    #nullable enable
    
    /// <summary>
    /// Profile of the customer selected to perform the service.
    /// </summary>
    public ATMCustomerProfile4? Profile { get; init; } 
    /// <summary>
    /// Language selected by the customer at the ATM for the customer session. Reference ISO 639-1 (alpha-2) et ISO 639-2 (alpha-3).
    /// </summary>
    public LanguageCode? SelectedLanguage { get; init; } 
    /// <summary>
    /// Result of the customer authentication for this transaction.
    /// </summary>
    public TransactionVerificationResult5? AuthenticationResult { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
