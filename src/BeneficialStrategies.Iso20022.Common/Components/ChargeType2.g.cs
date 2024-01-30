﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ChargeType2.  ISO2002 ID# _VPT7gdp-Ed-ak6NoX_4Aeg_-884329785.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specification of the charge type.
/// </summary>
public partial record ChargeType2
{
    #nullable enable
    
    /// <summary>
    /// Structured format.
    /// </summary>
    public required ChargeType7Code Structured { get; init; } 
    /// <summary>
    /// Additional information about the type of charge.
    /// </summary>
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    #nullable disable
}
