﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardTransactionDetail3.  ISO2002 ID# _zU1DIYIeEeSvPp7yXrNQIw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the card transaction.
/// </summary>
[DataContract]
[XmlType]
public partial record CardTransactionDetail3
{
    #nullable enable
    
    /// <summary>
    /// Amounts of the transaction expressed within the terminal currency.
    /// </summary>
    [DataMember]
    public required CardTransactionAmount3 TransactionAmounts { get; init; } 
    /// <summary>
    /// Fees between acquirer and issuer exclusive of the transaction amount, and expressed in the currency of the reconciliation.
    /// </summary>
    [DataMember]
    public ValueList<DetailedAmount11> TransactionFees { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Additional amounts from the processor or the issuer without financial impacts on the transaction amount.
    /// </summary>
    [DataMember]
    public ValueList<DetailedAmount10> AdditionalAmounts { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Reason to send a card acquirer to issuer message.
    /// It corresponds to ISO 8583 field number 25 for the version 93, and field number 9 for the version 2003.
    /// </summary>
    [DataMember]
    public MessageReason1Code? MessageReason { get; init; } 
    /// <summary>
    /// Transaction authorisation deadline to complete the related payment.
    /// It corresponds to ISO 8583 field number 57 for the version 93, and field number 3 for the version 2003.
    /// </summary>
    [DataMember]
    public IsoISODate? ValidityDate { get; init; } 
    /// <summary>
    /// Transaction category level on an unattended terminal.
    /// </summary>
    [DataMember]
    public IsoMax35NumericText? UnattendedLevelCategory { get; init; } 
    /// <summary>
    /// Way to identify a customer account or a relationship to its account affected for debits, inquiries and the “from” account for transfers.
    /// </summary>
    [DataMember]
    public CardAccount1? AccountFrom { get; init; } 
    /// <summary>
    /// Way to identify a customer account or a relationship to its account affected for credits and the “to” account for transfers.
    /// </summary>
    [DataMember]
    public CardAccount1? AccountTo { get; init; } 
    /// <summary>
    /// Data related to a financial loan (instalment) or to a recurring transaction.
    /// </summary>
    [DataMember]
    public RecurringTransaction2? Instalment { get; init; } 
    /// <summary>
    /// Information requested against money laundering for a transfer transaction.
    /// </summary>
    [DataMember]
    public AntiMoneyLaundering1? AntiMoneyLaundering { get; init; } 
    /// <summary>
    /// Data related to an integrated circuit card application.
    /// It corresponds to ISO 8583 field number 55 for the versions 93 and 2003.
    /// </summary>
    [DataMember]
    public IsoMax10000Binary? ICCRelatedData { get; init; } 
    
    #nullable disable
}
