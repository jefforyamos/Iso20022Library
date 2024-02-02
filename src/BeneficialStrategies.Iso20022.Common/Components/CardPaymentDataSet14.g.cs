﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentDataSet14.  ISO2002 ID# _4LejsY3VEeWjkqXgn_0Imw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Result of the captured set of transactions.
/// </summary>
[DataContract]
[XmlType]
public partial record CardPaymentDataSet14
{
    #nullable enable
    
    /// <summary>
    /// Identification of the data set.
    /// </summary>
    [DataMember]
    public required DataSetIdentification5 DataSetIdentification { get; init; } 
    /// <summary>
    /// Result of the data set capture.
    /// </summary>
    [DataMember]
    public required ResponseType5 DataSetResult { get; init; } 
    /// <summary>
    /// Indicates if the data set must be removed from the POI (Point Of Interaction).
    /// </summary>
    [DataMember]
    public required IsoTrueFalseIndicator RemoveDataSet { get; init; } 
    /// <summary>
    /// Initiator of the data set.
    /// </summary>
    [DataMember]
    public GenericIdentification53? DataSetInitiator { get; init; } 
    /// <summary>
    /// Transaction totals of the batch.
    /// </summary>
    [DataMember]
    public ValueList<TransactionTotals7> TransactionTotals { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Transaction in the batch, whose capture has been rejected.
    /// </summary>
    [DataMember]
    public ValueList<CardPaymentDataSet15> RejectedTransaction { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
