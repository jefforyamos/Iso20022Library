﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Type.  ISO2002 ID# _1RhVca_XEeaiqo1qOdNaWg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CollateralAccountIdentificationType3Choice;

/// <summary>
/// Indicates the type of collateral account expressed as a code.
/// </summary>
public partial record Type : CollateralAccountIdentificationType3Choice_
{
    public required CollateralAccountType1Code Value { get; init; }
}
