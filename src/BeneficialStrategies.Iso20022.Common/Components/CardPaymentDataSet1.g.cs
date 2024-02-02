﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentDataSet1.  ISO2002 ID# _TDm_yAEcEeCQm6a_G2yO_w_158061117.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of transactions to capture, sharing common characteristics.
/// </summary>
[DataContract]
[XmlType]
public partial record CardPaymentDataSet1
{
    #nullable enable
    
    /// <summary>
    /// Identification of the data set.
    /// </summary>
    [DataMember]
    public required DataSetIdentification1 DataSetIdentification { get; init; } 
    /// <summary>
    /// Identification of partners involved in the data set building.
    /// </summary>
    [DataMember]
    public ValueList<Traceability1> Traceability { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Initiator of the data set.
    /// </summary>
    [DataMember]
    public GenericIdentification32? DataSetInitiator { get; init; } 
    /// <summary>
    /// Transaction totals of the data set.
    /// </summary>
    [DataMember]
    public ValueList<TransactionTotals1> TransactionTotals { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Data common to all transactions of the data set.
    /// </summary>
    [DataMember]
    public CommonData1? CommonData { get; init; } 
    /// <summary>
    /// Set of transaction to capture.
    /// </summary>
    [DataMember]
    public ValueList<CardPaymentDataSetTransaction1> TransactionToCapture { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
