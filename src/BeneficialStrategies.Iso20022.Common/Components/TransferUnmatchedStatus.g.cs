﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransferUnmatchedStatus.  ISO2002 ID# _U0V2xNp-Ed-ak6NoX_4Aeg_-105274052.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status is unmatched.
/// </summary>
[DataContract]
[XmlType]
public partial record TransferUnmatchedStatus
{
    #nullable enable
    
    /// <summary>
    /// Reason for an unmatched status in the report.
    /// </summary>
    [DataMember]
    public required TransferUnmatchedStatusReason1 Reason { get; init; } 
    /// <summary>
    /// Proprietary identification for a reason of a specific status in the report.
    /// </summary>
    [DataMember]
    public required GenericIdentification1 DataSourceScheme { get; init; } 
    /// <summary>
    /// Indicates that there is no reason available or to report.
    /// </summary>
    [DataMember]
    public required NoReasonCode NoReason { get; init; } 
    
    #nullable disable
}
