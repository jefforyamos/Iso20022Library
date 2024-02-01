﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Other.  ISO2002 ID# _iR9Bh3SbEeiH1ZOt2UD8vQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MemberIdentification3Choice;

/// <summary>
/// Unique identification of an agent, as assigned by an institution, using an identification scheme.
/// </summary>
public partial record Other : MemberIdentification3Choice_
{
    #nullable enable
    /// <summary>
    /// Unique and unambiguous identification of a person.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Name of the identification scheme.
    /// </summary>
    public FinancialIdentificationSchemeName1Choice_? SchemeName { get; init; } 
    /// <summary>
    /// Entity that assigns the identification.
    /// </summary>
    public IsoMax35Text? Issuer { get; init; } 
    #nullable disable
}
