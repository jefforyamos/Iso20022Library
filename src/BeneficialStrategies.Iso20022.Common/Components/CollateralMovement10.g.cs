﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CollateralMovement10.  ISO2002 ID# _r4UOdYpIEeaNTaanBSMWmg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the agreed amount and the collateral movement direction.
/// </summary>
public partial record CollateralMovement10
{
    #nullable enable
    
    /// <summary>
    /// Provides the call amount that is agreed and that will result in a collateral movement.
    /// </summary>
    public required IsoActiveCurrencyAndAmount AgreedAmount { get; init; } 
    /// <summary>
    /// Provides the collateral movement direction that is a delivery and optionally a return, or a return only.
    /// </summary>
    public ICollateralMovement5Choice? MovementDirection { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
