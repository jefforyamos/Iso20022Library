﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Transaction.  ISO2002 ID# _HJT6I6ifEeWHO_l3hf2rlA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UnsecuredMarketReport3Choice;

/// <summary>
/// Provides the details of the unsecured market transaction as reported by the reporting agent.
/// </summary>
public partial record Transaction : UnsecuredMarketReport3Choice_
{
    #nullable enable
    /// <summary>
    /// Defines the status of the reported transaction, that is details on whether the transaction is a new transaction, an amendment of a previously reported transaction, a cancellation of a previously reported transaction or a correction to a previously reported and rejected transaction.
    /// </summary>
    public required TransactionOperationType1Code ReportedTransactionStatus { get; init; } 
    /// <summary>
    /// Unique and unambiguous legal entity identification of the branch of the reporting agent in which the transaction has been booked.
    /// Usage: This field must only be provided if the transaction has been conducted and booked by a branch of the reporting agent and only if this branch has its own LEI that the reporting agent can clearly identify. 
    /// Where the transaction has been booked by the head office or the reporting agent cannot be identified by a unique branch-specific LEI, the reporting agent must provide the LEI of the head office.
    /// </summary>
    public IsoLEIIdentifier? BranchIdentification { get; init; } 
    /// <summary>
    /// Unique transaction identifier will be created at the time a transaction is first executed, shared with all registered entities and counterparties involved in the transaction, and used to track that particular transaction during its lifetime.
    /// </summary>
    public IsoMax105Text? UniqueTransactionIdentifier { get; init; } 
    /// <summary>
    /// Internal unique transaction identifier used by the reporting agent for each transaction.
    /// </summary>
    public required IsoMax105Text ProprietaryTransactionIdentification { get; init; } 
    /// <summary>
    /// Internal unique proprietary transaction identifier as assigned by the counterparty of the reporting agent for each transaction.
    /// </summary>
    public IsoMax105Text? CounterpartyProprietaryTransactionIdentification { get; init; } 
    /// <summary>
    /// Identification of the counterparty of the reporting agent for the reported transaction.
    /// </summary>
    public required CounterpartyIdentification2Choice_ CounterpartyIdentification { get; init; } 
    /// <summary>
    /// Date and time on which the parties entered into the reported transaction.
    /// Usage: when time is available, it must be reported.
    /// It is to be reported with only the date when the time of the transaction is not available. 
    /// The reported time is the execution time when available or otherwise the time at which the transaction entered the trading system of the reporting agent.
    /// </summary>
    public required DateAndDateTimeChoice_ TradeDate { get; init; } 
    /// <summary>
    /// Date on which the amount of money is exchanged by counterparties or on which the purchase or sale of a debt instrument settles. 
    /// With regard to call accounts and other unsecured borrowing/lending redeemable at notice, it is the date on which the deposit is rolled over, that is on which it would have been paid back if it had been called/not rolled over. In the case of a settlement failure in which settlement takes place on a different date than initially agreed, no transactional amendment needs to be reported.
    /// </summary>
    public required IsoISODate SettlementDate { get; init; } 
    /// <summary>
    /// Date on which the amount of money is due to be repaid by the borrower to the lender or on which a debt instrument matures and is due to be paid back. In regards to callable and puttable instruments, the final maturity date must be provided. For call accounts and other unsecured borrowing/lending redeemable upon notice, the first date on which the instrument may be redeemed must be provided.
    /// </summary>
    public required IsoISODate MaturityDate { get; init; } 
    /// <summary>
    /// Defines whether the transaction is a cash borrowing or cash lending transaction.
    /// </summary>
    public required MoneyMarketTransactionType1Code TransactionType { get; init; } 
    /// <summary>
    /// Defines the instrument via which the borrowing or lending transaction takes place.
    /// </summary>
    public required FinancialInstrumentProductType1Code InstrumentType { get; init; } 
    /// <summary>
    /// Amount of money initially borrowed or lent on deposits. In the case of debt securities, it is the nominal amount of the security issued or purchased.
    /// </summary>
    public required IsoActiveCurrencyAndAmount TransactionNominalAmount { get; init; } 
    /// <summary>
    /// Dirty price at which the security is issued or traded in percentage points, and which is to be reported as 100 for unsecured deposits.
    /// </summary>
    public required IsoPercentageRate DealPrice { get; init; } 
    /// <summary>
    /// Fixed rate for deposits and debt instruments with fixed coupons or variable rate for debt instruments for which the pay out at maturity or period depends on observed value of some underlying reference rate as well as for unsecured deposits paying interest at regular intervals. 
    /// </summary>
    public required InterestRateType1Code RateType { get; init; } 
    /// <summary>
    /// Interest rate expressed in accordance with the local money market convention at which the repurchase agreement has been concluded and at which the cash lent is remunerated.
    /// Usage:
    /// When the remuneration for securities lending transactions is represented by a fee amount, the fee amount will be translated into a deal rate per annum based on the ratio between the fee amount and the transaction nominal amount times number of days based on relevant money market convention divided by the number of days between the settlement date and the maturity of the transaction. 
    /// Only actual values, as opposed to estimated or default values, will be reported for this variable.
    /// This value can be either positive or negative irrespective of whether the cash is borrowed or lent. It represents the contractually agreed remuneration rate on the transaction nominal amount regardless of the transaction sign (that whether the transaction type is reported as borrowed or lent).
    /// </summary>
    public Rate2? DealRate { get; init; } 
    /// <summary>
    /// Debt instrument in which the periodic interest payments are calculated on the basis of the value (that is fixing of an underlying reference rate such as EURIBOR) on predefined dates (that is fixing) dates and which has a maturity of no more than one year.
    /// </summary>
    public FloatingRateNote2? FloatingRateNote { get; init; } 
    /// <summary>
    /// Specifies whether the transaction is arranged via a third party broker or not.
    /// </summary>
    public BrokeredDeal1Code? BrokeredDeal { get; init; } 
    /// <summary>
    /// Provides the option details, when the transaction reported is a call/put option.
    /// </summary>
    public IReadOnlyCollection<Option12> CallPutOption { get; init; } = [];
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    public SupplementaryData1? SupplementaryData { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}
