﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for EndOfDayRequirement1.  ISO2002 ID# __p1KALC8EeaSl6vJk5Bd8w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Obligations of a clearing member with respect to a central counterparty that are calculated based on end of day positions.
/// </summary>
public partial record EndOfDayRequirement1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the initial margin requirement for position.
    /// </summary>
    public IsoActiveCurrencyAndAmount? InitialMarginRequirement { get; init; } 
    /// <summary>
    /// Daily change in mark-to-market for the associated position. Indicates whether variation margin paid to clearing members (true) or received from clearing members (false).
    /// </summary>
    public AmountAndDirection102? VariationMarginRequirement { get; init; } 
    
    #nullable disable
}
