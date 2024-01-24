﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ForwardDataSetSubmissionReportV04.  ISO2002 ID# _2hJwodQrEeK0PPbKncCqzA.
//
namespace BeneficialStrategies.Iso20022.tsmt;

/// <summary>
/// Scope
/// The ForwardDataSetSubmissionReport message is sent by the matching application to the counterparty(ies) of the submitter of data sets.
/// This message is used to pass on information related to the purchasing agreement(s) covered by the transaction(s) referred to in the message.
/// Usage
/// The ForwardDataSetSubmission message can be sent by the matching application to forward the details of a DataSetSubmission message that it has obtained.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The ForwardDataSetSubmissionReport message is sent by the matching application to the counterparty(ies) of the submitter of data sets.|This message is used to pass on information related to the purchasing agreement(s) covered by the transaction(s) referred to in the message.|Usage|The ForwardDataSetSubmission message can be sent by the matching application to forward the details of a DataSetSubmission message that it has obtained.")]
public partial record ForwardDataSetSubmissionReportV04 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FwdDataSetSubmissnRpt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ForwardDataSetSubmissionReportV04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ForwardDataSetSubmissionReportV04Document ToDocument()
    {
        return new ForwardDataSetSubmissionReportV04Document { Message = this };
    }
}

/// <summary>
/// Scope
/// The ForwardDataSetSubmissionReport message is sent by the matching application to the counterparty(ies) of the submitter of data sets.
/// This message is used to pass on information related to the purchasing agreement(s) covered by the transaction(s) referred to in the message.
/// Usage
/// The ForwardDataSetSubmission message can be sent by the matching application to forward the details of a DataSetSubmission message that it has obtained.
/// This is the outer document that contains <seealso cref="ForwardDataSetSubmissionReportV04"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ForwardDataSetSubmissionReportV04Document : IOuterDocument<ForwardDataSetSubmissionReportV04>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ForwardDataSetSubmissionReportV04"/> is required.
    /// </summary>
    public required ForwardDataSetSubmissionReportV04 Message { get; init; }
}
