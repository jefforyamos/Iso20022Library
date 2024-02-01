﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NonFinancialInstitution.  ISO2002 ID# _6j9NM7sAEea-m5tPqiasmQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CounterpartyTradeNature4Choice;

/// <summary>
/// Indicates that reporting counterparty is a non financial institution.
/// </summary>
public partial record NonFinancialInstitution : CounterpartyTradeNature4Choice_
{
    #nullable enable
    /// <summary>
    /// Taxonomy for non-financial counterparties. The categories correspond to the main sections of NACE classification as defined in the regulation.
    /// </summary>
    public IsoNACEDomainIdentifier? Sector { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Information whether the reporting counterparty is above the clearing threshold referred to the regulation.
    /// </summary>
    public required IsoTrueFalseIndicator ClearingThreshold { get; init; } 
    /// <summary>
    /// Directly linked to commercial activity or treasury financing: Information on whether the contract is objectively measurable as directly linked to the reporting counterparty's commercial or treasury financing activity.
    /// </summary>
    public required IsoTrueFalseIndicator DirectlyLinkedActivity { get; init; } 
    #nullable disable
}
