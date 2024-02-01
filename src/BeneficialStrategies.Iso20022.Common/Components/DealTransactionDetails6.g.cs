﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DealTransactionDetails6.  ISO2002 ID# _lpi_4RIcEeyLzJfz3xPQNA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the triparty collateral transaction deal.
/// </summary>
public partial record DealTransactionDetails6
{
    #nullable enable
    
    /// <summary>
    /// Identifies the number of days in which the cash investor and dealer can agree to revisit the terms of an agreement.
    /// </summary>
    public IsoExact3NumericText? MinimumNoticePeriod { get; init; } 
    /// <summary>
    /// Closing date/time or maturity date/time of the transaction.
    /// </summary>
    public required ClosingDate4Choice_ ClosingDate { get; init; } 
    /// <summary>
    /// Specifies the details for the deal amounts.
    /// </summary>
    public CollateralAmount12? DealDetailsAmount { get; init; } 
    /// <summary>
    /// Interest rate to be paid on the transaction amount as agreed between the counterparties and the tenor of the interest rate index.
    /// </summary>
    public RateOrName4Choice_? PricingRateAndIndex { get; init; } 
    /// <summary>
    /// Indicates for a floating rate transaction if an overnight frequency  rate fixing should be applied.  If not present, a periodic fixing frequency will be applied (default is N).
    /// </summary>
    public FrequencyRateFixing1Choice_? OvernightFrequencyRateFixing { get; init; } 
    /// <summary>
    /// Margin allowed over or under a given rate.
    /// </summary>
    public IsoPercentageRate? Spread { get; init; } 
    /// <summary>
    /// Specifies the computation method of (accrued) interest of the financial instrument.
    /// </summary>
    public InterestComputationMethodFormat4Choice_? DayCountBasis { get; init; } 
    /// <summary>
    /// Specifies whether the instruction is free or against payment.
    /// </summary>
    public DeliveryReceiptType2Code? Payment { get; init; } 
    /// <summary>
    /// Specifies whether it is a Call option (right to purchase a specific underlying asset) or a Put option (right to sell a specific underlying asset).
    /// </summary>
    public OptionType6Choice_? OptionType { get; init; } 
    /// <summary>
    /// Indication whether the counterparties to the transaction have agreed to an evergreen or extendable repo.
    /// </summary>
    public RepoTerminationOption1Code? TerminationOption { get; init; } 
    
    #nullable disable
}
