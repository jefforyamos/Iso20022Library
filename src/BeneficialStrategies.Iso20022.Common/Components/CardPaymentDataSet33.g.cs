﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentDataSet33.  ISO2002 ID# _PbyDIXIuEe299ZbWCkdR_w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Result of the captured set of transactions.
/// </summary>
public partial record CardPaymentDataSet33
{
    #nullable enable
    
    /// <summary>
    /// Identification of the data set.
    /// </summary>
    public required DataSetIdentification5 DataSetIdentification { get; init; } 
    /// <summary>
    /// Result of the data set capture.
    /// </summary>
    public required ResponseType10 DataSetResult { get; init; } 
    /// <summary>
    /// Indicates if the data set must be removed from the POI (Point Of Interaction).
    /// </summary>
    public required IsoTrueFalseIndicator RemoveDataSet { get; init; } 
    /// <summary>
    /// Initiator of the data set.
    /// </summary>
    public GenericIdentification176? DataSetInitiator { get; init; } 
    /// <summary>
    /// Transaction totals of the batch.
    /// </summary>
    public TransactionTotals12[] TransactionTotals { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Transaction in the batch, whose capture has been rejected.
    /// </summary>
    public CardPaymentDataSet32[] RejectedTransaction { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Transaction in the batch, whose capture has been suspended.
    /// </summary>
    public CardPaymentDataSet32[] SuspendedTransaction { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Transaction in the batch, whose capture has been approved after suspension.
    /// </summary>
    public CardPaymentDataSet32[] ResumedApproval { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Transaction in the batch, whose capture has been rejected after suspension.
    /// </summary>
    public CardPaymentDataSet32[] ResumedRejection { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
