﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Type.  ISO2002 ID# _ZUDu8YFxEeWtPe6Crjmeug.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CollateralAccountIdentificationType2Choice;

/// <summary>
/// Indicates the type of collateral account expressed as a code.
/// </summary>
public partial record Type : ICollateralAccountIdentificationType2Choice
{
    public required CollateralAccountType1Code Value { get; init; }
}
