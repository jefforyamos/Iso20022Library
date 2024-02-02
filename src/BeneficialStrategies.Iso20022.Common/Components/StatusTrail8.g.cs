﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for StatusTrail8.  ISO2002 ID# _Ui2OAewMEeiazoAmcoGsBQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the history of status and reasons for a pending, posted or cancelled transaction.
/// </summary>
[DataContract]
[XmlType]
public partial record StatusTrail8
{
    #nullable enable
    
    /// <summary>
    /// Date and time at which the status was assigned.
    /// </summary>
    [DataMember]
    public required IsoISODateTime StatusDate { get; init; } 
    /// <summary>
    /// Unique and unambiguous way to identify the organisation that sent the message instance.
    /// </summary>
    [DataMember]
    public OrganisationIdentification31? SendingOrganisationIdentification { get; init; } 
    /// <summary>
    /// Unique and unambiguous way to identify the user that created the message instance.
    /// </summary>
    [DataMember]
    public IsoMax35Text? UserIdentification { get; init; } 
    /// <summary>
    /// Provides details on the processing status of the transaction.
    /// </summary>
    [DataMember]
    public ProcessingStatus75Choice_? ProcessingStatus { get; init; } 
    /// <summary>
    /// Provides the matching status of an instruction as per the account servicer or the Market Infrastructure based on an allegement. At this time no matching took place on the market (at the CSD/ICSD/MI).
    /// </summary>
    [DataMember]
    public MatchingStatus25Choice_? InferredMatchingStatus { get; init; } 
    /// <summary>
    /// Provides the matching status of the instruction.
    /// </summary>
    [DataMember]
    public MatchingStatus25Choice_? MatchingStatus { get; init; } 
    /// <summary>
    /// Provides the status of settlement of a transaction.
    /// </summary>
    [DataMember]
    public SettlementStatus17Choice_? SettlementStatus { get; init; } 
    /// <summary>
    /// Provides details on the modification processing status of the transaction.
    /// </summary>
    [DataMember]
    public ModificationProcessingStatus7Choice_? ModificationProcessingStatus { get; init; } 
    /// <summary>
    /// Provides details on the processing status of the cancellation request.
    /// </summary>
    [DataMember]
    public ProcessingStatus53Choice_? CancellationStatus { get; init; } 
    /// <summary>
    /// Status is settled.
    /// </summary>
    [DataMember]
    public ProprietaryReason4? Settled { get; init; } 
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [DataMember]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
