﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DocumentIdentification34.  ISO2002 ID# _celQqZKQEeWHWpTQn1FFVg.
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
/// Identification of a document as well as the document number.
/// </summary>
[IsoId("_celQqZKQEeWHWpTQn1FFVg")]
[DisplayName("Document Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DocumentIdentification34
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DocumentIdentification34 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DocumentIdentification34( DocumentIdentification4Choice_ reqIdentification )
    {
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identifier of the document (message) assigned either by the account servicer or the account owner.
    /// </summary>
    [IsoId("_celQq5KQEeWHWpTQn1FFVg")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentIdentification4Choice_ Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentIdentification4Choice_ Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification4Choice_ Identification { get; init; } 
    #else
    public DocumentIdentification4Choice_ Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the type of document.
    /// </summary>
    [IsoId("_celQs5KQEeWHWpTQn1FFVg")]
    [DisplayName("Document Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DocNb")]
    #endif
    [IsoXmlTag("DocNb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentNumber6Choice_? DocumentNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentNumber6Choice_? DocumentNumber { get; init; } 
    #else
    public DocumentNumber6Choice_? DocumentNumber { get; set; } 
    #endif
    
    
    #nullable disable
    
}
