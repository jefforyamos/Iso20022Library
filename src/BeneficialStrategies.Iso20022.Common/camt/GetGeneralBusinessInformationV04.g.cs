﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for GetGeneralBusinessInformationV04.  ISO2002 ID# _jwlbfxbvEeiyVv5j1vf1VQ.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
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
/// This record is an implementation of the camt.020.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The GetGeneralBusinessInformation message is sent by a member to the transaction administrator.
/// It is used to request information on a broadcast-type message previously sent by the transaction administrator to all or some of the members, giving information related to the processing business.
/// Usage
/// The transaction administrator can send general business information messages to the members, which may request further action from them. General business information can contain either static data announcing foreseen events affecting the system operations, or dynamic data warning or notifying about unexpected events.
/// This type of information can be transmitted in either of the two following ways:
/// - non-solicited reports are pushed by the transaction administrator to the (selected) members together with a reference, a qualifier and a subject line
/// - upon request from the members (pull mode), the transaction administrator delivers the full text/content of the message back to the user
/// The Get General Business Information message is used in this second context. At any time during the operating hours of the system, the member can query the transaction administrator to get information about a report of general business information previously sent.
/// The member can request information based on the following elements:
/// - reference of the report previously delivered
/// - subject of the report previously delivered, detailing the purpose and content of the message
/// - priority of the report previously sent, and indication of its format. (Note that if the format is indicated, the subject refers to a set of pre-agreed texts. This enumeration has to be agreed upon by the transaction administrator and the members of the system.)
/// - details of the previously sent message
/// This message will be replied to by a ReturnGeneralBusinessInformation message.
/// Additional information on the generic design of the Get/Return messages can be found in the section How to Use the Cash Management Messages.
/// </summary>
[Description(@"Scope|The GetGeneralBusinessInformation message is sent by a member to the transaction administrator.|It is used to request information on a broadcast-type message previously sent by the transaction administrator to all or some of the members, giving information related to the processing business.|Usage|The transaction administrator can send general business information messages to the members, which may request further action from them. General business information can contain either static data announcing foreseen events affecting the system operations, or dynamic data warning or notifying about unexpected events.|This type of information can be transmitted in either of the two following ways:|- non-solicited reports are pushed by the transaction administrator to the (selected) members together with a reference, a qualifier and a subject line|- upon request from the members (pull mode), the transaction administrator delivers the full text/content of the message back to the user|The Get General Business Information message is used in this second context. At any time during the operating hours of the system, the member can query the transaction administrator to get information about a report of general business information previously sent.|The member can request information based on the following elements:|- reference of the report previously delivered|- subject of the report previously delivered, detailing the purpose and content of the message|- priority of the report previously sent, and indication of its format. (Note that if the format is indicated, the subject refers to a set of pre-agreed texts. This enumeration has to be agreed upon by the transaction administrator and the members of the system.)|- details of the previously sent message|This message will be replied to by a ReturnGeneralBusinessInformation message.|Additional information on the generic design of the Get/Return messages can be found in the section How to Use the Cash Management Messages.")]
[IsoId("_jwlbfxbvEeiyVv5j1vf1VQ")]
[DisplayName("Get General Business Information V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record GetGeneralBusinessInformationV04 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.020.001.04";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "GetGnlBizInf";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.020.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a GetGeneralBusinessInformationV04 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public GetGeneralBusinessInformationV04( MessageHeader1 reqMessageHeader )
    {
        MessageHeader = reqMessageHeader;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_jwlbgRbvEeiyVv5j1vf1VQ")]
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
    /// Definition of the general business information query.
    /// </summary>
    [IsoId("_jwlbgxbvEeiyVv5j1vf1VQ")]
    [DisplayName("General Business Information Query Definition")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GnlBizInfQryDef")]
    #endif
    [IsoXmlTag("GnlBizInfQryDef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BusinessInformationQueryDefinition3? GeneralBusinessInformationQueryDefinition { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BusinessInformationQueryDefinition3? GeneralBusinessInformationQueryDefinition { get; init; } 
    #else
    public BusinessInformationQueryDefinition3? GeneralBusinessInformationQueryDefinition { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_jwlbhRbvEeiyVv5j1vf1VQ")]
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


// Since GetGeneralBusinessInformationV04Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to GetGeneralBusinessInformationV04.

