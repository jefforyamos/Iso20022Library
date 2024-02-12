﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardIndividualTransaction2.  ISO2002 ID# _0jmr9Tj3EeSz-s1QOUJaOg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Individual card transaction entry details.
/// </summary>
[IsoId("_0jmr9Tj3EeSz-s1QOUJaOg")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Card Individual Transaction")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardIndividualTransaction2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Data related to an integrated circuit card application.
    /// </summary>
    [IsoId("_vfHeYzj3EeSz-s1QOUJaOg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("ICC Related Data")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 1025 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax1025Text? ICCRelatedData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ICCRelatedData { get; init; } 
    #else
    public System.String? ICCRelatedData { get; set; } 
    #endif
    
    /// <summary>
    /// Context of the card payment transaction.
    /// </summary>
    [IsoId("_vfHeZDj3EeSz-s1QOUJaOg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Payment Context")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentContext3? PaymentContext { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentContext3? PaymentContext { get; init; } 
    #else
    public PaymentContext3? PaymentContext { get; set; } 
    #endif
    
    /// <summary>
    /// Service in addition to the main service.
    /// </summary>
    [IsoId("_0yxwYTj3EeSz-s1QOUJaOg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Additional Service")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardPaymentServiceType2Code? AdditionalService { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentServiceType2Code? AdditionalService { get; init; } 
    #else
    public CardPaymentServiceType2Code? AdditionalService { get; set; } 
    #endif
    
    /// <summary>
    /// Category code conform to ISO 18245, related to the type of services or goods the merchant provides for the transaction.
    /// This element is also known as the MerchantCategoryCode.
    /// </summary>
    [IsoId("_0yxwYzj3EeSz-s1QOUJaOg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction Category")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExternalCardTransactionCategory1Code? TransactionCategory { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? TransactionCategory { get; init; } 
    #else
    public string? TransactionCategory { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification of the sales reconciliation period between the acceptor and the acquirer. This identification might be linked to the identification of the settlement for further verification by the merchant.
    /// </summary>
    [IsoId("_0yxwZTj3EeSz-s1QOUJaOg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Sale Reconciliation Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SaleReconciliationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SaleReconciliationIdentification { get; init; } 
    #else
    public System.String? SaleReconciliationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique reference of the sales as provided by the merchant.
    /// </summary>
    [IsoId("_0yxwZzj3EeSz-s1QOUJaOg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Sale Reference Number")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SaleReferenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SaleReferenceNumber { get; init; } 
    #else
    public System.String? SaleReferenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Reason for representment of a card transaction.
    /// </summary>
    [IsoId("_vfHeZTj3EeSz-s1QOUJaOg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Re Presentment Reason")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExternalRePresentmentReason1Code? RePresentmentReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalRePresentmentReason1Code? RePresentmentReason { get; init; } 
    #else
    public ExternalRePresentmentReason1Code? RePresentmentReason { get; set; } 
    #endif
    
    /// <summary>
    /// Sequential number of the card transaction, as assigned by the POI (Point of Interaction). |Usage: The sequential number is increased incrementally for each transaction.
    /// </summary>
    [IsoId("_0yxwaTj3EeSz-s1QOUJaOg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Sequence Number")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SequenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SequenceNumber { get; init; } 
    #else
    public System.String? SequenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the transaction assigned by the POI (Point Of Interaction).
    /// </summary>
    [IsoId("_0yxwazj3EeSz-s1QOUJaOg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionIdentifier1? TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionIdentifier1? TransactionIdentification { get; init; } 
    #else
    public TransactionIdentifier1? TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Product purchased with the transaction.
    /// </summary>
    [IsoId("_0yxwbTj3EeSz-s1QOUJaOg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Product")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Product2? Product { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Product2? Product { get; init; } 
    #else
    public Product2? Product { get; set; } 
    #endif
    
    /// <summary>
    /// Date when the deposit was validated by the financial institution that collected the cash.
    /// </summary>
    [IsoId("_0yxwbzj3EeSz-s1QOUJaOg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Validation Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ValidationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ValidationDate { get; init; } 
    #else
    public System.DateOnly? ValidationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Sequential number of the validation of the cash deposit.
    /// Usage: The sequential number is increased incrementally for each transaction.
    /// </summary>
    [IsoId("_0yxwcTj3EeSz-s1QOUJaOg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Validation Sequence Number")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ValidationSequenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ValidationSequenceNumber { get; init; } 
    #else
    public System.String? ValidationSequenceNumber { get; set; } 
    #endif
    
    
    #nullable disable
    
}
