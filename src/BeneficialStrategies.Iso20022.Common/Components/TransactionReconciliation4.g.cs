﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransactionReconciliation4.  ISO2002 ID# _E71q4cNXEeWGDrnsYu2p6g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reconciliation transaction between an acceptor and an acquirer.
/// </summary>
[DataContract]
[XmlType]
public partial record TransactionReconciliation4
{
    #nullable enable
    
    /// <summary>
    /// Indicates if the transaction requires a closure of the reconciliation period.
    /// </summary>
    [DataMember]
    public IsoTrueFalseIndicator? ClosePeriod { get; init; } 
    /// <summary>
    /// Unique identification of a reconciliation transaction.
    /// </summary>
    [DataMember]
    public required TransactionIdentifier1 ReconciliationTransactionIdentification { get; init; } 
    /// <summary>
    /// Unique identification of the reconciliation period between the acceptor and the acquirer.
    /// </summary>
    [DataMember]
    public required IsoMax35Text ReconciliationIdentification { get; init; } 
    /// <summary>
    /// Transaction totals during the reconciliation period for a certain type of transaction.
    /// </summary>
    [DataMember]
    public ValueList<TransactionTotals7> TransactionTotals { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Additional information related to the reconciliation transaction.
    /// </summary>
    [DataMember]
    public IsoMax70Text? AdditionalTransactionData { get; init; } 
    
    #nullable disable
}
