﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ModificationReason4.  ISO2002 ID# _C9XfKzq3EeWyoP0PbocV1Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Modification reasons.
/// </summary>
[DataContract]
[XmlType]
public partial record ModificationReason4
{
    #nullable enable
    
    /// <summary>
    /// Specifies the reason why the transaction is modified.
    /// </summary>
    [DataMember]
    public required ModificationReason4Choice_ Code { get; init; } 
    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    [DataMember]
    public IsoMax210Text? AdditionalReasonInformation { get; init; } 
    
    #nullable disable
}
