﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OriginalGroupHeader17.  ISO2002 ID# _ZefxgW49EeiU9cctagi5ow.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the original group, to which the message refers.
/// </summary>
[DataContract]
[XmlType]
public partial record OriginalGroupHeader17
{
    #nullable enable
    
    /// <summary>
    /// Point to point reference, as assigned by the original instructing party, to unambiguously identify the original message.
    /// </summary>
    [DataMember]
    public required IsoMax35Text OriginalMessageIdentification { get; init; } 
    /// <summary>
    /// Specifies the original message name identifier to which the message refers.
    /// </summary>
    [DataMember]
    public required IsoMax35Text OriginalMessageNameIdentification { get; init; } 
    /// <summary>
    /// Date and time at which the original message was created.
    /// </summary>
    [DataMember]
    public IsoISODateTime? OriginalCreationDateTime { get; init; } 
    /// <summary>
    /// Number of individual transactions contained in the original message.
    /// </summary>
    [DataMember]
    public IsoMax15NumericText? OriginalNumberOfTransactions { get; init; } 
    /// <summary>
    /// Total of all individual amounts included in the original message, irrespective of currencies.
    /// </summary>
    [DataMember]
    public IsoDecimalNumber? OriginalControlSum { get; init; } 
    /// <summary>
    /// Specifies the status of a group of transactions.
    /// </summary>
    [DataMember]
    public ExternalPaymentGroupStatus1Code? GroupStatus { get; init; } 
    /// <summary>
    /// Provides detailed information on the status reason.
    /// </summary>
    [DataMember]
    public ValueList<StatusReasonInformation12> StatusReasonInformation { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Detailed information on the number of transactions for each identical transaction status.
    /// </summary>
    [DataMember]
    public ValueList<NumberOfTransactionsPerStatus5> NumberOfTransactionsPerStatus { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
