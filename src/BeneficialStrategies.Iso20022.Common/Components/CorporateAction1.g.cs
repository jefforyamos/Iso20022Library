﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateAction1.  ISO2002 ID# _TdBeiNp-Ed-ak6NoX_4Aeg_-1683156107.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// An event determined by a corporation's board of directors, that changes the existing corporate capital structure or financial condition.
/// </summary>
public partial record CorporateAction1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the code of corporate action event, in free-text format.
    /// </summary>
    public IsoMax35Text? Code { get; init; } 
    /// <summary>
    /// Reference assigned by the account servicer to unambiguously identify a corporate action event.
    /// </summary>
    public IsoMax35Text? Number { get; init; } 
    /// <summary>
    /// Proprietary corporate action event information.
    /// </summary>
    public IsoMax35Text? Proprietary { get; init; } 
    
    #nullable disable
}
