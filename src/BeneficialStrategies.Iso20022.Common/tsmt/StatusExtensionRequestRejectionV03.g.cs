﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for StatusExtensionRequestRejectionV03.  ISO2002 ID# _zwHRWNE8Ed-BzquC8wXy7w_1399062507.
//
namespace BeneficialStrategies.Iso20022.tsmt;

/// <summary>
/// Scope
/// The StatusExtensionRequestRejection message is sent by the party requested to accept or reject a request to extend the status of a transaction to the matching application.
/// This message is used to inform about the rejection of a request to extend the status of a transaction.
/// Usage
/// The StatusExtensionRequestRejection message can be sent by the party requested to accept or reject the request to extend the status of a transaction to inform that it rejects the request.
/// The message can be sent in response to a StatusExtensionRequestNotification message.
/// The acceptance of a request to extend the status of a transaction can be achieved by sending a StatusExtensionRequestAcceptance message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The StatusExtensionRequestRejection message is sent by the party requested to accept or reject a request to extend the status of a transaction to the matching application.|This message is used to inform about the rejection of a request to extend the status of a transaction.|Usage|The StatusExtensionRequestRejection message can be sent by the party requested to accept or reject the request to extend the status of a transaction to inform that it rejects the request.|The message can be sent in response to a StatusExtensionRequestNotification message.|The acceptance of a request to extend the status of a transaction can be achieved by sending a StatusExtensionRequestAcceptance message.")]
public partial record StatusExtensionRequestRejectionV03 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "StsXtnsnReqRjctn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="StatusExtensionRequestRejectionV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public StatusExtensionRequestRejectionV03Document ToDocument()
    {
        return new StatusExtensionRequestRejectionV03Document { Message = this };
    }
}

/// <summary>
/// Scope
/// The StatusExtensionRequestRejection message is sent by the party requested to accept or reject a request to extend the status of a transaction to the matching application.
/// This message is used to inform about the rejection of a request to extend the status of a transaction.
/// Usage
/// The StatusExtensionRequestRejection message can be sent by the party requested to accept or reject the request to extend the status of a transaction to inform that it rejects the request.
/// The message can be sent in response to a StatusExtensionRequestNotification message.
/// The acceptance of a request to extend the status of a transaction can be achieved by sending a StatusExtensionRequestAcceptance message.
/// This is the outer document that contains <seealso cref="StatusExtensionRequestRejectionV03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record StatusExtensionRequestRejectionV03Document : IOuterDocument<StatusExtensionRequestRejectionV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.033.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="StatusExtensionRequestRejectionV03"/> is required.
    /// </summary>
    public required StatusExtensionRequestRejectionV03 Message { get; init; }
}
