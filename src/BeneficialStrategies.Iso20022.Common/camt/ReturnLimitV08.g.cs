﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ReturnLimitV08.  ISO2002 ID# _jwlcGRbvEeiyVv5j1vf1VQ.
//
namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// Scope
/// The ReturnLimit message is sent by the transaction administrator to a member of the system.
/// It is used to provide information on the details of one or more limits set by the member (or on behalf of the member) and managed by the transaction administrator.
/// The ReturnLimit message can be sent as a response to a related GetLimit message (pull mode) or initiated by the transaction administrator (push mode). The push of information can take place either at prearranged times or as a warning or alarm when a problem has occurred.
/// Usage
/// At any time during the operating hours of the system, the member can query the transaction administrator to get information about the limit(s) that the transaction administrator manages for the member.
/// The transaction administrator may also send a ReturnLimit message with pre-defined information at times previously agreed with the member or to warn the member about a particular problem that may have arisen and which needs attention.
/// The message from the transaction administrator can contain information on the following elements:
/// - type of risk and/or liquidity limit
/// - value of the limit(s) (default and/or current limit(s) for risk and/or liquidity management)
/// - identification of the system
/// - status of the limit(s) (default and/or current limit(s) for risk and/or liquidity management)
/// - point in time when the limit becomes effective
/// - identification of the counterparty
/// Additional information on the generic design of the Get/Return messages can be found in the section How to Use the Cash Management Messages.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The ReturnLimit message is sent by the transaction administrator to a member of the system.|It is used to provide information on the details of one or more limits set by the member (or on behalf of the member) and managed by the transaction administrator.|The ReturnLimit message can be sent as a response to a related GetLimit message (pull mode) or initiated by the transaction administrator (push mode). The push of information can take place either at prearranged times or as a warning or alarm when a problem has occurred.|Usage|At any time during the operating hours of the system, the member can query the transaction administrator to get information about the limit(s) that the transaction administrator manages for the member.|The transaction administrator may also send a ReturnLimit message with pre-defined information at times previously agreed with the member or to warn the member about a particular problem that may have arisen and which needs attention.|The message from the transaction administrator can contain information on the following elements:|- type of risk and/or liquidity limit|- value of the limit(s) (default and/or current limit(s) for risk and/or liquidity management)|- identification of the system|- status of the limit(s) (default and/or current limit(s) for risk and/or liquidity management)|- point in time when the limit becomes effective|- identification of the counterparty|Additional information on the generic design of the Get/Return messages can be found in the section How to Use the Cash Management Messages.")]
public partial record ReturnLimitV08 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RtrLmt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_jwlcGxbvEeiyVv5j1vf1VQ")]
    [Description(@"Common business identification for the message.")]
    [DataMember(Name="MsgHdr")]
    [XmlElement(ElementName="MsgHdr")]
    [Required]
    public required SomeMessageHeaderRecord MessageHeader { get; init; }
    
    /// <summary>
    /// Reports on limits.
    /// </summary>
    [IsoId("_jwlcHRbvEeiyVv5j1vf1VQ")]
    [Description(@"Reports on limits.")]
    [DataMember(Name="RptOrErr")]
    [XmlElement(ElementName="RptOrErr")]
    [Required]
    public required SomeReportOrErrorRecord ReportOrError { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_jwlcHxbvEeiyVv5j1vf1VQ")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ReturnLimitV08Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ReturnLimitV08Document ToDocument()
    {
        return new ReturnLimitV08Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ReturnLimitV08"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ReturnLimitV08Document : IOuterDocument<ReturnLimitV08>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.010.001.08";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ReturnLimitV08"/> is required.
    /// </summary>
    public required ReturnLimitV08 Message { get; init; }
}
