﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for EntryTransaction1.  ISO2002 ID# _T7aqvNp-Ed-ak6NoX_4Aeg_-2096191844.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Posting to an account that results in an increase or decrease to a balance.
/// </summary>
public partial record EntryTransaction1
{
    #nullable enable
    
    /// <summary>
    /// Set of elements providing the identification of the underlying transaction.
    /// </summary>
    public TransactionReferences1? References { get; init; } 
    /// <summary>
    /// Set of elements providing details information on the original amount.||Usage: This component (on transaction level) should be used in case booking is for a single transaction and the original amount is different from the entry amount. It can also be used in case individual original amounts are provided in case of a batch or aggregate booking.
    /// </summary>
    public AmountAndCurrencyExchange2? AmountDetails { get; init; } 
    /// <summary>
    /// Set of elements used to indicate when the booked funds will become available, ie can be accessed and start generating interest. ||Usage: this type of info is eg used in US, and is linked to particular instruments, such as cheques.|Example: When a cheque is deposited, it will be booked on the deposit day, but the funds will only be accessible as of the indicated availability day (according to national banking regulations).
    /// </summary>
    public CashBalanceAvailability1? Availability { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Set of elements to fully identify the type of underlying transaction resulting in an entry.
    /// </summary>
    public BankTransactionCodeStructure1? BankTransactionCode { get; init; } 
    /// <summary>
    /// Provides information on the charges included in the entry amount.||Usage: This component (on transaction level) can be used in case the booking is for a single transaction, and charges are included in the entry amount. It can also be used in case individual charge amounts are applied to individual transactions in case of a batch or aggregate amount booking.
    /// </summary>
    public ChargesInformation3? Charges { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Set of elements providing details on the interest amount included in the entry amount.||Usage: This component (on transaction level) can be used in case the booking is for a single transaction, and interest amount is included in the entry amount. It can also be used in case individual interest amounts are applied to individual transactions in case of a batch or aggregate amount booking.
    /// </summary>
    public TransactionInterest1? Interest { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Set of elements identifying the parties related to the underlying transaction.
    /// </summary>
    public TransactionParty1? RelatedParties { get; init; } 
    /// <summary>
    /// Set of elements identifying the agents related to the underlying transaction.
    /// </summary>
    public TransactionAgents1? RelatedAgents { get; init; } 
    /// <summary>
    /// Underlying reason for the payment transaction, eg, a charity payment, or a commercial agreement between the creditor and the debtor. ||Usage: purpose is used by the end-customers, ie originating party, initiating party, debtor, creditor, final party, to provide information concerning the nature of the payment transaction. Purpose is a content element, which is not used for processing by any of the agents involved in the payment chain.
    /// </summary>
    public IPurpose1Choice? Purpose { get; init; } 
    /// <summary>
    /// Information related to the handling of the remittance information by any of the agents in the transaction processing chain.
    /// </summary>
    public IReadOnlyCollection<RemittanceLocation1> RelatedRemittanceInformation { get; init; } = [];
    /// <summary>
    /// Information that enables the matching, ie, reconciliation, of a payment with the items that the payment is intended to settle, eg, commercial invoices in an account receivable system.
    /// </summary>
    public RemittanceInformation1? RemittanceInformation { get; init; } 
    /// <summary>
    /// Set of elements identifying the dates related to the underlying transactions.
    /// </summary>
    public TransactionDates1? RelatedDates { get; init; } 
    /// <summary>
    /// Set of elements identifying the price information related to the underlying transaction.
    /// </summary>
    public ITransactionPrice1Choice? RelatedPrice { get; init; } 
    /// <summary>
    /// Identifies related quantities (eg of securities) in the underlying transaction.
    /// </summary>
    public ITransactionQuantities1Choice? RelatedQuantities { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Identification of a security, as assigned under a formal or proprietary identification scheme.
    /// </summary>
    public ISecurityIdentification4Choice? FinancialInstrumentIdentification { get; init; } 
    /// <summary>
    /// Amount of money due to the government or tax authority, according to various pre-defined parameters such as thresholds or income.
    /// </summary>
    public TaxInformation2? Tax { get; init; } 
    /// <summary>
    /// Set of elements specifying the return information.
    /// </summary>
    public ReturnReasonInformation5? ReturnInformation { get; init; } 
    /// <summary>
    /// Set of elements identifying the underlying corporate action.
    /// </summary>
    public CorporateAction1? CorporateAction { get; init; } 
    /// <summary>
    /// Safekeeping or investment account. A safekeeping account is an account on which a securities entry is made. An investment account is an account between an investor(s) and a fund manager or a fund. The account can contain holdings in any investment fund or investment fund class managed (or distributed) by the fund manager, within the same fund family.
    /// </summary>
    public CashAccount7? SafekeepingAccount { get; init; } 
    /// <summary>
    /// Further details on the transaction details.
    /// </summary>
    public IsoMax500Text? AdditionalTransactionInformation { get; init; } 
    
    #nullable disable
}
