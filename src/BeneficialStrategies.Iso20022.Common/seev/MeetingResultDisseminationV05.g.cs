﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for MeetingResultDisseminationV05.  ISO2002 ID# _xDJ_IVtcEeSwKe7KuKvXhg.
//
namespace BeneficialStrategies.Iso20022.seev;

/// <summary>
/// Scope
/// An issuer, its agent or an intermediary sends the MeetingResultDissemination message to another intermediary, to a party holding the right to vote, to a registered security holder or to a beneficial holder to provide information on the voting results of a shareholders meeting.
/// Usage
/// The MeetingResultDissemination message is used to provide the vote results per resolution. It may also provide information on the level of participation.
/// This message is also used to notify an update or amendment to a previously sent MeetingResultDissemination message.
/// This message definition is intended for use with the Business Application Header.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|An issuer, its agent or an intermediary sends the MeetingResultDissemination message to another intermediary, to a party holding the right to vote, to a registered security holder or to a beneficial holder to provide information on the voting results of a shareholders meeting.|Usage|The MeetingResultDissemination message is used to provide the vote results per resolution. It may also provide information on the level of participation.|This message is also used to notify an update or amendment to a previously sent MeetingResultDissemination message.|This message definition is intended for use with the Business Application Header.")]
public partial record MeetingResultDisseminationV05 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgRsltDssmntn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Information specific to an amendment.
    /// </summary>
    [IsoId("_xDJ_JVtcEeSwKe7KuKvXhg")]
    [Description(@"Information specific to an amendment.")]
    [DataMember(Name="Amdmnt")]
    [XmlElement(ElementName="Amdmnt")]
    public SomeAmendmentRecord? Amendment { get; init; }
    
    /// <summary>
    /// Series of elements which allow to identify a meeting.
    /// </summary>
    [IsoId("_xDJ_J1tcEeSwKe7KuKvXhg")]
    [Description(@"Series of elements which allow to identify a meeting.")]
    [DataMember(Name="MtgRef")]
    [XmlElement(ElementName="MtgRef")]
    [Required]
    public required SomeMeetingReferenceRecord MeetingReference { get; init; }
    
    /// <summary>
    /// Identifies the securities for which the meeting is organised.
    /// </summary>
    [IsoId("_xDJ_K1tcEeSwKe7KuKvXhg")]
    [Description(@"Identifies the securities for which the meeting is organised.")]
    [DataMember(Name="Scty")]
    [XmlElement(ElementName="Scty")]
    public required IReadonlyCollection<SomeSecurityRecord> Security { get; init; } // Min=1, Max=200
    
    /// <summary>
    /// Results per resolution.
    /// </summary>
    [IsoId("_xDJ_LVtcEeSwKe7KuKvXhg")]
    [Description(@"Results per resolution.")]
    [DataMember(Name="VoteRslt")]
    [XmlElement(ElementName="VoteRslt")]
    public required IReadonlyCollection<SomeVoteResultRecord> VoteResult { get; init; } // Min=1, Max=1000
    
    /// <summary>
    /// Information about the participation to the voting process.
    /// </summary>
    [IsoId("_xDJ_L1tcEeSwKe7KuKvXhg")]
    [Description(@"Information about the participation to the voting process.")]
    [DataMember(Name="Prtcptn")]
    [XmlElement(ElementName="Prtcptn")]
    public SomeParticipationRecord? Participation { get; init; }
    
    /// <summary>
    /// Information on where additional information can be received.
    /// </summary>
    [IsoId("_xDJ_MVtcEeSwKe7KuKvXhg")]
    [Description(@"Information on where additional information can be received.")]
    [DataMember(Name="AddtlInf")]
    [XmlElement(ElementName="AddtlInf")]
    public SomeAdditionalInformationRecord? AdditionalInformation { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_xXGYQFtoEeSwKe7KuKvXhg")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="MeetingResultDisseminationV05Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public MeetingResultDisseminationV05Document ToDocument()
    {
        return new MeetingResultDisseminationV05Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="MeetingResultDisseminationV05"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record MeetingResultDisseminationV05Document : IOuterDocument<MeetingResultDisseminationV05>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.008.001.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="MeetingResultDisseminationV05"/> is required.
    /// </summary>
    public required MeetingResultDisseminationV05 Message { get; init; }
}
