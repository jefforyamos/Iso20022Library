﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ATMTransaction15.  ISO2002 ID# _DGFika4AEeWL1uap3dNhCQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Deposit transaction for which the service is requested.
/// </summary>
[DataContract]
[XmlType]
public partial record ATMTransaction15
{
    #nullable enable
    
    /// <summary>
    /// Identification of the transaction assigned by the ATM.
    /// </summary>
    [DataMember]
    public required TransactionIdentifier1 TransactionIdentification { get; init; } 
    /// <summary>
    /// Identification of the reconciliation period assigned by the ATM.
    /// </summary>
    [DataMember]
    public IsoMax35Text? ReconciliationIdentification { get; init; } 
    /// <summary>
    /// Unprotected account information.
    /// </summary>
    [DataMember]
    public CardAccount9? AccountData { get; init; } 
    /// <summary>
    /// Encryption of account information.
    /// </summary>
    [DataMember]
    public ContentInformationType10? ProtectedAccountData { get; init; } 
    /// <summary>
    /// Total amount of the deposit transaction.
    /// </summary>
    [DataMember]
    public AmountAndCurrency1? TotalAmount { get; init; } 
    /// <summary>
    /// Amounts of the deposit transaction.
    /// </summary>
    [DataMember]
    public ValueList<DetailedAmount16> DetailedRequestedAmount { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Deposited media put in the safe.
    /// </summary>
    [DataMember]
    public ValueList<ATMDepositedMedia1> DepositedMedia { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// True if a receipt has be requested by the customer.
    /// </summary>
    [DataMember]
    public IsoTrueFalseIndicator? RequestedReceipt { get; init; } 
    /// <summary>
    /// Sequence of one or more TLV data elements from the ATM application, in accordance with ISO 7816-6, not in a specific order. Present if the transaction is performed with an EMV chip card application.
    /// </summary>
    [DataMember]
    public IsoMax10000Binary? ICCRelatedData { get; init; } 
    
    #nullable disable
}
