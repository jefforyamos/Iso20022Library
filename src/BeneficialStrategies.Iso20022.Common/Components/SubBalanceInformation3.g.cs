﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SubBalanceInformation3.  ISO2002 ID# _QZ0MOdp-Ed-ak6NoX_4Aeg_497605547.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Net position of a segregated holding of a single security within the overall position held in the securities account, eg, sub-balance per status.
/// </summary>
public partial record SubBalanceInformation3
{
    #nullable enable
    
    /// <summary>
    /// Quantity of securities in the sub-balance.
    /// </summary>
    public required ISubBalanceQuantity1Choice Quantity { get; init; } 
    /// <summary>
    /// Type of subbalance.
    /// </summary>
    public required ISubBalanceType2Choice SubBalanceType { get; init; } 
    
    #nullable disable
}
