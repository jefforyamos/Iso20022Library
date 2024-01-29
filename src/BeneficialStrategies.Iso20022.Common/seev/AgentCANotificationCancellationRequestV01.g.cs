﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AgentCANotificationCancellationRequestV01.  ISO2002 ID# _TRVISdEwEd-BzquC8wXy7w_1381384285.
//
namespace BeneficialStrategies.Iso20022.seev;

/// <summary>
/// Scope
/// This message is sent by an issuer (or its agent) to a CSD to request the cancellation of a notification advice message.
/// Usage
/// When this message is used to request the cancellation of a notification advice message, the function of the message must be cancellation.
/// When this message is used to request the withdrawal of a Corporate Action event or option, then the function of the message must be withdrawal.
/// In both cases, the building block notification advice identification must be present to link this cancellation request to the notification advice that was previously sent.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|This message is sent by an issuer (or its agent) to a CSD to request the cancellation of a notification advice message.|Usage|When this message is used to request the cancellation of a notification advice message, the function of the message must be cancellation.|When this message is used to request the withdrawal of a Corporate Action event or option, then the function of the message must be withdrawal.|In both cases, the building block notification advice identification must be present to link this cancellation request to the notification advice that was previously sent.")]
public partial record AgentCANotificationCancellationRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AgtCANtfctnCxlReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Identification assigned by the Sender to unambiguously identify the cancellation request.
    /// </summary>
    [IsoId("_TRVIStEwEd-BzquC8wXy7w_-958501125")]
    [Description(@"Identification assigned by the Sender to unambiguously identify the cancellation request.")]
    [DataMember(Name="Id")]
    [XmlElement(ElementName="Id")]
    [Required]
    public required SomeIdentificationRecord Identification { get; init; }
    
    /// <summary>
    /// Provides information about the type of notification cancellation request and linked message.
    /// </summary>
    [IsoId("_TRVIS9EwEd-BzquC8wXy7w_604000016")]
    [Description(@"Provides information about the type of notification cancellation request and linked message.")]
    [DataMember(Name="NtfctnCxlTpAndLkg")]
    [XmlElement(ElementName="NtfctnCxlTpAndLkg")]
    [Required]
    public required SomeNotificationCancellationTypeAndLinkageRecord NotificationCancellationTypeAndLinkage { get; init; }
    
    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_TRVITNEwEd-BzquC8wXy7w_-624173928")]
    [Description(@"General information about the corporate action event.")]
    [DataMember(Name="CorpActnGnlInf")]
    [XmlElement(ElementName="CorpActnGnlInf")]
    [Required]
    public required SomeCorporateActionGeneralInformationRecord CorporateActionGeneralInformation { get; init; }
    
    /// <summary>
    /// Detailed information of the notification advice to be cancelled.
    /// </summary>
    [IsoId("_TRVITdEwEd-BzquC8wXy7w_807888623")]
    [Description(@"Detailed information of the notification advice to be cancelled.")]
    [DataMember(Name="CorpActnNtfctnDtls")]
    [XmlElement(ElementName="CorpActnNtfctnDtls")]
    public SomeCorporateActionNotificationDetailsRecord? CorporateActionNotificationDetails { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AgentCANotificationCancellationRequestV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AgentCANotificationCancellationRequestV01Document ToDocument()
    {
        return new AgentCANotificationCancellationRequestV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AgentCANotificationCancellationRequestV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AgentCANotificationCancellationRequestV01Document : IOuterDocument<AgentCANotificationCancellationRequestV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.010.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AgentCANotificationCancellationRequestV01"/> is required.
    /// </summary>
    public required AgentCANotificationCancellationRequestV01 Message { get; init; }
}