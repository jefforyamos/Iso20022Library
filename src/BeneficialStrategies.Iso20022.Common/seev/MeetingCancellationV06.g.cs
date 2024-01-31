﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for MeetingCancellationV06.  ISO2002 ID# _yXBbUayREemMosWmlQ33EA.
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
/// This record is an implementation of the seev.002.001.06 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The MeetingCancellation message is sent by the party that sent the MeetingNotification message to the original receiver. It is sent to cancel a previously announced meeting or to advise the withdrawal of a meeting.
/// Usage
/// The MeetingCancellation message is used to advise that the meeting has been cancelled by the account servicer or withdrawn by the Issuer. 
/// This message definition is intended for use with the Business Application Header.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The MeetingCancellation message is sent by the party that sent the MeetingNotification message to the original receiver. It is sent to cancel a previously announced meeting or to advise the withdrawal of a meeting.|Usage|The MeetingCancellation message is used to advise that the meeting has been cancelled by the account servicer or withdrawn by the Issuer. |This message definition is intended for use with the Business Application Header.")]
public partial record MeetingCancellationV06 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.002.001.06";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgCxl";
    
    #nullable enable
    /// <summary>
    /// Set of elements that allow to identify unambiguously a meeting.
    /// </summary>
    [IsoId("_yXBbVayREemMosWmlQ33EA")]
    [Description(@"Set of elements that allow to identify unambiguously a meeting.")]
    [DataMember(Name="MtgRef")]
    [XmlElement(ElementName="MtgRef")]
    [Required]
    public required MeetingReference9 MeetingReference { get; init; }
    
    /// <summary>
    /// Identification of the security for which the meeting was organised.
    /// </summary>
    [IsoId("_yXBbV6yREemMosWmlQ33EA")]
    [Description(@"Identification of the security for which the meeting was organised.")]
    [DataMember(Name="Scty")]
    [XmlElement(ElementName="Scty")]
    public required IReadOnlyCollection<SecurityPosition10> Security { get; init; } = []; // Min=1, Max=200
    
    /// <summary>
    /// Justification for the cancellation.
    /// </summary>
    [IsoId("_yXBbWayREemMosWmlQ33EA")]
    [Description(@"Justification for the cancellation.")]
    [DataMember(Name="Rsn")]
    [XmlElement(ElementName="Rsn")]
    [Required]
    public required MeetingCancellationReason2 Reason { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_yXBbW6yREemMosWmlQ33EA")]
    [Description(@"Additional information that cannot be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="MeetingCancellationV06Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public MeetingCancellationV06Document ToDocument()
    {
        return new MeetingCancellationV06Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="MeetingCancellationV06"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record MeetingCancellationV06Document : IOuterDocument<MeetingCancellationV06>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.002.001.06";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="MeetingCancellationV06"/> is required.
    /// </summary>
    public required MeetingCancellationV06 Message { get; init; }
}
