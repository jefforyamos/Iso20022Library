﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InquiryResponse1.  ISO2002 ID# _gk0NkVfjEeeg8PDQoAs78Q.
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
/// Information related to the inquiry response message.
/// </summary>
[IsoId("_gk0NkVfjEeeg8PDQoAs78Q")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Inquiry Response")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InquiryResponse1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InquiryResponse1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InquiryResponse1( Environment15 reqEnvironment,Context2 reqContext,Transaction87 reqTransaction,ProcessingResult5 reqProcessingResult )
    {
        Environment = reqEnvironment;
        Context = reqContext;
        Transaction = reqTransaction;
        ProcessingResult = reqProcessingResult;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_gygrUVfjEeeg8PDQoAs78Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Environment")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Environment15 Environment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public Environment15 Environment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Environment15 Environment { get; init; } 
    #else
    public Environment15 Environment { get; set; } 
    #endif
    
    /// <summary>
    /// Context in which the card transaction is performed.
    /// </summary>
    [IsoId("_mzS0Ed8REeeNTcLLmuYy-w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Context")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Context2 Context { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public Context2 Context { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Context2 Context { get; init; } 
    #else
    public Context2 Context { get; set; } 
    #endif
    
    /// <summary>
    /// Card transaction for which an authorisation is requested.
    /// </summary>
    [IsoId("_gygrVVfjEeeg8PDQoAs78Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Transaction87 Transaction { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public Transaction87 Transaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Transaction87 Transaction { get; init; } 
    #else
    public Transaction87 Transaction { get; set; } 
    #endif
    
    /// <summary>
    /// Result of the inquiry processing.
    /// </summary>
    [IsoId("_xSGF8e-_EeeJbIMlSHFAag")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Processing Result")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ProcessingResult5 ProcessingResult { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public ProcessingResult5 ProcessingResult { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProcessingResult5 ProcessingResult { get; init; } 
    #else
    public ProcessingResult5 ProcessingResult { get; set; } 
    #endif
    
    /// <summary>
    /// Data related to an integrated circuit card application embedded in the payment card of the cardholder.
    /// ISO 8583 bit 55
    /// </summary>
    [IsoId("_gygrV1fjEeeg8PDQoAs78Q")]
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
    [IsoId("_u0higdXwEee5XtaG1wqDfQ")]
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
    [IsoId("_5YDqUaK5EeeQobSgLcPRvA")]
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
