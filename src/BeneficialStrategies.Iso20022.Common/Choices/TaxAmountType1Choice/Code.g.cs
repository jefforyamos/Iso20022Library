﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _tsra01kyEeGeoaLUQk__nA_1392476130.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TaxAmountType1Choice;

/// <summary>
/// Specifies the amount type, in a coded form.
/// </summary>
public partial record Code : TaxAmountType1Choice_
{
    public required ExternalTaxAmountType1Code Value { get; init; }
}
