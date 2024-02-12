﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InquiryInitiation2.  ISO2002 ID# _FSdbIYEREeu6D49Gi-ZPwQ.
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
/// Information related to the inquiry initiation message.
/// </summary>
[IsoId("_FSdbIYEREeu6D49Gi-ZPwQ")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Inquiry Initiation")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InquiryInitiation2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InquiryInitiation2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InquiryInitiation2( Environment18 reqEnvironment,Context11 reqContext,Transaction131 reqTransaction )
    {
        Environment = reqEnvironment;
        Context = reqContext;
        Transaction = reqTransaction;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_FW-uwYEREeu6D49Gi-ZPwQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Environment")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Environment18 Environment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public Environment18 Environment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Environment18 Environment { get; init; } 
    #else
    public Environment18 Environment { get; set; } 
    #endif
    
    /// <summary>
    /// Context in which the card transaction is performed.
    /// </summary>
    [IsoId("_FW-uw4EREeu6D49Gi-ZPwQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Context")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Context11 Context { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public Context11 Context { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Context11 Context { get; init; } 
    #else
    public Context11 Context { get; set; } 
    #endif
    
    /// <summary>
    /// Card transaction for which an authorisation is requested.
    /// </summary>
    [IsoId("_FW-uxYEREeu6D49Gi-ZPwQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Transaction131 Transaction { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public Transaction131 Transaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Transaction131 Transaction { get; init; } 
    #else
    public Transaction131 Transaction { get; set; } 
    #endif
    
    /// <summary>
    /// Component contains data structures applicable to certain industries that require specific data within transaction messages
    /// </summary>
    [IsoId("_6bmnASX7Eeym0KcvJF9aDQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Addendum Data")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AddendumData5? AddendumData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AddendumData5? AddendumData { get; init; } 
    #else
    public AddendumData5? AddendumData { get; set; } 
    #endif
    
    /// <summary>
    /// Result of the inquiry processing.
    /// ISO 8583:87 bit 110
    /// ISO 8583:93 bit 111
    /// ISO 8583:2003 bit 50
    /// </summary>
    [IsoId("_FW-ux4EREeu6D49Gi-ZPwQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Processing Result")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProcessingResult11? ProcessingResult { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProcessingResult11? ProcessingResult { get; init; } 
    #else
    public ProcessingResult11? ProcessingResult { get; set; } 
    #endif
    
    /// <summary>
    /// Data related to an integrated circuit card application embedded in the payment card of the cardholder.
    /// ISO 8583 bit 55
    /// </summary>
    [IsoId("_FW-uyYEREeu6D49Gi-ZPwQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("ICC Related Data")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 0 ,MinimumLength = 0)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax10KHexBinaryText? ICCRelatedData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ICCRelatedData { get; init; } 
    #else
    public System.String? ICCRelatedData { get; set; } 
    #endif
    
    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [IsoId("_FW-uy4EREeu6D49Gi-ZPwQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Protected Data")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProtectedData1? ProtectedData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProtectedData1? ProtectedData { get; init; } 
    #else
    public ProtectedData1? ProtectedData { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_FW-uzYEREeu6D49Gi-ZPwQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Supplementary Data")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
