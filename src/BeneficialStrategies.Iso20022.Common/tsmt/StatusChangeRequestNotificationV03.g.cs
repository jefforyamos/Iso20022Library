﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for StatusChangeRequestNotificationV03.  ISO2002 ID# _wSYmONE8Ed-BzquC8wXy7w_439569273.
//
namespace BeneficialStrategies.Iso20022.tsmt;

/// <summary>
/// Scope
/// The StatusChangeRequestNotification message is sent by the matching application to the party requested to accept or reject the request of a change in the status of a transaction.
/// This message is used to notify the request of a change in the status of a transaction.
/// Usage
/// The StatusChangeRequestNotification message can be sent by the matching application to pass on the information about the request of a change in the status of a transaction that it has obtained through the receipt of a StatusChangeRequest message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The StatusChangeRequestNotification message is sent by the matching application to the party requested to accept or reject the request of a change in the status of a transaction.|This message is used to notify the request of a change in the status of a transaction.|Usage|The StatusChangeRequestNotification message can be sent by the matching application to pass on the information about the request of a change in the status of a transaction that it has obtained through the receipt of a StatusChangeRequest message.")]
public partial record StatusChangeRequestNotificationV03 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "StsChngReqNtfctn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="StatusChangeRequestNotificationV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public StatusChangeRequestNotificationV03Document ToDocument()
    {
        return new StatusChangeRequestNotificationV03Document { Message = this };
    }
}

/// <summary>
/// Scope
/// The StatusChangeRequestNotification message is sent by the matching application to the party requested to accept or reject the request of a change in the status of a transaction.
/// This message is used to notify the request of a change in the status of a transaction.
/// Usage
/// The StatusChangeRequestNotification message can be sent by the matching application to pass on the information about the request of a change in the status of a transaction that it has obtained through the receipt of a StatusChangeRequest message.
/// This is the outer document that contains <seealso cref="StatusChangeRequestNotificationV03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record StatusChangeRequestNotificationV03Document : IOuterDocument<StatusChangeRequestNotificationV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.028.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="StatusChangeRequestNotificationV03"/> is required.
    /// </summary>
    public required StatusChangeRequestNotificationV03 Message { get; init; }
}
