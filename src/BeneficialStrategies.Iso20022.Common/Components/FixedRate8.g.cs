﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FixedRate8.  ISO2002 ID# _gwtNQayDEem81-uIvTF5rQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Fixed rate related information.
/// </summary>
public partial record FixedRate8
{
    #nullable enable
    
    /// <summary>
    /// Annualised interest rate on the principal amount of the repurchase transaction in accordance with the day count convention.
    /// </summary>
    public IsoPercentageRate? Rate { get; init; } 
    /// <summary>
    /// Method for calculating the accrued interest on the principal amount for a fixed rate.
    /// </summary>
    public IInterestComputationMethodFormat6Choice? DayCountBasis { get; init; } 
    
    #nullable disable
}
