﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CorporateActionInstructionV05.  ISO2002 ID# _2B2dRxbDEeOb5dMswipsLQ.
//
namespace BeneficialStrategies.Iso20022.seev;

/// <summary>
/// Scope|An account owner sends the CorporateActionInstruction message to an account servicer to instruct election on a corporate action event.
/// This message is used to provide the custodian with instructions on how the account owner wishes to proceed with a corporate action event. Instructions include investment decisions regarding the exercise of rights issues, the election of stock or cash when the option is available, and decisions on the conversion or tendering of securities.|Usage|The message may also be used to:|- re-send a message previously sent (the sub-function of the message is Duplicate),|- provide a third party with a copy of a message for information (the sub-function of the message is Copy),|- re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate),|using the relevant elements in the business application header (BAH).|ISO 15022 - 20022 COEXISTENCE
/// This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|An account owner sends the CorporateActionInstruction message to an account servicer to instruct election on a corporate action event.|This message is used to provide the custodian with instructions on how the account owner wishes to proceed with a corporate action event. Instructions include investment decisions regarding the exercise of rights issues, the election of stock or cash when the option is available, and decisions on the conversion or tendering of securities.|Usage|The message may also be used to:|- re-send a message previously sent (the sub-function of the message is Duplicate),|- provide a third party with a copy of a message for information (the sub-function of the message is Copy),|- re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate),|using the relevant elements in the business application header (BAH).|ISO 15022 - 20022 COEXISTENCE|This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”.")]
public partial record CorporateActionInstructionV05 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CorpActnInstr";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// When used in a corporate action instruction, indicates that the current instruction is replacing a previous one that was cancelled earlier. When used in a corporate action instruction cancellation request, indicates that cancelled instruction will be replaced by a new corporate action instruction to be sent later.
    /// </summary>
    [IsoId("_2B2dVxbDEeOb5dMswipsLQ")]
    [Description(@"When used in a corporate action instruction, indicates that the current instruction is replacing a previous one that was cancelled earlier. When used in a corporate action instruction cancellation request, indicates that cancelled instruction will be replaced by a new corporate action instruction to be sent later.")]
    [DataMember(Name="ChngInstrInd")]
    [XmlElement(ElementName="ChngInstrInd")]
    public SomeChangeInstructionIndicatorRecord? ChangeInstructionIndicator { get; init; }
    
    /// <summary>
    /// Identification of a previously sent cancelled instruction document.
    /// </summary>
    [IsoId("_2B2dWRbDEeOb5dMswipsLQ")]
    [Description(@"Identification of a previously sent cancelled instruction document.")]
    [DataMember(Name="CancInstrId")]
    [XmlElement(ElementName="CancInstrId")]
    public SomeCancelledInstructionIdentificationRecord? CancelledInstructionIdentification { get; init; }
    
    /// <summary>
    /// Identification of a previously sent instruction cancellation request document.
    /// </summary>
    [IsoId("_2B2dWxbDEeOb5dMswipsLQ")]
    [Description(@"Identification of a previously sent instruction cancellation request document.")]
    [DataMember(Name="InstrCxlReqId")]
    [XmlElement(ElementName="InstrCxlReqId")]
    public SomeInstructionCancellationRequestIdentificationRecord? InstructionCancellationRequestIdentification { get; init; }
    
    /// <summary>
    /// Identification of other documents as well as the document number.
    /// </summary>
    [IsoId("_2B2dXRbDEeOb5dMswipsLQ")]
    [Description(@"Identification of other documents as well as the document number.")]
    [DataMember(Name="OthrDocId")]
    [XmlElement(ElementName="OthrDocId")]
    public SomeOtherDocumentIdentificationRecord? OtherDocumentIdentification { get; init; }
    
    /// <summary>
    /// Identification of an other corporate action event that needs to be closely linked to the processing of the event notified in this document.
    /// </summary>
    [IsoId("_2B2dXxbDEeOb5dMswipsLQ")]
    [Description(@"Identification of an other corporate action event that needs to be closely linked to the processing of the event notified in this document.")]
    [DataMember(Name="EvtsLkg")]
    [XmlElement(ElementName="EvtsLkg")]
    public SomeEventsLinkageRecord? EventsLinkage { get; init; }
    
    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_2B2dYRbDEeOb5dMswipsLQ")]
    [Description(@"General information about the corporate action event.")]
    [DataMember(Name="CorpActnGnlInf")]
    [XmlElement(ElementName="CorpActnGnlInf")]
    [Required]
    public required SomeCorporateActionGeneralInformationRecord CorporateActionGeneralInformation { get; init; }
    
    /// <summary>
    /// General information about the safekeeping account, owner and account balance.
    /// </summary>
    [IsoId("_2B2dYxbDEeOb5dMswipsLQ")]
    [Description(@"General information about the safekeeping account, owner and account balance.")]
    [DataMember(Name="AcctDtls")]
    [XmlElement(ElementName="AcctDtls")]
    [Required]
    public required SomeAccountDetailsRecord AccountDetails { get; init; }
    
    /// <summary>
    /// Provides information about the beneficial owner of the securities.
    /// </summary>
    [IsoId("_2B2dZRbDEeOb5dMswipsLQ")]
    [Description(@"Provides information about the beneficial owner of the securities.")]
    [DataMember(Name="BnfclOwnrDtls")]
    [XmlElement(ElementName="BnfclOwnrDtls")]
    public SomeBeneficialOwnerDetailsRecord? BeneficialOwnerDetails { get; init; }
    
    /// <summary>
    /// Information about the corporate action instruction.
    /// </summary>
    [IsoId("_2B2dZxbDEeOb5dMswipsLQ")]
    [Description(@"Information about the corporate action instruction.")]
    [DataMember(Name="CorpActnInstr")]
    [XmlElement(ElementName="CorpActnInstr")]
    [Required]
    public required SomeCorporateActionInstructionRecord CorporateActionInstruction { get; init; }
    
    /// <summary>
    /// Provides additional information.
    /// </summary>
    [IsoId("_2B2daRbDEeOb5dMswipsLQ")]
    [Description(@"Provides additional information.")]
    [DataMember(Name="AddtlInf")]
    [XmlElement(ElementName="AddtlInf")]
    public SomeAdditionalInformationRecord? AdditionalInformation { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_2B2daxbDEeOb5dMswipsLQ")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CorporateActionInstructionV05Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CorporateActionInstructionV05Document ToDocument()
    {
        return new CorporateActionInstructionV05Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CorporateActionInstructionV05"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record CorporateActionInstructionV05Document : IOuterDocument<CorporateActionInstructionV05>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.033.001.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CorporateActionInstructionV05"/> is required.
    /// </summary>
    public required CorporateActionInstructionV05 Message { get; init; }
}
