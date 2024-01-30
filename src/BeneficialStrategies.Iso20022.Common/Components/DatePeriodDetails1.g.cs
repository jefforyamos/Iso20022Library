﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DatePeriodDetails1.  ISO2002 ID# _T-1yKNp-Ed-ak6NoX_4Aeg_-1267403940.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Range of time defined by a start date and an end date.
/// </summary>
public partial record DatePeriodDetails1
{
    #nullable enable
    
    /// <summary>
    /// Start date of the range.
    /// </summary>
    public required IsoISODate FromDate { get; init; } 
    /// <summary>
    /// End date of the range.
    /// </summary>
    public IsoISODate? ToDate { get; init; } 
    
    #nullable disable
}
