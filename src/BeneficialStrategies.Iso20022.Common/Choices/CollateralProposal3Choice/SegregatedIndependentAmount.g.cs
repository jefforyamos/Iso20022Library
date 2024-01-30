﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for SegregatedIndependentAmount.  ISO2002 ID# _P0F1U19-EeSMgPeFpRHeJw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CollateralProposal3Choice;

/// <summary>
/// Provides details about the proposal for the segregated independent amount.
/// </summary>
public partial record SegregatedIndependentAmount : ICollateralProposal3Choice
{
    #nullable enable
    /// <summary>
    /// Provides the call amount that is agreed and that will result in a collateral movement.
    /// </summary>
    public required IsoActiveCurrencyAndAmount AgreedAmount { get; init; } 
    /// <summary>
    /// Provides the collateral movement direction that is a delivery and optionaly a return, or a return only.
    /// </summary>
    public ICollateralMovement3Choice? MovementDirection { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}
