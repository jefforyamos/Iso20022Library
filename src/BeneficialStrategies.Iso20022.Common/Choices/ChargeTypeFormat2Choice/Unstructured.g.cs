﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Unstructured.  ISO2002 ID# _UyQMGNp-Ed-ak6NoX_4Aeg_2129381679.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ChargeTypeFormat2Choice;

/// <summary>
/// Specifies the type of charge in free text form.
/// </summary>
public partial record Unstructured : IChargeTypeFormat2Choice
{
    public required IsoMax35Text Value { get; init; }
}
