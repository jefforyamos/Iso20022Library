﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Incoterms4.  ISO2002 ID# _pdzLMValEeOkkLyrDUP66g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the applicable Incoterm and associated location.
/// </summary>
public partial record Incoterms4
{
    #nullable enable
    
    /// <summary>
    /// Specifies the Incoterms.
    /// </summary>
    public required IIncoterms4Choice IncotermsCode { get; init; } 
    /// <summary>
    /// Location where the Incoterms are actioned. Reference UN/ECE Recommendation 16 - LOCODE - Code for Trade and Transport Locations (www.unece.org/cefact/recommendations).
    /// </summary>
    public IsoMax70Text? Location { get; init; } 
    
    #nullable disable
}
