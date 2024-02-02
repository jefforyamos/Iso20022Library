﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentTransactionDetails43.  ISO2002 ID# _5ZOFMfnGEeaYndR2y_Ep9g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the transaction in the authorisation response contained in a batch.
/// </summary>
[DataContract]
[XmlType]
public partial record CardPaymentTransactionDetails43
{
    #nullable enable
    
    /// <summary>
    /// Currency associated with the transaction.
    /// </summary>
    [DataMember]
    public ActiveCurrencyCode? Currency { get; init; } 
    /// <summary>
    /// Total amount of the transaction.
    /// </summary>
    [DataMember]
    public required IsoImpliedCurrencyAndAmount TotalAmount { get; init; } 
    /// <summary>
    /// Detailed amounts associated with the total amount of transaction.
    /// </summary>
    [DataMember]
    public DetailedAmount15? DetailedAmount { get; init; } 
    /// <summary>
    /// Amount of the transaction that will be invoiced to the cardholder.
    /// </summary>
    [DataMember]
    public IsoImpliedCurrencyAndAmount? InvoiceAmount { get; init; } 
    /// <summary>
    /// Transaction authorisation deadline to complete the related payment.
    /// </summary>
    [DataMember]
    public IsoISODate? ValidityDate { get; init; } 
    /// <summary>
    /// Type of cardholder account used for the transaction.
    /// </summary>
    [DataMember]
    public CardAccountType3Code? AccountType { get; init; } 
    /// <summary>
    /// Data related to an integrated circuit card application.
    /// </summary>
    [DataMember]
    public IsoMax10000Binary? ICCRelatedData { get; init; } 
    
    #nullable disable
}
