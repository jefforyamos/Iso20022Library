﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CaseAssignment2.  ISO2002 ID# _T9Nac9p-Ed-ak6NoX_4Aeg_-1609381277.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to represent the assignment of a case to a party.
/// </summary>
[DataContract]
[XmlType]
public partial record CaseAssignment2
{
    #nullable enable
    
    /// <summary>
    /// Uniquely identifies the case assignment.
    /// </summary>
    [DataMember]
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Party who assigns the case. |Usage: This is also the sender of the message.
    /// </summary>
    [DataMember]
    public required Party7Choice_ Assigner { get; init; } 
    /// <summary>
    /// Party to which the case is assigned.|Usage: This is also the receiver of the message.
    /// </summary>
    [DataMember]
    public required Party7Choice_ Assignee { get; init; } 
    /// <summary>
    /// Date and time at which the assignment was created.
    /// </summary>
    [DataMember]
    public required IsoISODateTime CreationDateTime { get; init; } 
    
    #nullable disable
}
