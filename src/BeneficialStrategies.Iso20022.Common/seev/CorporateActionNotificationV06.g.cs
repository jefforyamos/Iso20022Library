﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CorporateActionNotificationV06.  ISO2002 ID# _Rc5ogTm_EeWENZE2jGFgGw.
//
namespace BeneficialStrategies.Iso20022.seev;

/// <summary>
/// Scope
/// An account servicer sends the CorporateActionNotification message to an account owner or its designated agent to notify details of a corporate action event and optionally account information, eligible balance and entitlements.|
/// It may also include possible elections or choices available to the account owner. The account servicer can initially send the CorporateActionNotification message as a preliminary advice, subsequently replaced by another CorporateActionNotification message with complete or confirmed information.|
/// It may also be sent to an account owner or its designated agent, to remind of event details and/or of missing or incomplete instructions for a corporate action event.
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent (the sub-function of the message is Duplicate),
/// - provide a third party with a copy of a message for information (the sub-function of the message is Copy),
/// - re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate),
/// using the relevant elements in the business application header (BAH).
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|An account servicer sends the CorporateActionNotification message to an account owner or its designated agent to notify details of a corporate action event and optionally account information, eligible balance and entitlements.||It may also include possible elections or choices available to the account owner. The account servicer can initially send the CorporateActionNotification message as a preliminary advice, subsequently replaced by another CorporateActionNotification message with complete or confirmed information.||It may also be sent to an account owner or its designated agent, to remind of event details and/or of missing or incomplete instructions for a corporate action event.|Usage|The message may also be used to:|- re-send a message previously sent (the sub-function of the message is Duplicate),|- provide a third party with a copy of a message for information (the sub-function of the message is Copy),|- re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate),|using the relevant elements in the business application header (BAH).")]
public partial record CorporateActionNotificationV06 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CorpActnNtfctn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Page number of the message and continuation indicator to indicate that the multi-parts notification is to continue or that the message is the last page of the multi-parts notification.
    /// </summary>
    [IsoId("_Rc5oqzm_EeWENZE2jGFgGw")]
    [Description(@"Page number of the message and continuation indicator to indicate that the multi-parts notification is to continue or that the message is the last page of the multi-parts notification.")]
    [DataMember(Name="Pgntn")]
    [XmlElement(ElementName="Pgntn")]
    public SomePaginationRecord? Pagination { get; init; }
    
    /// <summary>
    /// General information about the event notification type, status and contents.
    /// </summary>
    [IsoId("_Rc5orTm_EeWENZE2jGFgGw")]
    [Description(@"General information about the event notification type, status and contents.")]
    [DataMember(Name="NtfctnGnlInf")]
    [XmlElement(ElementName="NtfctnGnlInf")]
    [Required]
    public required SomeNotificationGeneralInformationRecord NotificationGeneralInformation { get; init; }
    
    /// <summary>
    /// Identification of a previously sent notification document.
    /// </summary>
    [IsoId("_Rc5orzm_EeWENZE2jGFgGw")]
    [Description(@"Identification of a previously sent notification document.")]
    [DataMember(Name="PrvsNtfctnId")]
    [XmlElement(ElementName="PrvsNtfctnId")]
    public SomePreviousNotificationIdentificationRecord? PreviousNotificationIdentification { get; init; }
    
    /// <summary>
    /// Identification of a related instruction document.
    /// </summary>
    [IsoId("_Rc5osTm_EeWENZE2jGFgGw")]
    [Description(@"Identification of a related instruction document.")]
    [DataMember(Name="InstrId")]
    [XmlElement(ElementName="InstrId")]
    public SomeInstructionIdentificationRecord? InstructionIdentification { get; init; }
    
    /// <summary>
    /// Identification of other documents as well as the document number.
    /// </summary>
    [IsoId("_Rc5oszm_EeWENZE2jGFgGw")]
    [Description(@"Identification of other documents as well as the document number.")]
    [DataMember(Name="OthrDocId")]
    [XmlElement(ElementName="OthrDocId")]
    public SomeOtherDocumentIdentificationRecord? OtherDocumentIdentification { get; init; }
    
    /// <summary>
    /// Identification of an other corporate action event that needs to be closely linked to the processing of the event notified in this document.
    /// </summary>
    [IsoId("_Rc5otTm_EeWENZE2jGFgGw")]
    [Description(@"Identification of an other corporate action event that needs to be closely linked to the processing of the event notified in this document.")]
    [DataMember(Name="EvtsLkg")]
    [XmlElement(ElementName="EvtsLkg")]
    public SomeEventsLinkageRecord? EventsLinkage { get; init; }
    
    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_Rc5otzm_EeWENZE2jGFgGw")]
    [Description(@"General information about the corporate action event.")]
    [DataMember(Name="CorpActnGnlInf")]
    [XmlElement(ElementName="CorpActnGnlInf")]
    [Required]
    public required SomeCorporateActionGeneralInformationRecord CorporateActionGeneralInformation { get; init; }
    
    /// <summary>
    /// General information about the safekeeping account, owner and account balance.
    /// </summary>
    [IsoId("_Rc5ouTm_EeWENZE2jGFgGw")]
    [Description(@"General information about the safekeeping account, owner and account balance.")]
    [DataMember(Name="AcctDtls")]
    [XmlElement(ElementName="AcctDtls")]
    [Required]
    public required SomeAccountDetailsRecord AccountDetails { get; init; }
    
    /// <summary>
    /// Provides details on rights credited to the account as for instance trading period, expiry date, renounceability.
    /// </summary>
    [IsoId("_Rc5ouzm_EeWENZE2jGFgGw")]
    [Description(@"Provides details on rights credited to the account as for instance trading period, expiry date, renounceability.")]
    [DataMember(Name="IntrmdtScty")]
    [XmlElement(ElementName="IntrmdtScty")]
    public SomeIntermediateSecurityRecord? IntermediateSecurity { get; init; }
    
    /// <summary>
    /// Information about the corporate action event.
    /// </summary>
    [IsoId("_Rc5ovTm_EeWENZE2jGFgGw")]
    [Description(@"Information about the corporate action event.")]
    [DataMember(Name="CorpActnDtls")]
    [XmlElement(ElementName="CorpActnDtls")]
    public SomeCorporateActionDetailsRecord? CorporateActionDetails { get; init; }
    
    /// <summary>
    /// Information about the corporate action option.
    /// </summary>
    [IsoId("_Rc5ovzm_EeWENZE2jGFgGw")]
    [Description(@"Information about the corporate action option.")]
    [DataMember(Name="CorpActnOptnDtls")]
    [XmlElement(ElementName="CorpActnOptnDtls")]
    public SomeCorporateActionOptionDetailsRecord? CorporateActionOptionDetails { get; init; }
    
    /// <summary>
    /// Provides additional information.
    /// </summary>
    [IsoId("_Rc5owTm_EeWENZE2jGFgGw")]
    [Description(@"Provides additional information.")]
    [DataMember(Name="AddtlInf")]
    [XmlElement(ElementName="AddtlInf")]
    public SomeAdditionalInformationRecord? AdditionalInformation { get; init; }
    
    /// <summary>
    /// Party appointed to administer the event on behalf of the issuer company/offeror. The party may be contacted for more information about the event.
    /// </summary>
    [IsoId("_Rc5owzm_EeWENZE2jGFgGw")]
    [Description(@"Party appointed to administer the event on behalf of the issuer company/offeror. The party may be contacted for more information about the event.")]
    [DataMember(Name="IssrAgt")]
    [XmlElement(ElementName="IssrAgt")]
    public SomeIssuerAgentRecord? IssuerAgent { get; init; }
    
    /// <summary>
    /// Agent (principal or fiscal paying agent) appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.
    /// </summary>
    [IsoId("_Rc5oxTm_EeWENZE2jGFgGw")]
    [Description(@"Agent (principal or fiscal paying agent) appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.")]
    [DataMember(Name="PngAgt")]
    [XmlElement(ElementName="PngAgt")]
    public SomePayingAgentRecord? PayingAgent { get; init; }
    
    /// <summary>
    /// Sub-agent appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.
    /// </summary>
    [IsoId("_Rc5oxzm_EeWENZE2jGFgGw")]
    [Description(@"Sub-agent appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.")]
    [DataMember(Name="SubPngAgt")]
    [XmlElement(ElementName="SubPngAgt")]
    public SomeSubPayingAgentRecord? SubPayingAgent { get; init; }
    
    /// <summary>
    /// Party/agent responsible for maintaining the register of a security.
    /// </summary>
    [IsoId("_Rc5oyTm_EeWENZE2jGFgGw")]
    [Description(@"Party/agent responsible for maintaining the register of a security.")]
    [DataMember(Name="Regar")]
    [XmlElement(ElementName="Regar")]
    public SomeRegistrarRecord? Registrar { get; init; }
    
    /// <summary>
    /// A broker-dealer responsible for reselling to new investors securities (usually bonds) that have been tendered for purchase by their owner.
    /// </summary>
    [IsoId("_Rc5oyzm_EeWENZE2jGFgGw")]
    [Description(@"A broker-dealer responsible for reselling to new investors securities (usually bonds) that have been tendered for purchase by their owner.")]
    [DataMember(Name="RsellngAgt")]
    [XmlElement(ElementName="RsellngAgt")]
    public SomeResellingAgentRecord? ResellingAgent { get; init; }
    
    /// <summary>
    /// A trust company, bank or similar financial institution assigned by an issuer to accept presentations of instruments, usually bonds, for transfer and or exchange.
    /// </summary>
    [IsoId("_Rc5ozTm_EeWENZE2jGFgGw")]
    [Description(@"A trust company, bank or similar financial institution assigned by an issuer to accept presentations of instruments, usually bonds, for transfer and or exchange.")]
    [DataMember(Name="PhysSctiesAgt")]
    [XmlElement(ElementName="PhysSctiesAgt")]
    public SomePhysicalSecuritiesAgentRecord? PhysicalSecuritiesAgent { get; init; }
    
    /// <summary>
    /// A trust company, bank or similar financial institution who acts on behalf of an out of town agent or event agent where securities can be delivered in person.
    /// </summary>
    [IsoId("_Rc5ozzm_EeWENZE2jGFgGw")]
    [Description(@"A trust company, bank or similar financial institution who acts on behalf of an out of town agent or event agent where securities can be delivered in person.")]
    [DataMember(Name="DrpAgt")]
    [XmlElement(ElementName="DrpAgt")]
    public SomeDropAgentRecord? DropAgent { get; init; }
    
    /// <summary>
    /// A trust company, bank or similar financial institution assigned by an issuer to maintain records of investors and account balances and transactions for the consent of a material change.
    /// </summary>
    [IsoId("_Rc5o0Tm_EeWENZE2jGFgGw")]
    [Description(@"A trust company, bank or similar financial institution assigned by an issuer to maintain records of investors and account balances and transactions for the consent of a material change.")]
    [DataMember(Name="SlctnAgt")]
    [XmlElement(ElementName="SlctnAgt")]
    public SomeSolicitationAgentRecord? SolicitationAgent { get; init; }
    
    /// <summary>
    /// A trust company, bank or similar financial institution assigned by an Issuer to provide information and copies of the offering documentation.
    /// </summary>
    [IsoId("_Rc5o0zm_EeWENZE2jGFgGw")]
    [Description(@"A trust company, bank or similar financial institution assigned by an Issuer to provide information and copies of the offering documentation.")]
    [DataMember(Name="InfAgt")]
    [XmlElement(ElementName="InfAgt")]
    public SomeInformationAgentRecord? InformationAgent { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_Rc5o1Tm_EeWENZE2jGFgGw")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CorporateActionNotificationV06Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CorporateActionNotificationV06Document ToDocument()
    {
        return new CorporateActionNotificationV06Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CorporateActionNotificationV06"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record CorporateActionNotificationV06Document : IOuterDocument<CorporateActionNotificationV06>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.031.001.06";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CorporateActionNotificationV06"/> is required.
    /// </summary>
    public required CorporateActionNotificationV06 Message { get; init; }
}
