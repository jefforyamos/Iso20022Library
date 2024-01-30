﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ProcessingCharacteristics4.  ISO2002 ID# _xBKBcTgBEei6RvewLQWEqw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Processing characteristics linked to a subscription to an investment fund or alternative/hedge fund.
/// </summary>
public partial record ProcessingCharacteristics4
{
    #nullable enable
    
    /// <summary>
    /// Currency in which a subscription is accepted.
    /// </summary>
    public ActiveCurrencyCode? DealingCurrencyAccepted { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies whether an application form is required for the initial investment.
    /// </summary>
    public Forms1? InitialInvestmentApplication { get; init; } 
    /// <summary>
    /// Specifies whether an application form is required for the subsequent investments.
    /// </summary>
    public Forms1? SubsequentInvestmentApplication { get; init; } 
    /// <summary>
    /// Indicates whether a subscription can be instructed by amount.
    /// </summary>
    public IsoYesNoIndicator? AmountIndicator { get; init; } 
    /// <summary>
    /// Indicates whether a subscription can be instructed as a number of units.
    /// </summary>
    public IsoYesNoIndicator? UnitsIndicator { get; init; } 
    /// <summary>
    /// Indicates the rounding direction applied to nearest unit.
    /// </summary>
    public RoundingDirection2Code? Rounding { get; init; } 
    /// <summary>
    /// Location of the main fund order desk.
    /// </summary>
    public MainFundOrderDeskLocation1? MainFundOrderDeskLocation { get; init; } 
    /// <summary>
    /// Frequency at which the subscriptions are done.
    /// </summary>
    public EventFrequency5Code? DealingFrequency { get; init; } 
    /// <summary>
    /// Description of frequency at which the subscription is done.
    /// </summary>
    public IsoMax350Text? DealingFrequencyDescription { get; init; } 
    /// <summary>
    /// Latest time at which an order to subscribe can be given.
    /// </summary>
    public IsoISOTime? DealingCutOffTime { get; init; } 
    /// <summary>
    /// Dealing cut-off timeframe.
    /// </summary>
    public TimeFrame4? DealingCutOffTimeFrame { get; init; } 
    /// <summary>
    /// Time at which the deal confirmation is issued.
    /// </summary>
    public IsoISOTime? DealConfirmationTime { get; init; } 
    /// <summary>
    /// Time frame within which the deal confirmation is issued.
    /// </summary>
    public TimeFrame5? DealConfirmationTimeFrame { get; init; } 
    /// <summary>
    /// Specific period, for example, for some guaranteed funds, during which the units/shares may be subscribed.
    /// </summary>
    public IsoMax350Text? LimitedPeriod { get; init; } 
    /// <summary>
    /// Settlement timing.
    /// </summary>
    public ITimeFrame7Choice? SettlementCycle { get; init; } 
    /// <summary>
    /// Additional information about the subscription processing characteristics.
    /// </summary>
    public AdditionalInformation15? AdditionalInformation { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
