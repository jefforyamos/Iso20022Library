﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for MeetingInstructionV09.  ISO2002 ID# _nIzHsTQ7Ee22Z83HpR5E8w.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.seev.MeetingInstructionV09>;

namespace BeneficialStrategies.Iso20022.seev;


/// <summary>
/// This record is an implementation of the seev.004.001.09 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The MeetingInstruction message is sent by a party holding the right to vote to an intermediary, the issuer or its agent to request the receiving party to act upon one or several instructions.
/// Usage
/// The MeetingInstruction message is used to vote, to require attendance to a meeting, to request registration of securities and assign a proxy. One instruction or multiple instructions can be carried within the same message.
/// Once the message is sent, it cannot be modified. It must be cancelled by a MeetingInstructionCancellationRequest. Only after receipt of a confirmed cancelled status via the
/// MeetingInstructionStatus message, a new MeetingInstruction message can be sent.
/// This message definition is intended for use with the Business Application Header (BAH).
/// </summary>
[Serializable]
[Description(@"Scope|The MeetingInstruction message is sent by a party holding the right to vote to an intermediary, the issuer or its agent to request the receiving party to act upon one or several instructions.|Usage|The MeetingInstruction message is used to vote, to require attendance to a meeting, to request registration of securities and assign a proxy. One instruction or multiple instructions can be carried within the same message.|Once the message is sent, it cannot be modified. It must be cancelled by a MeetingInstructionCancellationRequest. Only after receipt of a confirmed cancelled status via the|MeetingInstructionStatus message, a new MeetingInstruction message can be sent.|This message definition is intended for use with the Business Application Header (BAH).")]
public partial record MeetingInstructionV09 : IOuterRecord<MeetingInstructionV09,MeetingInstructionV09Document>
    ,IIsoXmlSerilizable<MeetingInstructionV09>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.004.001.09";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgInstr";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => MeetingInstructionV09Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Page number of the message and continuation indicator to indicate that the multi-part instruction is to continue or that the message is the last page of the multi-part instruction.
    /// </summary>
    [IsoId("_xiGS4TT-Ee2tRf29bleifQ")]
    [Description(@"Page number of the message and continuation indicator to indicate that the multi-part instruction is to continue or that the message is the last page of the multi-part instruction.")]
    [DataMember(Name="Pgntn")]
    [XmlElement(ElementName="Pgntn")]
    public Pagination1? Pagination { get; init; }
    
    /// <summary>
    /// Unique identification of the group of meeting instruction messages when the instruction is split in multiple (paginated) messages.
    /// </summary>
    [IsoId("_7o9OIDT-Ee2tRf29bleifQ")]
    [Description(@"Unique identification of the group of meeting instruction messages when the instruction is split in multiple (paginated) messages.")]
    [DataMember(Name="MtgInstrId")]
    [XmlElement(ElementName="MtgInstrId")]
    public IsoMax35Text? MeetingInstructionIdentification { get; init; }
    
    /// <summary>
    /// Set of elements to allow the unambiguous identification of a meeting.
    /// </summary>
    [IsoId("_nIzHtzQ7Ee22Z83HpR5E8w")]
    [Description(@"Set of elements to allow the unambiguous identification of a meeting.")]
    [DataMember(Name="MtgRef")]
    [XmlElement(ElementName="MtgRef")]
    [Required]
    public required MeetingReference10 MeetingReference { get; init; }
    
    /// <summary>
    /// Security for which the meeting is organised.
    /// </summary>
    [IsoId("_nIzHuTQ7Ee22Z83HpR5E8w")]
    [Description(@"Security for which the meeting is organised.")]
    [DataMember(Name="FinInstrmId")]
    [XmlElement(ElementName="FinInstrmId")]
    [Required]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; }
    
    /// <summary>
    /// Identification of the cancellation request message requesting cancellation of individual instruction(s).
    /// </summary>
    [IsoId("_J-5jgDUAEe2tRf29bleifQ")]
    [Description(@"Identification of the cancellation request message requesting cancellation of individual instruction(s).")]
    [DataMember(Name="InstrCxlReqId")]
    [XmlElement(ElementName="InstrCxlReqId")]
    public MeetingInstructionCancellation1? InstructionCancellationRequestIdentification { get; init; }
    
    /// <summary>
    /// Identification of the message and individual instruction(s) for which the cancellation was requested.
    /// </summary>
    [IsoId("_bAVEMDUAEe2tRf29bleifQ")]
    [Description(@"Identification of the message and individual instruction(s) for which the cancellation was requested.")]
    [DataMember(Name="CancInstrId")]
    [XmlElement(ElementName="CancInstrId")]
    public MeetingInstructionIdentification1? CancelledInstructionIdentification { get; init; }
    
    /// <summary>
    /// Identification of other messages/documents as well as the messages/documents number.
    /// </summary>
    [IsoId("_nIzHuzQ7Ee22Z83HpR5E8w")]
    [Description(@"Identification of other messages/documents as well as the messages/documents number.")]
    [DataMember(Name="OthrDocId")]
    [XmlElement(ElementName="OthrDocId")]
    public DocumentIdentification32? OtherDocumentIdentification { get; init; }
    
    /// <summary>
    /// The position of the instructing party and the action that it wants to take.
    /// </summary>
    [IsoId("_nIzHvTQ7Ee22Z83HpR5E8w")]
    [Description(@"The position of the instructing party and the action that it wants to take.")]
    [DataMember(Name="Instr")]
    [XmlElement(ElementName="Instr")]
    [Required]
    public required Instruction7 Instruction { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_nIzHvzQ7Ee22Z83HpR5E8w")]
    [Description(@"Additional information that cannot be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="MeetingInstructionV09Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public MeetingInstructionV09Document ToDocument()
    {
        return new MeetingInstructionV09Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("MtgInstr");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        if (Pagination is Pagination1 PaginationValue)
        {
            writer.WriteStartElement(null, "Pgntn", xmlNamespace );
            PaginationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (MeetingInstructionIdentification is IsoMax35Text MeetingInstructionIdentificationValue)
        {
            writer.WriteStartElement(null, "MtgInstrId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(MeetingInstructionIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "MtgRef", xmlNamespace );
        MeetingReference.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "FinInstrmId", xmlNamespace );
        FinancialInstrumentIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (InstructionCancellationRequestIdentification is MeetingInstructionCancellation1 InstructionCancellationRequestIdentificationValue)
        {
            writer.WriteStartElement(null, "InstrCxlReqId", xmlNamespace );
            InstructionCancellationRequestIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CancelledInstructionIdentification is MeetingInstructionIdentification1 CancelledInstructionIdentificationValue)
        {
            writer.WriteStartElement(null, "CancInstrId", xmlNamespace );
            CancelledInstructionIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OtherDocumentIdentification is DocumentIdentification32 OtherDocumentIdentificationValue)
        {
            writer.WriteStartElement(null, "OthrDocId", xmlNamespace );
            OtherDocumentIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Instr", xmlNamespace );
        Instruction.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static MeetingInstructionV09 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="MeetingInstructionV09"/>.
/// </summary>
[Serializable]
public partial record MeetingInstructionV09Document : IOuterDocument<MeetingInstructionV09>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.004.001.09";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="MeetingInstructionV09"/> is required.
    /// </summary>
    [DataMember(Name=MeetingInstructionV09.XmlTag)]
    public required MeetingInstructionV09 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(MeetingInstructionV09.XmlTag);
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
