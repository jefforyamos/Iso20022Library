﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for MandateAcceptanceReportV05.  ISO2002 ID# _as1iAUjuEeaVLL5QKJ4f-A.
//
namespace BeneficialStrategies.Iso20022.pain;

/// <summary>
/// Scope
/// The MandateAcceptanceReport message is sent from the agent of the receiver (debtor or creditor) of the MandateRequest message (initiation, amendment or cancellation) to the agent of the initiator of the MandateRequest message (debtor or creditor).
/// A MandateAcceptanceReport message is used to confirm the acceptance or rejection of a MandateRequest message. Where acceptance is part of the full process flow, a MandateRequest message only becomes valid after a confirmation of acceptance is received through a MandateAcceptanceReport message from the agent of the receiver.
/// Usage
/// The MandateAcceptanceReport message can contain one or more confirmation(s) of acceptance or rejection of a specific Mandate Request.
/// The messages can be exchanged between debtor agent and creditor agent and between debtor agent and debtor and creditor agent and creditor.
/// The MandateAcceptanceReport message can be used in domestic and cross-border scenarios.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The MandateAcceptanceReport message is sent from the agent of the receiver (debtor or creditor) of the MandateRequest message (initiation, amendment or cancellation) to the agent of the initiator of the MandateRequest message (debtor or creditor).|A MandateAcceptanceReport message is used to confirm the acceptance or rejection of a MandateRequest message. Where acceptance is part of the full process flow, a MandateRequest message only becomes valid after a confirmation of acceptance is received through a MandateAcceptanceReport message from the agent of the receiver.|Usage|The MandateAcceptanceReport message can contain one or more confirmation(s) of acceptance or rejection of a specific Mandate Request.|The messages can be exchanged between debtor agent and creditor agent and between debtor agent and debtor and creditor agent and creditor.|The MandateAcceptanceReport message can be used in domestic and cross-border scenarios.")]
public partial record MandateAcceptanceReportV05 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MndtAccptncRpt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Set of characteristics to identify the message and parties playing a role in the mandate acceptance, but which are not part of the mandate.
    /// </summary>
    [IsoId("_as1iBUjuEeaVLL5QKJ4f-A")]
    [Description(@"Set of characteristics to identify the message and parties playing a role in the mandate acceptance, but which are not part of the mandate.")]
    [DataMember(Name="GrpHdr")]
    [XmlElement(ElementName="GrpHdr")]
    [Required]
    public required SomeGroupHeaderRecord GroupHeader { get; init; }
    
    /// <summary>
    /// Provides information on the acceptance or rejection of the mandate request.
    /// </summary>
    [IsoId("_as1iB0juEeaVLL5QKJ4f-A")]
    [Description(@"Provides information on the acceptance or rejection of the mandate request.")]
    [DataMember(Name="UndrlygAccptncDtls")]
    [XmlElement(ElementName="UndrlygAccptncDtls")]
    [Required]
    public required SomeUnderlyingAcceptanceDetailsRecord UnderlyingAcceptanceDetails { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_as1iCUjuEeaVLL5QKJ4f-A")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="MandateAcceptanceReportV05Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public MandateAcceptanceReportV05Document ToDocument()
    {
        return new MandateAcceptanceReportV05Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="MandateAcceptanceReportV05"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record MandateAcceptanceReportV05Document : IOuterDocument<MandateAcceptanceReportV05>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:pain.012.001.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="MandateAcceptanceReportV05"/> is required.
    /// </summary>
    public required MandateAcceptanceReportV05 Message { get; init; }
}
