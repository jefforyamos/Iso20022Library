﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Other.  ISO2002 ID# _8FGzwMgqEeuGrNSsxk3B0A.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesTransactionPrice19Choice;

/// <summary>
/// Price or quantity expressed in another notation.
/// </summary>
public partial record Other : SecuritiesTransactionPrice19Choice_
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
