﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ReturnGeneralBusinessInformationV06.  ISO2002 ID# _jwlcERbvEeiyVv5j1vf1VQ.
//
namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// Scope
/// The ReturnGeneralBusinessInformation message is sent by the transaction administrator to a member of the system. It is used to provide some or all of the members with information related to the processing of the system.
/// The Return General Business Information message can be sent as a response to a related GetGeneralBusinessInformation message (pull mode) or initiated by the transaction administrator (push mode). The push of information can take place either at prearranged times or as a warning or alarm when a problem has occurred.
/// Usage
/// The transaction administrator can send general business information messages to the members, which may request further action from them. General business information can contain either static data announcing foreseen events affecting the system operations, or dynamic data warning or notifying about unexpected events.
/// This type of information can be transmitted in either of the two following ways:
/// - non-solicited reports are pushed by the transaction administrator to the (selected) members together with a reference, a qualifier and a subject line
/// - upon request from the members (pull mode), the transaction administrator delivers the full text/content of the message back to the user
/// In either case, the message from the transaction administrator can contain information based on the following elements:
/// - subject of the report detailing the purpose and content of the message
/// - details of the report
/// - indication of the priority of the report and of its format. (Note that if the format is indicated, the subject refers to a set of pre-agreed texts. This enumeration has to be agreed upon by the transaction administrator and the members of the system).
/// Additional information on the generic design of the Get/Return messages can be found in the MDR Part 1 section How to Use the Cash Management Messages.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The ReturnGeneralBusinessInformation message is sent by the transaction administrator to a member of the system. It is used to provide some or all of the members with information related to the processing of the system.|The Return General Business Information message can be sent as a response to a related GetGeneralBusinessInformation message (pull mode) or initiated by the transaction administrator (push mode). The push of information can take place either at prearranged times or as a warning or alarm when a problem has occurred.|Usage|The transaction administrator can send general business information messages to the members, which may request further action from them. General business information can contain either static data announcing foreseen events affecting the system operations, or dynamic data warning or notifying about unexpected events.|This type of information can be transmitted in either of the two following ways:|- non-solicited reports are pushed by the transaction administrator to the (selected) members together with a reference, a qualifier and a subject line|- upon request from the members (pull mode), the transaction administrator delivers the full text/content of the message back to the user|In either case, the message from the transaction administrator can contain information based on the following elements:|- subject of the report detailing the purpose and content of the message|- details of the report|- indication of the priority of the report and of its format. (Note that if the format is indicated, the subject refers to a set of pre-agreed texts. This enumeration has to be agreed upon by the transaction administrator and the members of the system).|Additional information on the generic design of the Get/Return messages can be found in the MDR Part 1 section How to Use the Cash Management Messages.")]
public partial record ReturnGeneralBusinessInformationV06 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RtrGnlBizInf";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_jwlcExbvEeiyVv5j1vf1VQ")]
    [Description(@"Common business identification for the message.")]
    [DataMember(Name="MsgHdr")]
    [XmlElement(ElementName="MsgHdr")]
    [Required]
    public required SomeMessageHeaderRecord MessageHeader { get; init; }
    
    /// <summary>
    /// Report on the Business Information.
    /// </summary>
    [IsoId("_jwlcFRbvEeiyVv5j1vf1VQ")]
    [Description(@"Report on the Business Information.")]
    [DataMember(Name="RptOrErr")]
    [XmlElement(ElementName="RptOrErr")]
    [Required]
    public required SomeReportOrErrorRecord ReportOrError { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_jwlcFxbvEeiyVv5j1vf1VQ")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ReturnGeneralBusinessInformationV06Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ReturnGeneralBusinessInformationV06Document ToDocument()
    {
        return new ReturnGeneralBusinessInformationV06Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ReturnGeneralBusinessInformationV06"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ReturnGeneralBusinessInformationV06Document : IOuterDocument<ReturnGeneralBusinessInformationV06>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.021.001.06";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ReturnGeneralBusinessInformationV06"/> is required.
    /// </summary>
    public required ReturnGeneralBusinessInformationV06 Message { get; init; }
}
