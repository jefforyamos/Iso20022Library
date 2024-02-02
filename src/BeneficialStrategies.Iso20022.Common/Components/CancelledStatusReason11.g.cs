﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CancelledStatusReason11.  ISO2002 ID# _w-u9kUGUEeWqy4niLuXETA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies reasons for the cancelled status.
/// </summary>
[DataContract]
[XmlType]
public partial record CancelledStatusReason11
{
    #nullable enable
    
    /// <summary>
    /// Specifies the reason why the instruction or instruction cancellation has been cancelled.
    /// </summary>
    [DataMember]
    public required CancelledReason8Choice_ ReasonCode { get; init; } 
    /// <summary>
    /// Provides additional information about the processed instruction.
    /// </summary>
    [DataMember]
    public IsoMax210Text? AdditionalReasonInformation { get; init; } 
    
    #nullable disable
}
