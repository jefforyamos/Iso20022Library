﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for NotificationToReceiveCancellationAdviceV06.  ISO2002 ID# _yaKCAW42EeiU9cctagi5ow.
//
namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// Scope
/// The NotificationToReceiveCancellationAdvice message is sent by an account owner or by a party acting on the account owner's behalf to one of the account owner's account servicing institutions. It is used to advise the account servicing institution about the cancellation of one or more notifications in a previous NotificationToReceive message.
/// Usage
/// The NotificationToReceiveCancellationAdvice message is used to advise the account servicing institution that the funds are no longer expected. The message can be used in either a direct or a relay scenario.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The NotificationToReceiveCancellationAdvice message is sent by an account owner or by a party acting on the account owner's behalf to one of the account owner's account servicing institutions. It is used to advise the account servicing institution about the cancellation of one or more notifications in a previous NotificationToReceive message.|Usage|The NotificationToReceiveCancellationAdvice message is used to advise the account servicing institution that the funds are no longer expected. The message can be used in either a direct or a relay scenario.")]
public partial record NotificationToReceiveCancellationAdviceV06 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "NtfctnToRcvCxlAdvc";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Set of elements used to provide further details on the message.
    /// </summary>
    [IsoId("_yaKCA242EeiU9cctagi5ow")]
    [Description(@"Set of elements used to provide further details on the message.")]
    [DataMember(Name="GrpHdr")]
    [XmlElement(ElementName="GrpHdr")]
    [Required]
    public required SomeGroupHeaderRecord GroupHeader { get; init; }
    
    /// <summary>
    /// Set of elements used to identify the original notification, to which the cancellation advice refers.
    /// </summary>
    [IsoId("_yaKCBW42EeiU9cctagi5ow")]
    [Description(@"Set of elements used to identify the original notification, to which the cancellation advice refers.")]
    [DataMember(Name="OrgnlNtfctn")]
    [XmlElement(ElementName="OrgnlNtfctn")]
    [Required]
    public required SomeOriginalNotificationRecord OriginalNotification { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_yaKCB242EeiU9cctagi5ow")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="NotificationToReceiveCancellationAdviceV06Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public NotificationToReceiveCancellationAdviceV06Document ToDocument()
    {
        return new NotificationToReceiveCancellationAdviceV06Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="NotificationToReceiveCancellationAdviceV06"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record NotificationToReceiveCancellationAdviceV06Document : IOuterDocument<NotificationToReceiveCancellationAdviceV06>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.058.001.06";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="NotificationToReceiveCancellationAdviceV06"/> is required.
    /// </summary>
    public required NotificationToReceiveCancellationAdviceV06 Message { get; init; }
}
