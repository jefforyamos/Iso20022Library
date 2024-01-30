﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for SignedQuantity.  ISO2002 ID# _cfsEYZKQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Quantity23Choice;

/// <summary>
/// Signed quantity of security.
/// </summary>
public partial record SignedQuantity : IQuantity23Choice
{
    #nullable enable
    /// <summary>
    /// Sign of the quantity of security.
    /// </summary>
    public required ShortLong1Code ShortLongPosition { get; init; } 
    /// <summary>
    /// Quantity of security.
    /// </summary>
    public required IFinancialInstrumentQuantity15Choice Quantity { get; init; } 
    #nullable disable
}
