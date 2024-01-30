﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _RfQKRNp-Ed-ak6NoX_4Aeg_1712163909.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.TaxableIncomePerShareCalculatedType1Choice;

/// <summary>
/// Specifies whether the fund calculates a taxable interest per share (TIS).
/// </summary>
public partial record Proprietary : ITaxableIncomePerShareCalculatedType1Choice
{
    #nullable enable
    /// <summary>
    /// Identification assigned by an institution.
    /// </summary>
    public required IsoMax4AlphaNumericText Identification { get; init; } 
    /// <summary>
    /// Name of the identification scheme.
    /// </summary>
    public IsoMax35Text? SchemeName { get; init; } 
    /// <summary>
    /// Entity that assigns the identification.
    /// </summary>
    public required IsoMax35Text Issuer { get; init; } 
    #nullable disable
}
