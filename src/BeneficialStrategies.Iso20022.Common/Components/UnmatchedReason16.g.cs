﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for UnmatchedReason16.  ISO2002 ID# _xKGj0Tq0EeWyoP0PbocV1Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the reason why the instruction has an unmatched status.
/// </summary>
[DataContract]
[XmlType]
public partial record UnmatchedReason16
{
    #nullable enable
    
    /// <summary>
    /// Specifies the reason why the instruction has an unmatched status.
    /// </summary>
    [DataMember]
    public required UnmatchedReason23Choice_ Code { get; init; } 
    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    [DataMember]
    public IsoMax210Text? AdditionalReasonInformation { get; init; } 
    
    #nullable disable
}
