﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for UndertakingIssuanceNotificationV01.  ISO2002 ID# _9ft4hnltEeG7BsjMvd1mEw_-1741086320.
//
namespace BeneficialStrategies.Iso20022.tsrv;

/// <summary>
/// The UndertakingIssuanceNotification message is sent by the party that issued the undertaking to the applicant to notify it of the contents of an undertaking issued electronically or on paper. The undertaking that is notified could be a demand guarantee, standby letter of credit, counter-undertaking (counter-guarantee or counter-standby), or suretyship undertaking. In addition to containing details on the applicable rules, expiry date, the amount, required documents, and terms and conditions of the undertaking, the message may provide information from the sender such as confirmation details.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The UndertakingIssuanceNotification message is sent by the party that issued the undertaking to the applicant to notify it of the contents of an undertaking issued electronically or on paper. The undertaking that is notified could be a demand guarantee, standby letter of credit, counter-undertaking (counter-guarantee or counter-standby), or suretyship undertaking. In addition to containing details on the applicable rules, expiry date, the amount, required documents, and terms and conditions of the undertaking, the message may provide information from the sender such as confirmation details.")]
public partial record UndertakingIssuanceNotificationV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "UdrtkgIssncNtfctn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Details related to the notification of the issued undertaking.
    /// </summary>
    [IsoId("_9ft4h3ltEeG7BsjMvd1mEw_725603216")]
    [Description(@"Details related to the notification of the issued undertaking.")]
    [DataMember(Name="UdrtkgIssncNtfctnDtls")]
    [XmlElement(ElementName="UdrtkgIssncNtfctnDtls")]
    [Required]
    public required SomeUndertakingIssuanceNotificationDetailsRecord UndertakingIssuanceNotificationDetails { get; init; }
    
    /// <summary>
    /// Digital signature of the undertaking notification.
    /// </summary>
    [IsoId("_9ft4iHltEeG7BsjMvd1mEw_-695540807")]
    [Description(@"Digital signature of the undertaking notification.")]
    [DataMember(Name="DgtlSgntr")]
    [XmlElement(ElementName="DgtlSgntr")]
    public SomeDigitalSignatureRecord? DigitalSignature { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="UndertakingIssuanceNotificationV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public UndertakingIssuanceNotificationV01Document ToDocument()
    {
        return new UndertakingIssuanceNotificationV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="UndertakingIssuanceNotificationV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record UndertakingIssuanceNotificationV01Document : IOuterDocument<UndertakingIssuanceNotificationV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsrv.003.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="UndertakingIssuanceNotificationV01"/> is required.
    /// </summary>
    public required UndertakingIssuanceNotificationV01 Message { get; init; }
}
