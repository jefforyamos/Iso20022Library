﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CaseAssignment3.  ISO2002 ID# _sbKvolkyEeGeoaLUQk__nA_1583838951.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Represents the assignment of a case to a party.
/// </summary>
public partial record CaseAssignment3
{
    #nullable enable
    
    /// <summary>
    /// Uniquely identifies the case assignment.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Party who assigns the case. |Usage: This is also the sender of the message.
    /// </summary>
    public required Party12Choice_ Assigner { get; init; } 
    /// <summary>
    /// Party to which the case is assigned.|Usage: This is also the receiver of the message.
    /// </summary>
    public required Party12Choice_ Assignee { get; init; } 
    /// <summary>
    /// Date and time at which the assignment was created.
    /// </summary>
    public required IsoISODateTime CreationDateTime { get; init; } 
    
    #nullable disable
}
