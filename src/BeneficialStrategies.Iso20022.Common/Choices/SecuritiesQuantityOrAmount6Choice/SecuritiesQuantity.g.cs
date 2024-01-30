﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for SecuritiesQuantity.  ISO2002 ID# _N-tRIRuyEeyhRdHRjakS2w.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesQuantityOrAmount6Choice;

/// <summary>
/// Provides information about securities quantity linked to a corporate action option.
/// </summary>
public partial record SecuritiesQuantity : ISecuritiesQuantityOrAmount6Choice
{
    #nullable enable
    /// <summary>
    /// Minimum quantity of securities to be accepted (used in the framework of conditional privilege on election). In case of proration, if this minimum quantity is not reached then the instruction is void.
    /// </summary>
    public IFinancialInstrumentQuantity33Choice? ConditionalQuantity { get; init; } 
    /// <summary>
    /// Quantity of securities to which this instruction applies.
    /// </summary>
    public required IQuantity52Choice InstructedQuantity { get; init; } 
    /// <summary>
    /// Quantity of additional shares requested due to the difference of “round-up against payment” practice between the account servicer and the account holder (for instance for French dividend option).
    /// </summary>
    public IFinancialInstrumentQuantity33Choice? AdditionalRoundUpQuantity { get; init; } 
    #nullable disable
}
