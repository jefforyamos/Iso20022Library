﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for NotificationEntry1.  ISO2002 ID# _T73WoNp-Ed-ak6NoX_4Aeg_-125433999.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the elements of an entry in the report.
/// </summary>
public partial record NotificationEntry1
{
    #nullable enable
    
    /// <summary>
    /// Amount of money in the cash entry.
    /// </summary>
    public required IsoCurrencyAndAmount Amount { get; init; } 
    /// <summary>
    /// Specifies if an entry is a credit or a debit.
    /// </summary>
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    /// <summary>
    /// Indicates whether the entry is the result of a reversal operation.||Usage: this element should only be present if the entry is the result of a reversal operation.|If the CreditDebitIndicator is CRDT and ReversalIndicator is Yes, the original operation was a debit entry.|If the CreditDebitIndicator is DBIT and ReversalIndicator is Yes, the original operation was a credit entry.
    /// </summary>
    public IsoTrueFalseIndicator? ReversalIndicator { get; init; } 
    /// <summary>
    /// Status of an entry on the books of the account servicer.
    /// </summary>
    public required EntryStatus4Code Status { get; init; } 
    /// <summary>
    /// Date and time when an entry is posted to an account on the account servicer's books.||Usage: Booking date is only present if Status is booked.
    /// </summary>
    public IDateAndDateTimeChoice? BookingDate { get; init; } 
    /// <summary>
    /// Date and time assets become available to the account owner (in a credit entry), or cease to be available to the account owner (in a debit entry).||Usage: When entry status is pending, and value date is present, value date refers to an expected/requested value date.|For entries which are subject to availability/float (and for which availability information is present), value date must not be used, as the availability component identifies the number of availability days.
    /// </summary>
    public IDateAndDateTimeChoice? ValueDate { get; init; } 
    /// <summary>
    /// Account servicing institution's reference for the entry.
    /// </summary>
    public IsoMax35Text? AccountServicerReference { get; init; } 
    /// <summary>
    /// Set of elements used to indicate when the booked amount of money will become available, ie can be accessed and start generating interest. ||Usage: this type of info is eg used in US, and is linked to particular instruments, such as cheques.|Example: When a cheque is deposited, it will be booked on the deposit day, but the funds will only be accessible as of the indicated availability day (according to national banking regulations).
    /// </summary>
    public CashBalanceAvailability1? Availability { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Set of elements to fully identify the type of underlying transaction resulting in the entry.
    /// </summary>
    public required BankTransactionCodeStructure1 BankTransactionCode { get; init; } 
    /// <summary>
    /// Indicates whether the transaction is exempt from commission.
    /// </summary>
    public IsoYesNoIndicator? CommissionWaiverIndicator { get; init; } 
    /// <summary>
    /// Indicates whether the underlying transaction details are provided through a separate message, eg in case of aggregate bookings.
    /// </summary>
    public MessageIdentification2? AdditionalInformationIndicator { get; init; } 
    /// <summary>
    /// Set of elements providing details on batched transactions.||Usage: this element can be repeated in case more than one batch is included in the entry, eg, in lockbox scenarios, to specify the ID and number of transactions included in each of the batches.
    /// </summary>
    public BatchInformation1? Batch { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Set of elements providing information on the original amount.||Usage: This component (on entry level) should be used when a total original batch or aggregate amount has to be provided. (If required, the individual original amounts can be included in the same component on transaction details level).
    /// </summary>
    public AmountAndCurrencyExchange2? AmountDetails { get; init; } 
    /// <summary>
    /// Provides information on the charges included in the entry amount.||Usage: this component is used on entry level in case of batch or aggregate bookings.
    /// </summary>
    public ChargesInformation3? Charges { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Set of elements providing details on the interest amount included in the entry amount.||Usage: This component is used on entry level in case of batch or aggregate bookings.
    /// </summary>
    public TransactionInterest1? Interest { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Set of elements providing information on the underlying transaction (s).
    /// </summary>
    public EntryTransaction1? TransactionDetails { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Further details on the entry details.
    /// </summary>
    public IsoMax500Text? AdditionalEntryInformation { get; init; } 
    
    #nullable disable
}
