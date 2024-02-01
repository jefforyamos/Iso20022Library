﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MarginCallResult3.  ISO2002 ID# _9b69MKMPEeCojJW5vEuTEQ_2035479962.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the summation of the call amounts per margin type and optionaly the default fund amount (only for CCP).
/// </summary>
public partial record MarginCallResult3
{
    #nullable enable
    
    /// <summary>
    /// Specifies the total amount required by the clearing member to participate to the default fund.
    /// </summary>
    public IsoActiveCurrencyAndAmount? DefaultFundAmount { get; init; } 
    /// <summary>
    /// Provides the summation of the call amounts for the variation margin and the segregated independent amount or the segregated independent amount only or the total margin call amount only.
    /// </summary>
    public required MarginCallResult2Choice_ MarginCallResult { get; init; } 
    
    #nullable disable
}
