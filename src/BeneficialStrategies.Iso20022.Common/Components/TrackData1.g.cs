﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TrackData1.  ISO2002 ID# _Sqk0swEcEeCQm6a_G2yO_w_184409498.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Magnetic track or equivalent payment card data.
/// </summary>
public partial record TrackData1
{
    #nullable enable
    
    /// <summary>
    /// Track number of the card.
    /// </summary>
    public IsoExact1NumericText? TrackNumber { get; init; } 
    /// <summary>
    /// Card track content or equivalent.
    /// </summary>
    public required IsoMax140Text TrackValue { get; init; } 
    
    #nullable disable
}
