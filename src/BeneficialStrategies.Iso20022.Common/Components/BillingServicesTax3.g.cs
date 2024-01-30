﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for BillingServicesTax3.  ISO2002 ID# _6RcRdZqlEeGSON8vddiWzQ_-658807987.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides for regional taxes on the service.
/// </summary>
public partial record BillingServicesTax3
{
    #nullable enable
    
    /// <summary>
    /// Identification number of the specific region tax used to calculate the tax.
    /// </summary>
    public required IsoMax35Text Number { get; init; } 
    /// <summary>
    /// Name used to describe the tax (such as the national value added tax).
    /// </summary>
    public IsoMax40Text? Description { get; init; } 
    /// <summary>
    /// Rate used to calculate the tax.
    /// </summary>
    public required IsoDecimalNumber Rate { get; init; } 
    /// <summary>
    /// Specifies the tax obligation for taxable services within a tax region for a specific tax identifier (such as national value added tax equals 34,00), and expressed in the tax region’s host currency.
    /// </summary>
    public required AmountAndDirection34 TotalTaxAmount { get; init; } 
    
    #nullable disable
}
