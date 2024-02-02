﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardTransactionAmount3.  ISO2002 ID# _t4bwwYNvEeSXtJ8rlirVJw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amounts of the transaction expressed within the terminal currency.
/// </summary>
[DataContract]
[XmlType]
public partial record CardTransactionAmount3
{
    #nullable enable
    
    /// <summary>
    /// Total amount of the transaction.
    /// It corresponds to ISO 8583, field number 4, completed by the field number 49 for the versions 87 and 93.
    /// </summary>
    [DataMember]
    public required IsoCurrencyAndAmount TotalAmount { get; init; } 
    /// <summary>
    /// Qualifies the amount of the transaction.
    /// </summary>
    [DataMember]
    public TypeOfAmount1Code? AmountQualifier { get; init; } 
    /// <summary>
    /// Present when cardholder billing currency differs from transaction currency expressed in TransactionAmount. It may be populated by the scheme or intermediary processor as normally Acceptor does not know cardholder billing currency.
    /// </summary>
    [DataMember]
    public DetailedAmount8? CardholderBillingTransactionAmount { get; init; } 
    /// <summary>
    /// Only present within financial transactions when reconciliation currency differs from transaction currency. It may be populated by acquirers in the request or by the schemes in the responses, depending where the reconciliation point is located.
    /// </summary>
    [DataMember]
    public DetailedAmount8? ReconciliationTransactionAmount { get; init; } 
    /// <summary>
    /// Details of the transaction amount, for informational purpose, for instance to be included within cardholder statement.
    /// It corresponds partially to ISO 8583, field number 54.
    /// </summary>
    [DataMember]
    public ValueList<DetailedAmount9> DetailedAmount { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
