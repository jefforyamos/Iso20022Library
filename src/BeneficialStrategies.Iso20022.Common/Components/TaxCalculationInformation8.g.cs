﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TaxCalculationInformation8.  ISO2002 ID# _3_FFgRwcEeOIveEnnb_1-A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information used to calculate the tax.
/// </summary>
public partial record TaxCalculationInformation8
{
    #nullable enable
    
    /// <summary>
    /// Form of the rebate, for example, cash.
    /// </summary>
    public TaxBasis1Choice_? Basis { get; init; } 
    /// <summary>
    /// Amount of money on which the tax is charged.
    /// </summary>
    public required IsoActiveCurrencyAnd13DecimalAmount TaxableAmount { get; init; } 
    
    #nullable disable
}
