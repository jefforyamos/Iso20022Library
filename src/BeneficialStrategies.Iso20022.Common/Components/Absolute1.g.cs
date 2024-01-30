﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Absolute1.  ISO2002 ID# _oHfs8MBmEeak3I7j2hsibw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Definition of absolute price move of a financial instrument.
/// </summary>
public partial record Absolute1
{
    #nullable enable
    
    /// <summary>
    /// Unit of measure for the absolute stress.
    /// </summary>
    public required IsoMax35Text Unit { get; init; } 
    /// <summary>
    /// Number of units of measure shifted.
    /// </summary>
    public required IsoNumber Quantity { get; init; } 
    
    #nullable disable
}
