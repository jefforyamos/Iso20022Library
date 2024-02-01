﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for IndividualPerson39.  ISO2002 ID# _fQtPUa-SEemJ1NnLPsTFaw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Human entity, as distinguished from a corporate entity (which is sometimes referred to as an 'artificial person').
/// </summary>
public partial record IndividualPerson39
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the proxy.
    /// </summary>
    public PartyIdentification223Choice_? PreassignedProxy { get; init; } 
    /// <summary>
    /// Organisation represented by the person, or for which the person works.
    /// </summary>
    public PartyIdentification129Choice_? EmployingParty { get; init; } 
    /// <summary>
    /// Details related to the attendance card.
    /// </summary>
    public required AttendanceCard2 AttendanceCardDetails { get; init; } 
    
    #nullable disable
}
