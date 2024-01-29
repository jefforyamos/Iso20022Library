﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for MeetingCancellationV08.  ISO2002 ID# _lKgSIRrdEeyhRdHRjakS2w.
//
namespace BeneficialStrategies.Iso20022.seev;

/// <summary>
/// Scope
/// The MeetingCancellation message is sent by the party that sent the MeetingNotification message to the original receiver. It is sent to cancel a previously announced meeting or to advise the withdrawal of a meeting.
/// Usage
/// The MeetingCancellation message is used to advise that the meeting has been cancelled by the account servicer or withdrawn by the issuer. 
/// This message definition is intended for use with the Business Application Header (BAH).
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The MeetingCancellation message is sent by the party that sent the MeetingNotification message to the original receiver. It is sent to cancel a previously announced meeting or to advise the withdrawal of a meeting.|Usage|The MeetingCancellation message is used to advise that the meeting has been cancelled by the account servicer or withdrawn by the issuer. |This message definition is intended for use with the Business Application Header (BAH).")]
public partial record MeetingCancellationV08 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgCxl";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Set of elements to allow the unambiguous identification of a meeting.
    /// </summary>
    [IsoId("_lKgSKRrdEeyhRdHRjakS2w")]
    [Description(@"Set of elements to allow the unambiguous identification of a meeting.")]
    [DataMember(Name="MtgRef")]
    [XmlElement(ElementName="MtgRef")]
    [Required]
    public required SomeMeetingReferenceRecord MeetingReference { get; init; }
    
    /// <summary>
    /// Identification of the security for which the meeting was organised.
    /// </summary>
    [IsoId("_lKgSKxrdEeyhRdHRjakS2w")]
    [Description(@"Identification of the security for which the meeting was organised.")]
    [DataMember(Name="Scty")]
    [XmlElement(ElementName="Scty")]
    public required IReadonlyCollection<SomeSecurityRecord> Security { get; init; } // Min=1, Max=200
    
    /// <summary>
    /// Justification for the cancellation.
    /// </summary>
    [IsoId("_lKgSLRrdEeyhRdHRjakS2w")]
    [Description(@"Justification for the cancellation.")]
    [DataMember(Name="Rsn")]
    [XmlElement(ElementName="Rsn")]
    [Required]
    public required SomeReasonRecord Reason { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_lKgSLxrdEeyhRdHRjakS2w")]
    [Description(@"Additional information that cannot be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="MeetingCancellationV08Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public MeetingCancellationV08Document ToDocument()
    {
        return new MeetingCancellationV08Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="MeetingCancellationV08"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record MeetingCancellationV08Document : IOuterDocument<MeetingCancellationV08>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.002.001.08";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="MeetingCancellationV08"/> is required.
    /// </summary>
    public required MeetingCancellationV08 Message { get; init; }
}