﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CorporateActionInstructionCancellationRequest002V12.  ISO2002 ID# _PGRLc199Ee262vCSVgjImg.
//
namespace BeneficialStrategies.Iso20022.seev;

/// <summary>
/// Scope
/// The CorporateActionInstructionCancellationRequest message is sent by an account owner to an account servicer to request cancellation of a previously sent corporate action election instruction.
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent (the sub-function of the message is Duplicate),
/// - provide a third party with a copy of a message for information (the sub-function of the message is Copy),
/// - re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate), using the relevant elements in the business application header (BAH).
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The CorporateActionInstructionCancellationRequest message is sent by an account owner to an account servicer to request cancellation of a previously sent corporate action election instruction.|Usage|The message may also be used to:|- re-send a message previously sent (the sub-function of the message is Duplicate),|- provide a third party with a copy of a message for information (the sub-function of the message is Copy),|- re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate), using the relevant elements in the business application header (BAH).")]
public partial record CorporateActionInstructionCancellationRequest002V12 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CorpActnInstrCxlReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Indicates that cancelled instruction will be replaced by a new corporate action instruction to be sent later.
    /// </summary>
    [IsoId("_PGRLfl99Ee262vCSVgjImg")]
    [Description(@"Indicates that cancelled instruction will be replaced by a new corporate action instruction to be sent later.")]
    [DataMember(Name="ChngInstrInd")]
    [XmlElement(ElementName="ChngInstrInd")]
    public SomeChangeInstructionIndicatorRecord? ChangeInstructionIndicator { get; init; }
    
    /// <summary>
    /// Identification of a previously sent instruction document.
    /// </summary>
    [IsoId("_PGRLgF99Ee262vCSVgjImg")]
    [Description(@"Identification of a previously sent instruction document.")]
    [DataMember(Name="InstrId")]
    [XmlElement(ElementName="InstrId")]
    [Required]
    public required SomeInstructionIdentificationRecord InstructionIdentification { get; init; }
    
    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_PGRLgl99Ee262vCSVgjImg")]
    [Description(@"General information about the corporate action event.")]
    [DataMember(Name="CorpActnGnlInf")]
    [XmlElement(ElementName="CorpActnGnlInf")]
    [Required]
    public required SomeCorporateActionGeneralInformationRecord CorporateActionGeneralInformation { get; init; }
    
    /// <summary>
    /// General information about the safekeeping account and the account owner.
    /// </summary>
    [IsoId("_PGRLhF99Ee262vCSVgjImg")]
    [Description(@"General information about the safekeeping account and the account owner.")]
    [DataMember(Name="AcctDtls")]
    [XmlElement(ElementName="AcctDtls")]
    [Required]
    public required SomeAccountDetailsRecord AccountDetails { get; init; }
    
    /// <summary>
    /// Information about the corporate action option.
    /// </summary>
    [IsoId("_PGRLhl99Ee262vCSVgjImg")]
    [Description(@"Information about the corporate action option.")]
    [DataMember(Name="CorpActnInstr")]
    [XmlElement(ElementName="CorpActnInstr")]
    [Required]
    public required SomeCorporateActionInstructionRecord CorporateActionInstruction { get; init; }
    
    /// <summary>
    /// Provides detailed information on protect and cover protect instructions.
    /// </summary>
    [IsoId("_PGRLiF99Ee262vCSVgjImg")]
    [Description(@"Provides detailed information on protect and cover protect instructions.")]
    [DataMember(Name="PrtctInstr")]
    [XmlElement(ElementName="PrtctInstr")]
    public SomeProtectInstructionRecord? ProtectInstruction { get; init; }
    
    /// <summary>
    /// Provides additional information.
    /// </summary>
    [IsoId("_PGRLil99Ee262vCSVgjImg")]
    [Description(@"Provides additional information.")]
    [DataMember(Name="AddtlInf")]
    [XmlElement(ElementName="AddtlInf")]
    public SomeAdditionalInformationRecord? AdditionalInformation { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_PGRLjF99Ee262vCSVgjImg")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CorporateActionInstructionCancellationRequest002V12Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CorporateActionInstructionCancellationRequest002V12Document ToDocument()
    {
        return new CorporateActionInstructionCancellationRequest002V12Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CorporateActionInstructionCancellationRequest002V12"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record CorporateActionInstructionCancellationRequest002V12Document : IOuterDocument<CorporateActionInstructionCancellationRequest002V12>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.040.002.12";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CorporateActionInstructionCancellationRequest002V12"/> is required.
    /// </summary>
    public required CorporateActionInstructionCancellationRequest002V12 Message { get; init; }
}