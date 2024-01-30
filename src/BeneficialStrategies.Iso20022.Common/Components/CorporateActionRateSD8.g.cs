﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionRateSD8.  ISO2002 ID# _5QCpUaFXEeSK_vfd3NHBGg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action option securities movement rate details.
/// </summary>
public partial record CorporateActionRateSD8
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    public required IsoMax350Text PlaceAndName { get; init; } 
    /// <summary>
    /// Corresponding rate of the security being disbursed as a result of the corporate action as declared by the issuer or offeror on the market.
    /// </summary>
    public ICorporateActionRateSD6Choice? DeclaredSecurityRate { get; init; } 
    /// <summary>
    /// Denotes whether the rate is approximate.
    /// </summary>
    public IsoYesNoIndicator? EstimatedRateFlag { get; init; } 
    /// <summary>
    /// Rate at which the fee will be charged to a DTC participant.
    /// </summary>
    public IPriceFormatSD2Choice? DeclaredFeeRate { get; init; } 
    
    #nullable disable
}
