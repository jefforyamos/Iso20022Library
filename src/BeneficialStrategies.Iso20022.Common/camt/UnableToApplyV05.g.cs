﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for UnableToApplyV05.  ISO2002 ID# _1ksHkUglEeaGKYpLDboHPQ.
//
namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// Scope
/// The Unable To Apply message is sent by a case creator or a case assigner to a case assignee. This message is used to initiate an investigation of a payment instruction that cannot be executed or reconciled.
/// Usage
/// The Unable To Apply case occurs in two situations:
/// - an agent cannot execute the payment instruction due to missing or incorrect information
/// - a creditor cannot reconcile the payment entry as it is received unexpectedly, or missing or incorrect information prevents reconciliation
/// The Unable To Apply message
/// - always follows the reverse route of the original payment instruction
/// - must be forwarded to the preceding agents in the payment processing chain, where appropriate
/// - covers one and only one payment instruction (or payment entry) at a time; if several payment instructions cannot be executed or several payment entries cannot be reconciled, then multiple Unable To Apply messages must be sent.
/// Depending on what stage the payment is and what has been done to it, for example incorrect routing, errors/omissions when processing the instruction or even the absence of any error, the unable to apply case may lead to a:
/// - Additional Payment Information message, sent to the case creator/case assigner, if a truncation or omission in a payment instruction prevented reconciliation.
/// - Request To Cancel Payment message, sent to the subsequent agent in the payment processing chain, if the original payment instruction has been incorrectly routed through the chain of agents (this also entails a new corrected payment instruction being issued). Prior to sending the payment cancellation request, the agent should first send a resolution indicating that a cancellation will follow (CWFW).
/// - Request To Modify Payment message, sent to the subsequent agent in the payment processing chain, if a truncation or omission has occurred during the processing of the original payment instruction. Prior to sending the modify payment request, the agent should first send a resolution indicating that a modification will follow (MWFW).
/// - Debit Authorisation Request message, sent to the case creator/case assigner, if the payment instruction has reached an incorrect creditor.
/// The UnableToApply message has the following main characteristics:
/// The case creator (the instructed party/creditor of a payment instruction) assigns a unique case identification and optionally the reason code for the Unable To Apply message. This information will be passed unchanged to all subsequent case assignees.
/// The case creator specifies the identification of the underlying payment instruction. This identification needs to be updated by the subsequent case assigner(s) in order to match the one used with their case assignee(s).
/// The Unable To Apply Justification element allows the assigner to indicate whether a specific element causes the unable to apply situation (incorrect element and/or mismatched element can be listed) or whether any supplementary information needs to be forwarded.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The Unable To Apply message is sent by a case creator or a case assigner to a case assignee. This message is used to initiate an investigation of a payment instruction that cannot be executed or reconciled.|Usage|The Unable To Apply case occurs in two situations:|- an agent cannot execute the payment instruction due to missing or incorrect information|- a creditor cannot reconcile the payment entry as it is received unexpectedly, or missing or incorrect information prevents reconciliation|The Unable To Apply message|- always follows the reverse route of the original payment instruction|- must be forwarded to the preceding agents in the payment processing chain, where appropriate|- covers one and only one payment instruction (or payment entry) at a time; if several payment instructions cannot be executed or several payment entries cannot be reconciled, then multiple Unable To Apply messages must be sent.|Depending on what stage the payment is and what has been done to it, for example incorrect routing, errors/omissions when processing the instruction or even the absence of any error, the unable to apply case may lead to a:|- Additional Payment Information message, sent to the case creator/case assigner, if a truncation or omission in a payment instruction prevented reconciliation.|- Request To Cancel Payment message, sent to the subsequent agent in the payment processing chain, if the original payment instruction has been incorrectly routed through the chain of agents (this also entails a new corrected payment instruction being issued). Prior to sending the payment cancellation request, the agent should first send a resolution indicating that a cancellation will follow (CWFW).|- Request To Modify Payment message, sent to the subsequent agent in the payment processing chain, if a truncation or omission has occurred during the processing of the original payment instruction. Prior to sending the modify payment request, the agent should first send a resolution indicating that a modification will follow (MWFW).|- Debit Authorisation Request message, sent to the case creator/case assigner, if the payment instruction has reached an incorrect creditor.|The UnableToApply message has the following main characteristics:|The case creator (the instructed party/creditor of a payment instruction) assigns a unique case identification and optionally the reason code for the Unable To Apply message. This information will be passed unchanged to all subsequent case assignees.|The case creator specifies the identification of the underlying payment instruction. This identification needs to be updated by the subsequent case assigner(s) in order to match the one used with their case assignee(s).|The Unable To Apply Justification element allows the assigner to indicate whether a specific element causes the unable to apply situation (incorrect element and/or mismatched element can be listed) or whether any supplementary information needs to be forwarded.")]
public partial record UnableToApplyV05 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "UblToApply";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="UnableToApplyV05Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public UnableToApplyV05Document ToDocument()
    {
        return new UnableToApplyV05Document { Message = this };
    }
}

/// <summary>
/// Scope
/// The Unable To Apply message is sent by a case creator or a case assigner to a case assignee. This message is used to initiate an investigation of a payment instruction that cannot be executed or reconciled.
/// Usage
/// The Unable To Apply case occurs in two situations:
/// - an agent cannot execute the payment instruction due to missing or incorrect information
/// - a creditor cannot reconcile the payment entry as it is received unexpectedly, or missing or incorrect information prevents reconciliation
/// The Unable To Apply message
/// - always follows the reverse route of the original payment instruction
/// - must be forwarded to the preceding agents in the payment processing chain, where appropriate
/// - covers one and only one payment instruction (or payment entry) at a time; if several payment instructions cannot be executed or several payment entries cannot be reconciled, then multiple Unable To Apply messages must be sent.
/// Depending on what stage the payment is and what has been done to it, for example incorrect routing, errors/omissions when processing the instruction or even the absence of any error, the unable to apply case may lead to a:
/// - Additional Payment Information message, sent to the case creator/case assigner, if a truncation or omission in a payment instruction prevented reconciliation.
/// - Request To Cancel Payment message, sent to the subsequent agent in the payment processing chain, if the original payment instruction has been incorrectly routed through the chain of agents (this also entails a new corrected payment instruction being issued). Prior to sending the payment cancellation request, the agent should first send a resolution indicating that a cancellation will follow (CWFW).
/// - Request To Modify Payment message, sent to the subsequent agent in the payment processing chain, if a truncation or omission has occurred during the processing of the original payment instruction. Prior to sending the modify payment request, the agent should first send a resolution indicating that a modification will follow (MWFW).
/// - Debit Authorisation Request message, sent to the case creator/case assigner, if the payment instruction has reached an incorrect creditor.
/// The UnableToApply message has the following main characteristics:
/// The case creator (the instructed party/creditor of a payment instruction) assigns a unique case identification and optionally the reason code for the Unable To Apply message. This information will be passed unchanged to all subsequent case assignees.
/// The case creator specifies the identification of the underlying payment instruction. This identification needs to be updated by the subsequent case assigner(s) in order to match the one used with their case assignee(s).
/// The Unable To Apply Justification element allows the assigner to indicate whether a specific element causes the unable to apply situation (incorrect element and/or mismatched element can be listed) or whether any supplementary information needs to be forwarded.
/// This is the outer document that contains <seealso cref="UnableToApplyV05"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record UnableToApplyV05Document : IOuterDocument<UnableToApplyV05>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.026.001.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="UnableToApplyV05"/> is required.
    /// </summary>
    public required UnableToApplyV05 Message { get; init; }
}
