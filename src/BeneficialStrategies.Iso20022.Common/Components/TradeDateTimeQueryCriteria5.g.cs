﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TradeDateTimeQueryCriteria5.  ISO2002 ID# _np2jIWE3Ee2S65ml6YCOtA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Date and time query criteria.
/// </summary>
public partial record TradeDateTimeQueryCriteria5
{
    #nullable enable
    
    /// <summary>
    /// Indicates the reporting date and full hour that transaction was reported.
    /// </summary>
    public DateTimePeriod1? ReportingDateTime { get; init; } 
    /// <summary>
    /// Indicates the date and full hour the trade was executed.
    /// </summary>
    public DateTimePeriod1? ExecutionDateTime { get; init; } 
    /// <summary>
    /// Indicates the date when the trade was matured.
    /// </summary>
    public IDateOrBlankQuery2Choice? MaturityDate { get; init; } 
    /// <summary>
    /// Indicates the date when obligations under the contract come into effect.
    /// </summary>
    public DatePeriod1? EffectiveDate { get; init; } 
    /// <summary>
    /// Date and time of the valuation.
    /// </summary>
    public DateTimePeriod1? ValuationDateTime { get; init; } 
    /// <summary>
    /// Indicates the date when the trade was terminated.
    /// </summary>
    public IDateOrBlankQuery2Choice? ExpirationDate { get; init; } 
    /// <summary>
    /// Indicates the effective date of the early termination of the reported derivative transaction.
    /// </summary>
    public DatePeriod1? EarlyTerminationDate { get; init; } 
    /// <summary>
    /// Indicates the collateral time stamp range.
    /// </summary>
    public IDateTimeOrBlankQuery1Choice? CollateralTimeStamp { get; init; } 
    
    #nullable disable
}
