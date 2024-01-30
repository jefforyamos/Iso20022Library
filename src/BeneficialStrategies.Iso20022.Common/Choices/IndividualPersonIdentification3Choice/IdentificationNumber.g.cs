﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for IdentificationNumber.  ISO2002 ID# _G6_50YoWEeahcZ3Nzs1Qag.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.IndividualPersonIdentification3Choice;

/// <summary>
/// Identification of the person that owns the account.
/// </summary>
public partial record IdentificationNumber : IIndividualPersonIdentification3Choice
{
    #nullable enable
    /// <summary>
    /// Identification of a party, such as a tax or social security identifier.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Type of identification.
    /// </summary>
    public required IOtherIdentification3Choice IdentificationType { get; init; } 
    #nullable disable
}
