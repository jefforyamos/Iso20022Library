﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for BillingCompensation1.  ISO2002 ID# _6PzSsJqlEeGSON8vddiWzQ_-1213048629.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the compensation data of an incorrect billing.
/// </summary>
public partial record BillingCompensation1
{
    #nullable enable
    
    /// <summary>
    /// Defines the type of billing compensation.
    /// </summary>
    public required BillingCompensationType1Choice_ Type { get; init; } 
    /// <summary>
    /// Defines the value of compensation.
    /// </summary>
    public required AmountAndDirection34 Value { get; init; } 
    /// <summary>
    /// Identifies the currency type used to report the value or total, in a coded form, such as Settlement (STLM).
    /// </summary>
    public BillingCurrencyType2Code? CurrencyType { get; init; } 
    
    #nullable disable
}
