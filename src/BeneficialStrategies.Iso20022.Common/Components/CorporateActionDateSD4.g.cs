﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionDateSD4.  ISO2002 ID# _1ePnUzL3EeKU9IrkkToqcw_1659480407.
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
public partial record CorporateActionDateSD4
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [DataMember]
    public required IsoMax350Text PlaceAndName { get; init; } 
    /// <summary>
    /// Date on which accounting for due bills starts and associated tracking begins.
    /// </summary>
    [DataMember]
    public IsoISODate? InterimAccountingStartDate { get; init; } 
    /// <summary>
    /// Date on which the event security is no longer listed on the exchange.
    /// </summary>
    [DataMember]
    public IsoISODate? DelistingDate { get; init; } 
    /// <summary>
    /// Date by which a holder can exercise warrants.
    /// </summary>
    [DataMember]
    public IsoISODate? ExercisePeriodBeginDate { get; init; } 
    /// <summary>
    /// Date by which a holder listed as a member of the claimant group in a lawsuit may object to the proposed solution.
    /// </summary>
    [DataMember]
    public IsoISODate? ObjectionDate { get; init; } 
    /// <summary>
    /// Date by which claimants may exclude themselves from an ongoing class action lawsuit.
    /// </summary>
    [DataMember]
    public IsoISODate? ExclusionDate { get; init; } 
    /// <summary>
    /// Date by which a holder must file claim forms to become a member of the claimant group in a lawsuit.
    /// </summary>
    [DataMember]
    public IsoISODate? ProofOfClaimFilingDate { get; init; } 
    
    #nullable disable
}
