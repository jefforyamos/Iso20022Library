﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RoundingParameters1.  ISO2002 ID# _QRxDcNp-Ed-ak6NoX_4Aeg_-1749123923.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters applied to a fractional number.
/// </summary>
public partial record RoundingParameters1
{
    #nullable enable
    
    /// <summary>
    /// Float value specifying the value to which rounding is required, eg, 10 means round to a multiple of 10 units/shares, 0.5 means round to a multiple of 0.5 units/shares.
    /// </summary>
    public IsoDecimalNumber? RoundingModulus { get; init; } 
    /// <summary>
    /// Rounding direction applied to fractional numbers, eg, round up.
    /// </summary>
    public required RoundingDirection1Code RoundingDirection { get; init; } 
    
    #nullable disable
}
