﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for LoanData139.  ISO2002 ID# _lod1KczsEeux2uvSBFU54Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the loan data details in case of a repurchase trade transaction.
/// </summary>
public partial record LoanData139
{
    #nullable enable
    
    /// <summary>
    /// Unique Trade Identifier (UTI) as agreed with the other counterparty.
    /// </summary>
    public IsoMax52Text? UniqueTradeIdentifier { get; init; } 
    /// <summary>
    /// Date on which the reportable event pertaining to the transaction and captured by the report took place.
    /// </summary>
    public IsoISODate? EventDate { get; init; } 
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
    /// Date on which the counterparties contractually agree the exchange of securities or commodities versus collateral for the opening leg (spot leg) of the secured financing transaction. In the case of rollover of transaction open term, this is the date on which the rollover settles, even if no exchange of cash takes place.
    /// </summary>
    public IsoISODate? ValueDate { get; init; } 
    /// <summary>
    /// Minimum number of business days that one of the counterparties has to inform about the termination of the transaction.
    /// </summary>
    public IsoMax20PositiveNumber? MinimumNoticePeriod { get; init; } 
    /// <summary>
    /// Earliest date that the cash lender has the right to call back a portion of the amount of money or to terminate the transaction.
    /// </summary>
    public IsoISODate? EarliestCallBackDate { get; init; } 
    /// <summary>
    /// Indication whether the secured financing transaction is subject to a general or special collateral arrangement.
    /// </summary>
    public SpecialCollateral1Code? GeneralCollateral { get; init; } 
    /// <summary>
    /// Indicates whether the transaction was settled using the Delivery-by-Value (DBV) mechanism.
    /// </summary>
    public IsoTrueFalseIndicator? DeliveryByValue { get; init; } 
    /// <summary>
    /// Delivery method of the collateral.
    /// </summary>
    public CollateralDeliveryMethod1Code? CollateralDeliveryMethod { get; init; } 
    /// <summary>
    /// Period before or at the end of which the loan should be repaid or renegotiated for another term. 
    /// </summary>
    public ContractTerm7Choice_[] Term { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Interest rate of the loan.
    /// </summary>
    public InterestRate27Choice_? InterestRate { get; init; } 
    /// <summary>
    /// Amount of money to be settled as of the start date and maturity date of the transaction.
    /// </summary>
    public PrincipalAmount3? PrincipalAmount { get; init; } 
    /// <summary>
    /// Termination date in the case of a full early termination of the Securities Financing Transaction (SFT).
    /// </summary>
    public IsoISODate? TerminationDate { get; init; } 
    
    #nullable disable
}
