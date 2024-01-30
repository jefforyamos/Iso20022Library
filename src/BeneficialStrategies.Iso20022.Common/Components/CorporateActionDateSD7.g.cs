﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionDateSD7.  ISO2002 ID# _SgmSUJEZEeajS_7NioJdVA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action options date details.
/// </summary>
public partial record CorporateActionDateSD7
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    public required IsoMax350Text PlaceAndName { get; init; } 
    /// <summary>
    /// Actual early expiration time as set by the issuer/offer/agent.
    /// </summary>
    public IsoISODateTime? ActualEarlyExpirationDate { get; init; } 
    /// <summary>
    /// Last day protect instructions can be submitted to the issuer / agent.
    /// </summary>
    public IsoISODateTime? ActualProtectExpirationDate { get; init; } 
    /// <summary>
    /// Last day protect instructions can be submitted to the issuer / agent for the early expiration.
    /// </summary>
    public IsoISODateTime? ActualEarlyProtectExpirationDate { get; init; } 
    /// <summary>
    /// Last day protect instructions can be submitted to DTC for the early expiration.
    /// </summary>
    public IsoISODateTime? DTCEarlyProtectExpirationDate { get; init; } 
    /// <summary>
    /// Last day cover early protect instructions can be submitted to the issuer / agent.
    /// </summary>
    public IsoISODateTime? ActualEarlyCoverProtectExpirationDate { get; init; } 
    /// <summary>
    /// Last day cover early protect instructions can be submitted to DTC.
    /// </summary>
    public IsoISODateTime? DTCEarlyCoverProtectExpirationDate { get; init; } 
    
    #nullable disable
}
