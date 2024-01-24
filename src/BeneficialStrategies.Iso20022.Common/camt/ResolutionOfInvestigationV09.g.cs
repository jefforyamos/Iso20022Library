﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ResolutionOfInvestigationV09.  ISO2002 ID# _eX_OZ22PEei3KuUgpx7Xcw.
//
namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// Scope
/// The ResolutionOfInvestigation message is sent by a case assignee to a case creator/case assigner.
/// This message is used to inform of the resolution of a case, and optionally provides details about.
/// - the corrective action undertaken by the case assignee;
/// - information on the return where applicable.
/// Usage
/// The ResolutionOfInvestigation message is used by the case assignee to inform a case creator or case assigner about the resolution of a:
/// - request to cancel payment case;
/// - request to modify payment case;
/// - unable to apply case;
/// - claim non receipt case.
/// The ResolutionOfInvestigation message covers one and only one case at a time. If the case assignee needs to communicate about several cases, then several Resolution Of Investigation messages must be sent.
/// The ResolutionOfInvestigation message provides:
/// - the final outcome of the case, whether positive or negative;
/// - optionally, the details of the corrective action undertaken by the case assignee and the information of the return.
/// Whenever a payment instruction has been generated to solve the case under investigation following a claim non receipt or an unable to apply, the optional CorrectionTransaction component present in the message must be completed.
/// Whenever the action of modifying or cancelling a payment results in funds being returned or reversed, an investigating agent may provide the details in the resolution related investigation component, to identify the return or reversal transaction. These details will facilitate the account reconciliations at the initiating bank and the intermediaries. It must be stressed that the return or reversal of funds is outside the scope of this Exceptions and Investigation service. The features given here is only meant to transmit the information of return or reversal when it is available through the resolution of the case.
/// The ResolutionOfInvestigation message must:
/// - be forwarded by all subsequent case assignee(s) until it reaches the case creator;
/// - not be used in place of a RejectCaseAssignment or CaseStatusReport or NotificationOfCaseAssignment message.
/// Take note of an exceptional rule that allows the use of ResolutionOfInvestigation in lieu of a CaseStatusReport. CaseStatusReport is a response-message to a CaseStatusReportRequest. The latter which is sent when the assigner has reached its own time-out threshold to receive a response. However it may happen that when the request arrives, the investigating agent has just obtained a resolution. In such a situation, it would be redundant to send a CaseStatusReport when then followed immediately by a ResolutionOfInvestigation. It is therefore quite acceptable for the investigating agent, the assignee, to skip the Case Status Report and send the ResolutionOfInvestigation message directly.
/// The ResolutionOfInvestigation message should be the sole message to respond to a cancellation request. Details of the underlying transactions and the related statuses for which the cancellation request has been issued may be provided in the CancellationDetails component.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The ResolutionOfInvestigation message is sent by a case assignee to a case creator/case assigner.|This message is used to inform of the resolution of a case, and optionally provides details about.|- the corrective action undertaken by the case assignee;|- information on the return where applicable.|Usage|The ResolutionOfInvestigation message is used by the case assignee to inform a case creator or case assigner about the resolution of a:|- request to cancel payment case;|- request to modify payment case;|- unable to apply case;|- claim non receipt case.|The ResolutionOfInvestigation message covers one and only one case at a time. If the case assignee needs to communicate about several cases, then several Resolution Of Investigation messages must be sent.|The ResolutionOfInvestigation message provides:|- the final outcome of the case, whether positive or negative;|- optionally, the details of the corrective action undertaken by the case assignee and the information of the return.|Whenever a payment instruction has been generated to solve the case under investigation following a claim non receipt or an unable to apply, the optional CorrectionTransaction component present in the message must be completed.|Whenever the action of modifying or cancelling a payment results in funds being returned or reversed, an investigating agent may provide the details in the resolution related investigation component, to identify the return or reversal transaction. These details will facilitate the account reconciliations at the initiating bank and the intermediaries. It must be stressed that the return or reversal of funds is outside the scope of this Exceptions and Investigation service. The features given here is only meant to transmit the information of return or reversal when it is available through the resolution of the case.|The ResolutionOfInvestigation message must:|- be forwarded by all subsequent case assignee(s) until it reaches the case creator;|- not be used in place of a RejectCaseAssignment or CaseStatusReport or NotificationOfCaseAssignment message.|Take note of an exceptional rule that allows the use of ResolutionOfInvestigation in lieu of a CaseStatusReport. CaseStatusReport is a response-message to a CaseStatusReportRequest. The latter which is sent when the assigner has reached its own time-out threshold to receive a response. However it may happen that when the request arrives, the investigating agent has just obtained a resolution. In such a situation, it would be redundant to send a CaseStatusReport when then followed immediately by a ResolutionOfInvestigation. It is therefore quite acceptable for the investigating agent, the assignee, to skip the Case Status Report and send the ResolutionOfInvestigation message directly.|The ResolutionOfInvestigation message should be the sole message to respond to a cancellation request. Details of the underlying transactions and the related statuses for which the cancellation request has been issued may be provided in the CancellationDetails component.")]
public partial record ResolutionOfInvestigationV09 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RsltnOfInvstgtn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ResolutionOfInvestigationV09Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ResolutionOfInvestigationV09Document ToDocument()
    {
        return new ResolutionOfInvestigationV09Document { Message = this };
    }
}

