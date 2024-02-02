﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RejectedStatusReason29.  ISO2002 ID# _PD5eOsAUEembi_x1QDJfxw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies reasons for the rejected status.
/// </summary>
[DataContract]
[XmlType]
public partial record RejectedStatusReason29
{
    #nullable enable
    
    /// <summary>
    /// Specifies the reason why the instruction or instruction cancellation has been rejected.
    /// </summary>
    [DataMember]
    public required RejectedReason30Choice_ ReasonCode { get; init; } 
    /// <summary>
    /// Provides additional information about the processed instruction.
    /// </summary>
    [DataMember]
    public IsoMax350Text? AdditionalReasonInformation { get; init; } 
    
    #nullable disable
}
