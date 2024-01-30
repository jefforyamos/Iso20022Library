﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionDateSD11.  ISO2002 ID# _CPKmse2KEeiWtrflKsFqHg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action options date details.
/// </summary>
public partial record CorporateActionDateSD11
{
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    public IsoMax350Text? PlaceAndName { get; init; } 
    /// <summary>
    /// Actual early expiration time as set by the issuer/offer/agent.
    /// </summary>
    public IDateFormat49Choice? ActualEarlyExpirationDate { get; init; } 
    /// <summary>
    /// Last day protect instructions can be submitted to the issuer / agent.
    /// </summary>
    public IDateFormat49Choice? ActualProtectExpirationDate { get; init; } 
    /// <summary>
    /// Last day protect instructions can be submitted to the issuer / agent for the early expiration.
    /// </summary>
    public IDateFormat49Choice? ActualEarlyProtectExpirationDate { get; init; } 
    /// <summary>
    /// Last day protect instructions can be submitted to DTC for the early expiration.
    /// </summary>
    public IDateFormat49Choice? DTCEarlyProtectExpirationDate { get; init; } 
    /// <summary>
    /// Last day cover early protect instructions can be submitted to the issuer / agent.
    /// </summary>
    public IDateFormat49Choice? ActualEarlyCoverProtectExpirationDate { get; init; } 
    /// <summary>
    /// Last day cover early protect instructions can be submitted to DTC.
    /// </summary>
    public IDateFormat49Choice? DTCEarlyCoverProtectExpirationDate { get; init; } 
    /// <summary>
    /// For Reorganization events, date at which instructions will be accepted by agent for payment.
    /// </summary>
    public IDateFormat49Choice? ProcessToDate { get; init; } 
    /// <summary>
    /// Date on which DTC expects to receive funds for distribution from the issuer / offeror.  It will be used before payout details are available.
    /// </summary>
    public IsoISODate? DTCEarliestPaymentDate { get; init; } 
    
    #nullable disable
}
