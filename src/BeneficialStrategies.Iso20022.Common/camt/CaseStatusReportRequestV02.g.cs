﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CaseStatusReportRequestV02.  ISO2002 ID# _O2WCWNE-Ed-BzquC8wXy7w_940181382.
//
namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// Scope
/// The CaseStatusReportRequest message is sent by a case creator or case assigner to a case assignee.
/// This message is used to request the status of a case.
/// Usage
/// The Case Status Report Request message must be answered with a Case Status Report message. It can be used to request the status of a:
/// - request to cancel payment case
/// - request to modify payment case
/// - unable to apply case
/// - claim non receipt case
/// The Case Status Report Request message covers one and only one case at a time. If a case creator or case assigner needs the status of several cases, then multiple Case Status Report Request messages must be sent.
/// The Case Status Report Request message may be forwarded to subsequent case assignee(s) in the case processing chain.
/// The processing of a case generates Notification Of Case Assignment and/or Resolution Of Investigation messages to the case creator/case assigner. They alone should provide collaborating parties sufficient information about the progress of the investigation. The Case Status Report Request must therefore only be used when no information has been received from the case assignee within the expected time frame.
/// An agent may suspend an investigation by classifying it as overdue if, this agent, after sending the request for the status of the investigation, does not receive any response after a long time. Agents may set their individual threshold wait-time.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The CaseStatusReportRequest message is sent by a case creator or case assigner to a case assignee.|This message is used to request the status of a case.|Usage|The Case Status Report Request message must be answered with a Case Status Report message. It can be used to request the status of a:|- request to cancel payment case|- request to modify payment case|- unable to apply case|- claim non receipt case|The Case Status Report Request message covers one and only one case at a time. If a case creator or case assigner needs the status of several cases, then multiple Case Status Report Request messages must be sent.|The Case Status Report Request message may be forwarded to subsequent case assignee(s) in the case processing chain.|The processing of a case generates Notification Of Case Assignment and/or Resolution Of Investigation messages to the case creator/case assigner. They alone should provide collaborating parties sufficient information about the progress of the investigation. The Case Status Report Request must therefore only be used when no information has been received from the case assignee within the expected time frame.|An agent may suspend an investigation by classifying it as overdue if, this agent, after sending the request for the status of the investigation, does not receive any response after a long time. Agents may set their individual threshold wait-time.")]
public partial record CaseStatusReportRequestV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CaseStsRptReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CaseStatusReportRequestV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CaseStatusReportRequestV02Document ToDocument()
    {
        return new CaseStatusReportRequestV02Document { Message = this };
    }
}

/// <summary>
/// Scope
/// The CaseStatusReportRequest message is sent by a case creator or case assigner to a case assignee.
/// This message is used to request the status of a case.
/// Usage
/// The Case Status Report Request message must be answered with a Case Status Report message. It can be used to request the status of a:
/// - request to cancel payment case
/// - request to modify payment case
/// - unable to apply case
/// - claim non receipt case
/// The Case Status Report Request message covers one and only one case at a time. If a case creator or case assigner needs the status of several cases, then multiple Case Status Report Request messages must be sent.
/// The Case Status Report Request message may be forwarded to subsequent case assignee(s) in the case processing chain.
/// The processing of a case generates Notification Of Case Assignment and/or Resolution Of Investigation messages to the case creator/case assigner. They alone should provide collaborating parties sufficient information about the progress of the investigation. The Case Status Report Request must therefore only be used when no information has been received from the case assignee within the expected time frame.
/// An agent may suspend an investigation by classifying it as overdue if, this agent, after sending the request for the status of the investigation, does not receive any response after a long time. Agents may set their individual threshold wait-time.
/// This is the outer document that contains <seealso cref="CaseStatusReportRequestV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record CaseStatusReportRequestV02Document : IOuterDocument<CaseStatusReportRequestV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.038.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CaseStatusReportRequestV02"/> is required.
    /// </summary>
    public required CaseStatusReportRequestV02 Message { get; init; }
}
