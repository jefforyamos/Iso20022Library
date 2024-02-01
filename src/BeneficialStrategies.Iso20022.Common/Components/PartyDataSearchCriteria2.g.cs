﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyDataSearchCriteria2.  ISO2002 ID# _5ry10Z9wEeejnerJgFeC2w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of search criteria for querying party reference data.
/// </summary>
public partial record PartyDataSearchCriteria2
{
    #nullable enable
    
    /// <summary>
    /// Specifies the opening date of the party.
    /// </summary>
    public DatePeriodSearch1Choice_? OpeningDate { get; init; } 
    /// <summary>
    /// Specifies the closing date of the party.
    /// </summary>
    public DatePeriodSearch1Choice_? ClosingDate { get; init; } 
    /// <summary>
    /// Specifies the type classification of the party.
    /// </summary>
    public SystemPartyType1Choice_? Type { get; init; } 
    /// <summary>
    /// Unique identification of the party responsible for the maintenance of the party reference data.
    /// </summary>
    public PartyIdentification136? ResponsiblePartyIdentification { get; init; } 
    /// <summary>
    /// Unique identification to unambiguously identify the party within the system.
    /// </summary>
    public PartyIdentification136? PartyIdentification { get; init; } 
    /// <summary>
    /// Specifies the identification of a restriction.
    /// </summary>
    public IsoMax35Text? RestrictionIdentification { get; init; } 
    /// <summary>
    /// Specifies the date when the restriction for the party has been issued.
    /// </summary>
    public DateAndDateTimeSearch4Choice_? RestrictionIssueDate { get; init; } 
    /// <summary>
    /// Specifies the type of residence where the party has its permanent home or principal establishment.
    /// </summary>
    public ResidenceType1Code? ResidenceType { get; init; } 
    /// <summary>
    /// Specifies whether the party is locked or not, and the reason for this status, when required.
    /// </summary>
    public PartyLockStatus1? LockStatus { get; init; } 
    
    #nullable disable
}
