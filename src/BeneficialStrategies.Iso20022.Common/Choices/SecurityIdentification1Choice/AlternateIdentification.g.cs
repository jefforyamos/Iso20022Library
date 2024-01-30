﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AlternateIdentification.  ISO2002 ID# _VcIPgNp-Ed-ak6NoX_4Aeg_-1748201304.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification1Choice;

/// <summary>
/// Proprietary identification of a security assigned by an institution or organisation.
/// </summary>
public partial record AlternateIdentification : ISecurityIdentification1Choice
{
    #nullable enable
    /// <summary>
    /// Unique and unambiguous identifier of a security.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Country of the proprietary identification scheme.
    /// </summary>
    public required CountryCode DomesticIdentificationSource { get; init; } 
    /// <summary>
    /// Entity that issues the proprietary identification.
    /// </summary>
    public required IsoMax35Text ProprietaryIdentificationSource { get; init; } 
    #nullable disable
}
