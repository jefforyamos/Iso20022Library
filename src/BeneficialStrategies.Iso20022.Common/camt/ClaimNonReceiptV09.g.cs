﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ClaimNonReceiptV09.  ISO2002 ID# _IBiyZ9cBEeq_l4BJLVUF2Q.
//
namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// Scope
/// The ClaimNonReceipt message is sent by a case creator/case assigner to a case assignee.
/// This message is used to initiate an investigation for missing funds at the creditor (missing credit entry to its account) or at an agent along the processing chain (missing cover for a received payment instruction).
/// Usage
/// The claim non receipt case occurs in two situations: 
/// - The creditor is expecting funds from a particular debtor and cannot find the corresponding credit entry on its account. In this situation, it is understood that the creditor will contact its debtor, and that the debtor will trigger the claim non receipt case on its behalf. A workflow where the creditor directly addresses a ClaimNonReceipt message to its account servicing institution is not retained;
/// - An agent in the processing chain cannot find a cover payment corresponding to a received payment instruction. In this situation, the agent may directly trigger the investigation by sending a ClaimNonReceipt message to the sender of the original payment instruction.
/// The ClaimNonReceipt message covers one and only one payment instruction at a time. If several expected payment instructions/cover instructions are found missing, then multiple ClaimNonReceipt messages must be sent.
/// Depending on the result of the investigation by a case assignee (incorrect routing, errors/omissions when processing the instruction or even the absence of an error) and the stage at which the payment instruction is being process, the claim non receipt case may lead to a: 
/// - CustomerPaymentCancellationRequest or FIToFIPaymentCancellationRequest message, sent to the subsequent agent in the payment processing chain, if the original payment instruction has been incorrectly routed through the chain of agents. (This also implies that a new, corrected, payment instruction is issued);
/// - RequestToModifyPayment message, sent to the subsequent agent in the payment processing chain, if a truncation or omission has occurred during the processing of the original payment instruction.
/// If the above situations occur, the assignee wanting to request a payment cancellation or payment modification should first send out a ResolutionOfInvestigation with a confirmation status that indicates that either cancellation (CWFW) modification (MWFW) or unable to apply (UWFW) will follow. (See section on ResolutionOfInvestigation for more details).
/// In the cover is missing, the case assignee may also simply issue the omitted cover payment or when the initial cover information was incorrect, update the cover (through modification and/or cancellation as required) with the correction information provided in the ClaimNonReceipt message. The case assignee will issue a ResolutionOfInvestigation message with the CorrectionTransaction element mentioning the references of the cover payment.
/// The ClaimNonReceipt message may be forwarded to subsequent case assignees.
/// The ClaimNonReceipt message has the following main characteristics: 
/// - Case identification: The case creator assigns a unique case identification. This information will be passed unchanged to subsequent case assignee(s);
/// - Underlying payment: The case creator refers to the underlying payment instruction for the unambiguous identification of the payment instruction. This identification needs to be updated by the subsequent case assigner(s) in order to match the one used with their case assignee(s);
/// - Missing cover indicator: The MissingCoverIndicator element distinguishes between a missing cover situation (when set to YES - true) or a missing funds situation (when set to NO - false);
/// - CoverCorrection: The CoverCorrection element allows the case assigner to provide corrected cover information, when these are incorrect in the underlying payment instruction for which the cover is issued.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The ClaimNonReceipt message is sent by a case creator/case assigner to a case assignee.|This message is used to initiate an investigation for missing funds at the creditor (missing credit entry to its account) or at an agent along the processing chain (missing cover for a received payment instruction).|Usage|The claim non receipt case occurs in two situations: |- The creditor is expecting funds from a particular debtor and cannot find the corresponding credit entry on its account. In this situation, it is understood that the creditor will contact its debtor, and that the debtor will trigger the claim non receipt case on its behalf. A workflow where the creditor directly addresses a ClaimNonReceipt message to its account servicing institution is not retained;|- An agent in the processing chain cannot find a cover payment corresponding to a received payment instruction. In this situation, the agent may directly trigger the investigation by sending a ClaimNonReceipt message to the sender of the original payment instruction.|The ClaimNonReceipt message covers one and only one payment instruction at a time. If several expected payment instructions/cover instructions are found missing, then multiple ClaimNonReceipt messages must be sent.|Depending on the result of the investigation by a case assignee (incorrect routing, errors/omissions when processing the instruction or even the absence of an error) and the stage at which the payment instruction is being process, the claim non receipt case may lead to a: |- CustomerPaymentCancellationRequest or FIToFIPaymentCancellationRequest message, sent to the subsequent agent in the payment processing chain, if the original payment instruction has been incorrectly routed through the chain of agents. (This also implies that a new, corrected, payment instruction is issued);|- RequestToModifyPayment message, sent to the subsequent agent in the payment processing chain, if a truncation or omission has occurred during the processing of the original payment instruction.|If the above situations occur, the assignee wanting to request a payment cancellation or payment modification should first send out a ResolutionOfInvestigation with a confirmation status that indicates that either cancellation (CWFW) modification (MWFW) or unable to apply (UWFW) will follow. (See section on ResolutionOfInvestigation for more details).|In the cover is missing, the case assignee may also simply issue the omitted cover payment or when the initial cover information was incorrect, update the cover (through modification and/or cancellation as required) with the correction information provided in the ClaimNonReceipt message. The case assignee will issue a ResolutionOfInvestigation message with the CorrectionTransaction element mentioning the references of the cover payment.|The ClaimNonReceipt message may be forwarded to subsequent case assignees.|The ClaimNonReceipt message has the following main characteristics: |- Case identification: The case creator assigns a unique case identification. This information will be passed unchanged to subsequent case assignee(s);|- Underlying payment: The case creator refers to the underlying payment instruction for the unambiguous identification of the payment instruction. This identification needs to be updated by the subsequent case assigner(s) in order to match the one used with their case assignee(s);|- Missing cover indicator: The MissingCoverIndicator element distinguishes between a missing cover situation (when set to YES - true) or a missing funds situation (when set to NO - false);|- CoverCorrection: The CoverCorrection element allows the case assigner to provide corrected cover information, when these are incorrect in the underlying payment instruction for which the cover is issued.")]
public partial record ClaimNonReceiptV09 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ClmNonRct";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ClaimNonReceiptV09Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ClaimNonReceiptV09Document ToDocument()
    {
        return new ClaimNonReceiptV09Document { Message = this };
    }
}

