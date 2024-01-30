﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Attendance2.  ISO2002 ID# _eX9h8fNhEeqRfth943bvEA.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information and conditions provided for the physical attendance to the meeting.  
/// </summary>
public partial record Attendance2
{
    #nullable enable
    
    /// <summary>
    /// Conditions for physical admittance to the general meeting.
    /// </summary>
    // public IReadOnlyCollection<AttendanceAdmissionConditions2> AdmissionConditions { get; init; }
    /// <summary>
    /// Specifies how to order the attendance card or to give notice of attendance.
    /// </summary>
    public IsoMax350Text? ConfirmationInformation { get; init; } 
    /// <summary>
    /// Date and time by which the beneficial owner or agent must provide notification of its intention to participate in the meeting. This deadline is set by an intermediary.
    /// </summary>
    public IDateFormat58Choice? ConfirmationDeadline { get; init; } 
    /// <summary>
    /// Date and time by which the attendance to the meeting should be confirmed. This deadline is set by the issuer.
    /// </summary>
    public IDateFormat58Choice? ConfirmationMarketDeadline { get; init; } 
    
    #nullable disable
}
