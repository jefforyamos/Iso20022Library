﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CorporateActionMovementReversalAdviceV01.  ISO2002 ID# _Tfxz_tEwEd-BzquC8wXy7w_-2083816174.
//
namespace BeneficialStrategies.Iso20022.seev;

/// <summary>
/// Scope
/// An account servicer sends the CorporateActionMovementReversalAdvice message to an account owner or its designated agent to reverse previously confirmed posting of securities or cash.
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent (the sub-function of the message is Duplicate),
/// - provide a third party with a copy of a message for information (the sub-function of the message is Copy),
/// - re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate).|ISO 15022 - 20022 COEXISTENCE|This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|An account servicer sends the CorporateActionMovementReversalAdvice message to an account owner or its designated agent to reverse previously confirmed posting of securities or cash.|Usage|The message may also be used to:|- re-send a message previously sent (the sub-function of the message is Duplicate),|- provide a third party with a copy of a message for information (the sub-function of the message is Copy),|- re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate).|ISO 15022 - 20022 COEXISTENCE|This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”.")]
public partial record CorporateActionMovementReversalAdviceV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CorpActnMvmntRvslAdvc";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Information that unambiguously identifies a CorporateActionMovementReversalAdvice message as know by the account servicer.
    /// </summary>
    [IsoId("_Tfxz_9EwEd-BzquC8wXy7w_-995876600")]
    [Description(@"Information that unambiguously identifies a CorporateActionMovementReversalAdvice message as know by the account servicer.")]
    [DataMember(Name="Id")]
    [XmlElement(ElementName="Id")]
    [Required]
    public required SomeIdentificationRecord Identification { get; init; }
    
    /// <summary>
    /// Identification of a previously sent movement confirmation document.
    /// </summary>
    [IsoId("_Tfx0ANEwEd-BzquC8wXy7w_-901677518")]
    [Description(@"Identification of a previously sent movement confirmation document.")]
    [DataMember(Name="MvmntConfId")]
    [XmlElement(ElementName="MvmntConfId")]
    [Required]
    public required SomeMovementConfirmationIdentificationRecord MovementConfirmationIdentification { get; init; }
    
    /// <summary>
    /// Identification of other documents as well as the document number.
    /// </summary>
    [IsoId("_Tf7k8NEwEd-BzquC8wXy7w_-442684873")]
    [Description(@"Identification of other documents as well as the document number.")]
    [DataMember(Name="OthrDocId")]
    [XmlElement(ElementName="OthrDocId")]
    public SomeOtherDocumentIdentificationRecord? OtherDocumentIdentification { get; init; }
    
    /// <summary>
    /// Identification of an other corporate action event that needs to be closely linked to the processing of the event notified in this document.
    /// </summary>
    [IsoId("_Tf7k8dEwEd-BzquC8wXy7w_100077356")]
    [Description(@"Identification of an other corporate action event that needs to be closely linked to the processing of the event notified in this document.")]
    [DataMember(Name="EvtsLkg")]
    [XmlElement(ElementName="EvtsLkg")]
    public SomeEventsLinkageRecord? EventsLinkage { get; init; }
    
    /// <summary>
    /// Reason for the reversal.
    /// </summary>
    [IsoId("_Tf7k8tEwEd-BzquC8wXy7w_-2117806404")]
    [Description(@"Reason for the reversal.")]
    [DataMember(Name="RvslRsn")]
    [XmlElement(ElementName="RvslRsn")]
    public SomeReversalReasonRecord? ReversalReason { get; init; }
    
    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_Tf7k89EwEd-BzquC8wXy7w_205358419")]
    [Description(@"General information about the corporate action event.")]
    [DataMember(Name="CorpActnGnlInf")]
    [XmlElement(ElementName="CorpActnGnlInf")]
    [Required]
    public required SomeCorporateActionGeneralInformationRecord CorporateActionGeneralInformation { get; init; }
    
    /// <summary>
    /// General information about the safekeeping account, owner and account balance.
    /// </summary>
    [IsoId("_Tf7k9NEwEd-BzquC8wXy7w_357742721")]
    [Description(@"General information about the safekeeping account, owner and account balance.")]
    [DataMember(Name="AcctDtls")]
    [XmlElement(ElementName="AcctDtls")]
    [Required]
    public required SomeAccountDetailsRecord AccountDetails { get; init; }
    
    /// <summary>
    /// Information about the corporate action option.
    /// </summary>
    [IsoId("_Tf7k9dEwEd-BzquC8wXy7w_1547234386")]
    [Description(@"Information about the corporate action option.")]
    [DataMember(Name="CorpActnConfDtls")]
    [XmlElement(ElementName="CorpActnConfDtls")]
    [Required]
    public required SomeCorporateActionConfirmationDetailsRecord CorporateActionConfirmationDetails { get; init; }
    
    /// <summary>
    /// Provides additional information.
    /// </summary>
    [IsoId("_Tf7k9tEwEd-BzquC8wXy7w_1259424777")]
    [Description(@"Provides additional information.")]
    [DataMember(Name="AddtlInf")]
    [XmlElement(ElementName="AddtlInf")]
    public SomeAdditionalInformationRecord? AdditionalInformation { get; init; }
    
    /// <summary>
    /// Party that originated the message, if other than the sender.
    /// </summary>
    [IsoId("_Tf7k99EwEd-BzquC8wXy7w_1376711953")]
    [Description(@"Party that originated the message, if other than the sender.")]
    [DataMember(Name="MsgOrgtr")]
    [XmlElement(ElementName="MsgOrgtr")]
    public SomeMessageOriginatorRecord? MessageOriginator { get; init; }
    
    /// <summary>
    /// Party that is the final destination of the message, if other than the receiver.
    /// </summary>
    [IsoId("_Tf7k-NEwEd-BzquC8wXy7w_1608518050")]
    [Description(@"Party that is the final destination of the message, if other than the receiver.")]
    [DataMember(Name="MsgRcpt")]
    [XmlElement(ElementName="MsgRcpt")]
    public SomeMessageRecipientRecord? MessageRecipient { get; init; }
    
    /// <summary>
    /// Party appointed to administer the event on behalf of the issuer company/offeror. The party may be contacted for more information about the event.
    /// </summary>
    [IsoId("_TgFV8NEwEd-BzquC8wXy7w_1693481006")]
    [Description(@"Party appointed to administer the event on behalf of the issuer company/offeror. The party may be contacted for more information about the event.")]
    [DataMember(Name="IssrAgt")]
    [XmlElement(ElementName="IssrAgt")]
    public SomeIssuerAgentRecord? IssuerAgent { get; init; }
    
    /// <summary>
    /// Agent (principal or fiscal paying agent) appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.
    /// </summary>
    [IsoId("_TgFV8dEwEd-BzquC8wXy7w_1759051368")]
    [Description(@"Agent (principal or fiscal paying agent) appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.")]
    [DataMember(Name="PngAgt")]
    [XmlElement(ElementName="PngAgt")]
    public SomePayingAgentRecord? PayingAgent { get; init; }
    
    /// <summary>
    /// Sub-agent appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.
    /// </summary>
    [IsoId("_TgFV8tEwEd-BzquC8wXy7w_2048111600")]
    [Description(@"Sub-agent appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.")]
    [DataMember(Name="SubPngAgt")]
    [XmlElement(ElementName="SubPngAgt")]
    public SomeSubPayingAgentRecord? SubPayingAgent { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_TgFV89EwEd-BzquC8wXy7w_2122918303")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="Xtnsn")]
    [XmlElement(ElementName="Xtnsn")]
    public SomeExtensionRecord? Extension { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CorporateActionMovementReversalAdviceV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CorporateActionMovementReversalAdviceV01Document ToDocument()
    {
        return new CorporateActionMovementReversalAdviceV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CorporateActionMovementReversalAdviceV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record CorporateActionMovementReversalAdviceV01Document : IOuterDocument<CorporateActionMovementReversalAdviceV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.037.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CorporateActionMovementReversalAdviceV01"/> is required.
    /// </summary>
    public required CorporateActionMovementReversalAdviceV01 Message { get; init; }
}