﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for MeetingNotificationV08.  ISO2002 ID# _sVpAIfEkEeqRfth943bvEA.
//
namespace BeneficialStrategies.Iso20022.seev;

/// <summary>
/// Scope
/// The MeetingNotification message is sent by a notifying party, for example, an issuer, its agent or an intermediary to another intermediary, a party holding the right to vote, a registered security holder or to a beneficial holder to announce a meeting.
/// Usage
/// The MeetingNotification message is used to announce a meeting, for example, it provides information on the participation details and requirements for the meeting, the vote parameters and the resolutions. The MeetingNotification message may also be used to announce an update.
/// This message definition is intended for use with the Business Application Header (BAH).
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The MeetingNotification message is sent by a notifying party, for example, an issuer, its agent or an intermediary to another intermediary, a party holding the right to vote, a registered security holder or to a beneficial holder to announce a meeting.|Usage|The MeetingNotification message is used to announce a meeting, for example, it provides information on the participation details and requirements for the meeting, the vote parameters and the resolutions. The MeetingNotification message may also be used to announce an update.|This message definition is intended for use with the Business Application Header (BAH).")]
public partial record MeetingNotificationV08 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgNtfctn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="MeetingNotificationV08Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public MeetingNotificationV08Document ToDocument()
    {
        return new MeetingNotificationV08Document { Message = this };
    }
}

/// <summary>
/// Scope
/// The MeetingNotification message is sent by a notifying party, for example, an issuer, its agent or an intermediary to another intermediary, a party holding the right to vote, a registered security holder or to a beneficial holder to announce a meeting.
/// Usage
/// The MeetingNotification message is used to announce a meeting, for example, it provides information on the participation details and requirements for the meeting, the vote parameters and the resolutions. The MeetingNotification message may also be used to announce an update.
/// This message definition is intended for use with the Business Application Header (BAH).
/// This is the outer document that contains <seealso cref="MeetingNotificationV08"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record MeetingNotificationV08Document : IOuterDocument<MeetingNotificationV08>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.08";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="MeetingNotificationV08"/> is required.
    /// </summary>
    public required MeetingNotificationV08 Message { get; init; }
}
