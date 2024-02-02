﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for NotificationProcessingStatus1.  ISO2002 ID# _RkLGgNp-Ed-ak6NoX_4Aeg_32536059.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provide processing status information for a notification advice.
/// </summary>
[DataContract]
[XmlType]
public partial record NotificationProcessingStatus1
{
    #nullable enable
    
    /// <summary>
    /// The processing status.
    /// </summary>
    [DataMember]
    public required ProcessedStatus1FormatChoice_ Status { get; init; } 
    /// <summary>
    /// Additional information about the status.
    /// </summary>
    [DataMember]
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    #nullable disable
}
