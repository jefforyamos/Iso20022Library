﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CorporateActionMovementPreliminaryAdviceV01.  ISO2002 ID# _Td_rSdEwEd-BzquC8wXy7w_1611787017.
//
namespace BeneficialStrategies.Iso20022.seev;

/// <summary>
/// Scope
/// An account servicer sends the CorporateActionMovementPreliminaryAdvice message to an account owner or its designated agent to pre-advise upcoming posting or reversal of securities and/or cash postings.
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent (the sub-function of the message is Duplicate),
/// - provide a third party with a copy of a message for information (the sub-function of the message is Copy),
/// - re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate).|ISO 15022 - 20022 COEXISTENCE|This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|An account servicer sends the CorporateActionMovementPreliminaryAdvice message to an account owner or its designated agent to pre-advise upcoming posting or reversal of securities and/or cash postings.|Usage|The message may also be used to:|- re-send a message previously sent (the sub-function of the message is Duplicate),|- provide a third party with a copy of a message for information (the sub-function of the message is Copy),|- re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate).|ISO 15022 - 20022 COEXISTENCE|This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”.")]
public partial record CorporateActionMovementPreliminaryAdviceV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CorpActnMvmntPrlimryAdvc";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Information that unambiguously identifies a CorporateActionMovementPreliminaryAdvice message as know by the account servicer.
    /// </summary>
    [IsoId("_Td_rStEwEd-BzquC8wXy7w_-1401758896")]
    [Description(@"Information that unambiguously identifies a CorporateActionMovementPreliminaryAdvice message as know by the account servicer.")]
    [DataMember(Name="Id")]
    [XmlElement(ElementName="Id")]
    [Required]
    public required DocumentIdentification11 Identification { get; init; }
    
    /// <summary>
    /// General information about the movement preliminary advice document.
    /// </summary>
    [IsoId("_Td_rS9EwEd-BzquC8wXy7w_993770368")]
    [Description(@"General information about the movement preliminary advice document.")]
    [DataMember(Name="MvmntPrlimryAdvcGnlInf")]
    [XmlElement(ElementName="MvmntPrlimryAdvcGnlInf")]
    [Required]
    public required CorporateActionPreliminaryAdviceType1 MovementPreliminaryAdviceGeneralInformation { get; init; }
    
    /// <summary>
    /// Identification of a previously sent movement preliminary advice document.
    /// </summary>
    [IsoId("_TeI1MNEwEd-BzquC8wXy7w_-387727187")]
    [Description(@"Identification of a previously sent movement preliminary advice document.")]
    [DataMember(Name="PrvsMvmntPrlimryAdvcId")]
    [XmlElement(ElementName="PrvsMvmntPrlimryAdvcId")]
    public DocumentIdentification15? PreviousMovementPreliminaryAdviceIdentification { get; init; }
    
    /// <summary>
    /// Identification of a previously sent notification document.
    /// </summary>
    [IsoId("_TeI1MdEwEd-BzquC8wXy7w_-1346344232")]
    [Description(@"Identification of a previously sent notification document.")]
    [DataMember(Name="NtfctnId")]
    [XmlElement(ElementName="NtfctnId")]
    public DocumentIdentification15? NotificationIdentification { get; init; }
    
    /// <summary>
    /// Identification of a previously sent movement confirmation document.
    /// </summary>
    [IsoId("_TeI1MtEwEd-BzquC8wXy7w_-636936703")]
    [Description(@"Identification of a previously sent movement confirmation document.")]
    [DataMember(Name="MvmntConfId")]
    [XmlElement(ElementName="MvmntConfId")]
    public DocumentIdentification15? MovementConfirmationIdentification { get; init; }
    
    /// <summary>
    /// Identification of a related instruction document.
    /// </summary>
    [IsoId("_TeI1M9EwEd-BzquC8wXy7w_-988020441")]
    [Description(@"Identification of a related instruction document.")]
    [DataMember(Name="InstrId")]
    [XmlElement(ElementName="InstrId")]
    public DocumentIdentification9? InstructionIdentification { get; init; }
    
    /// <summary>
    /// Identification of other documents as well as the document number.
    /// </summary>
    [IsoId("_TeI1NNEwEd-BzquC8wXy7w_-576128180")]
    [Description(@"Identification of other documents as well as the document number.")]
    [DataMember(Name="OthrDocId")]
    [XmlElement(ElementName="OthrDocId")]
    public DocumentIdentification13? OtherDocumentIdentification { get; init; }
    
    /// <summary>
    /// Identification of an other corporate action event that needs to be closely linked to the processing of the event notified in this document.
    /// </summary>
    [IsoId("_TeI1NdEwEd-BzquC8wXy7w_1397891250")]
    [Description(@"Identification of an other corporate action event that needs to be closely linked to the processing of the event notified in this document.")]
    [DataMember(Name="EvtsLkg")]
    [XmlElement(ElementName="EvtsLkg")]
    public CorporateActionEventReference1? EventsLinkage { get; init; }
    
    /// <summary>
    /// Reason for the reversal.
    /// </summary>
    [IsoId("_TeI1NtEwEd-BzquC8wXy7w_1632045745")]
    [Description(@"Reason for the reversal.")]
    [DataMember(Name="RvslRsn")]
    [XmlElement(ElementName="RvslRsn")]
    public CorporateActionReversalReason1? ReversalReason { get; init; }
    
    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_TeI1N9EwEd-BzquC8wXy7w_1471771489")]
    [Description(@"General information about the corporate action event.")]
    [DataMember(Name="CorpActnGnlInf")]
    [XmlElement(ElementName="CorpActnGnlInf")]
    [Required]
    public required CorporateActionGeneralInformation3 CorporateActionGeneralInformation { get; init; }
    
    /// <summary>
    /// General information about the safekeeping account, owner and account balance.
    /// </summary>
    [IsoId("_TeSmMNEwEd-BzquC8wXy7w_-1655864801")]
    [Description(@"General information about the safekeeping account, owner and account balance.")]
    [DataMember(Name="AcctDtls")]
    [XmlElement(ElementName="AcctDtls")]
    [Required]
    public required IAccountIdentification7Choice AccountDetails { get; init; }
    
    /// <summary>
    /// Information about the corporate action option.
    /// </summary>
    [IsoId("_TeSmMdEwEd-BzquC8wXy7w_-1840834741")]
    [Description(@"Information about the corporate action option.")]
    [DataMember(Name="CorpActnMvmntDtls")]
    [XmlElement(ElementName="CorpActnMvmntDtls")]
    public CorporateActionOption10? CorporateActionMovementDetails { get; init; }
    
    /// <summary>
    /// Provides additional information.
    /// </summary>
    [IsoId("_TeSmMtEwEd-BzquC8wXy7w_248559991")]
    [Description(@"Provides additional information.")]
    [DataMember(Name="AddtlInf")]
    [XmlElement(ElementName="AddtlInf")]
    public CorporateActionNarrative6? AdditionalInformation { get; init; }
    
    /// <summary>
    /// Party that originated the message, if other than the sender.
    /// </summary>
    [IsoId("_TeSmM9EwEd-BzquC8wXy7w_994766215")]
    [Description(@"Party that originated the message, if other than the sender.")]
    [DataMember(Name="MsgOrgtr")]
    [XmlElement(ElementName="MsgOrgtr")]
    public IPartyIdentification10Choice? MessageOriginator { get; init; }
    
    /// <summary>
    /// Party that is the final destination of the message, if other than the receiver.
    /// </summary>
    [IsoId("_TeSmNNEwEd-BzquC8wXy7w_1065877947")]
    [Description(@"Party that is the final destination of the message, if other than the receiver.")]
    [DataMember(Name="MsgRcpt")]
    [XmlElement(ElementName="MsgRcpt")]
    public IPartyIdentification10Choice? MessageRecipient { get; init; }
    
    /// <summary>
    /// Party appointed to administer the event on behalf of the issuer company/offeror. The party may be contacted for more information about the event.
    /// </summary>
    [IsoId("_TeSmNdEwEd-BzquC8wXy7w_1118516589")]
    [Description(@"Party appointed to administer the event on behalf of the issuer company/offeror. The party may be contacted for more information about the event.")]
    [DataMember(Name="IssrAgt")]
    [XmlElement(ElementName="IssrAgt")]
    public IPartyIdentification10Choice? IssuerAgent { get; init; }
    
    /// <summary>
    /// Agent (principal or fiscal paying agent) appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.
    /// </summary>
    [IsoId("_TeSmNtEwEd-BzquC8wXy7w_1390957641")]
    [Description(@"Agent (principal or fiscal paying agent) appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.")]
    [DataMember(Name="PngAgt")]
    [XmlElement(ElementName="PngAgt")]
    public IPartyIdentification10Choice? PayingAgent { get; init; }
    
    /// <summary>
    /// Sub-agent appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.
    /// </summary>
    [IsoId("_TeSmN9EwEd-BzquC8wXy7w_1432514283")]
    [Description(@"Sub-agent appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.")]
    [DataMember(Name="SubPngAgt")]
    [XmlElement(ElementName="SubPngAgt")]
    public IPartyIdentification10Choice? SubPayingAgent { get; init; }
    
    /// <summary>
    /// Party/agent responsible for maintaining the register of a security.
    /// </summary>
    [IsoId("_TecXMNEwEd-BzquC8wXy7w_686181954")]
    [Description(@"Party/agent responsible for maintaining the register of a security.")]
    [DataMember(Name="Regar")]
    [XmlElement(ElementName="Regar")]
    public IPartyIdentification10Choice? Registrar { get; init; }
    
    /// <summary>
    /// A broker-dealer responsible for reselling to new investors securities (usually bonds) that have been tendered for purchase by their owner.
    /// </summary>
    [IsoId("_TecXMdEwEd-BzquC8wXy7w_-157068985")]
    [Description(@"A broker-dealer responsible for reselling to new investors securities (usually bonds) that have been tendered for purchase by their owner.")]
    [DataMember(Name="RsellngAgt")]
    [XmlElement(ElementName="RsellngAgt")]
    public IPartyIdentification10Choice? ResellingAgent { get; init; }
    
    /// <summary>
    /// A trust company, bank or similar financial institution assigned by an issuer to accept presentations of instruments, usually bonds, for transfer and or exchange.
    /// </summary>
    [IsoId("_TecXMtEwEd-BzquC8wXy7w_-920819365")]
    [Description(@"A trust company, bank or similar financial institution assigned by an issuer to accept presentations of instruments, usually bonds, for transfer and or exchange.")]
    [DataMember(Name="PhysSctiesAgt")]
    [XmlElement(ElementName="PhysSctiesAgt")]
    public IPartyIdentification10Choice? PhysicalSecuritiesAgent { get; init; }
    
    /// <summary>
    /// A trust company, bank or similar financial institution who acts on behalf of an out of town agent or event agent where securities can be delivered in person.
    /// </summary>
    [IsoId("_TecXM9EwEd-BzquC8wXy7w_-1003015589")]
    [Description(@"A trust company, bank or similar financial institution who acts on behalf of an out of town agent or event agent where securities can be delivered in person.")]
    [DataMember(Name="DrpAgt")]
    [XmlElement(ElementName="DrpAgt")]
    public IPartyIdentification10Choice? DropAgent { get; init; }
    
    /// <summary>
    /// A trust company, bank or similar financial institution assigned by an issuer to maintain records of investors and account balances and transactions for the consent of a material change.
    /// </summary>
    [IsoId("_TecXNNEwEd-BzquC8wXy7w_-145987139")]
    [Description(@"A trust company, bank or similar financial institution assigned by an issuer to maintain records of investors and account balances and transactions for the consent of a material change.")]
    [DataMember(Name="SlctnAgt")]
    [XmlElement(ElementName="SlctnAgt")]
    public IPartyIdentification10Choice? SolicitationAgent { get; init; }
    
    /// <summary>
    /// A trust company, bank or similar financial institution assigned by an Issuer to provide information and copies of the offering documentation.
    /// </summary>
    [IsoId("_TecXNdEwEd-BzquC8wXy7w_-117359460")]
    [Description(@"A trust company, bank or similar financial institution assigned by an Issuer to provide information and copies of the offering documentation.")]
    [DataMember(Name="InfAgt")]
    [XmlElement(ElementName="InfAgt")]
    public IPartyIdentification10Choice? InformationAgent { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_TecXNtEwEd-BzquC8wXy7w_733410265")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="Xtnsn")]
    [XmlElement(ElementName="Xtnsn")]
    public Extension2? Extension { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CorporateActionMovementPreliminaryAdviceV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CorporateActionMovementPreliminaryAdviceV01Document ToDocument()
    {
        return new CorporateActionMovementPreliminaryAdviceV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CorporateActionMovementPreliminaryAdviceV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record CorporateActionMovementPreliminaryAdviceV01Document : IOuterDocument<CorporateActionMovementPreliminaryAdviceV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.035.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CorporateActionMovementPreliminaryAdviceV01"/> is required.
    /// </summary>
    public required CorporateActionMovementPreliminaryAdviceV01 Message { get; init; }
}
