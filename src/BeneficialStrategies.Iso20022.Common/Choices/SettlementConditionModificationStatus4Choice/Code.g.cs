﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _8QcPy5NLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.SettlementConditionModificationStatus4Choice;

/// <summary>
/// Provides the status of the securities settlement condition modification request.
/// </summary>
public partial record Code : ISettlementConditionModificationStatus4Choice
{
    public required SettlementConditionModificationStatus1Code Value { get; init; }
}
