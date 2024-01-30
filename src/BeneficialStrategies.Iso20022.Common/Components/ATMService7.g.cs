﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ATMService7.  ISO2002 ID# _IAYH0Yq0EeSIDtZ76p6McQ.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Services allowed for the customer's profile.
/// </summary>
public partial record ATMService7
{
    #nullable enable
    
    /// <summary>
    /// Describes the type of inquiry selected by the customer or the ATM.
    /// </summary>
    public required ATMServiceType4Code ServiceType { get; init; } 
    /// <summary>
    /// Limits of amounts.
    /// </summary>
    public ATMTransactionAmounts3? Limits { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Preferred withdrawal transaction chosen by the customer.
    /// </summary>
    public ATMTransaction8? PreferredWithdrawal { get; init; } 
    
    #nullable disable
}
