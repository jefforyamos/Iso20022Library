﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentTransactionDetails38.  ISO2002 ID# _j12Ysa16EeawR4FMacHsRQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the transaction to capture.
/// </summary>
public partial record CardPaymentTransactionDetails38
{
    #nullable enable
    
    /// <summary>
    /// Currency associated with the transaction.
    /// </summary>
    public CurrencyCode? Currency { get; init; } 
    /// <summary>
    /// Total amount of the transaction.
    /// </summary>
    public required IsoImpliedCurrencyAndAmount TotalAmount { get; init; } 
    /// <summary>
    /// Qualifies the amount associated with the transaction.
    /// </summary>
    public TypeOfAmount8Code? AmountQualifier { get; init; } 
    /// <summary>
    /// Detailed amounts associated with the total amount of transaction.
    /// </summary>
    public DetailedAmount15? DetailedAmount { get; init; } 
    /// <summary>
    /// Amount requested to be authorised.
    /// </summary>
    public IsoImpliedCurrencyAndAmount? RequestedAmount { get; init; } 
    /// <summary>
    /// Amount authorised for the transaction.
    /// </summary>
    public IsoImpliedCurrencyAndAmount? AuthorisedAmount { get; init; } 
    /// <summary>
    /// Amount of the transaction that will be invoiced to the cardholder.
    /// </summary>
    public IsoImpliedCurrencyAndAmount? InvoiceAmount { get; init; } 
    /// <summary>
    /// Transaction authorisation deadline to complete the related payment.
    /// </summary>
    public IsoISODate? ValidityDate { get; init; } 
    /// <summary>
    /// Transaction category level on an unattended POI (Point Of Interaction).
    /// </summary>
    public IsoMax35NumericText? UnattendedLevelCategory { get; init; } 
    /// <summary>
    /// Type of cardholder account used for the transaction.
    /// </summary>
    public CardAccountType3Code? AccountType { get; init; } 
    /// <summary>
    /// Result of the currency conversion proposed to the cardholder.
    /// </summary>
    public CurrencyConversion13? CurrencyConversionResult { get; init; } 
    /// <summary>
    /// Data related to a financial loan (instalment) or to a recurring transaction.
    /// </summary>
    public RecurringTransaction2? Instalment { get; init; } 
    /// <summary>
    /// Payment transaction with an aggregated amount.
    /// </summary>
    public AggregationTransaction2? AggregationTransaction { get; init; } 
    /// <summary>
    /// Identification of the product codes that are purchased.
    /// </summary>
    public IsoMax10Text? ProductCodeSetIdentification { get; init; } 
    /// <summary>
    /// Item purchased with the transaction.
    /// </summary>
    public Product3[] SaleItem { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Location of the delivery, for instance pump number or parking bay.
    /// </summary>
    public IsoMax10Text? DeliveryLocation { get; init; } 
    /// <summary>
    /// Detailed invoice data.
    /// </summary>
    public CardPaymentInvoice2? CardPaymentInvoice { get; init; } 
    /// <summary>
    /// Data related to an integrated circuit card application.
    /// </summary>
    public IsoMax10000Binary? ICCRelatedData { get; init; } 
    
    #nullable disable
}
