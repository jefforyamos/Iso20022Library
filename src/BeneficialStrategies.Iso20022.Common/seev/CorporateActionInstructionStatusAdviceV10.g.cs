﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CorporateActionInstructionStatusAdviceV10.  ISO2002 ID# _BBGsdbT-EeiTob_PrFFUxA.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.seev;


/// <summary>
/// This record is an implementation of the seev.034.001.10 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The CorporateActionInstructionStatusAdvice message is sent by an account servicer to an account owner or its designated agent, to report status of a received corporate action election instruction.|
/// This message is used to advise the status, or a change in status, of a corporate action-related transaction previously instructed by, or executed on behalf of, the account owner. This will include the acknowledgement/rejection of a corporate action instruction.
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent (the sub-function of the message is Duplicate),
/// - provide a third party with a copy of a message for information (the sub-function of the message is Copy),
/// - re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate), using the relevant elements in the business application header (BAH).
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The CorporateActionInstructionStatusAdvice message is sent by an account servicer to an account owner or its designated agent, to report status of a received corporate action election instruction.||This message is used to advise the status, or a change in status, of a corporate action-related transaction previously instructed by, or executed on behalf of, the account owner. This will include the acknowledgement/rejection of a corporate action instruction.|Usage|The message may also be used to:|- re-send a message previously sent (the sub-function of the message is Duplicate),|- provide a third party with a copy of a message for information (the sub-function of the message is Copy),|- re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate), using the relevant elements in the business application header (BAH).")]
public partial record CorporateActionInstructionStatusAdviceV10 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.034.001.10";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CorpActnInstrStsAdvc";
    
    #nullable enable
    /// <summary>
    /// Identification of a related instruction document.
    /// </summary>
    [IsoId("_BBGsebT-EeiTob_PrFFUxA")]
    [Description(@"Identification of a related instruction document.")]
    [DataMember(Name="InstrId")]
    [XmlElement(ElementName="InstrId")]
    public DocumentIdentification9? InstructionIdentification { get; init; }
    
    /// <summary>
    /// Identification of other documents as well as the document number.
    /// </summary>
    [IsoId("_BBGse7T-EeiTob_PrFFUxA")]
    [Description(@"Identification of other documents as well as the document number.")]
    [DataMember(Name="OthrDocId")]
    [XmlElement(ElementName="OthrDocId")]
    public DocumentIdentification33? OtherDocumentIdentification { get; init; }
    
    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_BBGsfbT-EeiTob_PrFFUxA")]
    [Description(@"General information about the corporate action event.")]
    [DataMember(Name="CorpActnGnlInf")]
    [XmlElement(ElementName="CorpActnGnlInf")]
    [Required]
    public required CorporateActionGeneralInformation109 CorporateActionGeneralInformation { get; init; }
    
    /// <summary>
    /// Provides information about the processing status of the instruction.
    /// </summary>
    [IsoId("_BBQdAbT-EeiTob_PrFFUxA")]
    [Description(@"Provides information about the processing status of the instruction.")]
    [DataMember(Name="InstrPrcgSts")]
    [XmlElement(ElementName="InstrPrcgSts")]
    [Required]
    public required InstructionProcessingStatus31Choice_ InstructionProcessingStatus { get; init; }
    
    /// <summary>
    /// Information about the corporate action instruction.
    /// </summary>
    [IsoId("_BBQdA7T-EeiTob_PrFFUxA")]
    [Description(@"Information about the corporate action instruction.")]
    [DataMember(Name="CorpActnInstr")]
    [XmlElement(ElementName="CorpActnInstr")]
    public CorporateActionOption151? CorporateActionInstruction { get; init; }
    
    /// <summary>
    /// Provides detailed information on protect and cover protect instructions.
    /// </summary>
    [IsoId("_PT8YsLpSEeilsanBGAzy4A")]
    [Description(@"Provides detailed information on protect and cover protect instructions.")]
    [DataMember(Name="PrtctInstr")]
    [XmlElement(ElementName="PrtctInstr")]
    public ProtectInstruction2? ProtectInstruction { get; init; }
    
    /// <summary>
    /// Provides additional information.
    /// </summary>
    [IsoId("_BBQdBbT-EeiTob_PrFFUxA")]
    [Description(@"Provides additional information.")]
    [DataMember(Name="AddtlInf")]
    [XmlElement(ElementName="AddtlInf")]
    public CorporateActionNarrative10? AdditionalInformation { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_BBQdB7T-EeiTob_PrFFUxA")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CorporateActionInstructionStatusAdviceV10Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CorporateActionInstructionStatusAdviceV10Document ToDocument()
    {
        return new CorporateActionInstructionStatusAdviceV10Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CorporateActionInstructionStatusAdviceV10"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record CorporateActionInstructionStatusAdviceV10Document : IOuterDocument<CorporateActionInstructionStatusAdviceV10>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.034.001.10";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CorporateActionInstructionStatusAdviceV10"/> is required.
    /// </summary>
    public required CorporateActionInstructionStatusAdviceV10 Message { get; init; }
}
