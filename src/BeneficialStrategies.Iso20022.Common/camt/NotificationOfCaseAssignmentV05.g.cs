﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for NotificationOfCaseAssignmentV05.  ISO2002 ID# _eX_Oh22PEei3KuUgpx7Xcw.
//
namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// Scope
/// The NotificationOfCaseAssignment message is sent by a case assignee to a case creator/case assigner.
/// This message is used to inform the case assigner that:
/// - the assignee is reassigning the case to the next agent in the transaction processing chain for further action
/// - the assignee will work on the case himself, without re-assigning it to another party, and therefore indicating that the re-assignment has reached its end-point
/// Usage
/// The NotificationOfCaseAssignment message is used to notify the case creator or case assigner of further action undertaken by the case assignee in a:
/// - request to cancel payment case;
/// - request to modify payment case;
/// - unable to apply case;
/// - claim non receipt case.
/// The NotificationOfCaseAssignment message:
/// - covers one and only one case at a time. If the case assignee needs to inform a case creator or case assigner about several cases, then multiple Notification Of Case Assignment messages must be sent;
/// - except in the case where it is used to indicate that an agent is doing the correction himself, this message must be forwarded by all subsequent case assigner(s) until it reaches the case creator;
/// - must not be used in place of a Resolution Of Investigation or a Case Status Report message.
/// When the assignee does not reassign the case to another party (that is responding with a NotificationOfCaseAssignment message with notification MINE - The case is processed by the assignee), the case assignment should contain the case assignment elements as received in the original query.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The NotificationOfCaseAssignment message is sent by a case assignee to a case creator/case assigner.|This message is used to inform the case assigner that:|- the assignee is reassigning the case to the next agent in the transaction processing chain for further action|- the assignee will work on the case himself, without re-assigning it to another party, and therefore indicating that the re-assignment has reached its end-point|Usage|The NotificationOfCaseAssignment message is used to notify the case creator or case assigner of further action undertaken by the case assignee in a:|- request to cancel payment case;|- request to modify payment case;|- unable to apply case;|- claim non receipt case.|The NotificationOfCaseAssignment message:|- covers one and only one case at a time. If the case assignee needs to inform a case creator or case assigner about several cases, then multiple Notification Of Case Assignment messages must be sent;|- except in the case where it is used to indicate that an agent is doing the correction himself, this message must be forwarded by all subsequent case assigner(s) until it reaches the case creator;|- must not be used in place of a Resolution Of Investigation or a Case Status Report message.|When the assignee does not reassign the case to another party (that is responding with a NotificationOfCaseAssignment message with notification MINE - The case is processed by the assignee), the case assignment should contain the case assignment elements as received in the original query.")]
public partial record NotificationOfCaseAssignmentV05 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "NtfctnOfCaseAssgnmt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Specifies generic information about the notification.|The receiver of a notification must be the party which assigned the case to the sender.
    /// </summary>
    [IsoId("_eX_OiW2PEei3KuUgpx7Xcw")]
    [Description(@"Specifies generic information about the notification.|The receiver of a notification must be the party which assigned the case to the sender.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required ReportHeader5 Header { get; init; }
    
    /// <summary>
    /// Identifies the investigation case.
    /// </summary>
    [IsoId("_eX_Oi22PEei3KuUgpx7Xcw")]
    [Description(@"Identifies the investigation case.")]
    [DataMember(Name="Case")]
    [XmlElement(ElementName="Case")]
    [Required]
    public required Case5 Case { get; init; }
    
    /// <summary>
    /// Identifies the assignment of an investigation case from an assigner to an assignee.
    /// Usage: The assigner must be the sender of this confirmation and the assignee must be the receiver.
    /// </summary>
    [IsoId("_eX_OjW2PEei3KuUgpx7Xcw")]
    [Description(@"Identifies the assignment of an investigation case from an assigner to an assignee.|Usage: The assigner must be the sender of this confirmation and the assignee must be the receiver.")]
    [DataMember(Name="Assgnmt")]
    [XmlElement(ElementName="Assgnmt")]
    [Required]
    public required CaseAssignment5 Assignment { get; init; }
    
    /// <summary>
    /// Information about the type of action taken.
    /// </summary>
    [IsoId("_eX_Oj22PEei3KuUgpx7Xcw")]
    [Description(@"Information about the type of action taken.")]
    [DataMember(Name="Ntfctn")]
    [XmlElement(ElementName="Ntfctn")]
    [Required]
    public required CaseForwardingNotification3 Notification { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_eX_OkW2PEei3KuUgpx7Xcw")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="NotificationOfCaseAssignmentV05Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public NotificationOfCaseAssignmentV05Document ToDocument()
    {
        return new NotificationOfCaseAssignmentV05Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="NotificationOfCaseAssignmentV05"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record NotificationOfCaseAssignmentV05Document : IOuterDocument<NotificationOfCaseAssignmentV05>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.030.001.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="NotificationOfCaseAssignmentV05"/> is required.
    /// </summary>
    public required NotificationOfCaseAssignmentV05 Message { get; init; }
}
