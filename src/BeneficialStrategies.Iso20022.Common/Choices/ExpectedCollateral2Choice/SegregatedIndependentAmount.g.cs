﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for SegregatedIndependentAmount.  ISO2002 ID# _-sdWM4LZEeWrrO9HojbPQA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ExpectedCollateral2Choice;

/// <summary>
/// Provides the expected collateral type and direction for the segregated independent amount.
/// </summary>
public partial record SegregatedIndependentAmount : IExpectedCollateral2Choice
{
    #nullable enable
    /// <summary>
    /// Type of collateral that will be delivered and date by which the collateral movement is expected.
    /// </summary>
    public CollateralMovement9? Delivery { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Type of collateral that will be returned and date by which the collateral movement is expected.
    /// </summary>
    public CollateralMovement9? Return { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}
