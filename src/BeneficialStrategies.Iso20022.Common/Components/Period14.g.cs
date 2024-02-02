﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Period14.  ISO2002 ID# _jm0boeWhEeevU7McUP3D1w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Time span defined by a start date and time, and an end date and time.
/// </summary>
[DataContract]
[XmlType]
public partial record Period14
{
    #nullable enable
    
    /// <summary>
    /// Date and time at which the range starts.
    /// </summary>
    [DataMember]
    public required DateFormat56Choice_ StartDate { get; init; } 
    /// <summary>
    /// Date and time at which the range ends.
    /// </summary>
    [DataMember]
    public required DateFormat56Choice_ EndDate { get; init; } 
    
    #nullable disable
}
