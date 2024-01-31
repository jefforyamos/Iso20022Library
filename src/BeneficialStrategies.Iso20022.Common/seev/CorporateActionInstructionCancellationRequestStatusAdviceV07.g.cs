﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CorporateActionInstructionCancellationRequestStatusAdviceV07.  ISO2002 ID# _ynLurYb4Eea9VrPZgV7UBQ.
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
/// This record is an implementation of the seev.041.001.07 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account servicer sends the CorporateActionInstructionCancellationRequestStatusAdvice message to an account owner or its designated agent to report status of a previously received CorporateActionInstructionCancellationRequest message sent by the account owner. This will include the acknowledgement/rejection of a request to cancel an outstanding instruction. 
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
[Description(@"Scope|An account servicer sends the CorporateActionInstructionCancellationRequestStatusAdvice message to an account owner or its designated agent to report status of a previously received CorporateActionInstructionCancellationRequest message sent by the account owner. This will include the acknowledgement/rejection of a request to cancel an outstanding instruction. |Usage|The message may also be used to:|- re-send a message previously sent (the sub-function of the message is Duplicate),|- provide a third party with a copy of a message for information (the sub-function of the message is Copy),|- re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate),|using the relevant elements in the business application header (BAH).")]
public partial record CorporateActionInstructionCancellationRequestStatusAdviceV07 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.041.001.07";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CorpActnInstrCxlReqStsAdvc";
    
    #nullable enable
    /// <summary>
    /// Identification of a related instruction cancellation request document.
    /// </summary>
    [IsoId("_ynLusYb4Eea9VrPZgV7UBQ")]
    [Description(@"Identification of a related instruction cancellation request document.")]
    [DataMember(Name="InstrCxlReqId")]
    [XmlElement(ElementName="InstrCxlReqId")]
    public DocumentIdentification9? InstructionCancellationRequestIdentification { get; init; }
    
    /// <summary>
    /// Identification of other documents as well as the document number.
    /// </summary>
    [IsoId("_ynLus4b4Eea9VrPZgV7UBQ")]
    [Description(@"Identification of other documents as well as the document number.")]
    [DataMember(Name="OthrDocId")]
    [XmlElement(ElementName="OthrDocId")]
    public DocumentIdentification33? OtherDocumentIdentification { get; init; }
    
    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_ynLutYb4Eea9VrPZgV7UBQ")]
    [Description(@"General information about the corporate action event.")]
    [DataMember(Name="CorpActnGnlInf")]
    [XmlElement(ElementName="CorpActnGnlInf")]
    [Required]
    public required CorporateActionGeneralInformation109 CorporateActionGeneralInformation { get; init; }
    
    /// <summary>
    /// Provides information about the processing status of the instruction cancellation request.
    /// </summary>
    [IsoId("_ynLut4b4Eea9VrPZgV7UBQ")]
    [Description(@"Provides information about the processing status of the instruction cancellation request.")]
    [DataMember(Name="InstrCxlReqSts")]
    [XmlElement(ElementName="InstrCxlReqSts")]
    [Required]
    public required IInstructionCancellationRequestStatus11Choice InstructionCancellationRequestStatus { get; init; }
    
    /// <summary>
    /// Information about the corporate action option.
    /// </summary>
    [IsoId("_ynLuuYb4Eea9VrPZgV7UBQ")]
    [Description(@"Information about the corporate action option.")]
    [DataMember(Name="CorpActnInstr")]
    [XmlElement(ElementName="CorpActnInstr")]
    public CorporateActionOption116? CorporateActionInstruction { get; init; }
    
    /// <summary>
    /// Provides additional information.
    /// </summary>
    [IsoId("_ynLuu4b4Eea9VrPZgV7UBQ")]
    [Description(@"Provides additional information.")]
    [DataMember(Name="AddtlInf")]
    [XmlElement(ElementName="AddtlInf")]
    public CorporateActionNarrative10? AdditionalInformation { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_ynLuvYb4Eea9VrPZgV7UBQ")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CorporateActionInstructionCancellationRequestStatusAdviceV07Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CorporateActionInstructionCancellationRequestStatusAdviceV07Document ToDocument()
    {
        return new CorporateActionInstructionCancellationRequestStatusAdviceV07Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CorporateActionInstructionCancellationRequestStatusAdviceV07"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record CorporateActionInstructionCancellationRequestStatusAdviceV07Document : IOuterDocument<CorporateActionInstructionCancellationRequestStatusAdviceV07>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.041.001.07";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CorporateActionInstructionCancellationRequestStatusAdviceV07"/> is required.
    /// </summary>
    public required CorporateActionInstructionCancellationRequestStatusAdviceV07 Message { get; init; }
}
