﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Other.  ISO2002 ID# _IkBp4Dd7EeWebbGLlGzH3g.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradingVenueIdentification1Choice;

/// <summary>
/// Identification used where a venue does not have an already defined code type.
/// </summary>
public partial record Other : ITradingVenueIdentification1Choice
{
    #nullable enable
    /// <summary>
    /// Identification field of the submitting entity.
    /// </summary>
    public required IsoMax50Text Identification { get; init; } 
    /// <summary>
    /// Code list of venues to populate free form text identification.
    /// </summary>
    public required TradingVenue2Code Type { get; init; } 
    #nullable disable
}
