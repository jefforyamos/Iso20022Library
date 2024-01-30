﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Current.  ISO2002 ID# _8IjoJaMgEeCJ6YNENx4h-w_-2137818038.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CurrentOrDefaultReservation1Choice;

/// <summary>
/// Identification of the current reservation.
/// </summary>
public partial record Current : ICurrentOrDefaultReservation1Choice
{
    #nullable enable
    /// <summary>
    /// Unique identification of the reservation.
    /// </summary>
    public IsoMax35Text? ReservationIdentification { get; init; } 
    /// <summary>
    /// Identification of a particular cash clearing system.
    /// </summary>
    public ISystemIdentification2Choice? SystemIdentification { get; init; } 
    /// <summary>
    /// Nature of the reservation.
    /// </summary>
    public required IReservationType1Choice Type { get; init; } 
    /// <summary>
    /// Owner of the account which is being queried.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification5? AccountOwner { get; init; } 
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    public IAccountIdentification4Choice? AccountIdentification { get; init; } 
    #nullable disable
}
