﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Rate4.  ISO2002 ID# _uoQ2MbTVEee_k7HqaUKERA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to qualify the interest rate.
/// </summary>
public partial record Rate4
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of interest rate.
    /// </summary>
    public required RateType4Choice_ Type { get; init; } 
    /// <summary>
    /// An amount range where the interest rate is applicable.
    /// </summary>
    public ActiveOrHistoricCurrencyAndAmountRange2? ValidityRange { get; init; } 
    
    #nullable disable
}
