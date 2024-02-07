﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for MeetingVoteExecutionConfirmationV03.  ISO2002 ID# _TuFVsNEwEd-BzquC8wXy7w_156758329.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.seev.MeetingVoteExecutionConfirmationV03>;

namespace BeneficialStrategies.Iso20022.seev;


/// <summary>
/// This record is an implementation of the seev.007.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An issuer, its agent or an intermediary sends the MeetingVoteExecutionConfirmation message to confirm to the Sender of the MeetingInstruction message, the execution of their voting instruction.
/// Usage
/// This message is sent after the shareholders meeting has taken place. The Sender of this message confirms the execution of the vote at the meeting and confirms that the vote has been processed as instructed via the MeetingInstruction message.
/// This messages is sent if the Sender of the MeetingInstruction message has requested such a confirmation or if market practice or regulation stipulates the need for a full audit trail.
/// </summary>
[Serializable]
[Description(@"Scope|An issuer, its agent or an intermediary sends the MeetingVoteExecutionConfirmation message to confirm to the Sender of the MeetingInstruction message, the execution of their voting instruction.|Usage|This message is sent after the shareholders meeting has taken place. The Sender of this message confirms the execution of the vote at the meeting and confirms that the vote has been processed as instructed via the MeetingInstruction message.|This messages is sent if the Sender of the MeetingInstruction message has requested such a confirmation or if market practice or regulation stipulates the need for a full audit trail.")]
public partial record MeetingVoteExecutionConfirmationV03 : IOuterRecord<MeetingVoteExecutionConfirmationV03,MeetingVoteExecutionConfirmationV03Document>
    ,IIsoXmlSerilizable<MeetingVoteExecutionConfirmationV03>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.007.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgVoteExctnConf";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => MeetingVoteExecutionConfirmationV03Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Identifies the vote execution confirmation message.
    /// </summary>
    [IsoId("_TuFVsdEwEd-BzquC8wXy7w_-1220424664")]
    [Description(@"Identifies the vote execution confirmation message.")]
    [DataMember(Name="Id")]
    [XmlElement(ElementName="Id")]
    [Required]
    public required MessageIdentification1 Identification { get; init; }
    
    /// <summary>
    /// Identifies the meeting instruction message.
    /// </summary>
    [IsoId("_TuFVstEwEd-BzquC8wXy7w_-1202876694")]
    [Description(@"Identifies the meeting instruction message.")]
    [DataMember(Name="RltdRef")]
    [XmlElement(ElementName="RltdRef")]
    [Required]
    public required MessageIdentification RelatedReference { get; init; }
    
    /// <summary>
    /// Series of elements which allow to identify a meeting.
    /// </summary>
    [IsoId("_TuFVs9EwEd-BzquC8wXy7w_-1149311795")]
    [Description(@"Series of elements which allow to identify a meeting.")]
    [DataMember(Name="MtgRef")]
    [XmlElement(ElementName="MtgRef")]
    [Required]
    public required MeetingReference4 MeetingReference { get; init; }
    
    /// <summary>
    /// Party confirming the votes.
    /// </summary>
    [IsoId("_TuFVtNEwEd-BzquC8wXy7w_-1117911897")]
    [Description(@"Party confirming the votes.")]
    [DataMember(Name="RptgPty")]
    [XmlElement(ElementName="RptgPty")]
    [Required]
    public required PartyIdentification9Choice_ ReportingParty { get; init; }
    
    /// <summary>
    /// Identifies the securities for which the meeting is organised.
    /// </summary>
    [IsoId("_TuFVtdEwEd-BzquC8wXy7w_-1078202603")]
    [Description(@"Identifies the securities for which the meeting is organised.")]
    [DataMember(Name="SctyId")]
    [XmlElement(ElementName="SctyId")]
    [Required]
    public required SecurityIdentification11 SecurityIdentification { get; init; }
    
    /// <summary>
    /// Specifies how a party has voted for each agenda item.
    /// </summary>
    [IsoId("_TuFVttEwEd-BzquC8wXy7w_1618914221")]
    [Description(@"Specifies how a party has voted for each agenda item.")]
    [DataMember(Name="VoteInstrs")]
    [XmlElement(ElementName="VoteInstrs")]
    [Required]
    public required DetailedInstructionStatus9 VoteInstructions { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="MeetingVoteExecutionConfirmationV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public MeetingVoteExecutionConfirmationV03Document ToDocument()
    {
        return new MeetingVoteExecutionConfirmationV03Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("MtgVoteExctnConf");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "Id", xmlNamespace );
        Identification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "RltdRef", xmlNamespace );
        RelatedReference.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "MtgRef", xmlNamespace );
        MeetingReference.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "RptgPty", xmlNamespace );
        ReportingParty.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "SctyId", xmlNamespace );
        SecurityIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "VoteInstrs", xmlNamespace );
        VoteInstructions.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static MeetingVoteExecutionConfirmationV03 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="MeetingVoteExecutionConfirmationV03"/>.
/// </summary>
[Serializable]
public partial record MeetingVoteExecutionConfirmationV03Document : IOuterDocument<MeetingVoteExecutionConfirmationV03>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.007.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="MeetingVoteExecutionConfirmationV03"/> is required.
    /// </summary>
    [DataMember(Name=MeetingVoteExecutionConfirmationV03.XmlTag)]
    public required MeetingVoteExecutionConfirmationV03 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(MeetingVoteExecutionConfirmationV03.XmlTag);
        Message.Serialize(writer, DocumentNamespace);
        writer.WriteEndElement();
        writer.WriteEndElement();
        writer.WriteEndDocument();
    }
    
    public void ReadXml(XmlReader reader)
    {
        throw new NotImplementedException();
    }
    
    public System.Xml.Schema.XmlSchema GetSchema() => null;
}
