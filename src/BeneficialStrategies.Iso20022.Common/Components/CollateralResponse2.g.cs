﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CollateralResponse2.  ISO2002 ID# _s62bx4pDEeaNTaanBSMWmg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information on the collateral proposal(s), that is either in cash, securities or other types.
/// </summary>
public partial record CollateralResponse2
{
    #nullable enable
    
    /// <summary>
    /// Provides details on the securities collateral proposal.
    /// </summary>
    public SecuritiesCollateralResponse1? SecuritiesCollateralResponse { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides details on the cash collateral proposal.
    /// </summary>
    public CashCollateralResponse2? CashCollateralResponse { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides details on other collateral proposal.
    /// </summary>
    public OtherCollateralResponse2? OtherCollateralResponse { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
