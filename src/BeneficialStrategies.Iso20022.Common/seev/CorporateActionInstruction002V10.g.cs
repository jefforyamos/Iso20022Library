﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CorporateActionInstruction002V10.  ISO2002 ID# _bfXkswVSEeqjd8n6wD9JVw.
//
namespace BeneficialStrategies.Iso20022.seev;

/// <summary>
/// Scope
/// The CorporateActionInstruction message is sent by an account owner to an account servicer to instruct election on a corporate action event.|
/// This message is used to provide the custodian with instructions on how the account owner wishes to proceed with a corporate action event. Instructions include investment decisions regarding the exercise of rights issues, the election of stock or cash when the option is available, and decisions on the conversion or tendering of securities.
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent (the sub-function of the message is Duplicate),
/// - provide a third party with a copy of a message for information (the sub-function of the message is Copy),
/// - re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate), using the relevant elements in the business application header (BAH).
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The CorporateActionInstruction message is sent by an account owner to an account servicer to instruct election on a corporate action event.||This message is used to provide the custodian with instructions on how the account owner wishes to proceed with a corporate action event. Instructions include investment decisions regarding the exercise of rights issues, the election of stock or cash when the option is available, and decisions on the conversion or tendering of securities.|Usage|The message may also be used to:|- re-send a message previously sent (the sub-function of the message is Duplicate),|- provide a third party with a copy of a message for information (the sub-function of the message is Copy),|- re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate), using the relevant elements in the business application header (BAH).")]
public partial record CorporateActionInstruction002V10 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CorpActnInstr";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// When used in a corporate action instruction, indicates that the current instruction is replacing a previous one that was cancelled earlier. When used in a corporate action instruction cancellation request, indicates that cancelled instruction will be replaced by a new corporate action instruction to be sent later.
    /// </summary>
    [IsoId("_bfXkwgVSEeqjd8n6wD9JVw")]
    [Description(@"When used in a corporate action instruction, indicates that the current instruction is replacing a previous one that was cancelled earlier. When used in a corporate action instruction cancellation request, indicates that cancelled instruction will be replaced by a new corporate action instruction to be sent later.")]
    [DataMember(Name="ChngInstrInd")]
    [XmlElement(ElementName="ChngInstrInd")]
    public SomeChangeInstructionIndicatorRecord? ChangeInstructionIndicator { get; init; }
    
    /// <summary>
    /// Identification of a previously sent cancelled instruction document.
    /// </summary>
    [IsoId("_bfXkxAVSEeqjd8n6wD9JVw")]
    [Description(@"Identification of a previously sent cancelled instruction document.")]
    [DataMember(Name="CancInstrId")]
    [XmlElement(ElementName="CancInstrId")]
    public SomeCancelledInstructionIdentificationRecord? CancelledInstructionIdentification { get; init; }
    
    /// <summary>
    /// Identification of a previously sent instruction cancellation request document.
    /// </summary>
    [IsoId("_bfXkxgVSEeqjd8n6wD9JVw")]
    [Description(@"Identification of a previously sent instruction cancellation request document.")]
    [DataMember(Name="InstrCxlReqId")]
    [XmlElement(ElementName="InstrCxlReqId")]
    public SomeInstructionCancellationRequestIdentificationRecord? InstructionCancellationRequestIdentification { get; init; }
    
    /// <summary>
    /// Identification of other documents as well as the document number.
    /// </summary>
    [IsoId("_bfXkyAVSEeqjd8n6wD9JVw")]
    [Description(@"Identification of other documents as well as the document number.")]
    [DataMember(Name="OthrDocId")]
    [XmlElement(ElementName="OthrDocId")]
    public SomeOtherDocumentIdentificationRecord? OtherDocumentIdentification { get; init; }
    
    /// <summary>
    /// Identification of another corporate action event that needs to be closely linked to the processing of the event notified in this document.
    /// </summary>
    [IsoId("_bfXkygVSEeqjd8n6wD9JVw")]
    [Description(@"Identification of another corporate action event that needs to be closely linked to the processing of the event notified in this document.")]
    [DataMember(Name="EvtsLkg")]
    [XmlElement(ElementName="EvtsLkg")]
    public SomeEventsLinkageRecord? EventsLinkage { get; init; }
    
    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_bfXkzAVSEeqjd8n6wD9JVw")]
    [Description(@"General information about the corporate action event.")]
    [DataMember(Name="CorpActnGnlInf")]
    [XmlElement(ElementName="CorpActnGnlInf")]
    [Required]
    public required SomeCorporateActionGeneralInformationRecord CorporateActionGeneralInformation { get; init; }
    
    /// <summary>
    /// General information about the safekeeping account, owner and account balance.
    /// </summary>
    [IsoId("_bfXkzgVSEeqjd8n6wD9JVw")]
    [Description(@"General information about the safekeeping account, owner and account balance.")]
    [DataMember(Name="AcctDtls")]
    [XmlElement(ElementName="AcctDtls")]
    [Required]
    public required SomeAccountDetailsRecord AccountDetails { get; init; }
    
    /// <summary>
    /// Provides information about the beneficial owner of the securities.
    /// </summary>
    [IsoId("_bfXk0AVSEeqjd8n6wD9JVw")]
    [Description(@"Provides information about the beneficial owner of the securities.")]
    [DataMember(Name="BnfclOwnrDtls")]
    [XmlElement(ElementName="BnfclOwnrDtls")]
    public SomeBeneficialOwnerDetailsRecord? BeneficialOwnerDetails { get; init; }
    
    /// <summary>
    /// Information about the corporate action instruction.
    /// </summary>
    [IsoId("_bfXk0gVSEeqjd8n6wD9JVw")]
    [Description(@"Information about the corporate action instruction.")]
    [DataMember(Name="CorpActnInstr")]
    [XmlElement(ElementName="CorpActnInstr")]
    [Required]
    public required SomeCorporateActionInstructionRecord CorporateActionInstruction { get; init; }
    
    /// <summary>
    /// Provides detailed information on protect and cover protect instructions.
    /// </summary>
    [IsoId("_bfXk1AVSEeqjd8n6wD9JVw")]
    [Description(@"Provides detailed information on protect and cover protect instructions.")]
    [DataMember(Name="PrtctInstr")]
    [XmlElement(ElementName="PrtctInstr")]
    public SomeProtectInstructionRecord? ProtectInstruction { get; init; }
    
    /// <summary>
    /// Provides additional information.
    /// </summary>
    [IsoId("_bfXk1gVSEeqjd8n6wD9JVw")]
    [Description(@"Provides additional information.")]
    [DataMember(Name="AddtlInf")]
    [XmlElement(ElementName="AddtlInf")]
    public SomeAdditionalInformationRecord? AdditionalInformation { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_bfXk2AVSEeqjd8n6wD9JVw")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CorporateActionInstruction002V10Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CorporateActionInstruction002V10Document ToDocument()
    {
        return new CorporateActionInstruction002V10Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CorporateActionInstruction002V10"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record CorporateActionInstruction002V10Document : IOuterDocument<CorporateActionInstruction002V10>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.033.002.10";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CorporateActionInstruction002V10"/> is required.
    /// </summary>
    public required CorporateActionInstruction002V10 Message { get; init; }
}
