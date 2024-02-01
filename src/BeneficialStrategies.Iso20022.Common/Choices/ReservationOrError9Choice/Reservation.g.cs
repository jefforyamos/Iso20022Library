﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reservation.  ISO2002 ID# _RYRzgXhdEeidzqjNEfehPg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ReservationOrError9Choice;

/// <summary>
/// Requested information on the limit.
/// </summary>
public partial record Reservation : ReservationOrError9Choice_
{
    #nullable enable
    /// <summary>
    /// Amount of money of the limit, expressed in an eligible currency.
    /// </summary>
    public required Amount2Choice_ Amount { get; init; } 
    /// <summary>
    /// Status of the limit, such as enabled or disabled.
    /// </summary>
    public ReservationStatus1Choice_? Status { get; init; } 
    /// <summary>
    /// Date and time at which the reservation becomes effective.
    /// </summary>
    public DateAndDateTime2Choice_? StartDateTime { get; init; } 
    #nullable disable
}
