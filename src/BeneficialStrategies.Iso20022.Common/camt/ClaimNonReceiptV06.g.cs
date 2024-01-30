﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ClaimNonReceiptV06.  ISO2002 ID# _AOwV4V1tEeehlLdFiIrRgQ.
//
namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// Scope|The Claim Non Receipt message is sent by a case creator/case assigner to a case assignee.|This message is used to initiate an investigation for missing funds at the creditor (missing credit entry to its account) or at an agent along the processing chain (missing cover for a received payment instruction).|Usage|The claim non receipt case occurs in two situations: |- The creditor is expecting funds from a particular debtor and cannot find the corresponding credit entry on its account. In this situation, it is understood that the creditor will contact its debtor, and that the debtor will trigger the claim non receipt case on its behalf. A workflow where the creditor directly addresses a Claim Non Receipt message to its account servicing institution is not retained.|- An agent in the processing chain cannot find a cover payment corresponding to a received payment instruction. In this situation, the agent may directly trigger the investigation by sending a Claim Non Receipt message to the sender of the original payment instruction.|The Claim Non Receipt message covers one and only one payment instruction at a time. If several expected payment instructions/cover instructions are found missing, then multiple Claim Non Receipt messages must be sent.|Depending on the result of the investigation by a case assignee (incorrect routing, errors/omissions when processing the instruction or even the absence of an error) and the stage at which the payment instruction is being process, the claim non receipt case may lead to a: |- Request To Cancel Payment message, sent to the subsequent agent in the payment processing chain, if the original payment instruction has been incorrectly routed through the chain of agents. (This also implies that a new, corrected, payment instruction is issued).|- Request To Modify Payment message, sent to the subsequent agent in the payment processing chain, if a truncation or omission has occurred during the processing of the original payment instruction.|If the above situations occur, the assignee wanting to request a payment cancellation or payment modification should first send out a Resolution Of Investigation with a confirmation status that indicates that either cancellation (CWFW) modification (MWFW) or unable to apply (UWFW) will follow. (See section on Resolution Of Investigation for more details).|In the cover is missing, the case assignee may also simply issue the omitted cover payment or when the initial cover information was incorrect, update the cover (through modification and/or cancellation as required) with the correction information provided in the ClaimNonReceipt message. The case assignee will issue a Resolution Of Investigation message with the CorrectionTransaction element mentioning the references of the cover payment.|The Claim Non Receipt message may be forwarded to subsequent case assignees.|The ClaimNonReceipt message has the following main characteristics: |- Case Identification: |The case creator assigns a unique case identification. This information will be passed unchanged to subsequent case assignee(s).|- Underlying Payment: |The case creator refers to the underlying payment instruction for the unambiguous identification of the payment instruction. This identification needs to be updated by the subsequent case assigner(s) in order to match the one used with their case assignee(s).|- MissingCoverIndicator: |The MissingCoverIndication element distinguishes between a missing cover situation (when set to YES) or a missing funds situation (when set to NO).|- CoverCorrection|The CoverCorrection element allows the case assigner to provide corrected cover information, when these are incorrect in the underlying payment instruction for which the cover is issued.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The Claim Non Receipt message is sent by a case creator/case assigner to a case assignee.|This message is used to initiate an investigation for missing funds at the creditor (missing credit entry to its account) or at an agent along the processing chain (missing cover for a received payment instruction).|Usage|The claim non receipt case occurs in two situations: |- The creditor is expecting funds from a particular debtor and cannot find the corresponding credit entry on its account. In this situation, it is understood that the creditor will contact its debtor, and that the debtor will trigger the claim non receipt case on its behalf. A workflow where the creditor directly addresses a Claim Non Receipt message to its account servicing institution is not retained.|- An agent in the processing chain cannot find a cover payment corresponding to a received payment instruction. In this situation, the agent may directly trigger the investigation by sending a Claim Non Receipt message to the sender of the original payment instruction.|The Claim Non Receipt message covers one and only one payment instruction at a time. If several expected payment instructions/cover instructions are found missing, then multiple Claim Non Receipt messages must be sent.|Depending on the result of the investigation by a case assignee (incorrect routing, errors/omissions when processing the instruction or even the absence of an error) and the stage at which the payment instruction is being process, the claim non receipt case may lead to a: |- Request To Cancel Payment message, sent to the subsequent agent in the payment processing chain, if the original payment instruction has been incorrectly routed through the chain of agents. (This also implies that a new, corrected, payment instruction is issued).|- Request To Modify Payment message, sent to the subsequent agent in the payment processing chain, if a truncation or omission has occurred during the processing of the original payment instruction.|If the above situations occur, the assignee wanting to request a payment cancellation or payment modification should first send out a Resolution Of Investigation with a confirmation status that indicates that either cancellation (CWFW) modification (MWFW) or unable to apply (UWFW) will follow. (See section on Resolution Of Investigation for more details).|In the cover is missing, the case assignee may also simply issue the omitted cover payment or when the initial cover information was incorrect, update the cover (through modification and/or cancellation as required) with the correction information provided in the ClaimNonReceipt message. The case assignee will issue a Resolution Of Investigation message with the CorrectionTransaction element mentioning the references of the cover payment.|The Claim Non Receipt message may be forwarded to subsequent case assignees.|The ClaimNonReceipt message has the following main characteristics: |- Case Identification: |The case creator assigns a unique case identification. This information will be passed unchanged to subsequent case assignee(s).|- Underlying Payment: |The case creator refers to the underlying payment instruction for the unambiguous identification of the payment instruction. This identification needs to be updated by the subsequent case assigner(s) in order to match the one used with their case assignee(s).|- MissingCoverIndicator: |The MissingCoverIndication element distinguishes between a missing cover situation (when set to YES) or a missing funds situation (when set to NO).|- CoverCorrection|The CoverCorrection element allows the case assigner to provide corrected cover information, when these are incorrect in the underlying payment instruction for which the cover is issued.")]
public partial record ClaimNonReceiptV06 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ClmNonRct";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Identifies the assignment of an investigation case from an assigner to an assignee.|Usage: The Assigner must be the sender of this confirmation and the Assignee must be the receiver.
    /// </summary>
    [IsoId("_AOwV7V1tEeehlLdFiIrRgQ")]
    [Description(@"Identifies the assignment of an investigation case from an assigner to an assignee.|Usage: The Assigner must be the sender of this confirmation and the Assignee must be the receiver.")]
    [DataMember(Name="Assgnmt")]
    [XmlElement(ElementName="Assgnmt")]
    [Required]
    public required CaseAssignment4 Assignment { get; init; }
    
    /// <summary>
    /// Identifies the investigation case.
    /// </summary>
    [IsoId("_AOwV711tEeehlLdFiIrRgQ")]
    [Description(@"Identifies the investigation case.")]
    [DataMember(Name="Case")]
    [XmlElement(ElementName="Case")]
    public Case4? Case { get; init; }
    
    /// <summary>
    /// Identifies the payment instruction for which the Creditor has not received the funds.|Usage: In case of a missing cover, it must be the identification of the related payment instruction.|In case of a claim non receipt initiated by the debtor, it must be the identification of the instruction.
    /// </summary>
    [IsoId("_AOwV8V1tEeehlLdFiIrRgQ")]
    [Description(@"Identifies the payment instruction for which the Creditor has not received the funds.|Usage: In case of a missing cover, it must be the identification of the related payment instruction.|In case of a claim non receipt initiated by the debtor, it must be the identification of the instruction.")]
    [DataMember(Name="Undrlyg")]
    [XmlElement(ElementName="Undrlyg")]
    [Required]
    public required IUnderlyingTransaction4Choice Underlying { get; init; }
    
    /// <summary>
    /// Provides the cover related information of a claim non receipt investigation. The absence of the component means that the message is not a cover related investigation.
    /// </summary>
    [IsoId("_AOwV811tEeehlLdFiIrRgQ")]
    [Description(@"Provides the cover related information of a claim non receipt investigation. The absence of the component means that the message is not a cover related investigation.")]
    [DataMember(Name="CoverDtls")]
    [XmlElement(ElementName="CoverDtls")]
    public MissingCover3? CoverDetails { get; init; }
    
    /// <summary>
    /// Further information related to the processing of the investigation that may need to be acted upon by the assignee.
    /// </summary>
    [IsoId("_mzKs8dmaEeeVxZK_8SxOLQ")]
    [Description(@"Further information related to the processing of the investigation that may need to be acted upon by the assignee.")]
    [DataMember(Name="InstrForAssgne")]
    [XmlElement(ElementName="InstrForAssgne")]
    public InstructionForAssignee1? InstructionForAssignee { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_AOwV9V1tEeehlLdFiIrRgQ")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ClaimNonReceiptV06Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ClaimNonReceiptV06Document ToDocument()
    {
        return new ClaimNonReceiptV06Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ClaimNonReceiptV06"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ClaimNonReceiptV06Document : IOuterDocument<ClaimNonReceiptV06>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.027.001.06";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ClaimNonReceiptV06"/> is required.
    /// </summary>
    public required ClaimNonReceiptV06 Message { get; init; }
}
