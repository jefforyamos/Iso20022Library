﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for NotificationToReceiveStatusReportV03.  ISO2002 ID# _sRLtMFkyEeGeoaLUQk__nA_-2102986069.
//
namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// Scope
/// The NotificationToReceiveStatusReport message is sent by an account servicing institution to an account owner or to a party acting on the account owner's behalf. It is used to notify the account owner about the status of one or more expected payments that were advised in a previous NotificationToReceive message.
/// Usage
/// The NotificationToReceiveStatusReport message is sent in response to a NotificationToReceive message and can be used in either a direct or a relay scenario. It is used to advise the account owner of receipt of the funds as expected. It is also used to notify the account owner of non-receipt of funds or of discrepancies in the funds received.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The NotificationToReceiveStatusReport message is sent by an account servicing institution to an account owner or to a party acting on the account owner's behalf. It is used to notify the account owner about the status of one or more expected payments that were advised in a previous NotificationToReceive message.|Usage|The NotificationToReceiveStatusReport message is sent in response to a NotificationToReceive message and can be used in either a direct or a relay scenario. It is used to advise the account owner of receipt of the funds as expected. It is also used to notify the account owner of non-receipt of funds or of discrepancies in the funds received.")]
public partial record NotificationToReceiveStatusReportV03 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "NtfctnToRcvStsRpt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Set of elements used to provide further details on the message.
    /// </summary>
    [IsoId("_sRLtMVkyEeGeoaLUQk__nA_-1965847017")]
    [Description(@"Set of elements used to provide further details on the message.")]
    [DataMember(Name="GrpHdr")]
    [XmlElement(ElementName="GrpHdr")]
    [Required]
    public required SomeGroupHeaderRecord GroupHeader { get; init; }
    
    /// <summary>
    /// Set of elements used to identify the original notification and to provide the status.
    /// </summary>
    [IsoId("_sRLtMlkyEeGeoaLUQk__nA_1332047926")]
    [Description(@"Set of elements used to identify the original notification and to provide the status.")]
    [DataMember(Name="OrgnlNtfctnAndSts")]
    [XmlElement(ElementName="OrgnlNtfctnAndSts")]
    [Required]
    public required SomeOriginalNotificationAndStatusRecord OriginalNotificationAndStatus { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_sRLtM1kyEeGeoaLUQk__nA_-515949434")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="NotificationToReceiveStatusReportV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public NotificationToReceiveStatusReportV03Document ToDocument()
    {
        return new NotificationToReceiveStatusReportV03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="NotificationToReceiveStatusReportV03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record NotificationToReceiveStatusReportV03Document : IOuterDocument<NotificationToReceiveStatusReportV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.059.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="NotificationToReceiveStatusReportV03"/> is required.
    /// </summary>
    public required NotificationToReceiveStatusReportV03 Message { get; init; }
}
