﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Cleared.  ISO2002 ID# _Bemz8exYEemioJdkOVFBdw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Cleared12Choice;

/// <summary>
/// Indicates that the contract has been cleared.
/// </summary>
public partial record Cleared : Cleared12Choice_
{
    #nullable enable
    /// <summary>
    /// Indicates that the contract is intended to be cleared.
    /// </summary>
    public NoReasonCode? Reason { get; init; } 
    /// <summary>
    /// Identifies the central counterparty (CCP) that cleared the transaction.
    /// </summary>
    public OrganisationIdentification10Choice_? CCP { get; init; } 
    /// <summary>
    /// Time and date when clearing took place.
    /// </summary>
    public IsoISODateTime? ClearingDateTime { get; init; } 
    #nullable disable
}
