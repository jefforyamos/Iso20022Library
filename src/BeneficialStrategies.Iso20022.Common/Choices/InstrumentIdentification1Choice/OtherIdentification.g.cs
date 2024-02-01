﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for OtherIdentification.  ISO2002 ID# _AmCO0QbTEeqrW7Meu5r3kQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstrumentIdentification1Choice;

/// <summary>
/// Other identification of a security assigned by an institution or organisation.
/// </summary>
public partial record OtherIdentification : InstrumentIdentification1Choice_
{
    #nullable enable
    /// <summary>
    /// Proprietary information, often a code, issued by the data source scheme issuer.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Indicates the source of the identifier that represent the constituents of a custom basket.
    /// </summary>
    public required IsoMax35Text Source { get; init; } 
    #nullable disable
}
