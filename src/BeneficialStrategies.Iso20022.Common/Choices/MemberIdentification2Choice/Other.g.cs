﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Other.  ISO2002 ID# _8Hq3WaMgEeCJ6YNENx4h-w_-1497387865.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MemberIdentification2Choice;

/// <summary>
/// Unique identification of an agent, as assigned by an institution, using an identification scheme.
/// </summary>
public partial record Other : IMemberIdentification2Choice
{
    #nullable enable
    /// <summary>
    /// Unique and unambiguous identification of a person.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Name of the identification scheme.
    /// </summary>
    public IFinancialIdentificationSchemeName1Choice? SchemeName { get; init; } 
    /// <summary>
    /// Entity that assigns the identification.
    /// </summary>
    public IsoMax35Text? Issuer { get; init; } 
    #nullable disable
}
