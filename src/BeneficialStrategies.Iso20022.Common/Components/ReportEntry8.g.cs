﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ReportEntry8.  ISO2002 ID# _VnGelzqwEeWZFYSPlduMhw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on an entry in the report.
/// </summary>
public partial record ReportEntry8
{
    #nullable enable
    
    /// <summary>
    /// Unique reference for the entry.
    /// </summary>
    public IsoMax35Text? EntryReference { get; init; } 
    /// <summary>
    /// Amount of money in the cash entry.
    /// </summary>
    public required IsoActiveOrHistoricCurrencyAndAmount Amount { get; init; } 
    /// <summary>
    /// Indicates whether the entry is a credit or a debit entry.
    /// </summary>
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    /// <summary>
    /// Indicates whether or not the entry is the result of a reversal.|Usage: This element should only be present if the entry is the result of a reversal.|If the CreditDebitIndicator is CRDT and ReversalIndicator is Yes, the original operation was a debit entry.|If the CreditDebitIndicator is DBIT and ReversalIndicator is Yes, the original operation was a credit entry.
    /// </summary>
    public IsoTrueFalseIndicator? ReversalIndicator { get; init; } 
    /// <summary>
    /// Status of an entry on the books of the account servicer.
    /// </summary>
    public required EntryStatus2Code Status { get; init; } 
    /// <summary>
    /// Date and time when an entry is posted to an account on the account servicer's books.||Usage: Booking date is the expected booking date, unless the status is booked, in which case it is the actual booking date.
    /// </summary>
    public DateAndDateTimeChoice_? BookingDate { get; init; } 
    /// <summary>
    /// Date and time at which assets become available to the account owner in case of a credit entry, or cease to be available to the account owner in case of a debit entry.|Usage: If entry status is pending and value date is present, then the value date refers to an expected/requested value date.|For entries subject to availability/float and for which availability information is provided, the value date must not be used. In this case the availability component identifies the number of availability days.
    /// </summary>
    public DateAndDateTimeChoice_? ValueDate { get; init; } 
    /// <summary>
    /// Unique reference as assigned by the account servicing institution to unambiguously identify the entry.
    /// </summary>
    public IsoMax35Text? AccountServicerReference { get; init; } 
    /// <summary>
    /// Indicates when the booked amount of money will become available, that is can be accessed and starts generating interest. ||Usage: This type of information is used in the US and is linked to particular instruments such as cheques.|Example: When a cheque is deposited, it will be booked on the deposit day, but the amount of money will only be accessible as of the indicated availability day (according to national banking regulations).
    /// </summary>
    public CashAvailability1[] Availability { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Set of elements used to fully identify the type of underlying transaction resulting in an entry.
    /// </summary>
    public required BankTransactionCodeStructure4 BankTransactionCode { get; init; } 
    /// <summary>
    /// Indicates whether the transaction is exempt from commission.
    /// </summary>
    public IsoYesNoIndicator? CommissionWaiverIndicator { get; init; } 
    /// <summary>
    /// Indicates whether the underlying transaction details are provided through a separate message, as in the case of aggregate bookings.
    /// </summary>
    public MessageIdentification2? AdditionalInformationIndicator { get; init; } 
    /// <summary>
    /// Provides information on the original amount.||Usage: This component (on entry level) should be used when a total original batch or aggregate amount has to be provided. If required, the individual original amounts can be included in the same component on transaction details level.
    /// </summary>
    public AmountAndCurrencyExchange3? AmountDetails { get; init; } 
    /// <summary>
    /// Provides information on the charges, pre-advised or included in the entry amount.
    /// Usage: This component is used on entry level in case of batch or aggregate bookings.
    /// </summary>
    public Charges4? Charges { get; init; } 
    /// <summary>
    /// Channel used to technically input the instruction related to the entry.
    /// </summary>
    public TechnicalInputChannel1Choice_? TechnicalInputChannel { get; init; } 
    /// <summary>
    /// Provides details of the interest amount included in the entry amount.||Usage: This component is used on entry level in the case of batch or aggregate bookings.
    /// </summary>
    public TransactionInterest3? Interest { get; init; } 
    /// <summary>
    /// Provides details of the card transaction included in the entry amount, when globalised by the account servicer.
    /// </summary>
    public CardEntry2? CardTransaction { get; init; } 
    /// <summary>
    /// Provides details on the entry.
    /// </summary>
    public EntryDetails7[] EntryDetails { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Further details of the entry.
    /// </summary>
    public IsoMax500Text? AdditionalEntryInformation { get; init; } 
    
    #nullable disable
}
