﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InterestRateLegs14.  ISO2002 ID# _O8SFoSJLEe2zWP9pqvmqdw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details related to interest rate attributes.
/// </summary>
public partial record InterestRateLegs14
{
    #nullable enable
    
    /// <summary>
    /// Details concerning the rate in the first leg of an interest rate contract.
    /// </summary>
    public InterestRate33Choice_? FirstLeg { get; init; } 
    /// <summary>
    /// Details concerning the rate in the second leg of an interest rate contract.
    /// </summary>
    public InterestRate33Choice_? SecondLeg { get; init; } 
    
    #nullable disable
}
