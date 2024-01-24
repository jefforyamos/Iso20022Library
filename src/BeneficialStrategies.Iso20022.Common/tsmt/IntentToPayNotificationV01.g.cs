﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for IntentToPayNotificationV01.  ISO2002 ID# _qS03gtE8Ed-BzquC8wXy7w_-674719643.
//
namespace BeneficialStrategies.Iso20022.tsmt;

/// <summary>
/// Scope
/// The IntentToPayNotification message is sent by a party to the matching application in order to provide details about a future payment.
/// This message contains details about an intention to pay a certain amount, on a certain date, in relation to one or several transactions known to the matching application.
/// Usage
/// The IntentToPayNotification message can be sent by a party to the transaction at any time as long as the transaction is established and not yet closed.
/// The message is unsolicited, that is, it is not sent in response to another message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The IntentToPayNotification message is sent by a party to the matching application in order to provide details about a future payment.|This message contains details about an intention to pay a certain amount, on a certain date, in relation to one or several transactions known to the matching application.|Usage|The IntentToPayNotification message can be sent by a party to the transaction at any time as long as the transaction is established and not yet closed.|The message is unsolicited, that is, it is not sent in response to another message.")]
public partial record IntentToPayNotificationV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "InttToPayNtfctn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="IntentToPayNotificationV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public IntentToPayNotificationV01Document ToDocument()
    {
        return new IntentToPayNotificationV01Document { Message = this };
    }
}

/// <summary>
/// Scope
/// The IntentToPayNotification message is sent by a party to the matching application in order to provide details about a future payment.
/// This message contains details about an intention to pay a certain amount, on a certain date, in relation to one or several transactions known to the matching application.
/// Usage
/// The IntentToPayNotification message can be sent by a party to the transaction at any time as long as the transaction is established and not yet closed.
/// The message is unsolicited, that is, it is not sent in response to another message.
/// This is the outer document that contains <seealso cref="IntentToPayNotificationV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record IntentToPayNotificationV01Document : IOuterDocument<IntentToPayNotificationV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.044.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="IntentToPayNotificationV01"/> is required.
    /// </summary>
    public required IntentToPayNotificationV01 Message { get; init; }
}
