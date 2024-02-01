﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentDataSet13.  ISO2002 ID# _ozFJQY3IEeWjkqXgn_0Imw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of transactions to capture, sharing common characteristics.
/// </summary>
public partial record CardPaymentDataSet13
{
    #nullable enable
    
    /// <summary>
    /// Identification of the data set.
    /// </summary>
    public required DataSetIdentification5 DataSetIdentification { get; init; } 
    /// <summary>
    /// Identification of partners involved in the data set building.
    /// </summary>
    public Traceability5[] Traceability { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Initiator of the data set.
    /// </summary>
    public GenericIdentification53? DataSetInitiator { get; init; } 
    /// <summary>
    /// Transaction totals of the data set.
    /// </summary>
    public TransactionTotals7[] TransactionTotals { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Data common to all transactions of the data set.
    /// </summary>
    public CommonData5? CommonData { get; init; } 
    /// <summary>
    /// Set of transaction to Process.
    /// </summary>
    public CardPaymentDataSetTransaction4Choice_[] Transaction { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
