﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PendingProcessingReason13.  ISO2002 ID# _6QCdtZNLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the reason why the instruction or request has a pending processing status.
/// </summary>
[DataContract]
[XmlType]
public partial record PendingProcessingReason13
{
    #nullable enable
    
    /// <summary>
    /// Specifies the reason why the instruction has a pending processing status.
    /// </summary>
    [DataMember]
    public required PendingProcessingReason15Choice_ Code { get; init; } 
    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    [DataMember]
    public IsoRestrictedFINXMax210Text? AdditionalReasonInformation { get; init; } 
    
    #nullable disable
}
