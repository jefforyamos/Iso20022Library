﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for UnitOfMeasureCode.  ISO2002 ID# _QWXDkfFSEee_LsXdoqzkWg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UnitOfMeasure6Choice;

/// <summary>
/// Quantity of a product on a line specified by a number. For example, 100 (kgs), 50 (pieces).
/// </summary>
public partial record UnitOfMeasureCode : UnitOfMeasure6Choice_
{
    public required UnitOfMeasure9Code Value { get; init; }
}
