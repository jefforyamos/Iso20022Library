﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AgentCAInformationStatusAdviceV01.  ISO2002 ID# _TOM7y9EwEd-BzquC8wXy7w_11240695.
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


namespace BeneficialStrategies.Iso20022.seev;

/// <summary>
/// This record is an implementation of the seev.024.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// This message is sent by an issuer (or its agent) to a CSD to report the status, or change in status, of an information advice.
/// Usage
/// This message must be used in response to an Agent Corporate Action Information Advice in the case of a rejection. However, it may also be used to report other statuses.
/// The information advice identification must be present to link this message to the information advice for which the status is provided.
/// </summary>
[Description(@"Scope|This message is sent by an issuer (or its agent) to a CSD to report the status, or change in status, of an information advice.|Usage|This message must be used in response to an Agent Corporate Action Information Advice in the case of a rejection. However, it may also be used to report other statuses.|The information advice identification must be present to link this message to the information advice for which the status is provided.")]
[IsoId("_TOM7y9EwEd-BzquC8wXy7w_11240695")]
[DisplayName("Agent CA Information Status Advice V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AgentCAInformationStatusAdviceV01 : IOuterRecord<AgentCAInformationStatusAdviceV01,AgentCAInformationStatusAdviceV01Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.024.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AgtCAInfStsAdvc";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => AgentCAInformationStatusAdviceV01Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AgentCAInformationStatusAdviceV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AgentCAInformationStatusAdviceV01( DocumentIdentification8 reqIdentification,DocumentIdentification8 reqAgentCAInformationAdviceIdentification,CorporateActionInformationStatus1Choice_ reqInformationStatusDetails )
    {
        Identification = reqIdentification;
        AgentCAInformationAdviceIdentification = reqAgentCAInformationAdviceIdentification;
        InformationStatusDetails = reqInformationStatusDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification assigned by the Sender to unambiguously identify the status advice.
    /// </summary>
    [IsoId("_TOM7zNEwEd-BzquC8wXy7w_1654735985")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentIdentification8 Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentIdentification8 Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification8 Identification { get; init; } 
    #else
    public DocumentIdentification8 Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the linked Agent CA Information Advice for which a status is given.
    /// </summary>
    [IsoId("_TOWFsNEwEd-BzquC8wXy7w_1665816866")]
    [DisplayName("Agent CA Information Advice Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgtCAInfAdvcId")]
    #endif
    [IsoXmlTag("AgtCAInfAdvcId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentIdentification8 AgentCAInformationAdviceIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentIdentification8 AgentCAInformationAdviceIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification8 AgentCAInformationAdviceIdentification { get; init; } 
    #else
    public DocumentIdentification8 AgentCAInformationAdviceIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the corporate action such as the delivery details.
    /// </summary>
    [IsoId("_TOWFsdEwEd-BzquC8wXy7w_693722719")]
    [DisplayName("Corporate Action Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnAddtlInf")]
    #endif
    [IsoXmlTag("CorpActnAddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionAdditionalInformation1? CorporateActionAdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionAdditionalInformation1? CorporateActionAdditionalInformation { get; init; } 
    #else
    public CorporateActionAdditionalInformation1? CorporateActionAdditionalInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the information advice sent by the CSD.
    /// </summary>
    [IsoId("_TOWFstEwEd-BzquC8wXy7w_-904563755")]
    [DisplayName("Information Status Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InfStsDtls")]
    #endif
    [IsoXmlTag("InfStsDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionInformationStatus1Choice_ InformationStatusDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionInformationStatus1Choice_ InformationStatusDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionInformationStatus1Choice_ InformationStatusDetails { get; init; } 
    #else
    public CorporateActionInformationStatus1Choice_ InformationStatusDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated &lt;seealso cref=&quot;AgentCAInformationStatusAdviceV01Document&quot;/&gt;, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AgentCAInformationStatusAdviceV01Document ToDocument()
    {
        return new AgentCAInformationStatusAdviceV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying &lt;seealso cref=&quot;AgentCAInformationStatusAdviceV01&quot;/&gt;.
/// </summary>
[Serializable]
public partial record AgentCAInformationStatusAdviceV01Document : IOuterDocument<AgentCAInformationStatusAdviceV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.024.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of &lt;seealso cref=&quot;AgentCAInformationStatusAdviceV01&quot;/&gt; is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AgentCAInformationStatusAdviceV01 Message { get; init; }
    #else
    public AgentCAInformationStatusAdviceV01 Message { get; init; }
    #endif
}
