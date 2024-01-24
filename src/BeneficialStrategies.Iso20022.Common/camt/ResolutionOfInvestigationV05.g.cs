﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ResolutionOfInvestigationV05.  ISO2002 ID# _wQzazRPeEeSVo-TFVwFHvA.
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
/// Whenever a payment instruction has been generated to solve the case under investigation following a claim non receipt or an unable to apply, the optional CorrectionTransaction component present in the message must be completed.
/// Whenever the action of modifying or cancelling a payment results in funds being returned or reversed, an investigating agent may provide the details in the resolution related investigation component, to identify the return or reversal transaction. These details will facilitate the account reconciliations at the initiating bank and the intermediaries. It must be stressed that the return or reversal of funds is outside the scope of this Exceptions and Investigation service. The features given here is only meant to transmit the information of return or reversal when it is available through the resolution of the case.
/// The Resolution Of Investigation message must:
/// - be forwarded by all subsequent case assignee(s) until it reaches the case creator
/// - not be used in place of a Reject Case Assignment or Case Status Report or Notification Of Case Assignment message
/// Take note of an exceptional rule that allows the use of Resolution Of Investigation in lieu of a Case Status Report. Case Status Report is a response-message to a Case Status Report Request. The latter which is sent when the assigner has reached its own time-out threshold to receive a response. However it may happen that when the Request arrives, the investigating agent has just obtained a resolution. In such a situation, it would be redundant to send a Case Status Report when then followed immediately by a Resolution Of Investigation. It is therefore quite acceptable for the investigating agent, the assignee, to skip the Case Status Report and send the Resolution Of Investigation message directly.
/// The Resolution Of Investigation message should be the sole message to respond to a cancellation request. Details of the underlying transactions and the related statuses for which the cancellation request has been issued may be provided in the Cancellation Details component.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The Resolution Of Investigation message is sent by a case assignee to a case creator/case assigner.|This message is used to inform of the resolution of a case, and optionally provides details about.|- the corrective action undertaken by the case assignee|- information on the return where applicable|Usage|The Resolution Of Investigation message is used by the case assignee to inform a case creator or case assigner about the resolution of a:|- request to cancel payment case|- request to modify payment case|- unable to apply case|- claim non receipt case|The Resolution Of Investigation message covers one and only one case at a time. If the case assignee needs to communicate about several cases, then several Resolution Of Investigation messages must be sent.|The Resolution Of Investigation message provides:|- the final outcome of the case, whether positive or negative|- optionally, the details of the corrective action undertaken by the case assignee and the information of the return|Whenever a payment instruction has been generated to solve the case under investigation following a claim non receipt or an unable to apply, the optional CorrectionTransaction component present in the message must be completed.|Whenever the action of modifying or cancelling a payment results in funds being returned or reversed, an investigating agent may provide the details in the resolution related investigation component, to identify the return or reversal transaction. These details will facilitate the account reconciliations at the initiating bank and the intermediaries. It must be stressed that the return or reversal of funds is outside the scope of this Exceptions and Investigation service. The features given here is only meant to transmit the information of return or reversal when it is available through the resolution of the case.|The Resolution Of Investigation message must:|- be forwarded by all subsequent case assignee(s) until it reaches the case creator|- not be used in place of a Reject Case Assignment or Case Status Report or Notification Of Case Assignment message|Take note of an exceptional rule that allows the use of Resolution Of Investigation in lieu of a Case Status Report. Case Status Report is a response-message to a Case Status Report Request. The latter which is sent when the assigner has reached its own time-out threshold to receive a response. However it may happen that when the Request arrives, the investigating agent has just obtained a resolution. In such a situation, it would be redundant to send a Case Status Report when then followed immediately by a Resolution Of Investigation. It is therefore quite acceptable for the investigating agent, the assignee, to skip the Case Status Report and send the Resolution Of Investigation message directly.|The Resolution Of Investigation message should be the sole message to respond to a cancellation request. Details of the underlying transactions and the related statuses for which the cancellation request has been issued may be provided in the Cancellation Details component.")]
public partial record ResolutionOfInvestigationV05 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RsltnOfInvstgtn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Identifies the assignment of an investigation case from an assigner to an assignee.|Usage: The Assigner must be the sender of this confirmation and the Assignee must be the receiver.
    /// </summary>
    [IsoId("_wQza2RPeEeSVo-TFVwFHvA")]
    [Description(@"Identifies the assignment of an investigation case from an assigner to an assignee.|Usage: The Assigner must be the sender of this confirmation and the Assignee must be the receiver.")]
    [DataMember(Name="Assgnmt")]
    [XmlElement(ElementName="Assgnmt")]
    [Required]
    public required SomeAssignmentRecord Assignment { get; init; }
    
    /// <summary>
    /// Identifies a resolved case.
    /// </summary>
    [IsoId("_wQza2xPeEeSVo-TFVwFHvA")]
    [Description(@"Identifies a resolved case.")]
    [DataMember(Name="RslvdCase")]
    [XmlElement(ElementName="RslvdCase")]
    public SomeResolvedCaseRecord? ResolvedCase { get; init; }
    
    /// <summary>
    /// Indicates the status of the investigation.
    /// </summary>
    [IsoId("_wQza3RPeEeSVo-TFVwFHvA")]
    [Description(@"Indicates the status of the investigation.")]
    [DataMember(Name="Sts")]
    [XmlElement(ElementName="Sts")]
    [Required]
    public required SomeStatusRecord Status { get; init; }
    
    /// <summary>
    /// Specifies the details of the underlying transactions being cancelled.
    /// </summary>
    [IsoId("_wQza3xPeEeSVo-TFVwFHvA")]
    [Description(@"Specifies the details of the underlying transactions being cancelled.")]
    [DataMember(Name="CxlDtls")]
    [XmlElement(ElementName="CxlDtls")]
    public SomeCancellationDetailsRecord? CancellationDetails { get; init; }
    
    /// <summary>
    /// Details on the underlying statement entry.
    /// </summary>
    [IsoId("_wQza4RPeEeSVo-TFVwFHvA")]
    [Description(@"Details on the underlying statement entry.")]
    [DataMember(Name="StmtDtls")]
    [XmlElement(ElementName="StmtDtls")]
    public SomeStatementDetailsRecord? StatementDetails { get; init; }
    
    /// <summary>
    /// References a transaction initiated to fix the case under investigation.
    /// </summary>
    [IsoId("_wQza4xPeEeSVo-TFVwFHvA")]
    [Description(@"References a transaction initiated to fix the case under investigation.")]
    [DataMember(Name="CrrctnTx")]
    [XmlElement(ElementName="CrrctnTx")]
    public SomeCorrectionTransactionRecord? CorrectionTransaction { get; init; }
    
    /// <summary>
    /// Reference of a return or a reversal initiated to fix the case under investigation as part of the resolution.
    /// </summary>
    [IsoId("_wQza5RPeEeSVo-TFVwFHvA")]
    [Description(@"Reference of a return or a reversal initiated to fix the case under investigation as part of the resolution.")]
    [DataMember(Name="RsltnRltdInf")]
    [XmlElement(ElementName="RsltnRltdInf")]
    public SomeResolutionRelatedInformationRecord? ResolutionRelatedInformation { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_wQza5xPeEeSVo-TFVwFHvA")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ResolutionOfInvestigationV05Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ResolutionOfInvestigationV05Document ToDocument()
    {
        return new ResolutionOfInvestigationV05Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ResolutionOfInvestigationV05"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ResolutionOfInvestigationV05Document : IOuterDocument<ResolutionOfInvestigationV05>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.029.001.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ResolutionOfInvestigationV05"/> is required.
    /// </summary>
    public required ResolutionOfInvestigationV05 Message { get; init; }
}
