﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for OperationalError.  ISO2002 ID# _kniH5e5NEeCisYr99QEiWA_-450423967.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PartyOrOperationalError1Choice;

/// <summary>
/// Operational error resulting from a rejection.
/// </summary>
public partial record OperationalError : IPartyOrOperationalError1Choice
{
    #nullable enable
    /// <summary>
    /// Specification of the error, in coded or proprietary form.
    /// </summary>
    public required IErrorHandling1Choice Error { get; init; } 
    /// <summary>
    /// Specification of the error, in free format.
    /// </summary>
    public IsoMax140Text? Description { get; init; } 
    #nullable disable
}