/// <summary>
/// Scope
/// The ResolutionOfInvestigation message is sent by a case assignee to a case creator/case assigner.
/// This message is used to inform of the resolution of a case, and optionally provides details about.
/// - the corrective action undertaken by the case assignee;
/// - information on the return where applicable.
/// Usage
/// The ResolutionOfInvestigation message is used by the case assignee to inform a case creator or case assigner about the resolution of a:
/// - request to cancel payment case;
/// - request to modify payment case;
/// - unable to apply case;
/// - claim non receipt case.
/// The ResolutionOfInvestigation message covers one and only one case at a time. If the case assignee needs to communicate about several cases, then several Resolution Of Investigation messages must be sent.
/// The ResolutionOfInvestigation message provides:
/// - the final outcome of the case, whether positive or negative;
/// - optionally, the details of the corrective action undertaken by the case assignee and the information of the return.
/// Whenever a payment instruction has been generated to solve the case under investigation following a claim non receipt or an unable to apply, the optional CorrectionTransaction component present in the message must be completed.
/// Whenever the action of modifying or cancelling a payment results in funds being returned or reversed, an investigating agent may provide the details in the resolution related investigation component, to identify the return or reversal transaction. These details will facilitate the account reconciliations at the initiating bank and the intermediaries. It must be stressed that the return or reversal of funds is outside the scope of this Exceptions and Investigation service. The features given here is only meant to transmit the information of return or reversal when it is available through the resolution of the case.
/// The ResolutionOfInvestigation message must:
/// - be forwarded by all subsequent case assignee(s) until it reaches the case creator;
/// - not be used in place of a RejectCaseAssignment or CaseStatusReport or NotificationOfCaseAssignment message.
/// Take note of an exceptional rule that allows the use of ResolutionOfInvestigation in lieu of a CaseStatusReport. CaseStatusReport is a response-message to a CaseStatusReportRequest. The latter which is sent when the assigner has reached its own time-out threshold to receive a response. However it may happen that when the request arrives, the investigating agent has just obtained a resolution. In such a situation, it would be redundant to send a CaseStatusReport when then followed immediately by a ResolutionOfInvestigation. It is therefore quite acceptable for the investigating agent, the assignee, to skip the Case Status Report and send the ResolutionOfInvestigation message directly.
/// The ResolutionOfInvestigation message should be the sole message to respond to a cancellation request. Details of the underlying transactions and the related statuses for which the cancellation request has been issued may be provided in the CancellationDetails component.
/// This is the outer document that contains <seealso cref="ResolutionOfInvestigationV09"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ResolutionOfInvestigationV09Document : IOuterDocument<ResolutionOfInvestigationV09>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.029.001.09";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ResolutionOfInvestigationV09"/> is required.
    /// </summary>
    public required ResolutionOfInvestigationV09 Message { get; init; }
}
