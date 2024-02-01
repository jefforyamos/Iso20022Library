﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for NonFinancialInstitutionSector1.  ISO2002 ID# _LLI50IOdEeW2EdhfKzeL1w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides detailed information concerning non financial counterparties.
/// </summary>
public partial record NonFinancialInstitutionSector1
{
    #nullable enable
    
    /// <summary>
    /// Taxonomy for non-financial counterparties. The categories correspond to the main sections of NACE classification as defined in the regulation.
    /// </summary>
    public IsoNACEDomainIdentifier[] Sector { get; init; } = []; // Warning: Don't know multiplicity.
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
