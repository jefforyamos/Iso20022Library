﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InstalmentAmountDetails1.  ISO2002 ID# _yiOENNuXEei2qvU6FBLZYA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Instalment amount details
/// </summary>
public partial record InstalmentAmountDetails1
{
    #nullable enable
    
    /// <summary>
    /// Grace period unit type.
    /// </summary>
    public InstalmentAmountDetailsType1Code? Type { get; init; } 
    /// <summary>
    /// Grace period other unit type.
    /// </summary>
    public IsoMax35Text? OtherType { get; init; } 
    /// <summary>
    /// Grace period sub type. 
    /// </summary>
    public IsoMax35Text? SubType { get; init; } 
    /// <summary>
    /// Detailed instalment amount.
    /// </summary>
    public Amount5? Amount { get; init; } 
    /// <summary>
    /// Rate expressed as a percentage, that is, in hundredths, example, 0.7 is 7/10 of a percent, and 7.0 is 7%.
    /// </summary>
    public IsoPercentageRate? Percentage { get; init; } 
    
    #nullable disable
}
