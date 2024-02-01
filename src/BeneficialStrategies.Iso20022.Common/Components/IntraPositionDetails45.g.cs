﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for IntraPositionDetails45.  ISO2002 ID# _yklEC6OAEeeDTpy0mhI4TQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the intra-position movement.
/// </summary>
public partial record IntraPositionDetails45
{
    #nullable enable
    
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    public SafekeepingPlaceFormat10Choice_? SafekeepingPlace { get; init; } 
    /// <summary>
    /// Balance from which the securities were moved.
    /// </summary>
    public required SecuritiesBalanceType6Choice_ BalanceFrom { get; init; } 
    /// <summary>
    /// Intra-position movement(s) having been performed.
    /// </summary>
    public IntraPositionMovementDetails15[] IntraPositionMovement { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
