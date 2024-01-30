﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionDateSD10.  ISO2002 ID# _bmP1AeaKEei5aPS232E3Mw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action date details.
/// </summary>
public partial record CorporateActionDateSD10
{
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    public IsoMax350Text? PlaceAndName { get; init; } 
    /// <summary>
    /// Last day on which DTC (The Depository Trust Corporation) will accept instructions for CD early redemptions. This is specific to CDs when the registered holder is deceased.
    /// </summary>
    public IsoISODate? DTCLastDayForEarlyRedemption { get; init; } 
    /// <summary>
    /// Date when positions are captured and entitlements are calculated in the system at DTC (The Depository Trust Corporation).
    /// </summary>
    public IsoISODate? DTCPositionCaptureDate { get; init; } 
    /// <summary>
    /// Last day to deposit securities at DTC and receive the entitlement for an event approaching record date. Issues that have a New York cut-off date have an out-of-town agent on DTC's records.
    /// </summary>
    public IsoISODate? NewYorkCutOffDate { get; init; } 
    /// <summary>
    /// Cut Off date for DTC (The Depository Trust Corporation) deposit and withdrawal activity. Certain events require an earlier cut off date. This is typically used on event securities requiring the submission of bearer coupons. Those events usually stop deposit and withdrawal activity one month prior to the declared record date.
    /// </summary>
    public IsoISODate? DTCExtendedCutOffDate { get; init; } 
    /// <summary>
    /// Effective date as declared by the primary exchange that generally coincides with cessation of trading in the old security and commencement of trading in the new security.
    /// </summary>
    public IsoISODate? EffectiveDateByExchange { get; init; } 
    /// <summary>
    /// Date that DTC received formal notification from the agent/issuer stating that the securities are null and void.
    /// </summary>
    public IsoISODate? DateDeclaredWorthless { get; init; } 
    /// <summary>
    /// Date when DTC participant positions will be deleted. Typically used for expired rights and warrants.
    /// </summary>
    public IsoISODate? DeleteWorthlessSecurityDate { get; init; } 
    /// <summary>
    /// Date on which securities will be exited to DTC participants from DTC (The Depository Trust Corporation).
    /// </summary>
    public IsoISODate? DTCExitDate { get; init; } 
    /// <summary>
    /// Date on which a holder can begin to subscribe for new/additional shares.
    /// </summary>
    public IsoISODate? SubscriptionBeginDate { get; init; } 
    /// <summary>
    /// Date used for determining client position for allocating rights.
    /// </summary>
    public IsoISODate? RightsDistributionAsOfDate { get; init; } 
    /// <summary>
    /// Date at which the rights allocation occurred.
    /// </summary>
    public IsoISODate? RightsDistributionDate { get; init; } 
    /// <summary>
    /// Date which defines the timing of the Dividend Equivalent payment as per IRS regulation 871m.
    /// </summary>
    public IsoISODate? TimingDate { get; init; } 
    
    #nullable disable
}
