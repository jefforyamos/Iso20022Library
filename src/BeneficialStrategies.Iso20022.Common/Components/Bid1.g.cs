﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Bid1.  ISO2002 ID# _S0Cy8Np-Ed-ak6NoX_4Aeg_34105770.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Attempt to buy or sell a large number of financial instruments contained in or comprising a portfolio.
/// </summary>
public partial record Bid1
{
    #nullable enable
    
    /// <summary>
    /// Unique identifier for a Bid Request as assigned by institution. Uniqueness must be guaranteed within a single trading day.
    /// </summary>
    public required IsoMax35Text ClientBidIdentification { get; init; } 
    /// <summary>
    /// Provides the name of the order list.
    /// </summary>
    public IsoMax128Text? ListName { get; init; } 
    /// <summary>
    /// Unique and unambiguous identification of the bid.
    /// </summary>
    public IsoMax35Text? BidIdentification { get; init; } 
    /// <summary>
    /// Total number of distinct financial instruments for which the bid is applicable.
    /// </summary>
    public required IsoNumber TotalNumberSecurities { get; init; } 
    /// <summary>
    /// Indicates whether or not to exchange for physical.
    /// </summary>
    public required IsoYesNoIndicator ExchangeForPhysicalIndicator { get; init; } 
    /// <summary>
    /// Indicates a request for a foreign exchange accommodation trade to be executed along with security transaction.
    /// </summary>
    public required IsoYesNoIndicator ForeignExchangeExecutionRequestedIndicator { get; init; } 
    /// <summary>
    /// Indicates the type of transaction of which the order is a component.
    /// </summary>
    public required TradeType2Code TradeType { get; init; } 
    /// <summary>
    /// Expected total number of tickets/allocations to be fully executed.
    /// </summary>
    public IsoNumber? TotalNumberTickets { get; init; } 
    /// <summary>
    /// Identifies the request to receive a report on the progress of the order or not.||A 'Yes' value means a request for regular status messages to be sent.|A 'No' value means no request to receive regular status messages.
    /// </summary>
    public IsoYesNoIndicator? ProgressReportIndicator { get; init; } 
    /// <summary>
    /// Identifies the interval period in minutes between each ListStatus you wish to receive.
    /// </summary>
    public IsoISOTime? ProgressPeriodInterval { get; init; } 
    /// <summary>
    /// Indicates the total number of bidders participating to a list trade.
    /// </summary>
    public IsoNumber? TotalNumberOfBidders { get; init; } 
    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    public IsoISODateTime? TradeDate { get; init; } 
    /// <summary>
    /// Time at which current market prices are used to determine the value of a basket.
    /// </summary>
    public IsoISODateTime? StrikeTime { get; init; } 
    /// <summary>
    /// Represents the basis price type in a bid order (list trading).
    /// </summary>
    public required BasisPriceType1Choice_ BasisPriceType { get; init; } 
    /// <summary>
    /// General details about the liquidity of the financial instrument.
    /// </summary>
    public required LiquidityAndStatistics1 LiquidityAndStatistics { get; init; } 
    
    #nullable disable
}
