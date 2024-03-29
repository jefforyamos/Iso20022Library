﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ReturnGeneralBusinessInformationV06.  ISO2002 ID# _jwlcERbvEeiyVv5j1vf1VQ.
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
/// This record is an implementation of the camt.021.001.06 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The ReturnGeneralBusinessInformation message is sent by the transaction administrator to a member of the system. It is used to provide some or all of the members with information related to the processing of the system.
/// The Return General Business Information message can be sent as a response to a related GetGeneralBusinessInformation message (pull mode) or initiated by the transaction administrator (push mode). The push of information can take place either at prearranged times or as a warning or alarm when a problem has occurred.
/// Usage
/// The transaction administrator can send general business information messages to the members, which may request further action from them. General business information can contain either static data announcing foreseen events affecting the system operations, or dynamic data warning or notifying about unexpected events.
/// This type of information can be transmitted in either of the two following ways:
/// - non-solicited reports are pushed by the transaction administrator to the (selected) members together with a reference, a qualifier and a subject line
/// - upon request from the members (pull mode), the transaction administrator delivers the full text/content of the message back to the user
/// In either case, the message from the transaction administrator can contain information based on the following elements:
/// - subject of the report detailing the purpose and content of the message
/// - details of the report
/// - indication of the priority of the report and of its format. (Note that if the format is indicated, the subject refers to a set of pre-agreed texts. This enumeration has to be agreed upon by the transaction administrator and the members of the system).
/// Additional information on the generic design of the Get/Return messages can be found in the MDR Part 1 section How to Use the Cash Management Messages.
/// </summary>
[Description(@"Scope|The ReturnGeneralBusinessInformation message is sent by the transaction administrator to a member of the system. It is used to provide some or all of the members with information related to the processing of the system.|The Return General Business Information message can be sent as a response to a related GetGeneralBusinessInformation message (pull mode) or initiated by the transaction administrator (push mode). The push of information can take place either at prearranged times or as a warning or alarm when a problem has occurred.|Usage|The transaction administrator can send general business information messages to the members, which may request further action from them. General business information can contain either static data announcing foreseen events affecting the system operations, or dynamic data warning or notifying about unexpected events.|This type of information can be transmitted in either of the two following ways:|- non-solicited reports are pushed by the transaction administrator to the (selected) members together with a reference, a qualifier and a subject line|- upon request from the members (pull mode), the transaction administrator delivers the full text/content of the message back to the user|In either case, the message from the transaction administrator can contain information based on the following elements:|- subject of the report detailing the purpose and content of the message|- details of the report|- indication of the priority of the report and of its format. (Note that if the format is indicated, the subject refers to a set of pre-agreed texts. This enumeration has to be agreed upon by the transaction administrator and the members of the system).|Additional information on the generic design of the Get/Return messages can be found in the MDR Part 1 section How to Use the Cash Management Messages.")]
[IsoId("_jwlcERbvEeiyVv5j1vf1VQ")]
[DisplayName("Return General Business Information V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReturnGeneralBusinessInformationV06 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.021.001.06";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RtrGnlBizInf";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.021.001.06";
    
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
    /// Constructs a ReturnGeneralBusinessInformationV06 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReturnGeneralBusinessInformationV06( MessageHeader7 reqMessageHeader,GeneralBusinessOrError7Choice_ reqReportOrError )
    {
        MessageHeader = reqMessageHeader;
        ReportOrError = reqReportOrError;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_jwlcExbvEeiyVv5j1vf1VQ")]
    [DisplayName("Message Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgHdr")]
    #endif
    [IsoXmlTag("MsgHdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageHeader7 MessageHeader { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageHeader7 MessageHeader { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageHeader7 MessageHeader { get; init; } 
    #else
    public MessageHeader7 MessageHeader { get; set; } 
    #endif
    
    /// <summary>
    /// Report on the Business Information.
    /// </summary>
    [IsoId("_jwlcFRbvEeiyVv5j1vf1VQ")]
    [DisplayName("Report Or Error")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptOrErr")]
    #endif
    [IsoXmlTag("RptOrErr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GeneralBusinessOrError7Choice_ ReportOrError { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GeneralBusinessOrError7Choice_ ReportOrError { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GeneralBusinessOrError7Choice_ ReportOrError { get; init; } 
    #else
    public GeneralBusinessOrError7Choice_ ReportOrError { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_jwlcFxbvEeiyVv5j1vf1VQ")]
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


// Since ReturnGeneralBusinessInformationV06Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ReturnGeneralBusinessInformationV06.

