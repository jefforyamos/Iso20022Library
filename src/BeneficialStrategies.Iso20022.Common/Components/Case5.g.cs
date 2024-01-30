﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Case5.  ISO2002 ID# _8BF4W248EeiU9cctagi5ow.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details to identify an investigation case.
/// </summary>
public partial record Case5
{
    #nullable enable
    
    /// <summary>
    /// Uniquely identifies the case.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Party that created the investigation case.
    /// </summary>
    public required IParty40Choice Creator { get; init; } 
    /// <summary>
    /// Indicates whether or not the case was previously closed and is now re-opened.
    /// </summary>
    public IsoYesNoIndicator? ReopenCaseIndication { get; init; } 
    
    #nullable disable
}
