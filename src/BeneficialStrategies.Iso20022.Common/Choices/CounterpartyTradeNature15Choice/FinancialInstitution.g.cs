﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for FinancialInstitution.  ISO2002 ID# _1z1A8Qz1Ee2YoLD-1vFj0g.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CounterpartyTradeNature15Choice;

/// <summary>
/// Indicates that counterparty is a financial institution.
/// </summary>
public partial record FinancialInstitution : ICounterpartyTradeNature15Choice
{
    #nullable enable
    /// <summary>
    /// Specifies the nature of the counterparty business activities. 
    /// </summary>
    public IFinancialPartyClassification2Choice? Sector { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Information whether the counterparty is above the clearing threshold.
    /// Usage: If the element is not present, the ClearingThreshold is False.
    /// </summary>
    public IsoTrueFalseIndicator? ClearingThreshold { get; init; } 
    #nullable disable
}
