﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardTransaction11.  ISO2002 ID# _wiFRAXvDEeSKFIcWw3l4Yw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Network management transaction.
/// </summary>
[DataContract]
[XmlType]
public partial record CardTransaction11
{
    #nullable enable
    
    /// <summary>
    /// Type of network management service (correspond to the ISO 8583 field 24).
    /// </summary>
    [DataMember]
    public required CardServiceType2Code NetworkManagementType { get; init; } 
    /// <summary>
    /// Number of messages in the store and forward queue.
    /// </summary>
    [DataMember]
    public IsoNumber? NumberOfMessages { get; init; } 
    /// <summary>
    /// Maximum number of messages in the store and forward queue.
    /// </summary>
    [DataMember]
    public IsoNumber? MaximumNumberOfMessages { get; init; } 
    /// <summary>
    /// Date and time of the transaction.
    /// </summary>
    [DataMember]
    public IsoISODateTime? InitiatorDateTime { get; init; } 
    /// <summary>
    /// Response to the network management request.
    /// </summary>
    [DataMember]
    public ResponseType2? TransactionResponse { get; init; } 
    
    #nullable disable
}
