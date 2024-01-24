﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for IdentificationVerificationReportV01.  ISO2002 ID# _sR7vSWtdEeCY4-KZ9JEyUQ_-1219419046.
//
namespace BeneficialStrategies.Iso20022.acmt;

/// <summary>
/// Scope
/// The IdentificationVerificationReport message is sent by an assigner to an assignee. It is used to confirm whether or not the presented party and/or account identification information is correct.
/// Usage
/// The IdentificationVerificationReport message is sent as a response to an IdentificationVerificationRequest message.
/// The IdentificationVerificationReport message can contain one or more reports.
/// The IdentificationVerificationReport message may include a reason if the presented party and/or account identification information is confirmed to be incorrect.
/// The IdentificationVerificationReport message may include the correct party and/or account identification information.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The IdentificationVerificationReport message is sent by an assigner to an assignee. It is used to confirm whether or not the presented party and/or account identification information is correct.|Usage|The IdentificationVerificationReport message is sent as a response to an IdentificationVerificationRequest message.|The IdentificationVerificationReport message can contain one or more reports.|The IdentificationVerificationReport message may include a reason if the presented party and/or account identification information is confirmed to be incorrect.|The IdentificationVerificationReport message may include the correct party and/or account identification information.")]
public partial record IdentificationVerificationReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "IdVrfctnRpt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Identifies the identification assignment.
    /// </summary>
    [IsoId("_sSFgQGtdEeCY4-KZ9JEyUQ_1322063347")]
    [Description(@"Identifies the identification assignment.")]
    [DataMember(Name="Assgnmt")]
    [XmlElement(ElementName="Assgnmt")]
    [Required]
    public required SomeAssignmentRecord Assignment { get; init; }
    
    /// <summary>
    /// Provides for the reference to the original identification assignment.
    /// </summary>
    [IsoId("_sSFgQWtdEeCY4-KZ9JEyUQ_-2029313680")]
    [Description(@"Provides for the reference to the original identification assignment.")]
    [DataMember(Name="OrgnlAssgnmt")]
    [XmlElement(ElementName="OrgnlAssgnmt")]
    public SomeOriginalAssignmentRecord? OriginalAssignment { get; init; }
    
    /// <summary>
    /// Information concerning the verification of the identification data for which verification was requested.
    /// </summary>
    [IsoId("_sSFgQmtdEeCY4-KZ9JEyUQ_-1601120034")]
    [Description(@"Information concerning the verification of the identification data for which verification was requested.")]
    [DataMember(Name="Rpt")]
    [XmlElement(ElementName="Rpt")]
    [Required]
    public required SomeReportRecord Report { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="IdentificationVerificationReportV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public IdentificationVerificationReportV01Document ToDocument()
    {
        return new IdentificationVerificationReportV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="IdentificationVerificationReportV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record IdentificationVerificationReportV01Document : IOuterDocument<IdentificationVerificationReportV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.024.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="IdentificationVerificationReportV01"/> is required.
    /// </summary>
    public required IdentificationVerificationReportV01 Message { get; init; }
}
