﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Default.  ISO2002 ID# _8IjoJqMgEeCJ6YNENx4h-w_-508539744.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CurrentOrDefaultReservation1Choice;

/// <summary>
/// Identification of the default reservation.
/// </summary>
public partial record Default : CurrentOrDefaultReservation1Choice_
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
    public BranchAndFinancialInstitutionIdentification5? AccountOwner { get; init; } 
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    public AccountIdentification4Choice_? AccountIdentification { get; init; } 
    #nullable disable
}
