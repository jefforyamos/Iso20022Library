﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Transaction89.  ISO2002 ID# _uGVb8abXEeiva6IOmhpVHw.
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
/// Contains transaction details.
/// </summary>
[IsoId("_uGVb8abXEeiva6IOmhpVHw")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Transaction")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Transaction89
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Transaction89 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Transaction89( TransactionIdentification11 reqTransactionIdentification )
    {
        TransactionIdentification = reqTransactionIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reason to send the message.
    /// ISO 8583:93/2003 bit 25
    /// The ISO 8583 maintenance agency (MA) manages this code list.
    /// </summary>
    [IsoId("_uRyeC6bXEeiva6IOmhpVHw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Message Reason")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 0 ,MinimumLength = 0)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExact4NumericText? MessageReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MessageReason { get; init; } 
    #else
    public System.String? MessageReason { get; set; } 
    #endif
    
    /// <summary>
    /// Supports message reason codes that are not defined in external code list. 
    /// </summary>
    [IsoId("_uRyeDabXEeiva6IOmhpVHw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Alternate Message Reason")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AlternateMessageReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AlternateMessageReason { get; init; } 
    #else
    public System.String? AlternateMessageReason { get; set; } 
    #endif
    
    /// <summary>
    /// Data to qualify for incentive or other related programmes.
    /// </summary>
    [IsoId("_uRyeE6bXEeiva6IOmhpVHw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Special Programme Qualification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SpecialProgrammeQualification1? SpecialProgrammeQualification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SpecialProgrammeQualification1? SpecialProgrammeQualification { get; init; } 
    #else
    public SpecialProgrammeQualification1? SpecialProgrammeQualification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    [IsoId("_uRyeFabXEeiva6IOmhpVHw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionIdentification11 TransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public TransactionIdentification11 TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionIdentification11 TransactionIdentification { get; init; } 
    #else
    public TransactionIdentification11 TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Issuer provides a reference for the dispute.
    /// </summary>
    [IsoId("_wG1MsabaEeiva6IOmhpVHw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Dispute Reference")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DisputeReference1? DisputeReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DisputeReference1? DisputeReference { get; init; } 
    #else
    public DisputeReference1? DisputeReference { get; set; } 
    #endif
    
    /// <summary>
    /// Fulfilment request instructions for the retrieval.
    /// </summary>
    [IsoId("_3EYDEabZEeiva6IOmhpVHw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Retrieval Fulfilment Instructions")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RetrievalFulfilmentInstructions1? RetrievalFulfilmentInstructions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RetrievalFulfilmentInstructions1? RetrievalFulfilmentInstructions { get; init; } 
    #else
    public RetrievalFulfilmentInstructions1? RetrievalFulfilmentInstructions { get; set; } 
    #endif
    
    /// <summary>
    /// Fees not included in the transaction amount.
    /// </summary>
    [IsoId("_uRyeHabXEeiva6IOmhpVHw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Additional Fees")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalFee1? AdditionalFees { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalFee1? AdditionalFees { get; init; } 
    #else
    public AdditionalFee1? AdditionalFees { get; set; } 
    #endif
    
    /// <summary>
    /// Transaction data related to programmes and services, content and format based on bilateral agreements.
    /// </summary>
    [IsoId("_uRyeKabXEeiva6IOmhpVHw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction Description")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 1000 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax1000Text? TransactionDescription { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TransactionDescription { get; init; } 
    #else
    public System.String? TransactionDescription { get; set; } 
    #endif
    
    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_umAQ4RqnEeqH1IQNpbVpEw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Additional Data")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalData1? AdditionalData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalData1? AdditionalData { get; init; } 
    #else
    public AdditionalData1? AdditionalData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
