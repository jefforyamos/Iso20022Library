﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RejectionReason69.  ISO2002 ID# _2NxawTWhEe2OzdGcZrUAEQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason to reject the message.
/// </summary>
[DataContract]
[XmlType]
public partial record RejectionReason69
{
    #nullable enable
    
    /// <summary>
    /// Reason to reject the message.
    /// </summary>
    [DataMember]
    public required MessageRejectedReason2Code Reason { get; init; } 
    /// <summary>
    /// Additional information about the rejection reason.
    /// </summary>
    [DataMember]
    public IsoMax350Text? AdditionalInformation { get; init; } 
    /// <summary>
    /// Identification of the invalid or unrecognised reference.
    /// </summary>
    [DataMember]
    public LinkedMessage6Choice_? LinkedMessage { get; init; } 
    
    #nullable disable
}
