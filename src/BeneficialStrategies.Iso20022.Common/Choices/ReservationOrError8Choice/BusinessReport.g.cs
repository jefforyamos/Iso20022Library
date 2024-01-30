﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for BusinessReport.  ISO2002 ID# _DXEK4W4-EeiU9cctagi5ow.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ReservationOrError8Choice;

/// <summary>
/// Reports on reservations.
/// </summary>
public partial record BusinessReport : IReservationOrError8Choice
{
    #nullable enable
    /// <summary>
    /// Report is given for a current reservation.
    /// </summary>
    public ReservationReport6? CurrentReservation { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Report is given for a default reservation.
    /// </summary>
    public ReservationReport6? DefaultReservation { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}
