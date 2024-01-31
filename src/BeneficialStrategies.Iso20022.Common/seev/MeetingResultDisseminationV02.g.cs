﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for MeetingResultDisseminationV02.  ISO2002 ID# _Ts5C69EwEd-BzquC8wXy7w_762088787.
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
/// An issuer, its agent or an intermediary sends the MeetingResultDissemination message to another intermediary, to a party holding the right to vote, to a registered security holder or to a beneficial holder to provide information on the voting results of a shareholders meeting.
/// Usage
/// The MeetingResultDissemination message is used to provide the vote results per resolution. It may also provide information on the level of participation.
/// This message is also used to notify an update or amendment to a previously sent MeetingResultDissemination message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|An issuer, its agent or an intermediary sends the MeetingResultDissemination message to another intermediary, to a party holding the right to vote, to a registered security holder or to a beneficial holder to provide information on the voting results of a shareholders meeting.|Usage|The MeetingResultDissemination message is used to provide the vote results per resolution. It may also provide information on the level of participation.|This message is also used to notify an update or amendment to a previously sent MeetingResultDissemination message.")]
public partial record MeetingResultDisseminationV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgRsltDssmntn";
    
    #nullable enable
    /// <summary>
    /// Identifies the meeting dissemination notification message.
    /// </summary>
    [IsoId("_Ts5C7NEwEd-BzquC8wXy7w_-595761646")]
    [Description(@"Identifies the meeting dissemination notification message.")]
    [DataMember(Name="MtgRsltDssmntnId")]
    [XmlElement(ElementName="MtgRsltDssmntnId")]
    [Required]
    public required MessageIdentification1 MeetingResultDisseminationIdentification { get; init; }
    
    /// <summary>
    /// Information specific to an amemdment.
    /// </summary>
    [IsoId("_Ts5C7dEwEd-BzquC8wXy7w_350846493")]
    [Description(@"Information specific to an amemdment.")]
    [DataMember(Name="Amdmnt")]
    [XmlElement(ElementName="Amdmnt")]
    public AmendInformation2? Amendment { get; init; }
    
    /// <summary>
    /// Series of elements which allow to identify a meeting.
    /// </summary>
    [IsoId("_TtCz4NEwEd-BzquC8wXy7w_762088836")]
    [Description(@"Series of elements which allow to identify a meeting.")]
    [DataMember(Name="MtgRef")]
    [XmlElement(ElementName="MtgRef")]
    [Required]
    public required MeetingReference3 MeetingReference { get; init; }
    
    /// <summary>
    /// Party reporting the meeting results.
    /// </summary>
    [IsoId("_TtCz4dEwEd-BzquC8wXy7w_762088841")]
    [Description(@"Party reporting the meeting results.")]
    [DataMember(Name="RptgPty")]
    [XmlElement(ElementName="RptgPty")]
    [Required]
    public required IPartyIdentification9Choice ReportingParty { get; init; }
    
    /// <summary>
    /// Identifies the securities for which the meeting is organised.
    /// </summary>
    [IsoId("_TtCz4tEwEd-BzquC8wXy7w_762088866")]
    [Description(@"Identifies the securities for which the meeting is organised.")]
    [DataMember(Name="Scty")]
    [XmlElement(ElementName="Scty")]
    public required IReadOnlyCollection<SecurityPosition5> Security { get; init; } = []; // Min=1, Max=200
    
    /// <summary>
    /// Results per resolution.
    /// </summary>
    [IsoId("_TtCz49EwEd-BzquC8wXy7w_762088823")]
    [Description(@"Results per resolution.")]
    [DataMember(Name="VoteRslt")]
    [XmlElement(ElementName="VoteRslt")]
    public required IReadOnlyCollection<Vote5> VoteResult { get; init; } = []; // Min=1, Max=200
    
    /// <summary>
    /// Information about the participation to the voting process.
    /// </summary>
    [IsoId("_TtCz5NEwEd-BzquC8wXy7w_762088806")]
    [Description(@"Information about the participation to the voting process.")]
    [DataMember(Name="Prtcptn")]
    [XmlElement(ElementName="Prtcptn")]
    public Participation2? Participation { get; init; }
    
    /// <summary>
    /// Information on where additionnal information can be received.
    /// </summary>
    [IsoId("_TtCz5dEwEd-BzquC8wXy7w_762088789")]
    [Description(@"Information on where additionnal information can be received.")]
    [DataMember(Name="AddtlInf")]
    [XmlElement(ElementName="AddtlInf")]
    public CommunicationAddress4? AdditionalInformation { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="MeetingResultDisseminationV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public MeetingResultDisseminationV02Document ToDocument()
    {
        return new MeetingResultDisseminationV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="MeetingResultDisseminationV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record MeetingResultDisseminationV02Document : IOuterDocument<MeetingResultDisseminationV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.008.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="MeetingResultDisseminationV02"/> is required.
    /// </summary>
    public required MeetingResultDisseminationV02 Message { get; init; }
}
