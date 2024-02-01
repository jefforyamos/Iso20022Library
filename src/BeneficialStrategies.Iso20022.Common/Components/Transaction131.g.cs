﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Transaction131.  ISO2002 ID# _5CzlsYv4EeumSPwlS1PkxQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Inquiry transaction
/// </summary>
public partial record Transaction131
{
    #nullable enable
    
    /// <summary>
    /// Type of transaction associated with the main service.
    /// For valid values, see "Transaction type codes" in ISO 8583 "Financial transaction card originated messages — Interchange message specifications"
    /// </summary>
    public required ISO8583TransactionTypeCode TransactionType { get; init; } 
    /// <summary>
    /// Further breakdown of the transaction type being performed.
    /// </summary>
    public IsoMax35Text? TransactionSubType { get; init; } 
    /// <summary>
    /// Reason or purpose to send the message.
    /// The ISO 8583 maintenance agency (MA) manages this code list.
    /// </summary>
    public ISO8583MessageReasonCode[] MessageReason { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Supports message reason codes that are not defined  in external code list. 
    /// </summary>
    public IsoMax256Text[] AlternateMessageReason { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Additional functions or services to be performed in conjunction with the transaction.
    /// </summary>
    public AdditionalService2[] AdditionalService { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Data to qualify for incentive or other related programmes.
    /// </summary>
    public SpecialProgrammeQualification1[] SpecialProgrammeQualification { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    public required TransactionIdentification18 TransactionIdentification { get; init; } 
    /// <summary>
    /// Transaction currency of the acceptor.
    /// ISO 4217
    /// </summary>
    public ISO3NumericCurrencyCode? TransactionCurrency { get; init; } 
    /// <summary>
    /// Further details of some or all amounts in the transaction amount.   
    /// The detailed amount is used to calculate the reconciliation amount for messages in which the transaction amount is absent.
    /// </summary>
    public DetailedAmount23[] DetailedAmount { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Amount used for reconciliation. 
    /// Calculated based on the transaction amount, except when the transaction amount is absent. When transaction amount is absent, the reconciliation amount is calculated on the detailed amount field 
    /// </summary>
    public Amount15? ReconciliationAmount { get; init; } 
    /// <summary>
    /// Amounts that are not part of the transaction amount and not included in reconciliation.
    /// </summary>
    public AdditionalAmounts3[] AdditionalAmount { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Fees not included in the transaction amount but included in the settlement.
    /// </summary>
    public AdditionalFee2[] AdditionalFee { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Identifies a customer account or a relationship to its account affected for debit, inquiries and the source of funding for transfers.
    /// </summary>
    public AccountDetails3? AccountFrom { get; init; } 
    /// <summary>
    /// Transaction data related to programmes and services, content and format based on bilateral agreements.
    /// </summary>
    public IsoMax1000Text? TransactionDescription { get; init; } 
    /// <summary>
    /// Contains additional data.
    /// </summary>
    public AdditionalData1[] AdditionalData { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
