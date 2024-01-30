﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Transaction151.  ISO2002 ID# _hxv1AYdNEeuBS50MFjViNw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Batch management transaction.
/// </summary>
public partial record Transaction151
{
    #nullable enable
    
    /// <summary>
    /// Type of batch management activity.
    /// ISO 8583:87/93 bit 24
    /// ISO 8583:2003 bit 68-1
    /// </summary>
    public required BatchManagementType2Code BatchManagementType { get; init; } 
    /// <summary>
    /// Other type of batch management activity.
    /// </summary>
    public IsoMax35Text? OtherBatchManagementType { get; init; } 
    /// <summary>
    /// Identification of the batch management transaction.
    /// </summary>
    public TransactionIdentification12? TransactionIdentification { get; init; } 
    /// <summary>
    /// Fees not included in the transaction amount but included in the settlement.
    /// </summary>
    public AdditionalFee2? AdditionalFee { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Identification of a collection.
    /// Mandatory for start or end of a collection and their acknowledgements if the batch is included in a collection.
    /// All the messages included within the collection will have the same collection identification value.
    /// </summary>
    public IsoMax70Text? CollectionIdentification { get; init; } 
    /// <summary>
    /// Identification of a batch.
    /// All the messages included within the batch will have the same batch identification value.
    /// </summary>
    public IsoMax70Text? BatchIdentification { get; init; } 
    /// <summary>
    /// Total length in bytes of the collection to be transferred. 
    /// ISO 8583:2003 bit 70-2
    /// </summary>
    public IsoNumber? CollectionSize { get; init; } 
    /// <summary>
    /// Identification of the original collection.
    /// Mandatory when the collection containing the batch response has not the same identification as the collection containing the original batch.
    /// </summary>
    public IsoMax70Text? OriginalCollectionIdentification { get; init; } 
    /// <summary>
    /// Identification of the original batch to answer.
    /// Mandatory when the batch response has not the same identification as the batch initiation.
    /// </summary>
    public IsoMax70Text? OriginalBatchIdentification { get; init; } 
    /// <summary>
    /// Number of batches in the collection.
    /// For a start of collection, this is the number of expected batches if known.
    /// For a start of collection acknowledgement, this is the maximum number of batches that can be received in the collection.
    /// For an end of collection, this is the number of batches sent in the closing collection.
    /// For an end of collection acknowledgement, this is the number of batches received in the collection.
    /// </summary>
    public IsoNumber? NumberOfBatchesInCollection { get; init; } 
    /// <summary>
    /// Number of messages.
    /// ISO 8583:87 bit 72
    /// ISO 8583:2003 bit 70-1 or bit 69-1
    /// For a start of collection, this is the number of expected messages in the collection if known. 
    /// For a start of batch, this is the number of expected messages in the batch if known.
    /// For an AcknowledgementRequest , this is the number of sent messages since last check point.
    /// For an AcknowledgementResponse, this is the number of received messages since last check point.
    /// For an end of batch this is the number of received messages in the batch.
    /// For an end of collection, this is the number of received messages in the collection.
    /// Note: Batch management messages are excluded from the count.
    /// </summary>
    public IsoNumber? NumberOfMessages { get; init; } 
    /// <summary>
    /// Number of remaining messages in the collection.
    /// ISO 8583:2003 bit 70-3
    /// </summary>
    public IsoNumber? RemainingMessagesInCollection { get; init; } 
    /// <summary>
    /// For a start of collection, sequence number of first expected message of the collection. 
    /// For a start of batch, sequence number of first expected message of the batch.
    /// For an AcknowledgementRequest , sequence number of the last message sent for this checkpoint.
    /// For an AcknowledgementResponse, sequence number of the last message received for this checkpoint.
    /// For an end of batch, sequence number of last message of the batch.
    /// For an end of collection, sequence number of last message of the collection.
    /// </summary>
    public IsoMax15NumericText? MessageSequenceNumber { get; init; } 
    /// <summary>
    /// List of collection identification that should have been sent or received.
    /// </summary>
    public IsoMax70Text? CollectionIdentificationList { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// List of batch identifications of the collection.
    /// For a start of collection, the identification of expected batches, if known.
    /// For an end of collection, this is the identification of batches sent in the closing collection.
    /// For an end of collection acknowledgement, this is the identification of batches received in the collection.
    /// </summary>
    public IsoMax70Text? BatchIdentificationList { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Identification of a specific checkpoint.
    /// </summary>
    public IsoMax70Text? CheckpointIdentification { get; init; } 
    /// <summary>
    /// Checksum of the series of messages or batches in the collection.
    /// </summary>
    public IsoMax35Binary? CollectionChecksum { get; init; } 
    /// <summary>
    /// Checksum of the series of messages in the batch or until a checkpoint.
    /// </summary>
    public IsoMax35Binary? BatchChecksum { get; init; } 
    /// <summary>
    /// Indicator to request acknowledgement.
    /// True: Acknowledgement requested
    /// False: Acknowledgement not requested.
    /// </summary>
    public IsoTrueFalseIndicator? RequestAcknowledgement { get; init; } 
    /// <summary>
    /// Maximum number of messages to be sent before acknowledgement. The receiver will send an acknowledgement response every time the indicated number of messages is reached.
    /// </summary>
    public IsoNumber? MessagesBeforeAcknowledgement { get; init; } 
    /// <summary>
    /// Indicate whether the acknowledgement is positive or not.
    /// True: Positive acknowledgement.
    /// False: Negative acknowledgement.
    /// </summary>
    public IsoTrueFalseIndicator? PositiveAcknowledgement { get; init; } 
    /// <summary>
    /// Contains additional data.
    /// </summary>
    public AdditionalData1? AdditionalData { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Identifies that this batch or collection is a corrected version of a batch or collection that was previously sent.
    /// </summary>
    public CorrectionIdentification1? Correction { get; init; } 
    /// <summary>
    /// Indicates that batch or collection is not complete.
    /// </summary>
    public IsoTrueFalseIndicator? ContinuationIndicator { get; init; } 
    
    #nullable disable
}
