﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionOption2.  ISO2002 ID# _UGJUBtp-Ed-ak6NoX_4Aeg_-746417772.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information on a CA option.
/// </summary>
public partial record CorporateActionOption2
{
    #nullable enable
    
    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    public required ICorporateActionOption1FormatChoice OptionType { get; init; } 
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    public required IsoExact3NumericText OptionNumber { get; init; } 
    
    #nullable disable
}
