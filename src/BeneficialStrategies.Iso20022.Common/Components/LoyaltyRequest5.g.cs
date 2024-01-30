﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for LoyaltyRequest5.  ISO2002 ID# _e-jnMXGvEe2TbaNWBpRZpQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data to request a loyalty service. A loyalty request contents : the loyalty transaction request and the loyalty data if any.
/// </summary>
public partial record LoyaltyRequest5
{
    #nullable enable
    
    /// <summary>
    /// To retrieve Card Acquisition Data.
    /// </summary>
    public CustomerOrder1? CustomerOrder { get; init; } 
    /// <summary>
    /// Data related to the loyalty transaction.
    /// </summary>
    public required LoyaltyTransaction5 Transaction { get; init; } 
    /// <summary>
    /// Data related to a Loyalty program or account.
    /// </summary>
    public LoyaltyRequestData3? Data { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
