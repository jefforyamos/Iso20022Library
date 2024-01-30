﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for LoanData80.  ISO2002 ID# _g5iFAax2Eem81-uIvTF5rQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the loan data details in case of a margin lending transaction.
/// </summary>
public partial record LoanData80
{
    #nullable enable
    
    /// <summary>
    /// Unique trade Identifier (UTI) as agreed with the other counterparty.
    /// </summary>
    public required IsoMax52Text UniqueTradeIdentifier { get; init; } 
    /// <summary>
    /// Date on which the reportable event pertaining to the transaction and captured by the report took place.
    /// </summary>
    public required IsoISODate EventDate { get; init; } 
    /// <summary>
    /// Indicates the date and time when the contract was executed.
    /// </summary>
    public required IsoISODateTime ExecutionDateTime { get; init; } 
    /// <summary>
    /// Identification of the trading venue where the transaction was executed.
    /// </summary>
    public IsoMICIdentifier? TradingVenue { get; init; } 
    /// <summary>
    /// Specifies whether the collateral is subject to a title transfer collateral arrangement, a securities interest collateral arrangement, or a securities interest with the right of use.
    /// </summary>
    public CollateralDeliveryMethod1Code? CollateralDeliveryMethod { get; init; } 
    /// <summary>
    /// Total amount of margin loans in base currency.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? OutstandingMarginLoanAmount { get; init; } 
    /// <summary>
    /// Market value of short position in base currency.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? ShortMarketValueAmount { get; init; } 
    /// <summary>
    /// Data on amount and interest rates of the transaction.
    /// </summary>
    public InterestRate3? MarginLoanAttribute { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Termination date in the case of a full early termination of the SFT.
    /// </summary>
    public IsoISODate? TerminationDate { get; init; } 
    
    #nullable disable
}
