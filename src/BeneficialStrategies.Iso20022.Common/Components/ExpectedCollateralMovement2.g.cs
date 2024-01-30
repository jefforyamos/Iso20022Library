﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ExpectedCollateralMovement2.  ISO2002 ID# __DOQZYLZEeWrrO9HojbPQA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the expected collateral type and direction.
/// </summary>
public partial record ExpectedCollateralMovement2
{
    #nullable enable
    
    /// <summary>
    /// Type of collateral that will be delivered and date by which the collateral movement is expected.
    /// </summary>
    public CollateralMovement9? Delivery { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Type of collateral that will be returned and date by which the collateral movement is expected.
    /// </summary>
    public CollateralMovement9? Return { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
