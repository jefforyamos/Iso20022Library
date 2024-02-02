﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MandateCancellation5.  ISO2002 ID# _dBASSUjwEeaVLL5QKJ4f-A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the mandate to be cancelled.
/// </summary>
[DataContract]
[XmlType]
public partial record MandateCancellation5
{
    #nullable enable
    
    /// <summary>
    /// Provides information on the original message.
    /// </summary>
    [DataMember]
    public OriginalMessageInformation1? OriginalMessageInformation { get; init; } 
    /// <summary>
    /// Provides detailed information on the cancellation reason.
    /// </summary>
    [DataMember]
    public required PaymentCancellationReason1 CancellationReason { get; init; } 
    /// <summary>
    /// Provides the original mandate data.
    /// </summary>
    [DataMember]
    public required OriginalMandate4Choice_ OriginalMandate { get; init; } 
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [DataMember]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
