﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountContract4.  ISO2002 ID# _UkGbYdp-Ed-ak6NoX_4Aeg_197946061.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies target dates dates related to account opening and closing.
/// </summary>
public partial record AccountContract4
{
    #nullable enable
    
    /// <summary>
    /// Date on which the account and related services are expected to cease to be operational for the account owner.
    /// </summary>
    public IsoISODate? TargetClosingDate { get; init; } 
    /// <summary>
    /// Indicator that the account opening/maintenance/closing process needs to be treated urgently, that is, sooner than the terms established by the service level agreed between the account holder customer and the account servicing institution.
    /// </summary>
    public IsoYesNoIndicator? UrgencyFlag { get; init; } 
    /// <summary>
    /// Indicates removal of the account. After removal, an account will not appear anymore in reports.
    /// </summary>
    public IsoYesNoIndicator? RemovalIndicator { get; init; } 
    
    #nullable disable
}
