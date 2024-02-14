﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CreateMemberV01.  ISO2002 ID# _P8togckHEem3UrxZgQhVAw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif


namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// This record is an implementation of the camt.104.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The ModifyMember message is sent by a member to the transaction administrator.
/// It is used to create the profile of a member that the transaction administrator maintains.
/// Usage
/// Based on the criteria defined in the CreateLimit message, the transaction administrator will execute or reject the requested creation and respond with a Receipt message as a reply to the request.
/// </summary>
[Description(@"Scope|The ModifyMember message is sent by a member to the transaction administrator.|It is used to create the profile of a member that the transaction administrator maintains.|Usage|Based on the criteria defined in the CreateLimit message, the transaction administrator will execute or reject the requested creation and respond with a Receipt message as a reply to the request.")]
[IsoId("_P8togckHEem3UrxZgQhVAw")]
[DisplayName("Create Member V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CreateMemberV01 : IOuterRecord<CreateMemberV01,CreateMemberV01Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.104.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CretMmb";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => CreateMemberV01Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CreateMemberV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CreateMemberV01( MessageHeader1 reqMessageHeader,MemberIdentification3Choice_ reqMemberIdentification,Member6 reqValueSet )
    {
        MessageHeader = reqMessageHeader;
        MemberIdentification = reqMemberIdentification;
        ValueSet = reqValueSet;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_P8toickHEem3UrxZgQhVAw")]
    [DisplayName("Message Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgHdr")]
    #endif
    [IsoXmlTag("MsgHdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageHeader1 MessageHeader { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageHeader1 MessageHeader { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageHeader1 MessageHeader { get; init; } 
    #else
    public MessageHeader1 MessageHeader { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier of a system member, as assigned by the system, or the system administrator.
    /// </summary>
    [IsoId("_P8toi8kHEem3UrxZgQhVAw")]
    [DisplayName("Member Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MmbId")]
    #endif
    [IsoXmlTag("MmbId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MemberIdentification3Choice_ MemberIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MemberIdentification3Choice_ MemberIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MemberIdentification3Choice_ MemberIdentification { get; init; } 
    #else
    public MemberIdentification3Choice_ MemberIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// New member values.
    /// </summary>
    [IsoId("_P8tojckHEem3UrxZgQhVAw")]
    [DisplayName("Value Set")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValSet")]
    #endif
    [IsoXmlTag("ValSet")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Member6 ValueSet { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Member6 ValueSet { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Member6 ValueSet { get; init; } 
    #else
    public Member6 ValueSet { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_P8toj8kHEem3UrxZgQhVAw")]
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
    
    /// <summary>
    /// Using the state of this record, returns a populated &lt;seealso cref=&quot;CreateMemberV01Document&quot;/&gt;, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CreateMemberV01Document ToDocument()
    {
        return new CreateMemberV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying &lt;seealso cref=&quot;CreateMemberV01&quot;/&gt;.
/// </summary>
[Serializable]
public partial record CreateMemberV01Document : IOuterDocument<CreateMemberV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.104.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of &lt;seealso cref=&quot;CreateMemberV01&quot;/&gt; is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CreateMemberV01 Message { get; init; }
    #else
    public CreateMemberV01 Message { get; init; }
    #endif
}
