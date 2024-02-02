﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RepairReason9.  ISO2002 ID# _07ksUTqeEeWyoP0PbocV1Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the reason why the instruction is in repair.
/// </summary>
[DataContract]
[XmlType]
public partial record RepairReason9
{
    #nullable enable
    
    /// <summary>
    /// Specifies the reason why the instruction/request has a repair status.
    /// </summary>
    [DataMember]
    public required RepairReason10Choice_ Code { get; init; } 
    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    [DataMember]
    public IsoMax210Text? AdditionalReasonInformation { get; init; } 
    
    #nullable disable
}
