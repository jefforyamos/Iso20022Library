﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MarginCallResult1.  ISO2002 ID# _UlSuJtp-Ed-ak6NoX_4Aeg_740528065.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the summation of the call amounts per margin type and optionaly the default fund amount (only for CCP).
/// </summary>
public partial record MarginCallResult1
{
    #nullable enable
    
    /// <summary>
    /// Total amount required by the clearing member to participate to the default fund.
    /// </summary>
    public IsoActiveCurrencyAndAmount? DefaultFundAmount { get; init; } 
    /// <summary>
    /// Provides the summation of the call amounts for the variation margin and the segregated independent amount, or the segregated independent amount only.
    /// </summary>
    public required IMarginCallResult1Choice MarginCallResult { get; init; } 
    
    #nullable disable
}
