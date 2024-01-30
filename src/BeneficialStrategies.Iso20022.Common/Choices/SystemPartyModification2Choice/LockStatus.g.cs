﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for LockStatus.  ISO2002 ID# __edeA4v_Eei289CGNqs21g.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SystemPartyModification2Choice;

/// <summary>
/// Specifies whether the party is locked or not, and the reason for this status, when required.
/// </summary>
public partial record LockStatus : ISystemPartyModification2Choice
{
    #nullable enable
    /// <summary>
    /// Specifies the date from which the lock status is valid.
    /// </summary>
    public IsoISODate? ValidFrom { get; init; } 
    /// <summary>
    /// Lock status of the party.
    /// </summary>
    public required LockStatus1Code Status { get; init; } 
    /// <summary>
    /// Specifies the underlying reason for the locking of the party.
    /// </summary>
    public IsoMax35Text? LockReason { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}
