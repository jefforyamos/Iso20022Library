﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _QZhRRdp-Ed-ak6NoX_4Aeg_-1518979155.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SubBalanceQuantity2Choice;

/// <summary>
/// Quantity of securities in the sub-balance.
/// </summary>
public partial record Proprietary : SubBalanceQuantity2Choice_
{
    #nullable enable
    /// <summary>
    /// Proprietary information, often a code, issued by the data source scheme issuer.
    /// </summary>
    public required IsoMax4AlphaNumericText Identification { get; init; } 
    /// <summary>
    /// Entity that assigns the identification.
    /// </summary>
    public required IsoMax35Text Issuer { get; init; } 
    /// <summary>
    /// Name of the identification scheme.
    /// </summary>
    public IsoMax35Text? SchemeName { get; init; } 
    /// <summary>
    /// Value of the balance.
    /// </summary>
    public required IsoNumber Balance { get; init; } 
    #nullable disable
}
