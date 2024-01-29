﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for RejectInvestigationV06.  ISO2002 ID# _eX_Ok22PEei3KuUgpx7Xcw.
//
namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// Scope
/// The RejectInvestigation message is sent by a case assignee to a case creator or case assigner to reject a case given to him.
/// Usage
/// The RejectInvestigation message is used to notify the case creator or case assigner the rejection of an assignment by the case assignee in a:
/// - request to cancel payment case;
/// - request to modify payment case;
/// - unable to apply case;
/// - claim non receipt case.
/// Rejecting a case assignment occurs when:
/// - the case assignee is unable to trace the original payment instruction;
/// - the case assignee is unable, or does not have authority, to process the assigned case (indicate "You have by-passed a party";
/// - the case assignee has received a non expected message, and rejects the message with a wrong message indicator;
/// - the case assignee has not yet received the ResolutionOfInvestigation message and the case has already been reopened;
/// - the case assignee has rejects an non-cash related query.
/// The RejectInvestigation message covers one and only one case at a time. If the case assignee needs to reject several case assignments, then multiple RejectInvestigation messages must be sent.
/// The RejectInvestigation message must be forwarded by all subsequent case assignee(s) until it reaches the case assigner and must not be used in place of a ResolutionOfInvestigation or CaseStatusReport message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The RejectInvestigation message is sent by a case assignee to a case creator or case assigner to reject a case given to him.|Usage|The RejectInvestigation message is used to notify the case creator or case assigner the rejection of an assignment by the case assignee in a:|- request to cancel payment case;|- request to modify payment case;|- unable to apply case;|- claim non receipt case.|Rejecting a case assignment occurs when:|- the case assignee is unable to trace the original payment instruction;|- the case assignee is unable, or does not have authority, to process the assigned case (indicate ""You have by-passed a party"";|- the case assignee has received a non expected message, and rejects the message with a wrong message indicator;|- the case assignee has not yet received the ResolutionOfInvestigation message and the case has already been reopened;|- the case assignee has rejects an non-cash related query.|The RejectInvestigation message covers one and only one case at a time. If the case assignee needs to reject several case assignments, then multiple RejectInvestigation messages must be sent.|The RejectInvestigation message must be forwarded by all subsequent case assignee(s) until it reaches the case assigner and must not be used in place of a ResolutionOfInvestigation or CaseStatusReport message.")]
public partial record RejectInvestigationV06 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RjctInvstgtn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Identifies the assignment of an investigation case from an assigner to an assignee.
    /// Usage: The assigner must be the sender of this confirmation and the assignee must be the receiver.
    /// </summary>
    [IsoId("_eX_OlW2PEei3KuUgpx7Xcw")]
    [Description(@"Identifies the assignment of an investigation case from an assigner to an assignee.|Usage: The assigner must be the sender of this confirmation and the assignee must be the receiver.")]
    [DataMember(Name="Assgnmt")]
    [XmlElement(ElementName="Assgnmt")]
    [Required]
    public required SomeAssignmentRecord Assignment { get; init; }
    
    /// <summary>
    /// Identifies the investigation case.
    /// </summary>
    [IsoId("_eX_Ol22PEei3KuUgpx7Xcw")]
    [Description(@"Identifies the investigation case.")]
    [DataMember(Name="Case")]
    [XmlElement(ElementName="Case")]
    public SomeCaseRecord? Case { get; init; }
    
    /// <summary>
    /// Specifies the reason for the rejection of an investigation.
    /// </summary>
    [IsoId("_eX_OmW2PEei3KuUgpx7Xcw")]
    [Description(@"Specifies the reason for the rejection of an investigation.")]
    [DataMember(Name="Justfn")]
    [XmlElement(ElementName="Justfn")]
    [Required]
    public required SomeJustificationRecord Justification { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_eX_Om22PEei3KuUgpx7Xcw")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="RejectInvestigationV06Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public RejectInvestigationV06Document ToDocument()
    {
        return new RejectInvestigationV06Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="RejectInvestigationV06"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record RejectInvestigationV06Document : IOuterDocument<RejectInvestigationV06>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.031.001.06";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="RejectInvestigationV06"/> is required.
    /// </summary>
    public required RejectInvestigationV06 Message { get; init; }
}