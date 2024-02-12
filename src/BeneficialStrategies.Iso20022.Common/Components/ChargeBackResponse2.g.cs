﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ChargeBackResponse2.  ISO2002 ID# _tWE3AIdREeuBS50MFjViNw.
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
/// Information related to the chargeback response transaction.
/// </summary>
[IsoId("_tWE3AIdREeuBS50MFjViNw")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Charge Back Response")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ChargeBackResponse2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ChargeBackResponse2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ChargeBackResponse2( Environment29 reqEnvironment,Context16 reqContext,Transaction154 reqTransaction,ProcessingResult15 reqProcessingResult )
    {
        Environment = reqEnvironment;
        Context = reqContext;
        Transaction = reqTransaction;
        ProcessingResult = reqProcessingResult;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Environment of the chargeback.
    /// </summary>
    [IsoId("_ta00IYdREeuBS50MFjViNw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Environment")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Environment29 Environment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public Environment29 Environment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Environment29 Environment { get; init; } 
    #else
    public Environment29 Environment { get; set; } 
    #endif
    
    /// <summary>
    /// Context of the chargeback transaction.
    /// </summary>
    [IsoId("_ta00I4dREeuBS50MFjViNw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Context")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Context16 Context { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public Context16 Context { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Context16 Context { get; init; } 
    #else
    public Context16 Context { get; set; } 
    #endif
    
    /// <summary>
    /// Chargeback transaction details.
    /// </summary>
    [IsoId("_ta00JYdREeuBS50MFjViNw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Transaction154 Transaction { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public Transaction154 Transaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Transaction154 Transaction { get; init; } 
    #else
    public Transaction154 Transaction { get; set; } 
    #endif
    
    /// <summary>
    /// Result of the chargeback verification provided in the chargeback status.
    /// </summary>
    [IsoId("_ta00J4dREeuBS50MFjViNw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Processing Result")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ProcessingResult15 ProcessingResult { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public ProcessingResult15 ProcessingResult { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProcessingResult15 ProcessingResult { get; init; } 
    #else
    public ProcessingResult15 ProcessingResult { get; set; } 
    #endif
    
    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [IsoId("_ta00KYdREeuBS50MFjViNw")]
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
    [IsoId("_ta00K4dREeuBS50MFjViNw")]
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
