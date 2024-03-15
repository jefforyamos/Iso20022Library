﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OriginalMessage4.  ISO2002 ID# _LdpF-W49EeiU9cctagi5ow.
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
/// Unique and unambiguous identification of the original message references.
/// </summary>
[IsoId("_LdpF-W49EeiU9cctagi5ow")]
[DisplayName("Original Message")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OriginalMessage4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a OriginalMessage4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public OriginalMessage4( System.String reqOriginalMessageIdentification,System.String reqOriginalMessageNameIdentification,System.String reqOriginalRecordIdentification )
    {
        OriginalMessageIdentification = reqOriginalMessageIdentification;
        OriginalMessageNameIdentification = reqOriginalMessageNameIdentification;
        OriginalRecordIdentification = reqOriginalRecordIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Original message sender used to identify the message.
    /// </summary>
    [IsoId("_LnLcYW49EeiU9cctagi5ow")]
    [DisplayName("Original Sender")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlSndr")]
    #endif
    [IsoXmlTag("OrgnlSndr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Party40Choice_? OriginalSender { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Party40Choice_? OriginalSender { get; init; } 
    #else
    public Party40Choice_? OriginalSender { get; set; } 
    #endif
    
    /// <summary>
    /// Point to point reference assigned by the original instructing party to unambiguously identify the original group of individual transactions.
    /// </summary>
    [IsoId("_LnLcY249EeiU9cctagi5ow")]
    [DisplayName("Original Message Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlMsgId")]
    #endif
    [IsoXmlTag("OrgnlMsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text OriginalMessageIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String OriginalMessageIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String OriginalMessageIdentification { get; init; } 
    #else
    public System.String OriginalMessageIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the original message name identifier to which the message refers, such as pacs.003.001.01 or MT103.
    /// </summary>
    [IsoId("_LnLcZW49EeiU9cctagi5ow")]
    [DisplayName("Original Message Name Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlMsgNmId")]
    #endif
    [IsoXmlTag("OrgnlMsgNmId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text OriginalMessageNameIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String OriginalMessageNameIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String OriginalMessageNameIdentification { get; init; } 
    #else
    public System.String OriginalMessageNameIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Original date and time at which the message was created.
    /// </summary>
    [IsoId("_LnLcZ249EeiU9cctagi5ow")]
    [DisplayName("Original Creation Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlCreDtTm")]
    #endif
    [IsoXmlTag("OrgnlCreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? OriginalCreationDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? OriginalCreationDateTime { get; init; } 
    #else
    public System.DateTime? OriginalCreationDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the identification of original package of instructions, entries or records.
    /// </summary>
    [IsoId("_LnLcaW49EeiU9cctagi5ow")]
    [DisplayName("Original Package Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlPackgId")]
    #endif
    [IsoXmlTag("OrgnlPackgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OriginalPackageIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OriginalPackageIdentification { get; init; } 
    #else
    public System.String? OriginalPackageIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the identification of original entry, instruction or record within the package.
    /// </summary>
    [IsoId("_LnLca249EeiU9cctagi5ow")]
    [DisplayName("Original Record Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlRcrdId")]
    #endif
    [IsoXmlTag("OrgnlRcrdId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text OriginalRecordIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String OriginalRecordIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String OriginalRecordIdentification { get; init; } 
    #else
    public System.String OriginalRecordIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
