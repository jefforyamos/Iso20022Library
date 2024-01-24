﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for BaselineReportV03.  ISO2002 ID# _l8xdSNE8Ed-BzquC8wXy7w_1618740400.
//
namespace BeneficialStrategies.Iso20022.tsmt;

/// <summary>
/// Scope
/// The BaselineReport message is sent by the matching application to the parties involved in an amendment request or to the parties involved in a data set match.
/// The message is used to report either a pre-calculation or final calculation of the dynamic part of an established baseline.
/// Usage
/// The BaselineReport message can be sent by the matching application to the parties involved in an amendment request for a transaction established in the push-through mode. In the outlined scenario, the message is sent
/// - to the party requested to accept or reject an amendment request after the matching application has received a BaselineAmendmentRequest message. The message informs about the provisional status of the dynamic part of the baseline.
/// - to the requester and the accepter of an amendment request after the matching application has received an AmendmentAcceptance message conveying the acceptance of the amendment request. The message informs about the actual status of the dynamic part of the baseline.
/// or
/// The BaselineReport message can be sent by the matching application to the party which has sent an amendment request for a transaction established in the lodge mode. In the outlined scenario the message is used to inform about the actual status of the dynamic part of the baseline.
/// or
/// The BaselineReport message can be sent by the matching application to the parties involved in a data set match. In the outlined scenario, the message is sent
/// - to the submitter of the data set(s) in the case of a data set match for a transaction established in the lodge mode.
/// - to the submitter of the data set(s) and to the counterparty in case of a data set match for a transaction established in the push-through mode.The message can be sent after a successful data-set match or after the acceptance of mis-matched data sets to inform about the actual status of the dynamic part of the baseline.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The BaselineReport message is sent by the matching application to the parties involved in an amendment request or to the parties involved in a data set match.|The message is used to report either a pre-calculation or final calculation of the dynamic part of an established baseline.|Usage|The BaselineReport message can be sent by the matching application to the parties involved in an amendment request for a transaction established in the push-through mode. In the outlined scenario, the message is sent|- to the party requested to accept or reject an amendment request after the matching application has received a BaselineAmendmentRequest message. The message informs about the provisional status of the dynamic part of the baseline.|- to the requester and the accepter of an amendment request after the matching application has received an AmendmentAcceptance message conveying the acceptance of the amendment request. The message informs about the actual status of the dynamic part of the baseline.|or|The BaselineReport message can be sent by the matching application to the party which has sent an amendment request for a transaction established in the lodge mode. In the outlined scenario the message is used to inform about the actual status of the dynamic part of the baseline.|or|The BaselineReport message can be sent by the matching application to the parties involved in a data set match. In the outlined scenario, the message is sent|- to the submitter of the data set(s) in the case of a data set match for a transaction established in the lodge mode.|- to the submitter of the data set(s) and to the counterparty in case of a data set match for a transaction established in the push-through mode.The message can be sent after a successful data-set match or after the acceptance of mis-matched data sets to inform about the actual status of the dynamic part of the baseline.")]
public partial record BaselineReportV03 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "BaselnRpt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="BaselineReportV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public BaselineReportV03Document ToDocument()
    {
        return new BaselineReportV03Document { Message = this };
    }
}

/// <summary>
/// Scope
/// The BaselineReport message is sent by the matching application to the parties involved in an amendment request or to the parties involved in a data set match.
/// The message is used to report either a pre-calculation or final calculation of the dynamic part of an established baseline.
/// Usage
/// The BaselineReport message can be sent by the matching application to the parties involved in an amendment request for a transaction established in the push-through mode. In the outlined scenario, the message is sent
/// - to the party requested to accept or reject an amendment request after the matching application has received a BaselineAmendmentRequest message. The message informs about the provisional status of the dynamic part of the baseline.
/// - to the requester and the accepter of an amendment request after the matching application has received an AmendmentAcceptance message conveying the acceptance of the amendment request. The message informs about the actual status of the dynamic part of the baseline.
/// or
/// The BaselineReport message can be sent by the matching application to the party which has sent an amendment request for a transaction established in the lodge mode. In the outlined scenario the message is used to inform about the actual status of the dynamic part of the baseline.
/// or
/// The BaselineReport message can be sent by the matching application to the parties involved in a data set match. In the outlined scenario, the message is sent
/// - to the submitter of the data set(s) in the case of a data set match for a transaction established in the lodge mode.
/// - to the submitter of the data set(s) and to the counterparty in case of a data set match for a transaction established in the push-through mode.The message can be sent after a successful data-set match or after the acceptance of mis-matched data sets to inform about the actual status of the dynamic part of the baseline.
/// This is the outer document that contains <seealso cref="BaselineReportV03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record BaselineReportV03Document : IOuterDocument<BaselineReportV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.011.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="BaselineReportV03"/> is required.
    /// </summary>
    public required BaselineReportV03 Message { get; init; }
}
