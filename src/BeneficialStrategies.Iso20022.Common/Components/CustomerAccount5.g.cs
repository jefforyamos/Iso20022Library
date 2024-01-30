﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CustomerAccount5.  ISO2002 ID# _NYe7IQ1iEeKGXqvMN6jpiw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account owned by a customer.
/// </summary>
public partial record CustomerAccount5
{
    #nullable enable
    
    /// <summary>
    /// Identification of the account.
    /// </summary>
    public IAccountIdentification4Choice? Identification { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    public IsoMax70Text? Name { get; init; } 
    /// <summary>
    /// Specifies the current state of an account, eg, enabled or deleted.
    /// </summary>
    public AccountStatus3Code? Status { get; init; } 
    /// <summary>
    /// Type of the account.
    /// </summary>
    public ICashAccountType2Choice? Type { get; init; } 
    /// <summary>
    /// Medium of exchange of value.
    /// </summary>
    public required ActiveCurrencyCode Currency { get; init; } 
    /// <summary>
    /// Monthly average of the payment amounts (that is, payments going out) over a year.
    /// </summary>
    public IsoImpliedCurrencyAndAmount? MonthlyPaymentValue { get; init; } 
    /// <summary>
    /// Monthly average of the received amounts over a year (that is, payments coming in).
    /// </summary>
    public IsoImpliedCurrencyAndAmount? MonthlyReceivedValue { get; init; } 
    /// <summary>
    /// Monthly average of the number of payments (coming in and going out) over a year.
    /// </summary>
    public IsoMax5NumericText? MonthlyTransactionNumber { get; init; } 
    /// <summary>
    /// Sum of the end of day balances over a month divided by the number of business days in the month.
    /// </summary>
    public IsoImpliedCurrencyAndAmount? AverageBalance { get; init; } 
    /// <summary>
    /// Specifies the purpose of the account.
    /// </summary>
    public IsoMax140Text? AccountPurpose { get; init; } 
    /// <summary>
    /// Specifies the value of the balance under which a notification will be sent to the account owner.
    /// </summary>
    public IsoImpliedCurrencyAndAmount? FloorNotificationAmount { get; init; } 
    /// <summary>
    /// Specifies the value of the balance above which a notification will be sent to the account owner.
    /// </summary>
    public IsoImpliedCurrencyAndAmount? CeilingNotificationAmount { get; init; } 
    /// <summary>
    /// Specifies how often statements (for audit purposes) will be sent, in which format, to which address.
    /// </summary>
    public StatementFrequencyAndForm1? StatementFrequencyAndFormat { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Date when the account will be or was closed.
    /// </summary>
    public IsoISODate? ClosingDate { get; init; } 
    /// <summary>
    /// Restriction on capability or operations allowed.
    /// </summary>
    public Restriction1? Restriction { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
