﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Transaction105.  ISO2002 ID# _mdK4kVdVEeeIAMBcVOw01w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Inquiry transaction
/// </summary>
public partial record Transaction105
{
    #nullable enable
    
    /// <summary>
    /// Type of transaction associated with the main service.
    /// ISO 8583:87/93/2003 bit 3
    /// </summary>
    public required IsoExact2AlphaNumericText TransactionType { get; init; } 
    /// <summary>
    /// Provides further granularity of purpose of TransactionType
    /// </summary>
    public IsoMax35Text? TransactionSubType { get; init; } 
    /// <summary>
    /// Additional functions or services to be performed in conjunction with the transaction.
    /// </summary>
    public AdditionalService1[] AdditionalService { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Reason to send the message.
    /// ISO 8583:93/2003 bit 25.
    /// The ISO 8583 maintenance agency (MA) manages this code list.
    /// </summary>
    public IsoExact4NumericText[] MessageReason { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Supports message reason codes that are not defined  in external code list. 
    /// </summary>
    public IsoMax35Text? AlternateMessageReason { get; init; } 
    /// <summary>
    /// Data to qualify for incentive or other related programmes.
    /// </summary>
    public SpecialProgrammeQualification1[] SpecialProgrammeQualification { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    public required TransactionIdentification11 TransactionIdentification { get; init; } 
    /// <summary>
    /// Transaction currency of the acceptor.
    /// ISO 4217
    /// </summary>
    public ISO3NumericCurrencyCode? TransactionCurrency { get; init; } 
    /// <summary>
    /// Further details of some or all amounts in the transaction amount.   
    /// The detailed amount is used to calculate the reconciliation amount for messages in which the transaction amount is absent.
    /// </summary>
    public DetailedAmount20[] DetailedAmount { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Amount used for reconciliation. 
    /// Calculated based on the transaction amount, except when the transaction amount is absent. When transaction amount is absent, the reconciliation amount is calculated on the detailed amount field 
    /// </summary>
    public Amount4? ReconciliationAmount { get; init; } 
    /// <summary>
    /// Amounts that are not part of the transaction amount and not included in reconciliation.
    /// ISO 8583 bit 54
    /// </summary>
    public AdditionalAmounts2[] AdditionalAmounts { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Fees not included in the transaction amount but included in the settlement.
    /// </summary>
    public AdditionalFee1[] AdditionalFees { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Identifies a customer account or a relationship to its account affected for debit, inquiries and the source of funding for transfers.
    /// </summary>
    public AccountDetails2? AccountFrom { get; init; } 
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
