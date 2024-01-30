﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ReturnBusinessDayInformationV07.  ISO2002 ID# _jwlcARbvEeiyVv5j1vf1VQ.
//
namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// Scope
/// The ReturnBusinessDayInformation message is sent by the transaction administrator to a member of the system.
/// It is used to provide information on different types of administrative data linked to the system.
/// The ReturnBusinessDayInformation message can be sent as a response to a related GetBusines DayInformation message (pull mode), or initiated by the transaction administrator (push mode). The push of information can take place either at prearranged times or as a warning or alarm when a problem has occurred.
/// Usage
/// The transaction administrator is in charge of providing the members with business information. The term business day information covers all information related to the management of the system, that is, not related to the transactions or requests created in the system. The type of business information available can vary depending on the system.
/// The member can request information about the static data of the system through a series of criteria, corresponding to the known information stored within the transaction administrator. Based on the criteria received within the request, the transaction administrator will select items that match the request and report them to the requester.
/// The transaction administrator may also send a ReturnBusinessDayInformation message with pre-defined information at times previously agreed with the member or to warn the member about a particular problem that may have arisen and which needs attention.
/// The message from the transaction administrator can contain information based on the following elements:
/// - identification of the system
/// - status of the system and period in which this status is valid
/// - currency within the system concerned and details of the hours of availability linked to that particular currency
/// - events related to the functioning of the system and the timing of their occurrence
/// Additional information on the generic design of the Get/Return messages can be found in the MDR Part 1 section How to Use the Cash Management Messages.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The ReturnBusinessDayInformation message is sent by the transaction administrator to a member of the system.|It is used to provide information on different types of administrative data linked to the system.|The ReturnBusinessDayInformation message can be sent as a response to a related GetBusines DayInformation message (pull mode), or initiated by the transaction administrator (push mode). The push of information can take place either at prearranged times or as a warning or alarm when a problem has occurred.|Usage|The transaction administrator is in charge of providing the members with business information. The term business day information covers all information related to the management of the system, that is, not related to the transactions or requests created in the system. The type of business information available can vary depending on the system.|The member can request information about the static data of the system through a series of criteria, corresponding to the known information stored within the transaction administrator. Based on the criteria received within the request, the transaction administrator will select items that match the request and report them to the requester.|The transaction administrator may also send a ReturnBusinessDayInformation message with pre-defined information at times previously agreed with the member or to warn the member about a particular problem that may have arisen and which needs attention.|The message from the transaction administrator can contain information based on the following elements:|- identification of the system|- status of the system and period in which this status is valid|- currency within the system concerned and details of the hours of availability linked to that particular currency|- events related to the functioning of the system and the timing of their occurrence|Additional information on the generic design of the Get/Return messages can be found in the MDR Part 1 section How to Use the Cash Management Messages.")]
public partial record ReturnBusinessDayInformationV07 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RtrBizDayInf";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_jwlcAxbvEeiyVv5j1vf1VQ")]
    [Description(@"Common business identification for the message.")]
    [DataMember(Name="MsgHdr")]
    [XmlElement(ElementName="MsgHdr")]
    [Required]
    public required MessageHeader7 MessageHeader { get; init; }
    
    /// <summary>
    /// Reports on business day information.
    /// </summary>
    [IsoId("_jwlcBRbvEeiyVv5j1vf1VQ")]
    [Description(@"Reports on business day information.")]
    [DataMember(Name="RptOrErr")]
    [XmlElement(ElementName="RptOrErr")]
    [Required]
    public required IBusinessDayReportOrError9Choice ReportOrError { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_jwlcBxbvEeiyVv5j1vf1VQ")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ReturnBusinessDayInformationV07Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ReturnBusinessDayInformationV07Document ToDocument()
    {
        return new ReturnBusinessDayInformationV07Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ReturnBusinessDayInformationV07"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ReturnBusinessDayInformationV07Document : IOuterDocument<ReturnBusinessDayInformationV07>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.019.001.07";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ReturnBusinessDayInformationV07"/> is required.
    /// </summary>
    public required ReturnBusinessDayInformationV07 Message { get; init; }
}
