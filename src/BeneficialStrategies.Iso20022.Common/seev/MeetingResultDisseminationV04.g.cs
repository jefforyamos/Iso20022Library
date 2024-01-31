﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for MeetingResultDisseminationV04.  ISO2002 ID# _TtVu3NEwEd-BzquC8wXy7w_-1862035552.
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
/// This record is an implementation of the seev.008.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An issuer, its agent or an intermediary sends the MeetingResultDissemination message to another intermediary, to a party holding the right to vote, to a registered security holder or to a beneficial holder to provide information on the voting results of a shareholders meeting.
/// Usage
/// The MeetingResultDissemination message is used to provide the vote results per resolution. It may also provide information on the level of participation.
/// This message is also used to notify an update or amendment to a previously sent MeetingResultDissemination message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|An issuer, its agent or an intermediary sends the MeetingResultDissemination message to another intermediary, to a party holding the right to vote, to a registered security holder or to a beneficial holder to provide information on the voting results of a shareholders meeting.|Usage|The MeetingResultDissemination message is used to provide the vote results per resolution. It may also provide information on the level of participation.|This message is also used to notify an update or amendment to a previously sent MeetingResultDissemination message.")]
public partial record MeetingResultDisseminationV04 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.008.001.04";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgRsltDssmntn";
    
    #nullable enable
    /// <summary>
    /// Identifies the meeting dissemination notification message.
    /// </summary>
    [IsoId("_Ttff0NEwEd-BzquC8wXy7w_-643882585")]
    [Description(@"Identifies the meeting dissemination notification message.")]
    [DataMember(Name="Id")]
    [XmlElement(ElementName="Id")]
    [Required]
    public required MessageIdentification1 Identification { get; init; }
    
    /// <summary>
    /// Information specific to an amemdment.
    /// </summary>
    [IsoId("_Ttff0dEwEd-BzquC8wXy7w_-1365472690")]
    [Description(@"Information specific to an amemdment.")]
    [DataMember(Name="Amdmnt")]
    [XmlElement(ElementName="Amdmnt")]
    public AmendInformation2? Amendment { get; init; }
    
    /// <summary>
    /// Series of elements which allow to identify a meeting.
    /// </summary>
    [IsoId("_Ttff0tEwEd-BzquC8wXy7w_-2000504536")]
    [Description(@"Series of elements which allow to identify a meeting.")]
    [DataMember(Name="MtgRef")]
    [XmlElement(ElementName="MtgRef")]
    [Required]
    public required MeetingReference4 MeetingReference { get; init; }
    
    /// <summary>
    /// Party reporting the meeting results.
    /// </summary>
    [IsoId("_Ttff09EwEd-BzquC8wXy7w_1097656420")]
    [Description(@"Party reporting the meeting results.")]
    [DataMember(Name="RptgPty")]
    [XmlElement(ElementName="RptgPty")]
    [Required]
    public required IPartyIdentification9Choice ReportingParty { get; init; }
    
    /// <summary>
    /// Identifies the securities for which the meeting is organised.
    /// </summary>
    [IsoId("_Ttff1NEwEd-BzquC8wXy7w_1551743689")]
    [Description(@"Identifies the securities for which the meeting is organised.")]
    [DataMember(Name="Scty")]
    [XmlElement(ElementName="Scty")]
    public required IReadOnlyCollection<SecurityPosition6> Security { get; init; } = []; // Min=1, Max=200
    
    /// <summary>
    /// Results per resolution.
    /// </summary>
    [IsoId("_Ttff1dEwEd-BzquC8wXy7w_1540644912")]
    [Description(@"Results per resolution.")]
    [DataMember(Name="VoteRslt")]
    [XmlElement(ElementName="VoteRslt")]
    public required IReadOnlyCollection<Vote5> VoteResult { get; init; } = []; // Min=1, Max=1000
    
    /// <summary>
    /// Information about the participation to the voting process.
    /// </summary>
    [IsoId("_Ttff1tEwEd-BzquC8wXy7w_-1574630100")]
    [Description(@"Information about the participation to the voting process.")]
    [DataMember(Name="Prtcptn")]
    [XmlElement(ElementName="Prtcptn")]
    public Participation3? Participation { get; init; }
    
    /// <summary>
    /// Information on where additionnal information can be received.
    /// </summary>
    [IsoId("_Ttff19EwEd-BzquC8wXy7w_569790323")]
    [Description(@"Information on where additionnal information can be received.")]
    [DataMember(Name="AddtlInf")]
    [XmlElement(ElementName="AddtlInf")]
    public CommunicationAddress4? AdditionalInformation { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_TtopwNEwEd-BzquC8wXy7w_-2089507082")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="Xtnsn")]
    [XmlElement(ElementName="Xtnsn")]
    public Extension2? Extension { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="MeetingResultDisseminationV04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public MeetingResultDisseminationV04Document ToDocument()
    {
        return new MeetingResultDisseminationV04Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="MeetingResultDisseminationV04"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record MeetingResultDisseminationV04Document : IOuterDocument<MeetingResultDisseminationV04>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.008.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="MeetingResultDisseminationV04"/> is required.
    /// </summary>
    public required MeetingResultDisseminationV04 Message { get; init; }
}
