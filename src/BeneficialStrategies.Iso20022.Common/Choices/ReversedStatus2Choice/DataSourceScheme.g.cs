﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for DataSourceScheme.  ISO2002 ID# _bUFeJSY5EeW_ZNn8gbfY7Q.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ReversedStatus2Choice;

/// <summary>
/// Proprietary identification of the reason for the reversed status.
/// </summary>
public partial record DataSourceScheme : ReversedStatus2Choice_
{
    #nullable enable
    /// <summary>
    /// Identification assigned by an institution.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Name of the identification scheme.
    /// </summary>
    public IsoMax35Text? SchemeName { get; init; } 
    /// <summary>
    /// Entity that assigns the identification.
    /// </summary>
    public IsoMax35Text? Issuer { get; init; } 
    #nullable disable
}
