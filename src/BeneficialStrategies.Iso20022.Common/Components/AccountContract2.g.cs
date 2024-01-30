﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountContract2.  ISO2002 ID# _UkZWQtp-Ed-ak6NoX_4Aeg_-1896166238.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies target dates dates related to account opening and closing.
/// </summary>
public partial record AccountContract2
{
    #nullable enable
    
    /// <summary>
    /// Date on which the account and related basic services are expected to be operational for the account owner.
    /// </summary>
    public IsoISODate? TargetGoLiveDate { get; init; } 
    /// <summary>
    /// Date on which the account and related services are expected to cease to be operational for the account owner.
    /// </summary>
    public IsoISODate? TargetClosingDate { get; init; } 
    /// <summary>
    /// Indicator that the account opening/maintenance/closing process needs to be treated urgently, that is, sooner than the terms established by the service level agreed between the account holder customer and the account servicing institution.
    /// </summary>
    public IsoYesNoIndicator? UrgencyFlag { get; init; } 
    
    #nullable disable
}