/// <summary>
/// Scope
/// The ClaimNonReceipt message is sent by a case creator/case assigner to a case assignee.
/// This message is used to initiate an investigation for missing funds at the creditor (missing credit entry to its account) or at an agent along the processing chain (missing cover for a received payment instruction).
/// Usage
/// The claim non receipt case occurs in two situations: 
/// - The creditor is expecting funds from a particular debtor and cannot find the corresponding credit entry on its account. In this situation, it is understood that the creditor will contact its debtor, and that the debtor will trigger the claim non receipt case on its behalf. A workflow where the creditor directly addresses a ClaimNonReceipt message to its account servicing institution is not retained;
/// - An agent in the processing chain cannot find a cover payment corresponding to a received payment instruction. In this situation, the agent may directly trigger the investigation by sending a ClaimNonReceipt message to the sender of the original payment instruction.
/// The ClaimNonReceipt message covers one and only one payment instruction at a time. If several expected payment instructions/cover instructions are found missing, then multiple ClaimNonReceipt messages must be sent.
/// Depending on the result of the investigation by a case assignee (incorrect routing, errors/omissions when processing the instruction or even the absence of an error) and the stage at which the payment instruction is being process, the claim non receipt case may lead to a: 
/// - CustomerPaymentCancellationRequest or FIToFIPaymentCancellationRequest message, sent to the subsequent agent in the payment processing chain, if the original payment instruction has been incorrectly routed through the chain of agents. (This also implies that a new, corrected, payment instruction is issued);
/// - RequestToModifyPayment message, sent to the subsequent agent in the payment processing chain, if a truncation or omission has occurred during the processing of the original payment instruction.
/// If the above situations occur, the assignee wanting to request a payment cancellation or payment modification should first send out a ResolutionOfInvestigation with a confirmation status that indicates that either cancellation (CWFW) modification (MWFW) or unable to apply (UWFW) will follow. (See section on ResolutionOfInvestigation for more details).
/// In the cover is missing, the case assignee may also simply issue the omitted cover payment or when the initial cover information was incorrect, update the cover (through modification and/or cancellation as required) with the correction information provided in the ClaimNonReceipt message. The case assignee will issue a ResolutionOfInvestigation message with the CorrectionTransaction element mentioning the references of the cover payment.
/// The ClaimNonReceipt message may be forwarded to subsequent case assignees.
/// The ClaimNonReceipt message has the following main characteristics: 
/// - Case identification: The case creator assigns a unique case identification. This information will be passed unchanged to subsequent case assignee(s);
/// - Underlying payment: The case creator refers to the underlying payment instruction for the unambiguous identification of the payment instruction. This identification needs to be updated by the subsequent case assigner(s) in order to match the one used with their case assignee(s);
/// - Missing cover indicator: The MissingCoverIndicator element distinguishes between a missing cover situation (when set to YES - true) or a missing funds situation (when set to NO - false);
/// - CoverCorrection: The CoverCorrection element allows the case assigner to provide corrected cover information, when these are incorrect in the underlying payment instruction for which the cover is issued.
/// This is the outer document that contains <seealso cref="ClaimNonReceiptV09"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ClaimNonReceiptV09Document : IOuterDocument<ClaimNonReceiptV09>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.027.001.09";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ClaimNonReceiptV09"/> is required.
    /// </summary>
    public required ClaimNonReceiptV09 Message { get; init; }
}
