﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for EntryTransaction10.  ISO2002 ID# _-bxLB248EeiU9cctagi5ow.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the underlying transaction.
/// </summary>
public partial record EntryTransaction10
{
    #nullable enable
    
    /// <summary>
    /// Provides the identification of the underlying transaction.
    /// </summary>
    public TransactionReferences6? References { get; init; } 
    /// <summary>
    /// Amount of money in the cash transaction.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? Amount { get; init; } 
    /// <summary>
    /// Indicates whether the transaction is a credit or a debit transaction.
    /// </summary>
    public CreditDebitCode? CreditDebitIndicator { get; init; } 
    /// <summary>
    /// Provides detailed information on the original amount.||Usage: This component (on transaction level) should be used in case booking is for a single transaction and the original amount is different from the entry amount. It can also be used in case individual original amounts are provided in case of a batch or aggregate booking.
    /// </summary>
    public AmountAndCurrencyExchange3? AmountDetails { get; init; } 
    /// <summary>
    /// Indicates when the booked amount of money will become available, that is can be accessed and starts generating interest. ||Usage: This type of information is used in the US and is linked to particular instruments such as cheques.|Example: When a cheque is deposited, it will be booked on the deposit day, but the amount of money will only be accessible as of the indicated availability day (according to national banking regulations).
    /// </summary>
    public CashAvailability1? Availability { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Set of elements used to fully identify the type of underlying transaction resulting in an entry.
    /// </summary>
    public BankTransactionCodeStructure4? BankTransactionCode { get; init; } 
    /// <summary>
    /// Provides information on the charges, pre-advised or included in the entry amount.
    /// Usage: This component (on transaction level) can be used in case the booking is for a single transaction, and charges are included in the entry amount. It can also be used in case individual charge amounts are applied to individual transactions in case of a batch or aggregate amount booking.
    /// </summary>
    public Charges6? Charges { get; init; } 
    /// <summary>
    /// Provides details of the interest amount included in the entry amount.||Usage: This component (on transaction level) can be used if the booking is for a single transaction, and interest amount is included in the entry amount. It can also be used if individual interest amounts are applied to individual transactions in the case of a batch or aggregate amount booking.
    /// </summary>
    public TransactionInterest4? Interest { get; init; } 
    /// <summary>
    /// Set of elements used to identify the parties related to the underlying transaction.
    /// </summary>
    public TransactionParties6? RelatedParties { get; init; } 
    /// <summary>
    /// Set of elements used to identify the agents related to the underlying transaction.
    /// </summary>
    public TransactionAgents5? RelatedAgents { get; init; } 
    /// <summary>
    /// User community specific instrument.|Usage: This element is used to specify a local instrument, local clearing option and/or further qualify the service or service level.
    /// </summary>
    public ILocalInstrument2Choice? LocalInstrument { get; init; } 
    /// <summary>
    /// Underlying reason for the payment transaction.|Usage: Purpose is used by the end-customers, that is initiating party, (ultimate) debtor, (ultimate) creditor to provide information concerning the nature of the payment. Purpose is a content element, which is not used for processing by any of the agents involved in the payment chain.
    /// </summary>
    public IPurpose2Choice? Purpose { get; init; } 
    /// <summary>
    /// Provides information related to the handling of the remittance information by any of the agents in the transaction processing chain.
    /// </summary>
    public IReadOnlyCollection<RemittanceLocation7> RelatedRemittanceInformation { get; init; } = [];
    /// <summary>
    /// Structured information that enables the matching, that is reconciliation, of a payment with the items that the payment is intended to settle, such as commercial invoices in an account receivable system.
    /// </summary>
    public RemittanceInformation16? RemittanceInformation { get; init; } 
    /// <summary>
    /// Set of elements used to identify the dates related to the underlying transactions.
    /// </summary>
    public TransactionDates3? RelatedDates { get; init; } 
    /// <summary>
    /// Set of elements used to identify the price information related to the underlying transaction.
    /// </summary>
    public ITransactionPrice4Choice? RelatedPrice { get; init; } 
    /// <summary>
    /// Set of elements used to identify the related quantities, such as securities, in the underlying transaction.
    /// </summary>
    public ITransactionQuantities3Choice? RelatedQuantities { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Identification of a security, as assigned under a formal or proprietary identification scheme.
    /// </summary>
    public SecurityIdentification19? FinancialInstrumentIdentification { get; init; } 
    /// <summary>
    /// Provides details on the tax.
    /// </summary>
    public TaxInformation8? Tax { get; init; } 
    /// <summary>
    /// Provides the return information.
    /// </summary>
    public PaymentReturnReason5? ReturnInformation { get; init; } 
    /// <summary>
    /// Set of elements used to identify the underlying corporate action.
    /// </summary>
    public CorporateAction9? CorporateAction { get; init; } 
    /// <summary>
    /// Safekeeping or investment account. A safekeeping account is an account on which a securities entry is made. An investment account is an account between an investor(s) and a fund manager or a fund. The account can contain holdings in any investment fund or investment fund class managed (or distributed) by the fund manager, within the same fund family.
    /// </summary>
    public SecuritiesAccount19? SafekeepingAccount { get; init; } 
    /// <summary>
    /// Provides the details of a cash deposit for an amount of money in cash notes and/or coins.
    /// </summary>
    public CashDeposit1? CashDeposit { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides the data related to the card (number, scheme), terminal (number, identification) and transactional data used to uniquely identify a card transaction.
    /// </summary>
    public CardTransaction17? CardTransaction { get; init; } 
    /// <summary>
    /// Further details of the transaction.
    /// </summary>
    public IsoMax500Text? AdditionalTransactionInformation { get; init; } 
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    public SupplementaryData1? SupplementaryData { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
