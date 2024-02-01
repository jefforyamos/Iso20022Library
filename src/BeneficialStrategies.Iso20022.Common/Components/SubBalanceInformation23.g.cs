﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SubBalanceInformation23.  ISO2002 ID# _ciAolzi8Eeydid5dcNPKvg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Net position of a segregated holding of a single security within the overall position held in the securities account, for example sub-balance per status.
/// </summary>
public partial record SubBalanceInformation23
{
    #nullable enable
    
    /// <summary>
    /// Reason for the sub-balance.
    /// </summary>
    public required SubBalanceType13Choice_ SubBalanceType { get; init; } 
    /// <summary>
    /// Quantity of securities in the sub-balance.
    /// </summary>
    public required SubBalanceQuantity9Choice_ Quantity { get; init; } 
    /// <summary>
    /// Provides additional subbalance information.
    /// </summary>
    public IsoRestrictedFINXMax140Text? SubBalanceAdditionalDetails { get; init; } 
    /// <summary>
    /// Provides additional instrument sub-balance information on all or parts of the reported financial instrument (unregistered, tax exempt, etc.).
    /// </summary>
    public AdditionalBalanceInformation23[] AdditionalBalanceBreakdownDetails { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
