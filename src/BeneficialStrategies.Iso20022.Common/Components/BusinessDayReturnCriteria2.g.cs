﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for BusinessDayReturnCriteria2.  ISO2002 ID# _75XVlqMgEeCJ6YNENx4h-w_-59874421.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria used to report on business day information.
/// </summary>
public partial record BusinessDayReturnCriteria2
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the system date is requested.
    /// </summary>
    public IsoRequestedIndicator? SystemDateIndicator { get; init; } 
    /// <summary>
    /// Indicates whether the system status is requested.
    /// </summary>
    public IsoRequestedIndicator? SystemStatusIndicator { get; init; } 
    /// <summary>
    /// Indicates whether the system currency is requested.
    /// </summary>
    public IsoRequestedIndicator? SystemCurrencyIndicator { get; init; } 
    /// <summary>
    /// Indicates whether the closure information is requested.
    /// </summary>
    public IsoRequestedIndicator? ClosurePeriodIndicator { get; init; } 
    /// <summary>
    /// Indicates whether the events are requested.
    /// </summary>
    public IsoRequestedIndicator? EventIndicator { get; init; } 
    /// <summary>
    /// Indicates whether the session period is requested.
    /// </summary>
    public IsoRequestedIndicator? SessionPeriodIndicator { get; init; } 
    /// <summary>
    /// Indicates whether the system event type is requested.
    /// </summary>
    public IsoRequestedIndicator? EventTypeIndicator { get; init; } 
    
    #nullable disable
}
