﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for UndertakingAmendmentNotificationV01.  ISO2002 ID# _9g6LUnltEeG7BsjMvd1mEw_1297611038.
//
namespace BeneficialStrategies.Iso20022.tsrv;

/// <summary>
/// The UndertakingAmendmentNotification message is sent by the party that issued the undertaking to the applicant to notify it of the contents of a proposed amendment to the undertaking (issued electronically or on paper). The undertaking could be a demand guarantee, standby letter of credit, counter-undertaking (counter-guarantee or counter-standby), or suretyship undertaking. In addition to providing the proposed terms of the amendment and details on proposed changes to the undertaking, the message may provide other supporting information from the sender. It may also be used to notify the proposed termination or cancellation of the undertaking.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The UndertakingAmendmentNotification message is sent by the party that issued the undertaking to the applicant to notify it of the contents of a proposed amendment to the undertaking (issued electronically or on paper). The undertaking could be a demand guarantee, standby letter of credit, counter-undertaking (counter-guarantee or counter-standby), or suretyship undertaking. In addition to providing the proposed terms of the amendment and details on proposed changes to the undertaking, the message may provide other supporting information from the sender. It may also be used to notify the proposed termination or cancellation of the undertaking.")]
public partial record UndertakingAmendmentNotificationV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "UdrtkgAmdmntNtfctn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Details related to the notification of the proposed amended undertaking.
    /// </summary>
    [IsoId("_9g6LU3ltEeG7BsjMvd1mEw_1612122638")]
    [Description(@"Details related to the notification of the proposed amended undertaking.")]
    [DataMember(Name="UdrtkgAmdmntNtfctnDtls")]
    [XmlElement(ElementName="UdrtkgAmdmntNtfctnDtls")]
    [Required]
    public required Amendment6 UndertakingAmendmentNotificationDetails { get; init; }
    
    /// <summary>
    /// Digital signature of the notification.
    /// </summary>
    [IsoId("_9g6LVHltEeG7BsjMvd1mEw_1241284917")]
    [Description(@"Digital signature of the notification.")]
    [DataMember(Name="DgtlSgntr")]
    [XmlElement(ElementName="DgtlSgntr")]
    public PartyAndSignature2? DigitalSignature { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="UndertakingAmendmentNotificationV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public UndertakingAmendmentNotificationV01Document ToDocument()
    {
        return new UndertakingAmendmentNotificationV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="UndertakingAmendmentNotificationV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record UndertakingAmendmentNotificationV01Document : IOuterDocument<UndertakingAmendmentNotificationV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsrv.007.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="UndertakingAmendmentNotificationV01"/> is required.
    /// </summary>
    public required UndertakingAmendmentNotificationV01 Message { get; init; }
}
