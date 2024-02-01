﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FinancialItem1.  ISO2002 ID# _OTgzMzMy-AOSNFX-8224500.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies information about a financing relation between two parties represented by a document, for example invoice, credit.
/// The component may include an external document describing details of the underlying trade object using an external schema.
/// </summary>
public partial record FinancialItem1
{
    #nullable enable
    
    /// <summary>
    /// Parameters identifying the context of the item.
    /// </summary>
    public required FinancialItemParameters1 ItemContext { get; init; } 
    /// <summary>
    /// Identifier of financial document that is the base document for this item, for example an invoice number.
    /// </summary>
    public QualifiedDocumentInformation1[] FinancialDocumentReference { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Indicates whether the value is a debit or credit.
    /// </summary>
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    /// <summary>
    /// Specifies the total amount related to the financial document.
    /// </summary>
    public required InvoiceTotals1 TotalAmount { get; init; } 
    /// <summary>
    /// Specifies the remaining monetary amount.
    /// </summary>
    public IsoActiveCurrencyAndAmount? DueAmount { get; init; } 
    /// <summary>
    /// Instalment information for payment.
    /// </summary>
    public Instalment2[] InstalmentInformation { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Additional proprietary textual information concerning the item.
    /// </summary>
    public IsoMax2000Text? AdditionalInformation { get; init; } 
    /// <summary>
    /// Associated free form document, for example a delivery confirmation.
    /// </summary>
    public QualifiedDocumentInformation1[] AssociatedDocument { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Validation status of the item.
    /// </summary>
    public ValidationStatusInformation1? ValidationStatusInformation { get; init; } 
    /// <summary>
    /// Financing status if applicable for the item.
    /// </summary>
    public FinancingInformationAndStatus1? FinancingStatus { get; init; } 
    /// <summary>
    /// Structured proprietary information concerning details of the financial item.
    /// </summary>
    public SupplementaryData1? ProprietaryDetails { get; init; } 
    
    #nullable disable
}
