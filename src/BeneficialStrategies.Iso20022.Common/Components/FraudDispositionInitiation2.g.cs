﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FraudDispositionInitiation2.  ISO2002 ID# _I5XAQYgrEeu8-LhY4KPfWg.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
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
/// Information related to the  fraud disposition initiation message.
/// </summary>
[IsoId("_I5XAQYgrEeu8-LhY4KPfWg")]
[DisplayName("Fraud Disposition Initiation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FraudDispositionInitiation2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FraudDispositionInitiation2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FraudDispositionInitiation2( Environment28 reqEnvironment,Transaction128 reqTransaction,FraudDispositionStatus2 reqFraudDispositionStatus )
    {
        Environment = reqEnvironment;
        Transaction = reqTransaction;
        FraudDispositionStatus = reqFraudDispositionStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction
    /// </summary>
    [IsoId("_I-jCQYgrEeu8-LhY4KPfWg")]
    [DisplayName("Environment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Envt")]
    #endif
    [IsoXmlTag("Envt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Environment28 Environment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Environment28 Environment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Environment28 Environment { get; init; } 
    #else
    public Environment28 Environment { get; set; } 
    #endif
    
    /// <summary>
    /// Contains or describes conditions and characteristics of the transaction.
    /// </summary>
    [IsoId("_I-jCQ4grEeu8-LhY4KPfWg")]
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
    /// Card transaction for which an authorisation is requested.
    /// </summary>
    [IsoId("_I-jCRYgrEeu8-LhY4KPfWg")]
    [DisplayName("Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tx")]
    #endif
    [IsoXmlTag("Tx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Transaction128 Transaction { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Transaction128 Transaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Transaction128 Transaction { get; init; } 
    #else
    public Transaction128 Transaction { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the disposition of the previously submitted fraud reporting message.
    /// </summary>
    [IsoId("_I-jCR4grEeu8-LhY4KPfWg")]
    [DisplayName("Fraud Disposition Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrdDspstnSts")]
    #endif
    [IsoXmlTag("FrdDspstnSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FraudDispositionStatus2 FraudDispositionStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FraudDispositionStatus2 FraudDispositionStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FraudDispositionStatus2 FraudDispositionStatus { get; init; } 
    #else
    public FraudDispositionStatus2 FraudDispositionStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_I-jCSYgrEeu8-LhY4KPfWg")]
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
