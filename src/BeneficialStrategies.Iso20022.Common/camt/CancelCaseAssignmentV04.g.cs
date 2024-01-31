﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CancelCaseAssignmentV04.  ISO2002 ID# _eX_OnW2PEei3KuUgpx7Xcw.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.camt;


/// <summary>
/// Scope
/// The CancelCaseAssignment message is sent by a case creator or case assigner to a case assignee. This message is used to request the cancellation of a case.
/// Usage
/// The CancelCaseAssignment message is used to stop the processing of a case at a case assignee when a case assignment is incorrect or when the root cause for the case disappears (such as the account owner was able to reconcile after sending a ClaimNonReceipt message).
/// The CancelCaseAssignment message can be used to stop the processing of a:
/// - request to cancel payment case;
/// - request to modify payment case;
/// - unable to apply case;
/// - claim non receipt case.
/// The CancelCaseAssignment message covers one and only one case at a time. If several case assignments need to be cancelled, then multiple CancelCaseAssignment messages must be sent.
/// The CancelCaseAssignment message must be forwarded by all subsequent case assignee(s) in the case processing chain until it reaches the end point.
/// When an agent re-assigns the CancelCaseAssignment to a subsequent case assignee, this agent must send a NotificationOfCaseAssignment message to its assigner.
/// When the CancelCaseAssignment instruction has been acted upon by the relevant case assignee, a ResolutionOfInvestigation message is sent to the case assigner or case creator, in reply.
/// The CancelCaseAssignment message must not be used for other purposes. If, for example, a request to modify payment fails, and the case creator requests the cancellation of the payment, then a CustomerPaymentCancellationRequest or FIToFIPaymentCancellationRequest message must be used, with the case identification of the original RequestToModifyPayment message. In this context it is incorrect to use the CancelCaseAssignment message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The CancelCaseAssignment message is sent by a case creator or case assigner to a case assignee. This message is used to request the cancellation of a case.|Usage|The CancelCaseAssignment message is used to stop the processing of a case at a case assignee when a case assignment is incorrect or when the root cause for the case disappears (such as the account owner was able to reconcile after sending a ClaimNonReceipt message).|The CancelCaseAssignment message can be used to stop the processing of a:|- request to cancel payment case;|- request to modify payment case;|- unable to apply case;|- claim non receipt case.|The CancelCaseAssignment message covers one and only one case at a time. If several case assignments need to be cancelled, then multiple CancelCaseAssignment messages must be sent.|The CancelCaseAssignment message must be forwarded by all subsequent case assignee(s) in the case processing chain until it reaches the end point.|When an agent re-assigns the CancelCaseAssignment to a subsequent case assignee, this agent must send a NotificationOfCaseAssignment message to its assigner.|When the CancelCaseAssignment instruction has been acted upon by the relevant case assignee, a ResolutionOfInvestigation message is sent to the case assigner or case creator, in reply.|The CancelCaseAssignment message must not be used for other purposes. If, for example, a request to modify payment fails, and the case creator requests the cancellation of the payment, then a CustomerPaymentCancellationRequest or FIToFIPaymentCancellationRequest message must be used, with the case identification of the original RequestToModifyPayment message. In this context it is incorrect to use the CancelCaseAssignment message.")]
public partial record CancelCaseAssignmentV04 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CclCaseAssgnmt";
    
    #nullable enable
    /// <summary>
    /// Identifies the assignment of an investigation case from an assigner to an assignee.
    /// Usage: The assigner must be the sender of this confirmation and the assignee must be the receiver.
    /// </summary>
    [IsoId("_eX_On22PEei3KuUgpx7Xcw")]
    [Description(@"Identifies the assignment of an investigation case from an assigner to an assignee.|Usage: The assigner must be the sender of this confirmation and the assignee must be the receiver.")]
    [DataMember(Name="Assgnmt")]
    [XmlElement(ElementName="Assgnmt")]
    [Required]
    public required CaseAssignment5 Assignment { get; init; }
    
    /// <summary>
    /// Identifies the investigation case.
    /// </summary>
    [IsoId("_eX_OoW2PEei3KuUgpx7Xcw")]
    [Description(@"Identifies the investigation case.")]
    [DataMember(Name="Case")]
    [XmlElement(ElementName="Case")]
    [Required]
    public required Case5 Case { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_eX_Oo22PEei3KuUgpx7Xcw")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CancelCaseAssignmentV04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CancelCaseAssignmentV04Document ToDocument()
    {
        return new CancelCaseAssignmentV04Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CancelCaseAssignmentV04"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record CancelCaseAssignmentV04Document : IOuterDocument<CancelCaseAssignmentV04>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.032.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CancelCaseAssignmentV04"/> is required.
    /// </summary>
    public required CancelCaseAssignmentV04 Message { get; init; }
}
