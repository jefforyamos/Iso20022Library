﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionGeneralInformationSD34.  ISO2002 ID# _oQf1wegZEei5aPS232E3Mw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action general information.
/// </summary>
public partial record CorporateActionGeneralInformationSD34
{
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    public IsoMax350Text? PlaceAndName { get; init; } 
    /// <summary>
    /// DTC processing domain/ category for event types.
    /// </summary>
    public EventGroup2Code? EventGroup { get; init; } 
    /// <summary>
    /// DTCC (The Depository Trust and Clearing Corporation) native corporate action event type name. Used in place for the events that cannot be classified by ISO code and mapped to OTHR or when two or more distinct events (in DTCC model) use same ISO code and there are no additional data elements that distinguish those two or more events.
    /// </summary>
    public ExtendedEventType6Code? EventType { get; init; } 
    /// <summary>
    /// DTCC (The Depository Trust and Clearing Corporation) native corporate action sub event type name further defines the event type.
    /// </summary>
    public DTCCSubEventType6Code? SubEventType { get; init; } 
    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    public required SecurityIdentification20 SecurityIdentification { get; init; } 
    /// <summary>
    /// Account where financial instruments are maintained.
    /// </summary>
    public required IsoRestrictedFINXMax35Text SafekeepingAccount { get; init; } 
    /// <summary>
    /// Additional information about the corporate action event.
    /// </summary>
    public CorporateActionUnallocatedDetailsSD6? UnallocatedDetails { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
