﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DocumentIdentification29.  ISO2002 ID# _YMWsAdOWEeSQ_-lmj1tzfw.
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
/// Identifies a document by a unique identification and a date of issue.
/// </summary>
[IsoId("_YMWsAdOWEeSQ_-lmj1tzfw")]
[DisplayName("Document Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DocumentIdentification29
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DocumentIdentification29 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DocumentIdentification29( System.String reqIdentification,System.DateOnly reqDateOfIssue )
    {
        Identification = reqIdentification;
        DateOfIssue = reqDateOfIssue;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the document.
    /// </summary>
    [IsoId("_YWLWYdOWEeSQ_-lmj1tzfw")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identification { get; init; } 
    #else
    public System.String Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Date of issuance of the document.
    /// </summary>
    [IsoId("_YWLWY9OWEeSQ_-lmj1tzfw")]
    [DisplayName("Date Of Issue")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtOfIsse")]
    #endif
    [IsoXmlTag("DtOfIsse")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate DateOfIssue { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly DateOfIssue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly DateOfIssue { get; init; } 
    #else
    public System.DateOnly DateOfIssue { get; set; } 
    #endif
    
    
    #nullable disable
    
}
