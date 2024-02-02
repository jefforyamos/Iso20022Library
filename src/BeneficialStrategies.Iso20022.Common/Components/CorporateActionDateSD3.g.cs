﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionDateSD3.  ISO2002 ID# _1d8sZDL3EeKU9IrkkToqcw_1274784693.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action date details.
/// </summary>
[DataContract]
[XmlType]
public partial record CorporateActionDateSD3
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [DataMember]
    public required IsoMax350Text PlaceAndName { get; init; } 
    /// <summary>
    /// Last day on which DTC (The Depository Trust Corporation) will accept instructions for CD early redemptions. This is specific to CDs when the registered holder is deceased.
    /// </summary>
    [DataMember]
    public IsoISODate? DTCLastDayForEarlyRedemption { get; init; } 
    /// <summary>
    /// Date when positions are captured and entitlements are calculated in the system at DTC (The Depository Trust Corporation).
    /// </summary>
    [DataMember]
    public IsoISODate? DTCPositionCaptureDate { get; init; } 
    /// <summary>
    /// Last day to deposit securities at DTC and receive the entitlement for an event approaching record date. Issues that have a New York cut-off date have an out-of-town agent on DTC's records.
    /// </summary>
    [DataMember]
    public IsoISODate? NewYorkCutOffDate { get; init; } 
    /// <summary>
    /// Cutoff date for DTC (The Depository Trust Corporation) deposit and withdrawal activity. Certain events require an earlier cutoff date. This is typically used on event securities requiring the submission of bearer coupons. Those events usually stop deposit and withdrawal activity one month prior to the declared record date.
    /// </summary>
    [DataMember]
    public IsoISODate? DTCExtendedCutOffDate { get; init; } 
    /// <summary>
    /// Effective date as declared by the primary exchange that generally coincides with cessation of trading in the old security and commencement of trading in the new security.
    /// </summary>
    [DataMember]
    public IsoISODate? EffectiveDateByExchange { get; init; } 
    /// <summary>
    /// Date that DTC received formal notification from the agent/issuer stating that the securities are null and void.
    /// </summary>
    [DataMember]
    public IsoISODate? DateDeclaredWorthless { get; init; } 
    /// <summary>
    /// Date when DTC participant positions will be deleted. Typically used for expired rights and warrants.
    /// </summary>
    [DataMember]
    public IsoISODate? DeleteWorthlessSecurityDate { get; init; } 
    /// <summary>
    /// Date on which securities will be exited to DTC participants from DTC (The Depository Trust Corporation).
    /// </summary>
    [DataMember]
    public IsoISODate? DTCExitDate { get; init; } 
    /// <summary>
    /// Date on which a holder can begin to subscribe for new/additional shares.
    /// </summary>
    [DataMember]
    public IsoISODate? SubscriptionBeginDate { get; init; } 
    /// <summary>
    /// Date on which a company files a petition for reorganisation under Chapter 11 of the United States Bankruptcy Code.
    /// </summary>
    [DataMember]
    public IsoISODate? FilingDate { get; init; } 
    /// <summary>
    /// Hearing date as set by the court. Hearing date is material to the shareholder/interested party as this may be the last opportunity to make a case against/for a settlement.
    /// </summary>
    [DataMember]
    public IsoISODate? HearingDate { get; init; } 
    
    #nullable disable
}
