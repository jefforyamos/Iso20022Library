﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ResolutionOfInvestigation.  ISO2002 ID# _VIjx1tE_Ed-BzquC8wXy7w_2008786370.
//
namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// Scope
/// The Resolution Of Investigation message is sent by a case assignee to a case creator/case assigner.
/// This message is used to inform of the resolution of a case, and optionally provides details about.
/// - the corrective action undertaken by the case assignee
/// - information on the return where applicable
/// Usage
/// The Resolution Of Investigation message is used by the case assignee to inform a case creator or case assigner about the resolution of a:
/// - request to cancel payment case
/// - request to modify payment case
/// - unable to apply case
/// - claim non receipt case
/// The Resolution Of Investigation message covers one and only one case at a time. If the case assignee needs to communicate about several cases, then several Resolution Of Investigation messages must be sent.
/// The Resolution Of Investigation message provides:
/// - the final outcome of the case, whether positive or negative
/// - optionally, the details of the corrective action undertaken by the case assignee and the information of the return
/// Whenever a payment instruction has been generated to solve the case under investigation, the optional CorrectionTransaction component present in the message must be completed.
/// Whenever the action of modifying or cancelling a payment results in funds being returned, an investigating agent may attached some details in this message. These details facilitates the account reconciliations at the initiating bank and the intermediaries. It must be stressed that returning of funds is outside the scope of this Exceptions and Investigation service. The features given here is only meant to transmit the information of returns when it is available.
/// The Resolution Of Investigation message must
/// - be forwarded by all subsequent case assignee(s) until it reaches the case creator
/// - not be used in place of a Reject Case Assignment or Case Status Report or Notification Of Case Assignment message.
/// Take note of an exceptional rule that allows the use of Resolution Of Investigation in lieu of a Case Status Report. Case Status Report is a response-message to a Case Status Report Request. The latter which is sent when the assigner has waited too long (by his standard) for an answer. However it may happen that when the Request arrives, the investigating agent has just obtained a resolution. In such a situation, it would be redundant to send a Case Status Report when then followed immediately by a Resolution Of Investigation. It is therefore quite acceptable for the investigating agent, the assignee, to skip the Case Status Report and send the Resolution Of Investigation message directly.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The Resolution Of Investigation message is sent by a case assignee to a case creator/case assigner.|This message is used to inform of the resolution of a case, and optionally provides details about.|- the corrective action undertaken by the case assignee|- information on the return where applicable|Usage|The Resolution Of Investigation message is used by the case assignee to inform a case creator or case assigner about the resolution of a:|- request to cancel payment case|- request to modify payment case|- unable to apply case|- claim non receipt case|The Resolution Of Investigation message covers one and only one case at a time. If the case assignee needs to communicate about several cases, then several Resolution Of Investigation messages must be sent.|The Resolution Of Investigation message provides:|- the final outcome of the case, whether positive or negative|- optionally, the details of the corrective action undertaken by the case assignee and the information of the return|Whenever a payment instruction has been generated to solve the case under investigation, the optional CorrectionTransaction component present in the message must be completed.|Whenever the action of modifying or cancelling a payment results in funds being returned, an investigating agent may attached some details in this message. These details facilitates the account reconciliations at the initiating bank and the intermediaries. It must be stressed that returning of funds is outside the scope of this Exceptions and Investigation service. The features given here is only meant to transmit the information of returns when it is available.|The Resolution Of Investigation message must|- be forwarded by all subsequent case assignee(s) until it reaches the case creator|- not be used in place of a Reject Case Assignment or Case Status Report or Notification Of Case Assignment message.|Take note of an exceptional rule that allows the use of Resolution Of Investigation in lieu of a Case Status Report. Case Status Report is a response-message to a Case Status Report Request. The latter which is sent when the assigner has waited too long (by his standard) for an answer. However it may happen that when the Request arrives, the investigating agent has just obtained a resolution. In such a situation, it would be redundant to send a Case Status Report when then followed immediately by a Resolution Of Investigation. It is therefore quite acceptable for the investigating agent, the assignee, to skip the Case Status Report and send the Resolution Of Investigation message directly.")]
public partial record ResolutionOfInvestigation : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "camt.029.001.01";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ResolutionOfInvestigationDocument"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ResolutionOfInvestigationDocument ToDocument()
    {
        return new ResolutionOfInvestigationDocument { Message = this };
    }
}

/// <summary>
/// Scope
/// The Resolution Of Investigation message is sent by a case assignee to a case creator/case assigner.
/// This message is used to inform of the resolution of a case, and optionally provides details about.
/// - the corrective action undertaken by the case assignee
/// - information on the return where applicable
/// Usage
/// The Resolution Of Investigation message is used by the case assignee to inform a case creator or case assigner about the resolution of a:
/// - request to cancel payment case
/// - request to modify payment case
/// - unable to apply case
/// - claim non receipt case
/// The Resolution Of Investigation message covers one and only one case at a time. If the case assignee needs to communicate about several cases, then several Resolution Of Investigation messages must be sent.
/// The Resolution Of Investigation message provides:
/// - the final outcome of the case, whether positive or negative
/// - optionally, the details of the corrective action undertaken by the case assignee and the information of the return
/// Whenever a payment instruction has been generated to solve the case under investigation, the optional CorrectionTransaction component present in the message must be completed.
/// Whenever the action of modifying or cancelling a payment results in funds being returned, an investigating agent may attached some details in this message. These details facilitates the account reconciliations at the initiating bank and the intermediaries. It must be stressed that returning of funds is outside the scope of this Exceptions and Investigation service. The features given here is only meant to transmit the information of returns when it is available.
/// The Resolution Of Investigation message must
/// - be forwarded by all subsequent case assignee(s) until it reaches the case creator
/// - not be used in place of a Reject Case Assignment or Case Status Report or Notification Of Case Assignment message.
/// Take note of an exceptional rule that allows the use of Resolution Of Investigation in lieu of a Case Status Report. Case Status Report is a response-message to a Case Status Report Request. The latter which is sent when the assigner has waited too long (by his standard) for an answer. However it may happen that when the Request arrives, the investigating agent has just obtained a resolution. In such a situation, it would be redundant to send a Case Status Report when then followed immediately by a Resolution Of Investigation. It is therefore quite acceptable for the investigating agent, the assignee, to skip the Case Status Report and send the Resolution Of Investigation message directly.
/// This is the outer document that contains <seealso cref="ResolutionOfInvestigation"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ResolutionOfInvestigationDocument : IOuterDocument<ResolutionOfInvestigation>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.029.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ResolutionOfInvestigation"/> is required.
    /// </summary>
    public required ResolutionOfInvestigation Message { get; init; }
}
