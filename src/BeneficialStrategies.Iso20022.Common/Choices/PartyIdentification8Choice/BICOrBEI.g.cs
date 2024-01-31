﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for BICOrBEI.  ISO2002 ID# _Q7pG4Np-Ed-ak6NoX_4Aeg_1657637865.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification8Choice;

/// <summary>
/// Identification of a party by a BIC and an Alternative Identifier.
/// </summary>
public partial record BICOrBEI : IPartyIdentification8Choice
{
    #nullable enable
    /// <summary>
    /// Code allocated to a financial or non-financial institution by the ISO 9362 Registration Authority, as described in ISO 9362 "Banking - Banking telecommunication messages - Business identifier code (BIC)".
    /// </summary>
    public required IsoAnyBICIdentifier BICOrBEIValue { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier, as assigned to a financial institution using a proprietary identification scheme.
    /// </summary>
    public IReadOnlyCollection<IsoMax35Text> AlternativeIdentifier { get; init; } = [];
    #nullable disable
}
