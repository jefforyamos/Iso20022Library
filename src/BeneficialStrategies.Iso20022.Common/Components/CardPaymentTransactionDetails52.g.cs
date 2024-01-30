﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentTransactionDetails52.  ISO2002 ID# _Pvj04XDoEe2MCaKO5AtGsA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the transaction in the authorisation request in a batch.
/// </summary>
public partial record CardPaymentTransactionDetails52
{
    #nullable enable
    
    /// <summary>
    /// Currency associated with the transaction.
    /// </summary>
    public ActiveCurrencyCode? Currency { get; init; } 
    /// <summary>
    /// Total amount of the transaction.
    /// </summary>
    public required IsoImpliedCurrencyAndAmount TotalAmount { get; init; } 
    /// <summary>
    /// Contains the updated amount of all authorisations related to the same business transaction.
    /// </summary>
    public IsoImpliedCurrencyAndAmount? CumulativeAmount { get; init; } 
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
    /// Amount authorised for the payment transaction.
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
    /// Reason to process an online authorisation.
    /// </summary>
    public OnLineReason2Code? OnLineReason { get; init;  } // Warning: Don't know multiplicity.
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
    public CurrencyConversion27? CurrencyConversionResult { get; init; } 
    /// <summary>
    /// Data related to a financial loan (instalment) or to a recurring transaction.
    /// </summary>
    public RecurringTransaction5? Instalment { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Payment transaction with an aggregated amount.
    /// </summary>
    public AggregationTransaction3? AggregationTransaction { get; init; } 
    /// <summary>
    /// Codification used to identify the products.
    /// </summary>
    public IsoMax10Text? ProductCodeSetIdentification { get; init; } 
    /// <summary>
    /// Item purchased with the transaction.
    /// </summary>
    public Product6? SaleItem { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Location of the delivery, for instance pump number or parking bay.
    /// </summary>
    public IsoMax35Text? DeliveryLocation { get; init; } 
    /// <summary>
    /// In case a message is sent after the consumption of goods or service, it indicates the number of times the authorisation has been sent to the Acquirer in order to get an approval.
    /// </summary>
    public IsoPositiveNumber? ReSubmissionCounter { get; init; } 
    /// <summary>
    /// Additional information related to the transaction like an Invoice or IndustryData (for example  hospitality, lodging, transportation).
    /// </summary>
    public ExternallyDefinedData4? AdditionalInformation { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Data related to an integrated circuit card application.
    /// </summary>
    public IsoMax10000Binary? ICCRelatedData { get; init; } 
    
    #nullable disable
}
