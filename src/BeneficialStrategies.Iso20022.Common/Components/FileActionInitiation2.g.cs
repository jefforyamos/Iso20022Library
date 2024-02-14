﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FileActionInitiation2.  ISO2002 ID# _7nhvUYKvEeu4svNQ5N-l6w.
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
/// Information related to the file action.
/// </summary>
[IsoId("_7nhvUYKvEeu4svNQ5N-l6w")]
[DisplayName("File Action Initiation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FileActionInitiation2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FileActionInitiation2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FileActionInitiation2( Environment22 reqEnvironment,Transaction157 reqTransaction )
    {
        Environment = reqEnvironment;
        Transaction = reqTransaction;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Environment of the file action transaction.
    /// </summary>
    [IsoId("_7sqG8YKvEeu4svNQ5N-l6w")]
    [DisplayName("Environment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Envt")]
    #endif
    [IsoXmlTag("Envt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Environment22 Environment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Environment22 Environment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Environment22 Environment { get; init; } 
    #else
    public Environment22 Environment { get; set; } 
    #endif
    
    /// <summary>
    /// Contains or describes conditions and characteristics of the transaction.
    /// </summary>
    [IsoId("_7sqG84KvEeu4svNQ5N-l6w")]
    [DisplayName("Context")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cntxt")]
    #endif
    [IsoXmlTag("Cntxt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Context17? Context { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Context17? Context { get; init; } 
    #else
    public Context17? Context { get; set; } 
    #endif
    
    /// <summary>
    /// File action transaction details.
    /// </summary>
    [IsoId("_7sqG9YKvEeu4svNQ5N-l6w")]
    [DisplayName("Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tx")]
    #endif
    [IsoXmlTag("Tx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Transaction157 Transaction { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Transaction157 Transaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Transaction157 Transaction { get; init; } 
    #else
    public Transaction157 Transaction { get; set; } 
    #endif
    
    /// <summary>
    /// Results of the file action processing.
    /// </summary>
    [IsoId("_7sqG94KvEeu4svNQ5N-l6w")]
    [DisplayName("Processing Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrcgRslt")]
    #endif
    [IsoXmlTag("PrcgRslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ResultData9? ProcessingResult { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResultData9? ProcessingResult { get; init; } 
    #else
    public ResultData9? ProcessingResult { get; set; } 
    #endif
    
    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [IsoId("_7sqG-YKvEeu4svNQ5N-l6w")]
    [DisplayName("Protected Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtctdData")]
    #endif
    [IsoXmlTag("PrtctdData")]
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
    [IsoId("_7sqG-4KvEeu4svNQ5N-l6w")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
