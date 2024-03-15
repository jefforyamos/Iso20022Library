﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for GenericDocumentIdentification5.  ISO2002 ID# _8ScaG5NLEeWGlc8L7oPDIg.
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
/// Generic identification scheme for a document.
/// </summary>
[IsoId("_8ScaG5NLEeWGlc8L7oPDIg")]
[DisplayName("Generic Document Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record GenericDocumentIdentification5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a GenericDocumentIdentification5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public GenericDocumentIdentification5( System.String reqIdentification )
    {
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Message type number/message identifier of the message referenced in the linkage sequence.
    /// </summary>
    [IsoId("_8ScaHZNLEeWGlc8L7oPDIg")]
    [DisplayName("Message Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgNb")]
    #endif
    [IsoXmlTag("MsgNb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentNumber6Choice_? MessageNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentNumber6Choice_? MessageNumber { get; init; } 
    #else
    public DocumentNumber6Choice_? MessageNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the document.
    /// </summary>
    [IsoId("_8ScaJZNLEeWGlc8L7oPDIg")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoRestrictedFINXMax16Text Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identification { get; init; } 
    #else
    public System.String Identification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
