﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AgentCANotificationAdviceV01.  ISO2002 ID# _TRBmS9EwEd-BzquC8wXy7w_-1004018302.
//
namespace BeneficialStrategies.Iso20022.seev;

/// <summary>
/// Scope
/// This message is sent by an issuer (or its agent) to a CSD to:
/// - Provide a CSD with the details of a corporate action along with the possible options available to the clients of that CSD; and
/// - to update a corporate action notification. A notification advice can be initially sent as a preliminary advice and subsequently replaced by another notification advice with updated information.
/// Usage
/// This message is used:
/// - to provide a CSD with the details of a corporate action along with the possible options available to the clients of that CSD. The information can be complete or incomplete.
/// - to update a corporate action notification advice. A notification advice can be initially sent as a preliminary advice and subsequently replaced by another notification advice with updated information. As per SMPG recommendation, all the information should be provided in the update, not only updated information.
/// An Agent Corporate Action Notification Status Advice is sent in reply to the Agent Corporate Action Notification Advice.
/// Note: The amendment of a corporate action notification is done through a replacement mechanism in line with both the ISO 15022 messages used in the flow between the CSD and its clients, and the ISO 20022 proxy voting messages.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|This message is sent by an issuer (or its agent) to a CSD to:|- Provide a CSD with the details of a corporate action along with the possible options available to the clients of that CSD; and|- to update a corporate action notification. A notification advice can be initially sent as a preliminary advice and subsequently replaced by another notification advice with updated information.|Usage|This message is used:|- to provide a CSD with the details of a corporate action along with the possible options available to the clients of that CSD. The information can be complete or incomplete.|- to update a corporate action notification advice. A notification advice can be initially sent as a preliminary advice and subsequently replaced by another notification advice with updated information. As per SMPG recommendation, all the information should be provided in the update, not only updated information.|An Agent Corporate Action Notification Status Advice is sent in reply to the Agent Corporate Action Notification Advice.|Note: The amendment of a corporate action notification is done through a replacement mechanism in line with both the ISO 15022 messages used in the flow between the CSD and its clients, and the ISO 20022 proxy voting messages.")]
public partial record AgentCANotificationAdviceV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AgtCANtfctnAdvc";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Identification assigned by the Sender to unambiguously identify the advice.
    /// </summary>
    [IsoId("_TRBmTNEwEd-BzquC8wXy7w_-1254952623")]
    [Description(@"Identification assigned by the Sender to unambiguously identify the advice.")]
    [DataMember(Name="Id")]
    [XmlElement(ElementName="Id")]
    [Required]
    public required SomeIdentificationRecord Identification { get; init; }
    
    /// <summary>
    /// Provides information about the type of notification advice and linked message.
    /// </summary>
    [IsoId("_TRBmTdEwEd-BzquC8wXy7w_1228461264")]
    [Description(@"Provides information about the type of notification advice and linked message.")]
    [DataMember(Name="NtfctnTpAndLkg")]
    [XmlElement(ElementName="NtfctnTpAndLkg")]
    [Required]
    public required SomeNotificationTypeAndLinkageRecord NotificationTypeAndLinkage { get; init; }
    
    /// <summary>
    /// Provides general information about the notification advice.
    /// </summary>
    [IsoId("_TRLXQNEwEd-BzquC8wXy7w_2096170446")]
    [Description(@"Provides general information about the notification advice.")]
    [DataMember(Name="NtfctnGnlInf")]
    [XmlElement(ElementName="NtfctnGnlInf")]
    [Required]
    public required SomeNotificationGeneralInformationRecord NotificationGeneralInformation { get; init; }
    
    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_TRLXQdEwEd-BzquC8wXy7w_1097129069")]
    [Description(@"General information about the corporate action event.")]
    [DataMember(Name="CorpActnGnlInf")]
    [XmlElement(ElementName="CorpActnGnlInf")]
    [Required]
    public required SomeCorporateActionGeneralInformationRecord CorporateActionGeneralInformation { get; init; }
    
    /// <summary>
    /// Provides details information about the CA event.
    /// </summary>
    [IsoId("_TRLXQtEwEd-BzquC8wXy7w_314771575")]
    [Description(@"Provides details information about the CA event.")]
    [DataMember(Name="CorpActnDtls")]
    [XmlElement(ElementName="CorpActnDtls")]
    [Required]
    public required SomeCorporateActionDetailsRecord CorporateActionDetails { get; init; }
    
    /// <summary>
    /// Provides detailed information about the option of the CA event.
    /// </summary>
    [IsoId("_TRLXQ9EwEd-BzquC8wXy7w_-153062975")]
    [Description(@"Provides detailed information about the option of the CA event.")]
    [DataMember(Name="CorpActnOptnDtls")]
    [XmlElement(ElementName="CorpActnOptnDtls")]
    public SomeCorporateActionOptionDetailsRecord? CorporateActionOptionDetails { get; init; }
    
    /// <summary>
    /// Provides information about the contact responsible for the transaction identified in the message.
    /// </summary>
    [IsoId("_TRLXRNEwEd-BzquC8wXy7w_1561246672")]
    [Description(@"Provides information about the contact responsible for the transaction identified in the message.")]
    [DataMember(Name="CtctDtls")]
    [XmlElement(ElementName="CtctDtls")]
    public SomeContactDetailsRecord? ContactDetails { get; init; }
    
    /// <summary>
    /// Provides additional information.
    /// </summary>
    [IsoId("_TRLXRdEwEd-BzquC8wXy7w_335889321")]
    [Description(@"Provides additional information.")]
    [DataMember(Name="AddtlInf")]
    [XmlElement(ElementName="AddtlInf")]
    public SomeAdditionalInformationRecord? AdditionalInformation { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AgentCANotificationAdviceV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AgentCANotificationAdviceV01Document ToDocument()
    {
        return new AgentCANotificationAdviceV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AgentCANotificationAdviceV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AgentCANotificationAdviceV01Document : IOuterDocument<AgentCANotificationAdviceV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.009.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AgentCANotificationAdviceV01"/> is required.
    /// </summary>
    public required AgentCANotificationAdviceV01 Message { get; init; }
}
