﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CashBalance2.  ISO2002 ID# _SYBlU9p-Ed-ak6NoX_4Aeg_-2064635537.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements defining the balance details.
/// </summary>
public partial record CashBalance2
{
    #nullable enable
    
    /// <summary>
    /// Specifies the nature of a balance, eg, opening booked balance.
    /// </summary>
    public required IBalanceType2Choice Type { get; init; } 
    /// <summary>
    /// Provides further details on the credit line information.
    /// </summary>
    public CreditLine1? CreditLine { get; init; } 
    /// <summary>
    /// Currency and amount of money of the cash balance.
    /// </summary>
    public required IsoCurrencyAndAmount Amount { get; init; } 
    /// <summary>
    /// Indicates whether the balance is a credit or a debit balance. A zero balance is considered to be a credit balance.
    /// </summary>
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    /// <summary>
    /// Specifies the date (and time) of the balance.
    /// </summary>
    public required IDateAndDateTimeChoice Date { get; init; } 
    /// <summary>
    /// Set of elements used to indicate when the booked funds will become available, ie can be accessed and start generating interest. ||Usage: this type of info is eg used in US, and is linked to particular instruments, such as cheques.|Example: When a cheque is deposited, it will be booked on the deposit day, but the funds will only be accessible as of the indicated availability day (according to national banking regulations).
    /// </summary>
    public CashBalanceAvailability1? Availability { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
