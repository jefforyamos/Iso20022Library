﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for SecuritiesLending.  ISO2002 ID# _lod1JczsEeux2uvSBFU54Q.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransactionLoanData31Choice;

/// <summary>
/// Details of the securities lending transaction.
/// </summary>
public partial record SecuritiesLending : TransactionLoanData31Choice_
{
    #nullable enable
    /// <summary>
    /// Unique trade Identifier (UTI) as agreed with the other counterparty.
    /// </summary>
    public IsoMax52Text? UniqueTradeIdentifier { get; init; } 
    /// <summary>
    /// Date on which the reportable event pertaining to the transaction and captured by the report took place.
    /// </summary>
    public required IsoISODate EventDate { get; init; } 
    /// <summary>
    /// Indicates the date and time when the contract was executed.
    /// </summary>
    public IsoISODateTime? ExecutionDateTime { get; init; } 
    /// <summary>
    /// Indicates whether clearing of contract has taken place.
    /// </summary>
    public Cleared16Choice_? ClearingStatus { get; init; } 
    /// <summary>
    /// Identification of the trading venue where the transaction was executed.
    /// </summary>
    public IsoMICIdentifier? TradingVenue { get; init; } 
    /// <summary>
    /// Reference to master agreement under which the counterparties concluded a documented transaction.
    /// </summary>
    public MasterAgreement7? MasterAgreement { get; init; } 
    /// <summary>
    /// Date on which the counterparties contractually agree the exchange of securities or commodities versus collateral for the opening leg (spot leg) of the secured financing transaction. In the case of rollover of open term transactions, this is the date on which the rollover settles, even if no exchange of cash takes place.
    /// </summary>
    public IsoISODate? ValueDate { get; init; } 
    /// <summary>
    /// Indication whether the secured financing transaction is subject to a general collateral arrangement.
    /// </summary>
    public SpecialCollateral1Code? GeneralCollateral { get; init; } 
    /// <summary>
    /// This field specifies whether the transaction was settled using the Delivery-by-Value (DBV) mechanism.
    /// </summary>
    public IsoTrueFalseIndicator? DeliveryByValue { get; init; } 
    /// <summary>
    /// Specifies whether the collateral is subject to a title transfer collateral arrangement, a securities interest collateral arrangement, or a securities interest with the right of use.
    /// </summary>
    public CollateralDeliveryMethod1Code? CollateralDeliveryMethod { get; init; } 
    /// <summary>
    /// Indication whether the transaction is open term or, i.e. has no fixed maturity date, or fixed term with a contractually agreed maturity date.
    /// </summary>
    public ContractTerm7Choice_? Term { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Indication of the type of assets subject of the transaction.
    /// </summary>
    public SecurityCommodity9? AssetType { get; init; } 
    /// <summary>
    /// Specifies the loan value, that is the quantity or nominal amount multiplied by the price.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? LoanValue { get; init; } 
    /// <summary>
    /// Rate agreed to be paid by the lender for the reinvestment of the cash collateral minus lending fee.
    /// </summary>
    public InterestRate27Choice_? RebateRate { get; init; } 
    /// <summary>
    /// Fee that the borrower of the security or commodity pays to the lender.
    /// </summary>
    public IsoPercentageRate? LendingFee { get; init; } 
    /// <summary>
    /// Termination date in the case of a full early termination of the Securities Financing Transaction (SFT).
    /// </summary>
    public IsoISODate? TerminationDate { get; init; } 
    #nullable disable
}
