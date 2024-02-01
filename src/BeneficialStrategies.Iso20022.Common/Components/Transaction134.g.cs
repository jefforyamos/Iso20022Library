﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Transaction134.  ISO2002 ID# _xpB0YYv7EeumSPwlS1PkxQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Network management transaction.
/// </summary>
public partial record Transaction134
{
    #nullable enable
    
    /// <summary>
    /// Type of network management service.
    /// ISO 8583:87/93 bit 24
    /// ISO 8583:2003 bit 70
    /// </summary>
    public NetworkManagementType1Code? NetworkManagementType { get; init; } 
    /// <summary>
    /// Other type of network management in free text.
    /// </summary>
    public IsoMax35Text? OtherNetworkManagementType { get; init; } 
    /// <summary>
    /// Reason or purpose to send the message.
    /// The ISO 8583 maintenance agency (MA) manages this code list.
    /// </summary>
    public ISO8583MessageReasonCode[] MessageReason { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Supports message reason codes that are not defined in external code list. 
    /// </summary>
    public IsoMax256Text[] AlternateMessageReason { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    public required TransactionIdentification12 TransactionIdentification { get; init; } 
    /// <summary>
    /// Number of messages in the store and forward queue.
    /// </summary>
    public IsoNumber? NumberOfMessages { get; init; } 
    /// <summary>
    /// Maximum number of messages in the store and forward queue.
    /// </summary>
    public IsoNumber? MaximumNumberOfMessages { get; init; } 
    /// <summary>
    /// Fees not included in the transaction amount but included in the settlement.
    /// </summary>
    public AdditionalFee2[] AdditionalFee { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Additional information pertaining to the network management type or function being performed.
    /// </summary>
    public IsoMax1000Text? TransactionDescription { get; init; } 
    /// <summary>
    /// Contains additional data.
    /// </summary>
    public AdditionalData1[] AdditionalData { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
