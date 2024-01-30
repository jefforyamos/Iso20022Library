﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CorporateActionNotification002V10.  ISO2002 ID# _00UlUwVTEeqjd8n6wD9JVw.
//
namespace BeneficialStrategies.Iso20022.seev;

/// <summary>
/// Scope
/// The CorporateActionNotification message is sent by an account servicer to an account owner or its designated agent to notify details of a corporate action event and optionally account information, eligible balance and entitlements.|
/// It may also include possible elections or choices available to the account owner. The account servicer can initially send the CorporateActionNotification message as a preliminary advice, subsequently replaced by another CorporateActionNotification message with complete or confirmed information.|
/// It may also be sent to an account owner or its designated agent, to remind of event details and/or of missing or incomplete instructions for a corporate action event.
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent (the sub-function of the message is Duplicate),
/// - provide a third party with a copy of a message for information (the sub-function of the message is Copy),
/// - re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate), using the relevant elements in the business application header (BAH).
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The CorporateActionNotification message is sent by an account servicer to an account owner or its designated agent to notify details of a corporate action event and optionally account information, eligible balance and entitlements.||It may also include possible elections or choices available to the account owner. The account servicer can initially send the CorporateActionNotification message as a preliminary advice, subsequently replaced by another CorporateActionNotification message with complete or confirmed information.||It may also be sent to an account owner or its designated agent, to remind of event details and/or of missing or incomplete instructions for a corporate action event.|Usage|The message may also be used to:|- re-send a message previously sent (the sub-function of the message is Duplicate),|- provide a third party with a copy of a message for information (the sub-function of the message is Copy),|- re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate), using the relevant elements in the business application header (BAH).")]
public partial record CorporateActionNotification002V10 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CorpActnNtfctn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Page number of the message and continuation indicator to indicate that the multi-part notification is to continue or that the message is the last page of the multi-part notification.
    /// </summary>
    [IsoId("_00UlfwVTEeqjd8n6wD9JVw")]
    [Description(@"Page number of the message and continuation indicator to indicate that the multi-part notification is to continue or that the message is the last page of the multi-part notification.")]
    [DataMember(Name="Pgntn")]
    [XmlElement(ElementName="Pgntn")]
    public Pagination1? Pagination { get; init; }
    
    /// <summary>
    /// General information about the event notification type, status and contents.
    /// </summary>
    [IsoId("_00UlgQVTEeqjd8n6wD9JVw")]
    [Description(@"General information about the event notification type, status and contents.")]
    [DataMember(Name="NtfctnGnlInf")]
    [XmlElement(ElementName="NtfctnGnlInf")]
    [Required]
    public required CorporateActionNotification6 NotificationGeneralInformation { get; init; }
    
    /// <summary>
    /// Identification of a previously sent notification document.
    /// </summary>
    [IsoId("_00UlgwVTEeqjd8n6wD9JVw")]
    [Description(@"Identification of a previously sent notification document.")]
    [DataMember(Name="PrvsNtfctnId")]
    [XmlElement(ElementName="PrvsNtfctnId")]
    public DocumentIdentification37? PreviousNotificationIdentification { get; init; }
    
    /// <summary>
    /// Identification of a related instruction document.
    /// </summary>
    [IsoId("_00UlhQVTEeqjd8n6wD9JVw")]
    [Description(@"Identification of a related instruction document.")]
    [DataMember(Name="InstrId")]
    [XmlElement(ElementName="InstrId")]
    public DocumentIdentification17? InstructionIdentification { get; init; }
    
    /// <summary>
    /// Identification of other documents as well as the document number.
    /// </summary>
    [IsoId("_00UlhwVTEeqjd8n6wD9JVw")]
    [Description(@"Identification of other documents as well as the document number.")]
    [DataMember(Name="OthrDocId")]
    [XmlElement(ElementName="OthrDocId")]
    public DocumentIdentification38? OtherDocumentIdentification { get; init; }
    
    /// <summary>
    /// Identification of another corporate action event that needs to be closely linked to the processing of the event notified in this document.
    /// </summary>
    [IsoId("_00UliQVTEeqjd8n6wD9JVw")]
    [Description(@"Identification of another corporate action event that needs to be closely linked to the processing of the event notified in this document.")]
    [DataMember(Name="EvtsLkg")]
    [XmlElement(ElementName="EvtsLkg")]
    public CorporateActionEventReference4? EventsLinkage { get; init; }
    
    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_00UliwVTEeqjd8n6wD9JVw")]
    [Description(@"General information about the corporate action event.")]
    [DataMember(Name="CorpActnGnlInf")]
    [XmlElement(ElementName="CorpActnGnlInf")]
    [Required]
    public required CorporateActionGeneralInformation153 CorporateActionGeneralInformation { get; init; }
    
    /// <summary>
    /// General information about the safekeeping account, owner and account balance.
    /// </summary>
    [IsoId("_00UljQVTEeqjd8n6wD9JVw")]
    [Description(@"General information about the safekeeping account, owner and account balance.")]
    [DataMember(Name="AcctDtls")]
    [XmlElement(ElementName="AcctDtls")]
    [Required]
    public required IAccountIdentification45Choice AccountDetails { get; init; }
    
    /// <summary>
    /// Details on rights credited to the account as for instance trading period, expiry date, renounceability.
    /// </summary>
    [IsoId("_00UljwVTEeqjd8n6wD9JVw")]
    [Description(@"Details on rights credited to the account as for instance trading period, expiry date, renounceability.")]
    [DataMember(Name="IntrmdtScty")]
    [XmlElement(ElementName="IntrmdtScty")]
    public FinancialInstrumentAttributes94? IntermediateSecurity { get; init; }
    
    /// <summary>
    /// Information about the corporate action event.
    /// </summary>
    [IsoId("_00UlkQVTEeqjd8n6wD9JVw")]
    [Description(@"Information about the corporate action event.")]
    [DataMember(Name="CorpActnDtls")]
    [XmlElement(ElementName="CorpActnDtls")]
    public CorporateAction55? CorporateActionDetails { get; init; }
    
    /// <summary>
    /// Information about the corporate action option.
    /// </summary>
    [IsoId("_00UlkwVTEeqjd8n6wD9JVw")]
    [Description(@"Information about the corporate action option.")]
    [DataMember(Name="CorpActnOptnDtls")]
    [XmlElement(ElementName="CorpActnOptnDtls")]
    public CorporateActionOption176? CorporateActionOptionDetails { get; init; }
    
    /// <summary>
    /// Additional information on the event.
    /// </summary>
    [IsoId("_00UllQVTEeqjd8n6wD9JVw")]
    [Description(@"Additional information on the event.")]
    [DataMember(Name="AddtlInf")]
    [XmlElement(ElementName="AddtlInf")]
    public CorporateActionNarrative43? AdditionalInformation { get; init; }
    
    /// <summary>
    /// Party appointed to administer the event on behalf of the issuer company/offeror. The party may be contacted for more information about the event.
    /// </summary>
    [IsoId("_00UllwVTEeqjd8n6wD9JVw")]
    [Description(@"Party appointed to administer the event on behalf of the issuer company/offeror. The party may be contacted for more information about the event.")]
    [DataMember(Name="IssrAgt")]
    [XmlElement(ElementName="IssrAgt")]
    public IPartyIdentification151Choice? IssuerAgent { get; init; }
    
    /// <summary>
    /// Agent (principal or fiscal paying agent) appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.
    /// </summary>
    [IsoId("_00UlmQVTEeqjd8n6wD9JVw")]
    [Description(@"Agent (principal or fiscal paying agent) appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.")]
    [DataMember(Name="PngAgt")]
    [XmlElement(ElementName="PngAgt")]
    public IPartyIdentification137Choice? PayingAgent { get; init; }
    
    /// <summary>
    /// Sub-agent appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.
    /// </summary>
    [IsoId("_00UlmwVTEeqjd8n6wD9JVw")]
    [Description(@"Sub-agent appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.")]
    [DataMember(Name="SubPngAgt")]
    [XmlElement(ElementName="SubPngAgt")]
    public IPartyIdentification137Choice? SubPayingAgent { get; init; }
    
    /// <summary>
    /// Party/agent responsible for maintaining the register of the security.
    /// </summary>
    [IsoId("_00UlnQVTEeqjd8n6wD9JVw")]
    [Description(@"Party/agent responsible for maintaining the register of the security.")]
    [DataMember(Name="Regar")]
    [XmlElement(ElementName="Regar")]
    public IPartyIdentification137Choice? Registrar { get; init; }
    
    /// <summary>
    /// Broker-dealer responsible for reselling to new investors securities (usually bonds) that have been tendered for purchase by their owner.
    /// </summary>
    [IsoId("_00UlnwVTEeqjd8n6wD9JVw")]
    [Description(@"Broker-dealer responsible for reselling to new investors securities (usually bonds) that have been tendered for purchase by their owner.")]
    [DataMember(Name="RsellngAgt")]
    [XmlElement(ElementName="RsellngAgt")]
    public IPartyIdentification137Choice? ResellingAgent { get; init; }
    
    /// <summary>
    /// A trust company, bank or similar financial institution assigned by an issuer to accept presentations of instruments, usually bonds, for transfer and or exchange.
    /// </summary>
    [IsoId("_00UloQVTEeqjd8n6wD9JVw")]
    [Description(@"A trust company, bank or similar financial institution assigned by an issuer to accept presentations of instruments, usually bonds, for transfer and or exchange.")]
    [DataMember(Name="PhysSctiesAgt")]
    [XmlElement(ElementName="PhysSctiesAgt")]
    public IPartyIdentification137Choice? PhysicalSecuritiesAgent { get; init; }
    
    /// <summary>
    /// A trust company, bank or similar financial institution that acts on behalf of an out-of-town agent or event agent where securities can be delivered in person.
    /// </summary>
    [IsoId("_00UlowVTEeqjd8n6wD9JVw")]
    [Description(@"A trust company, bank or similar financial institution that acts on behalf of an out-of-town agent or event agent where securities can be delivered in person.")]
    [DataMember(Name="DrpAgt")]
    [XmlElement(ElementName="DrpAgt")]
    public IPartyIdentification137Choice? DropAgent { get; init; }
    
    /// <summary>
    /// A trust company, bank or similar financial institution assigned by an issuer to maintain records of investors and account balances and transactions for the consent of a material change.
    /// </summary>
    [IsoId("_00UlpQVTEeqjd8n6wD9JVw")]
    [Description(@"A trust company, bank or similar financial institution assigned by an issuer to maintain records of investors and account balances and transactions for the consent of a material change.")]
    [DataMember(Name="SlctnAgt")]
    [XmlElement(ElementName="SlctnAgt")]
    public IPartyIdentification137Choice? SolicitationAgent { get; init; }
    
    /// <summary>
    /// A trust company, bank or similar financial institution assigned by an Issuer to provide information and copies of the offering documentation.
    /// </summary>
    [IsoId("_00UlpwVTEeqjd8n6wD9JVw")]
    [Description(@"A trust company, bank or similar financial institution assigned by an Issuer to provide information and copies of the offering documentation.")]
    [DataMember(Name="InfAgt")]
    [XmlElement(ElementName="InfAgt")]
    public IPartyIdentification137Choice? InformationAgent { get; init; }
    
    /// <summary>
    /// Issuer of the financial instrument.
    /// </summary>
    [IsoId("_00UlqQVTEeqjd8n6wD9JVw")]
    [Description(@"Issuer of the financial instrument.")]
    [DataMember(Name="Issr")]
    [XmlElement(ElementName="Issr")]
    public IPartyIdentification151Choice? Issuer { get; init; }
    
    /// <summary>
    /// Party making the offer and which is different from the issuing company.
    /// </summary>
    [IsoId("_00UlqwVTEeqjd8n6wD9JVw")]
    [Description(@"Party making the offer and which is different from the issuing company.")]
    [DataMember(Name="Offerr")]
    [XmlElement(ElementName="Offerr")]
    public IPartyIdentification151Choice? Offeror { get; init; }
    
    /// <summary>
    /// A trust company, bank or similar financial institution appointed by a fund management company to maintain records of investors and account balances. The transfer agent records transactions, including subscriptions, redemptions, switches, transfers, and re-registrations.
    /// </summary>
    [IsoId("_00UlrQVTEeqjd8n6wD9JVw")]
    [Description(@"A trust company, bank or similar financial institution appointed by a fund management company to maintain records of investors and account balances. The transfer agent records transactions, including subscriptions, redemptions, switches, transfers, and re-registrations.")]
    [DataMember(Name="TrfAgt")]
    [XmlElement(ElementName="TrfAgt")]
    public IPartyIdentification151Choice? TransferAgent { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_00UlrwVTEeqjd8n6wD9JVw")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CorporateActionNotification002V10Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CorporateActionNotification002V10Document ToDocument()
    {
        return new CorporateActionNotification002V10Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CorporateActionNotification002V10"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record CorporateActionNotification002V10Document : IOuterDocument<CorporateActionNotification002V10>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.031.002.10";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CorporateActionNotification002V10"/> is required.
    /// </summary>
    public required CorporateActionNotification002V10 Message { get; init; }
}
