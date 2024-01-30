﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Range.  ISO2002 ID# _cmD8MdGgEeaQk737TH1Fzw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DateOrBlankQuery2Choice;

/// <summary>
/// Indicates the date range.
/// </summary>
public partial record Range : IDateOrBlankQuery2Choice
{
    #nullable enable
    /// <summary>
    /// Start date of the range.
    /// </summary>
    public IsoISODate? FromDate { get; init; } 
    /// <summary>
    /// End date of the range.
    /// </summary>
    public required IsoISODate ToDate { get; init; } 
    #nullable disable
}
