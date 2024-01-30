﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for SecuritiesQuantity.  ISO2002 ID# _Gql3oIlYEeavwKddCbm3hg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesQuantityOrAmount1Choice;

/// <summary>
/// Provides information about securities quantity linked to a corporate action option.
/// </summary>
public partial record SecuritiesQuantity : ISecuritiesQuantityOrAmount1Choice
{
    #nullable enable
    /// <summary>
    /// Minimum quantity of securities to be accepted (used in the framework of conditional privilege on election). In case of proration, if this minimum quantity is not reached then the instruction is void.
    /// </summary>
    public IFinancialInstrumentQuantity15Choice? ConditionalQuantity { get; init; } 
    /// <summary>
    /// Quantity of securities to which this instruction applies.
    /// </summary>
    public required IQuantity40Choice InstructedQuantity { get; init; } 
    #nullable disable
}
