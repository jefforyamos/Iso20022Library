﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for MeetingCancellationV02.  ISO2002 ID# _TlJcItEwEd-BzquC8wXy7w_-976963352.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.seev;


/// <summary>
/// Scope
/// The MeetingCancellation message is sent by the party that sent the MeetingNotification message to the original receiver. It is sent to cancel the previous MeetingNotification message or to advise the cancellation of a meeting.
/// Usage
/// The MeetingCancellation message is used in two different situations.
/// First, it is used to cancel a previously sent MeetingNotification message. In this case, the MessageCancellation, the MeetingReference and the Reason building blocks need to be present.
/// Second, it is used to advise that the meeting is cancelled. In this case, only the MeetingReference and Reason building blocks need to be present.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The MeetingCancellation message is sent by the party that sent the MeetingNotification message to the original receiver. It is sent to cancel the previous MeetingNotification message or to advise the cancellation of a meeting.|Usage|The MeetingCancellation message is used in two different situations.|First, it is used to cancel a previously sent MeetingNotification message. In this case, the MessageCancellation, the MeetingReference and the Reason building blocks need to be present.|Second, it is used to advise that the meeting is cancelled. In this case, only the MeetingReference and Reason building blocks need to be present.")]
public partial record MeetingCancellationV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgCxl";
    
    #nullable enable
    /// <summary>
    /// Identifies the cancellation message.
    /// </summary>
    [IsoId("_TlJcI9EwEd-BzquC8wXy7w_-1270178957")]
    [Description(@"Identifies the cancellation message.")]
    [DataMember(Name="CxlId")]
    [XmlElement(ElementName="CxlId")]
    [Required]
    public required MessageIdentification1 CancellationIdentification { get; init; }
    
    /// <summary>
    /// Information indicating that the cancellation of a message previously sent is requested (and not the cancellation of the meeting).
    /// </summary>
    [IsoId("_TlJcJNEwEd-BzquC8wXy7w_-976963274")]
    [Description(@"Information indicating that the cancellation of a message previously sent is requested (and not the cancellation of the meeting).")]
    [DataMember(Name="MsgCxl")]
    [XmlElement(ElementName="MsgCxl")]
    public AmendInformation1? MessageCancellation { get; init; }
    
    /// <summary>
    /// Series of elements which allow to identify a meeting.
    /// </summary>
    [IsoId("_TlJcJdEwEd-BzquC8wXy7w_-976963350")]
    [Description(@"Series of elements which allow to identify a meeting.")]
    [DataMember(Name="MtgRef")]
    [XmlElement(ElementName="MtgRef")]
    [Required]
    public required MeetingReference2 MeetingReference { get; init; }
    
    /// <summary>
    /// Party notifying the cancellation of the meeting.
    /// </summary>
    [IsoId("_TlJcJtEwEd-BzquC8wXy7w_-976963316")]
    [Description(@"Party notifying the cancellation of the meeting.")]
    [DataMember(Name="NtifngPty")]
    [XmlElement(ElementName="NtifngPty")]
    public IPartyIdentification9Choice? NotifyingParty { get; init; }
    
    /// <summary>
    /// Identifies the security for which the meeting was organised.
    /// </summary>
    [IsoId("_TlJcJ9EwEd-BzquC8wXy7w_-976963334")]
    [Description(@"Identifies the security for which the meeting was organised.")]
    [DataMember(Name="Scty")]
    [XmlElement(ElementName="Scty")]
    public required IReadOnlyCollection<SecurityPosition5> Security { get; init; } = []; // Min=0, Max=200
    
    /// <summary>
    /// Defines the justification for the cancellation.
    /// </summary>
    [IsoId("_TlJcKNEwEd-BzquC8wXy7w_-976963291")]
    [Description(@"Defines the justification for the cancellation.")]
    [DataMember(Name="Rsn")]
    [XmlElement(ElementName="Rsn")]
    [Required]
    public required MeetingCancellationReason1 Reason { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="MeetingCancellationV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public MeetingCancellationV02Document ToDocument()
    {
        return new MeetingCancellationV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="MeetingCancellationV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record MeetingCancellationV02Document : IOuterDocument<MeetingCancellationV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.002.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="MeetingCancellationV02"/> is required.
    /// </summary>
    public required MeetingCancellationV02 Message { get; init; }
}
