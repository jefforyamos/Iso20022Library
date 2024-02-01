﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for FinancialInstitutionIdentification.  ISO2002 ID# _Bp2Qk249EeiU9cctagi5ow.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Party43Choice;

/// <summary>
/// Unique and unambiguous identification of a financial institution.
/// </summary>
public partial record FinancialInstitutionIdentification : Party43Choice_
{
    #nullable enable
    /// <summary>
    /// Business identification code of the financial institution.
    /// </summary>
    public IsoBICFIDec2014Identifier? BICFI { get; init; } 
    /// <summary>
    /// Information used to identify a member within a clearing system.
    /// </summary>
    public ClearingSystemMemberIdentification2? ClearingSystemMemberIdentification { get; init; } 
    /// <summary>
    /// Legal entity identification as an alternate identification for a party.
    /// </summary>
    public IsoLEIIdentifier? LEI { get; init; } 
    /// <summary>
    /// Unique identification of an agent, as assigned by an institution, using an identification scheme.
    /// </summary>
    public GenericFinancialIdentification1? Other { get; init; } 
    #nullable disable
}
