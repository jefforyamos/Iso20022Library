﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FinancingItemList1.  ISO2002 ID# _OTgzMTk3-AOSNFX-8224490.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies a list of financing items exchanged between two parties, for example invoice, credit, financing request.
/// </summary>
public partial record FinancingItemList1
{
    #nullable enable
    
    /// <summary>
    /// Identification assigned to unambiguously identify the financing item list.
    /// </summary>
    public required IsoMax35Text Identifier { get; init; } 
    /// <summary>
    /// Date of creation of this document.
    /// </summary>
    public required IsoISODate IssueDate { get; init; } 
    /// <summary>
    /// Reference to related documents for example to original assignment in a status response or retry.
    /// </summary>
    public QualifiedDocumentInformation1? RelatedDocument { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Cut off date for items used to establish the total request amount.
    /// </summary>
    public IsoISODate? AmountCutOffDate { get; init; } 
    /// <summary>
    /// Party to which the list is assigned.
    /// </summary>
    public required QualifiedPartyIdentification1 Assignee { get; init; } 
    /// <summary>
    /// Party assigning the list.
    /// </summary>
    public required QualifiedPartyIdentification1 Assigner { get; init; } 
    /// <summary>
    /// Identifies parties that notify the assignment(s) and the notified parties.
    /// </summary>
    public FinancingNotificationParties1? NotificationInformation { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// List of items/transactions.
    /// </summary>
    public FinancialItem1? FinancialItem { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Number of individual items contained in the list.
    /// </summary>
    public required IsoMax15NumericText ItemCount { get; init; } 
    /// <summary>
    /// Total of all individual amounts included in the list, irrespective of currencies.
    /// </summary>
    public IsoDecimalNumber? ControlSum { get; init; } 
    /// <summary>
    /// Total amount in all items. Requires same currency, necessary when financing request is in percentage.
    /// </summary>
    public IsoActiveCurrencyAndAmount? TotalRequestAmount { get; init; } 
    /// <summary>
    /// Total amount requested.
    /// </summary>
    public IFinancingRateOrAmountChoice? TotalRequestFinancing { get; init; } 
    /// <summary>
    /// Acceptable exchange rate for financing by different currency.
    /// </summary>
    public AgreedRate1? AgreedRate { get; init; } 
    /// <summary>
    /// Instalment for the financing.
    /// </summary>
    public Instalment2? FinancingInstalment { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Additional free form information concerning the list.
    /// </summary>
    public IsoMax2000Text? AdditionalInformation { get; init; } 
    /// <summary>
    /// Validation status of the list.
    /// </summary>
    public ValidationStatusInformation1? ValidationStatusInformation { get; init; } 
    /// <summary>
    /// Financing status if applicable to the nature of the items.
    /// </summary>
    public FinancingInformationAndStatus1? FinancingStatus { get; init; } 
    
    #nullable disable
}
