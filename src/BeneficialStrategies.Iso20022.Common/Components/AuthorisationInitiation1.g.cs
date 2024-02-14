﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AuthorisationInitiation1.  ISO2002 ID# _fl_dEE9MEeeg87n1YQSQ_A.
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
/// Information related to the authorisation initiation message.
/// </summary>
[IsoId("_fl_dEE9MEeeg87n1YQSQ_A")]
[DisplayName("Authorisation Initiation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AuthorisationInitiation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AuthorisationInitiation1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AuthorisationInitiation1( Environment1 reqEnvironment,Context1 reqContext,Transaction77 reqTransaction )
    {
        Environment = reqEnvironment;
        Context = reqContext;
        Transaction = reqTransaction;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Contains or describes the information pertaining to the actors interacting with the transaction.
    /// </summary>
    [IsoId("_zHwMgE9MEeeg87n1YQSQ_A")]
    [DisplayName("Environment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Envt")]
    #endif
    [IsoXmlTag("Envt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Environment1 Environment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Environment1 Environment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Environment1 Environment { get; init; } 
    #else
    public Environment1 Environment { get; set; } 
    #endif
    
    /// <summary>
    /// Contains or describes conditions and characteristics of the transaction.
    /// </summary>
    [IsoId("_Lwgq8E9NEeeg87n1YQSQ_A")]
    [DisplayName("Context")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cntxt")]
    #endif
    [IsoXmlTag("Cntxt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Context1 Context { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Context1 Context { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Context1 Context { get; init; } 
    #else
    public Context1 Context { get; set; } 
    #endif
    
    /// <summary>
    /// Card transaction for which an authorisation is requested.
    /// </summary>
    [IsoId("_xRqYIE9NEeeg87n1YQSQ_A")]
    [DisplayName("Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tx")]
    #endif
    [IsoXmlTag("Tx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Transaction77 Transaction { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Transaction77 Transaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Transaction77 Transaction { get; init; } 
    #else
    public Transaction77 Transaction { get; set; } 
    #endif
    
    /// <summary>
    /// Component contains data structures applicable to certain industries that require specific data within transaction messages.
    /// </summary>
    [IsoId("_aFqcMP5pEeiLerArw36g0w")]
    [DisplayName("Addendum Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AdddmData")]
    #endif
    [IsoXmlTag("AdddmData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AddendumData1? AddendumData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AddendumData1? AddendumData { get; init; } 
    #else
    public AddendumData1? AddendumData { get; set; } 
    #endif
    
    /// <summary>
    /// Outcome of the processing of the authorisation.
    /// </summary>
    [IsoId("_DKH1ME9TEeePXdaAO32Uew")]
    [DisplayName("Processing Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrcgRslt")]
    #endif
    [IsoXmlTag("PrcgRslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProcessingResult1? ProcessingResult { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProcessingResult1? ProcessingResult { get; init; } 
    #else
    public ProcessingResult1? ProcessingResult { get; set; } 
    #endif
    
    /// <summary>
    /// Data related to an integrated circuit card application embedded in the payment card of the cardholder.
    /// ISO 8583 bit 55
    /// </summary>
    [IsoId("_HG7MgE9UEeePXdaAO32Uew")]
    [DisplayName("ICC Related Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ICCRltdData")]
    #endif
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10KHexBinaryText)]
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
    [IsoId("_etoz8dXvEee5XtaG1wqDfQ")]
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
    [IsoId("_TC5iwaK4EeeQobSgLcPRvA")]
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
