﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CustomerPaymentCancellationRequestV01.  ISO2002 ID# _RsSUuNE-Ed-BzquC8wXy7w_377163299.
//
namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// Scope
/// The Customer Payment Cancellation Request message is sent by a case creator/case assigner to a case assignee.
/// This message is used to request the cancellation of an original payment instruction. The Customer Payment Cancellation Request message is issued by the initiating party to request the cancellation of an initiation payment message previously sent (such as CustomerCreditTransferInitiation or CustomerDirectDebitInitiation).
/// Usage
/// The Customer Payment Cancellation Request message must be answered with a:
/// - Resolution Of Investigation message with a positive final outcome when the case assignee can perform the requested cancellation
/// - Resolution Of Investigation message with a negative final outcome when the case assignee may perform the requested cancellation but fails to do so (too late, irrevocable instruction.)
/// - Reject Investigation message when the case assignee is unable or not authorised to perform the requested cancellation
/// - Notification Of Case Assignment message to indicate whether the case assignee will take on the case himself or reassign the case to a subsequent party in the payment processing chain.
/// A Customer Payment Cancellation Request message concerns one and only one original payment instruction at a time.
/// When a case assignee successfully performs a cancellation, it must return the corresponding funds to the case assigner. It may provide some details about the return in the Resolution Of Investigation message.
/// The processing of a Customer Payment Cancellation Request message case may lead to a Debit Authorisation Request message sent to the creditor by its account servicing institution.
/// The Customer Payment Cancellation Request message may be used to escalate a case after an unsuccessful request to modify the payment. In this scenario, the case identification remains the same as in the original Customer Payment Cancellation Request message and the element ReopenCaseIndication is set to 'Yes' or 'true'.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The Customer Payment Cancellation Request message is sent by a case creator/case assigner to a case assignee.|This message is used to request the cancellation of an original payment instruction. The Customer Payment Cancellation Request message is issued by the initiating party to request the cancellation of an initiation payment message previously sent (such as CustomerCreditTransferInitiation or CustomerDirectDebitInitiation).|Usage|The Customer Payment Cancellation Request message must be answered with a:|- Resolution Of Investigation message with a positive final outcome when the case assignee can perform the requested cancellation|- Resolution Of Investigation message with a negative final outcome when the case assignee may perform the requested cancellation but fails to do so (too late, irrevocable instruction.)|- Reject Investigation message when the case assignee is unable or not authorised to perform the requested cancellation|- Notification Of Case Assignment message to indicate whether the case assignee will take on the case himself or reassign the case to a subsequent party in the payment processing chain.|A Customer Payment Cancellation Request message concerns one and only one original payment instruction at a time.|When a case assignee successfully performs a cancellation, it must return the corresponding funds to the case assigner. It may provide some details about the return in the Resolution Of Investigation message.|The processing of a Customer Payment Cancellation Request message case may lead to a Debit Authorisation Request message sent to the creditor by its account servicing institution.|The Customer Payment Cancellation Request message may be used to escalate a case after an unsuccessful request to modify the payment. In this scenario, the case identification remains the same as in the original Customer Payment Cancellation Request message and the element ReopenCaseIndication is set to 'Yes' or 'true'.")]
public partial record CustomerPaymentCancellationRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CstmrPmtCxlReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Identifies the assignment of an investigation case from an assigner to an assignee.|Usage: The Assigner must be the sender of this confirmation and the Assignee must be the receiver.
    /// </summary>
    [IsoId("_RsSUudE-Ed-BzquC8wXy7w_731514639")]
    [Description(@"Identifies the assignment of an investigation case from an assigner to an assignee.|Usage: The Assigner must be the sender of this confirmation and the Assignee must be the receiver.")]
    [DataMember(Name="Assgnmt")]
    [XmlElement(ElementName="Assgnmt")]
    [Required]
    public required SomeAssignmentRecord Assignment { get; init; }
    
    /// <summary>
    /// Identifies the investigation case.
    /// </summary>
    [IsoId("_RsSUutE-Ed-BzquC8wXy7w_377163330")]
    [Description(@"Identifies the investigation case.")]
    [DataMember(Name="Case")]
    [XmlElement(ElementName="Case")]
    public SomeCaseRecord? Case { get; init; }
    
    /// <summary>
    /// Provides details on the number of transactions and the control sum of the message.
    /// </summary>
    [IsoId("_RsSUu9E-Ed-BzquC8wXy7w_731514361")]
    [Description(@"Provides details on the number of transactions and the control sum of the message.")]
    [DataMember(Name="CtrlData")]
    [XmlElement(ElementName="CtrlData")]
    public SomeControlDataRecord? ControlData { get; init; }
    
    /// <summary>
    /// Identifies the payment instruction to be cancelled.
    /// </summary>
    [IsoId("_RscFsNE-Ed-BzquC8wXy7w_377163639")]
    [Description(@"Identifies the payment instruction to be cancelled.")]
    [DataMember(Name="Undrlyg")]
    [XmlElement(ElementName="Undrlyg")]
    [Required]
    public required SomeUnderlyingRecord Underlying { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CustomerPaymentCancellationRequestV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CustomerPaymentCancellationRequestV01Document ToDocument()
    {
        return new CustomerPaymentCancellationRequestV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CustomerPaymentCancellationRequestV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record CustomerPaymentCancellationRequestV01Document : IOuterDocument<CustomerPaymentCancellationRequestV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.055.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CustomerPaymentCancellationRequestV01"/> is required.
    /// </summary>
    public required CustomerPaymentCancellationRequestV01 Message { get; init; }
}