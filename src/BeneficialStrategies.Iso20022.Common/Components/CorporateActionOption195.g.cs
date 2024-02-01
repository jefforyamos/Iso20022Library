﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionOption195.  ISO2002 ID# _Qy2akRe-EeyroI8qKgB7Mg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the corporate action option.
/// </summary>
public partial record CorporateActionOption195
{
    #nullable enable
    
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    public required OptionNumber1Choice_ OptionNumber { get; init; } 
    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    public required CorporateActionOption33Choice_ OptionType { get; init; } 
    /// <summary>
    /// Specifies the features that may apply to a corporate action option.
    /// </summary>
    public OptionFeaturesFormat18Choice_[] OptionFeatures { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
    /// </summary>
    public FractionDispositionType27Choice_? FractionDisposition { get; init; } 
    /// <summary>
    /// Currency in which the cash disbursed from an interest or dividend payment is offered.
    /// </summary>
    public ActiveCurrencyCode? CurrencyOption { get; init; } 
    /// <summary>
    /// Provides information about the dates related to a corporate action option.
    /// </summary>
    public CorporateActionDate79? DateDetails { get; init; } 
    /// <summary>
    /// Provides information about the periods related to a corporate action option.
    /// </summary>
    public CorporateActionPeriod13? PeriodDetails { get; init; } 
    /// <summary>
    /// Provides information about rates and amounts related to a corporate action option.
    /// </summary>
    public CorporateActionRate107? RateAndAmountDetails { get; init; } 
    /// <summary>
    /// Provides information about the prices related to a corporate action option.
    /// </summary>
    public CorporateActionPrice61? PriceDetails { get; init; } 
    /// <summary>
    /// Place where the trade was executed.
    /// </summary>
    public MarketIdentification84? PlaceOfTrade { get; init; } 
    /// <summary>
    /// Provides information about the securities movement linked to the corporate action option.
    /// </summary>
    public SecuritiesOption78[] SecuritiesMovementDetails { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides information about the cash movement related to a corporate action option.
    /// </summary>
    public CashOption79[] CashMovementDetails { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
