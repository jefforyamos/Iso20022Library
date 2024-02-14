﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardAggregated2.  ISO2002 ID# _SkavGa6BEeexrtTFgmVD3Q.
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
/// Globalised card transaction entry details.
/// </summary>
[IsoId("_SkavGa6BEeexrtTFgmVD3Q")]
[DisplayName("Card Aggregated")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardAggregated2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Service in addition to the main service.
    /// </summary>
    [IsoId("_StCfka6BEeexrtTFgmVD3Q")]
    [DisplayName("Additional Service")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlSvc")]
    #endif
    [IsoXmlTag("AddtlSvc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardPaymentServiceType2Code? AdditionalService { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentServiceType2Code? AdditionalService { get; init; } 
    #else
    public CardPaymentServiceType2Code? AdditionalService { get; set; } 
    #endif
    
    /// <summary>
    /// Category code conform to ISO 18245, related to the type of services or goods the merchant provides for the transaction.
    /// </summary>
    [IsoId("_StCfk66BEeexrtTFgmVD3Q")]
    [DisplayName("Transaction Category")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxCtgy")]
    #endif
    [IsoXmlTag("TxCtgy")]
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
    [IsoId("_StCfla6BEeexrtTFgmVD3Q")]
    [DisplayName("Sale Reconciliation Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SaleRcncltnId")]
    #endif
    [IsoXmlTag("SaleRcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SaleReconciliationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SaleReconciliationIdentification { get; init; } 
    #else
    public System.String? SaleReconciliationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Range of sequence numbers on which the globalisation applies.
    /// </summary>
    [IsoId("_StCfl66BEeexrtTFgmVD3Q")]
    [DisplayName("Sequence Number Range")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SeqNbRg")]
    #endif
    [IsoXmlTag("SeqNbRg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardSequenceNumberRange1? SequenceNumberRange { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardSequenceNumberRange1? SequenceNumberRange { get; init; } 
    #else
    public CardSequenceNumberRange1? SequenceNumberRange { get; set; } 
    #endif
    
    /// <summary>
    /// Date range on which the globalisation applies.
    /// </summary>
    [IsoId("_StCfma6BEeexrtTFgmVD3Q")]
    [DisplayName("Transaction Date Range")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxDtRg")]
    #endif
    [IsoXmlTag("TxDtRg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateOrDateTimePeriod1Choice_? TransactionDateRange { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateOrDateTimePeriod1Choice_? TransactionDateRange { get; init; } 
    #else
    public DateOrDateTimePeriod1Choice_? TransactionDateRange { get; set; } 
    #endif
    
    
    #nullable disable
    
}
