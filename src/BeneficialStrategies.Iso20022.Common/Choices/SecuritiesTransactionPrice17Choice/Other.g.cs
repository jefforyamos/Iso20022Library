﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Other.  ISO2002 ID# _gSTIjZjcEeqkLZLH6DK3UQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesTransactionPrice17Choice;

/// <summary>
/// Indicates that price or quantity is expressed in another notation.
/// </summary>
public partial record Other : SecuritiesTransactionPrice17Choice_
{
    #nullable enable
    /// <summary>
    /// Value of the price.
    /// </summary>
    public IsoLongFraction19DecimalNumber? Value { get; init; } 
    /// <summary>
    /// Notation of the price.
    /// </summary>
    public IsoMax35Text? Type { get; init; } 
    #nullable disable
}
