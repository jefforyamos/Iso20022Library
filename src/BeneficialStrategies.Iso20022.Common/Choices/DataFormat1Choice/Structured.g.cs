﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Structured.  ISO2002 ID# _Uys4Btp-Ed-ak6NoX_4Aeg_1723007680.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DataFormat1Choice;

/// <summary>
/// Specification of data in structured form.
/// </summary>
public partial record Structured : DataFormat1Choice_
{
    #nullable enable
    /// <summary>
    /// Name of the identification scheme.
    /// </summary>
    public required IsoMax35Text SchemeName { get; init; } 
    /// <summary>
    /// Entity that assigns the identification.
    /// </summary>
    public IsoMax35Text? Issuer { get; init; } 
    #nullable disable
}
