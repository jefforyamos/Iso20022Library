﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Current.  ISO2002 ID# _Bxla0W4-EeiU9cctagi5ow.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CurrentOrDefaultReservation2Choice;

/// <summary>
/// Identification of the current reservation.
/// </summary>
public partial record Current : CurrentOrDefaultReservation2Choice_
{
    #nullable enable
    /// <summary>
    /// Unique identification of the reservation.
    /// </summary>
    public IsoMax35Text? ReservationIdentification { get; init; } 
    /// <summary>
    /// Identification of a particular cash clearing system.
    /// </summary>
    public SystemIdentification2Choice_? SystemIdentification { get; init; } 
    /// <summary>
    /// Nature of the reservation.
    /// </summary>
    public required ReservationType1Choice_ Type { get; init; } 
    /// <summary>
    /// Owner of the account which is being queried.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? AccountOwner { get; init; } 
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    public AccountIdentification4Choice_? AccountIdentification { get; init; } 
    #nullable disable
}
