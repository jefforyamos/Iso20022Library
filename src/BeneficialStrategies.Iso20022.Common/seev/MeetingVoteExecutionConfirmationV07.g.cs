﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for MeetingVoteExecutionConfirmationV07.  ISO2002 ID# _sV77O_EkEeqRfth943bvEA.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.seev.MeetingVoteExecutionConfirmationV07>;

namespace BeneficialStrategies.Iso20022.seev;


/// <summary>
/// This record is an implementation of the seev.007.001.07 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The MeetingVoteExecutionConfirmation message is sent by an issuer, its agent or an intermediary to another intermediary, a party holding the right to vote, a registered security holder or to a beneficial holder to confirm, to the Sender of the MeetingInstruction message, that their vote has been recorded and counted by the Issuer.
/// Usage
/// This message is sent after the shareholders meeting has taken place. The Sender of this message confirms the execution of the vote at the meeting.
/// This messages is sent if the Sender of the MeetingInstruction message has requested such a confirmation or if market practice or regulation stipulates the need for a full audit trail.
/// This message definition is intended for use with the Business Application Header (BAH).
/// </summary>
[Serializable]
[Description(@"Scope|The MeetingVoteExecutionConfirmation message is sent by an issuer, its agent or an intermediary to another intermediary, a party holding the right to vote, a registered security holder or to a beneficial holder to confirm, to the Sender of the MeetingInstruction message, that their vote has been recorded and counted by the Issuer.|Usage|This message is sent after the shareholders meeting has taken place. The Sender of this message confirms the execution of the vote at the meeting.|This messages is sent if the Sender of the MeetingInstruction message has requested such a confirmation or if market practice or regulation stipulates the need for a full audit trail.|This message definition is intended for use with the Business Application Header (BAH).")]
public partial record MeetingVoteExecutionConfirmationV07 : IOuterRecord<MeetingVoteExecutionConfirmationV07,MeetingVoteExecutionConfirmationV07Document>
    ,IIsoXmlSerilizable<MeetingVoteExecutionConfirmationV07>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.007.001.07";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgVoteExctnConf";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => MeetingVoteExecutionConfirmationV07Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Identification of the original meeting instruction message for which the vote execution  confirmation is provided.
    /// </summary>
    [IsoId("_sV77Q_EkEeqRfth943bvEA")]
    [Description(@"Identification of the original meeting instruction message for which the vote execution  confirmation is provided.")]
    [DataMember(Name="MtgInstrId")]
    [XmlElement(ElementName="MtgInstrId")]
    [Required]
    public required IsoMax35Text MeetingInstructionIdentification { get; init; }
    
    /// <summary>
    /// Set of elements to allow the unambiguous identification of a meeting.
    /// </summary>
    [IsoId("_sV77RfEkEeqRfth943bvEA")]
    [Description(@"Set of elements to allow the unambiguous identification of a meeting.")]
    [DataMember(Name="MtgRef")]
    [XmlElement(ElementName="MtgRef")]
    [Required]
    public required MeetingReference10 MeetingReference { get; init; }
    
    /// <summary>
    /// Security for which the meeting is organised.
    /// </summary>
    [IsoId("_sV77R_EkEeqRfth943bvEA")]
    [Description(@"Security for which the meeting is organised.")]
    [DataMember(Name="FinInstrmId")]
    [XmlElement(ElementName="FinInstrmId")]
    [Required]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; }
    
    /// <summary>
    /// Specifies how a party has voted for each agenda item.
    /// </summary>
    [IsoId("_sV77SfEkEeqRfth943bvEA")]
    [Description(@"Specifies how a party has voted for each agenda item.")]
    [DataMember(Name="VoteInstrs")]
    [XmlElement(ElementName="VoteInstrs")]
    public DetailedInstructionStatus15? VoteInstructions { get; init; }
    
    /// <summary>
    /// Address to use over the www (HTTP) service where the confirmations of the vote instructions can be found.
    /// </summary>
    [IsoId("_sV77S_EkEeqRfth943bvEA")]
    [Description(@"Address to use over the www (HTTP) service where the confirmations of the vote instructions can be found.")]
    [DataMember(Name="VoteInstrsConfURLAdr")]
    [XmlElement(ElementName="VoteInstrsConfURLAdr")]
    public IsoMax2048Text? VoteInstructionsConfirmationURLAddress { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_sV77TfEkEeqRfth943bvEA")]
    [Description(@"Additional information that cannot be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="MeetingVoteExecutionConfirmationV07Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public MeetingVoteExecutionConfirmationV07Document ToDocument()
    {
        return new MeetingVoteExecutionConfirmationV07Document { Message = this };
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
        writer.WriteStartElement(null, "MtgInstrId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(MeetingInstructionIdentification)); // data type Max35Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "MtgRef", xmlNamespace );
        MeetingReference.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "FinInstrmId", xmlNamespace );
        FinancialInstrumentIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (VoteInstructions is DetailedInstructionStatus15 VoteInstructionsValue)
        {
            writer.WriteStartElement(null, "VoteInstrs", xmlNamespace );
            VoteInstructionsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (VoteInstructionsConfirmationURLAddress is IsoMax2048Text VoteInstructionsConfirmationURLAddressValue)
        {
            writer.WriteStartElement(null, "VoteInstrsConfURLAdr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax2048Text(VoteInstructionsConfirmationURLAddressValue)); // data type Max2048Text System.String
            writer.WriteEndElement();
        }
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static MeetingVoteExecutionConfirmationV07 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="MeetingVoteExecutionConfirmationV07"/>.
/// </summary>
[Serializable]
public partial record MeetingVoteExecutionConfirmationV07Document : IOuterDocument<MeetingVoteExecutionConfirmationV07>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.007.001.07";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="MeetingVoteExecutionConfirmationV07"/> is required.
    /// </summary>
    [DataMember(Name=MeetingVoteExecutionConfirmationV07.XmlTag)]
    public required MeetingVoteExecutionConfirmationV07 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(MeetingVoteExecutionConfirmationV07.XmlTag);
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
