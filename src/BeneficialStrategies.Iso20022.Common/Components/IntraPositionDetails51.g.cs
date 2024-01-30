﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for IntraPositionDetails51.  ISO2002 ID# _ayWne-mrEemUgrefIx730g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the intra-position movement.
/// </summary>
public partial record IntraPositionDetails51
{
    #nullable enable
    
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    public ISafekeepingPlaceFormat29Choice? SafekeepingPlace { get; init; } 
    /// <summary>
    /// Balance from which the securities were moved.
    /// </summary>
    public required ISecuritiesBalanceType6Choice BalanceFrom { get; init; } 
    /// <summary>
    /// Intra-position movement(s) having been performed.
    /// </summary>
    public IntraPositionMovementDetails17? IntraPositionMovement { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
