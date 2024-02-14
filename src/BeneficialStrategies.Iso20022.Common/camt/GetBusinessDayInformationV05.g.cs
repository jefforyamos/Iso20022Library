﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for GetBusinessDayInformationV05.  ISO2002 ID# _jwlbbxbvEeiyVv5j1vf1VQ.
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
/// This record is an implementation of the camt.018.001.05 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The GetBusinessDayInformation message is sent by a member to the transaction administrator.
/// It is used to request information on different types of administrative data linked to the system.
/// Usage
/// The transaction administrator is in charge of providing the members with business information. The term business day information covers all information related to the management of the system, not related to the transactions created in the system. The type of business day information available can vary depending on the system.
/// At any time during the operating hours of the system, the member can query the transaction administrator to get information about the static data of the system.
/// The member can request information based on the following elements:
/// - identification of the system
/// - currency within the system concerned
/// - status of the system
/// - period of availability of a given currency linked to the system concerned (in case the system handles more than one currency)
/// - closure information (dates when the system will be inactive and reasons for this inactivity)
/// - event indicator (types of event and precise timing of their occurrence within the system concerned)
/// This message will be replied to by a ReturnBusinessDayInformation message. Additional information on the generic design of the Get/Return messages can be found in the section How to Use the Cash Management Messages.
/// </summary>
[Description(@"Scope|The GetBusinessDayInformation message is sent by a member to the transaction administrator.|It is used to request information on different types of administrative data linked to the system.|Usage|The transaction administrator is in charge of providing the members with business information. The term business day information covers all information related to the management of the system, not related to the transactions created in the system. The type of business day information available can vary depending on the system.|At any time during the operating hours of the system, the member can query the transaction administrator to get information about the static data of the system.|The member can request information based on the following elements:|- identification of the system|- currency within the system concerned|- status of the system|- period of availability of a given currency linked to the system concerned (in case the system handles more than one currency)|- closure information (dates when the system will be inactive and reasons for this inactivity)|- event indicator (types of event and precise timing of their occurrence within the system concerned)|This message will be replied to by a ReturnBusinessDayInformation message. Additional information on the generic design of the Get/Return messages can be found in the section How to Use the Cash Management Messages.")]
[IsoId("_jwlbbxbvEeiyVv5j1vf1VQ")]
[DisplayName("Get Business Day Information V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record GetBusinessDayInformationV05 : IOuterRecord<GetBusinessDayInformationV05,GetBusinessDayInformationV05Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.018.001.05";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "GetBizDayInf";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => GetBusinessDayInformationV05Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a GetBusinessDayInformationV05 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public GetBusinessDayInformationV05( MessageHeader9 reqMessageHeader )
    {
        MessageHeader = reqMessageHeader;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_jwlbcRbvEeiyVv5j1vf1VQ")]
    [DisplayName("Message Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgHdr")]
    #endif
    [IsoXmlTag("MsgHdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageHeader9 MessageHeader { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageHeader9 MessageHeader { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageHeader9 MessageHeader { get; init; } 
    #else
    public MessageHeader9 MessageHeader { get; set; } 
    #endif
    
    /// <summary>
    /// Defines the business day information query criteria.
    /// </summary>
    [IsoId("_jwlbcxbvEeiyVv5j1vf1VQ")]
    [DisplayName("Business Day Information Query Definition")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BizDayInfQryDef")]
    #endif
    [IsoXmlTag("BizDayInfQryDef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BusinessDayQuery2? BusinessDayInformationQueryDefinition { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BusinessDayQuery2? BusinessDayInformationQueryDefinition { get; init; } 
    #else
    public BusinessDayQuery2? BusinessDayInformationQueryDefinition { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_jwlbdRbvEeiyVv5j1vf1VQ")]
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
    /// Using the state of this record, returns a populated &lt;seealso cref=&quot;GetBusinessDayInformationV05Document&quot;/&gt;, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public GetBusinessDayInformationV05Document ToDocument()
    {
        return new GetBusinessDayInformationV05Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying &lt;seealso cref=&quot;GetBusinessDayInformationV05&quot;/&gt;.
/// </summary>
[Serializable]
public partial record GetBusinessDayInformationV05Document : IOuterDocument<GetBusinessDayInformationV05>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.018.001.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of &lt;seealso cref=&quot;GetBusinessDayInformationV05&quot;/&gt; is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GetBusinessDayInformationV05 Message { get; init; }
    #else
    public GetBusinessDayInformationV05 Message { get; init; }
    #endif
}
