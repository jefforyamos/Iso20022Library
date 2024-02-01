﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for BuySellBack.  ISO2002 ID# _lod1I8zsEeux2uvSBFU54Q.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransactionLoanData31Choice;

/// <summary>
/// Details of the buy sell back transaction.
/// </summary>
public partial record BuySellBack : TransactionLoanData31Choice_
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
    /// Date on which the counterparties contractually agree the exchange of securities or commodities versus collateral for the closing leg (forward leg) of the transaction.
    /// </summary>
    public IsoISODate? MaturityDate { get; init; } 
    /// <summary>
    /// Indication whether the transaction is subject to a general collateral arrangement.
    /// </summary>
    public SpecialCollateral1Code? GeneralCollateral { get; init; } 
    /// <summary>
    /// Amount of money to be settled as of the start date and maturity date of the transaction.
    /// </summary>
    public PrincipalAmount3? PrincipalAmount { get; init; } 
    /// <summary>
    /// Price of unit of collateral component, including accrued interest for interest-bearing securities.
    /// </summary>
    public SecuritiesTransactionPrice19Choice_? UnitPrice { get; init; } 
    /// <summary>
    /// Termination date in the case of a full early termination of the Securities Financing Transaction (SFT).
    /// </summary>
    public IsoISODate? TerminationDate { get; init; } 
    #nullable disable
}
