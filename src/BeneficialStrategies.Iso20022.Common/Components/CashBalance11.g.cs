﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CashBalance11.  ISO2002 ID# _gyBmcZ-dEee28J7y9KlTWg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Balance details for a cash account.
/// </summary>
public partial record CashBalance11
{
    #nullable enable
    
    /// <summary>
    /// Currency and amount of money of the cash balance.
    /// </summary>
    public required IsoImpliedCurrencyAndAmount Amount { get; init; } 
    /// <summary>
    /// Indicates whether the balance is a credit or a debit balance. A zero balance is considered to be a credit balance.
    /// </summary>
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    /// <summary>
    /// Specifies the nature of a balance.
    /// </summary>
    public BalanceType9Choice_? Type { get; init; } 
    /// <summary>
    /// Current status of a cash balance.
    /// </summary>
    public BalanceStatus1Code? Status { get; init; } 
    /// <summary>
    /// Date and time at which the balance is or will be available.
    /// </summary>
    public DateAndDateTime2Choice_? ValueDate { get; init; } 
    /// <summary>
    /// Number of payments taken into account for the calculation of the cash balance value.
    /// </summary>
    public IsoNumber? NumberOfPayments { get; init; } 
    
    #nullable disable
}
