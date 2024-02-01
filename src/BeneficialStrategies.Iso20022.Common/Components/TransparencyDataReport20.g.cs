﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransparencyDataReport20.  ISO2002 ID# _rydgQaaWEeqM19y9ajxjTA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides for reporting calculation results of non equity instruments as part of transparency.
/// </summary>
public partial record TransparencyDataReport20
{
    #nullable enable
    
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and status advice messages.
    /// Usage:
    /// This identification will be used in the status advice report sent back.
    /// </summary>
    public IsoMax35Text? TechnicalRecordIdentification { get; init; } 
    /// <summary>
    /// Identifies the financial instrument or the class of financial instruments to which the result relates.
    /// </summary>
    public required InstrumentOrSubClassIdentification2Choice_ Identification { get; init; } 
    /// <summary>
    /// Full name of the reporting entity.
    /// </summary>
    public IsoMax350Text? FullName { get; init; } 
    /// <summary>
    /// Segment MIC for the trading venue where applicable, otherwise the operational MIC.
    /// </summary>
    public IsoMICIdentifier? TradingVenue { get; init; } 
    /// <summary>
    /// Period to which the quantitative data fields relate.
    /// </summary>
    public Period4Choice_? ReportingPeriod { get; init; } 
    /// <summary>
    /// Flag to say if this ISIN is liquid or not post calculations.
    /// Usage:
    /// When not present, this field should be treated as not applicable.
    /// </summary>
    public IsoTrueFalseIndicator? Liquidity { get; init; } 
    /// <summary>
    /// The pre-trade Large in Scale threshold.
    /// </summary>
    public TonsOrCurrency2Choice_? PreTradeLargeInScaleThreshold { get; init; } 
    /// <summary>
    /// The post-trade Large in Scale threshold.
    /// </summary>
    public TonsOrCurrency2Choice_? PostTradeLargeInScaleThreshold { get; init; } 
    /// <summary>
    /// The pre-trade Size Specific to an Instrument threshold.
    /// </summary>
    public TonsOrCurrency2Choice_? PreTradeInstrumentSizeSpecificThreshold { get; init; } 
    /// <summary>
    /// The post-trade Size Specific to an Instrument threshold.
    /// </summary>
    public TonsOrCurrency2Choice_? PostTradeInstrumentSizeSpecificThreshold { get; init; } 
    /// <summary>
    /// Statistics for a financial instrument generated as part of transparency calculations.
    /// </summary>
    public StatisticsTransparency2? Statistics { get; init; } 
    
    #nullable disable
}
