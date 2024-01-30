﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for RepurchaseTrade.  ISO2002 ID# _KA3wkcz4EeufhKfUxzsnrQ.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.TransactionLoanData32Choice;

/// <summary>
/// Details of the repurchase trade transaction.
/// </summary>
public partial record RepurchaseTrade : ITransactionLoanData32Choice
{
    #nullable enable
    /// <summary>
    /// Unique trade Identifier (UTI) as agreed with the other counterparty.
    /// </summary>
    public required IsoMax52Text UniqueTradeIdentifier { get; init; } 
    /// <summary>
    /// Date on which the reportable event pertaining to the transaction and captured by the report took place. In the case of action types valuation update, collateral update, reuse update, margin update, the date for which the information contained in the report is provided.
    /// </summary>
    public required IsoISODate EventDate { get; init; } 
    /// <summary>
    /// Indicates the date and time when the contract was executed.
    /// </summary>
    public required IsoISODateTime ExecutionDateTime { get; init; } 
    /// <summary>
    /// Indicates whether clearing of contract has taken place.
    /// </summary>
    public required ICleared16Choice ClearingStatus { get; init; } 
    /// <summary>
    /// Venue of execution shall be identified by a unique code for this venue.
    /// </summary>
    public required IsoMICIdentifier TradingVenue { get; init; } 
    /// <summary>
    /// Reference to master agreement under which the counterparties concluded a documented transaction.
    /// </summary>
    public MasterAgreement7? MasterAgreement { get; init; } 
    /// <summary>
    /// Date on which the counterparties contractually agree the exchange of securities or commodities versus collateral for the opening leg (spot leg) of the secured financing transaction. In the case of rollover of open term repurchase transactions, this is the date on which the rollover settles, even if no exchange of cash takes place.
    /// </summary>
    public required IsoISODate ValueDate { get; init; } 
    /// <summary>
    /// Indication whether the transaction is subject to a general collateral arrangement. -‘true’ shall be populated for general collateral. General collateral specifies a collateral arrangement for a repurchase transaction in which the security lender may choose the security to provide as collateral with the cash provider amongst a relatively wide range of securities meeting predefined criteria.
    /// -‘false’ shall be populated for specific collateral. Specific collateral specifies a collateral arrangement for a repurchase transaction in which the buyer requests a specific security or commodity (individual ISIN) to be provided by the seller.
    /// </summary>
    public SpecialCollateral1Code? GeneralCollateral { get; init; } 
    /// <summary>
    /// Indicates whether the transaction was settled using the Delivery-by-Value (DBV) mechanism.
    /// </summary>
    public required IsoTrueFalseIndicator DeliveryByValue { get; init; } 
    /// <summary>
    /// Delivery method of the collateral.
    /// </summary>
    public required CollateralDeliveryMethod1Code CollateralDeliveryMethod { get; init; } 
    /// <summary>
    /// Period before or at the end of which the loan should be repaid or renegotiated for another term. 
    /// </summary>
    public IContractTerm7Choice? Term { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Interest rate of the loan.
    /// </summary>
    public IInterestRate27Choice? InterestRate { get; init; } 
    /// <summary>
    /// Amount of money to be settled as of the start date and maturity date of the transaction.
    /// </summary>
    public PrincipalAmount3? PrincipalAmount { get; init; } 
    /// <summary>
    /// Termination date in the case of a full early termination of the reported transaction.
    /// </summary>
    public IsoISODate? TerminationDate { get; init; } 
    /// <summary>
    /// Price of unit of collateral component, including accrued interest for interest-bearing securities.
    /// </summary>
    public ISecuritiesTransactionPrice19Choice? UnitPrice { get; init; } 
    #nullable disable
}
