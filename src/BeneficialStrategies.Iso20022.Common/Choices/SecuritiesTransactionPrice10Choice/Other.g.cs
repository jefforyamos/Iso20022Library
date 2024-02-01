﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Other.  ISO2002 ID# _QtVs6f9iEea3W_f2lS_aiw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesTransactionPrice10Choice;

/// <summary>
/// Indicates that price or quantity is expressed in another notation.
/// </summary>
public partial record Other : SecuritiesTransactionPrice10Choice_
{
    #nullable enable
    /// <summary>
    /// Value of the price.
    /// </summary>
    public IsoLongFraction21DecimalNumber? Value { get; init; } 
    /// <summary>
    /// Notation of the price.
    /// </summary>
    public IsoMax35Text? Type { get; init; } 
    #nullable disable
}
