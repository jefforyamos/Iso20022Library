﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for MeetingInstructionCancellationRequestV08.  ISO2002 ID# _lKgSUxrdEeyhRdHRjakS2w.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.seev.MeetingInstructionCancellationRequestV08>;

namespace BeneficialStrategies.Iso20022.seev;


/// <summary>
/// This record is an implementation of the seev.005.001.08 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The MeetingInstructionCancellationRequest message is sent by the same party that sent the
/// MeetingInstruction message. It is sent to request the cancellation of one, some or all of the instructions included in the original MeetingInstruction message.
/// Usage
/// This message must be answered by a MeetingInstructionStatus message. 
/// This message definition is intended for use with the Business Application Header (BAH).
/// </summary>
[Serializable]
[Description(@"Scope|The MeetingInstructionCancellationRequest message is sent by the same party that sent the|MeetingInstruction message. It is sent to request the cancellation of one, some or all of the instructions included in the original MeetingInstruction message.|Usage|This message must be answered by a MeetingInstructionStatus message. |This message definition is intended for use with the Business Application Header (BAH).")]
public partial record MeetingInstructionCancellationRequestV08 : IOuterRecord<MeetingInstructionCancellationRequestV08,MeetingInstructionCancellationRequestV08Document>
    ,IIsoXmlSerilizable<MeetingInstructionCancellationRequestV08>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.005.001.08";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgInstrCxlReq";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => MeetingInstructionCancellationRequestV08Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Identification of the original meeting instruction message for which the cancellation is requested or the original meeting instruction message containing the individual instruction(s) that is/are to be cancelled.
    /// </summary>
    [IsoId("_lKgSXRrdEeyhRdHRjakS2w")]
    [Description(@"Identification of the original meeting instruction message for which the cancellation is requested or the original meeting instruction message containing the individual instruction(s) that is/are to be cancelled.")]
    [DataMember(Name="MtgInstrId")]
    [XmlElement(ElementName="MtgInstrId")]
    [Required]
    public required IsoMax35Text MeetingInstructionIdentification { get; init; }
    
    /// <summary>
    /// Set of elements to allow the unambiguous identification of a meeting.
    /// </summary>
    [IsoId("_lKgSXxrdEeyhRdHRjakS2w")]
    [Description(@"Set of elements to allow the unambiguous identification of a meeting.")]
    [DataMember(Name="MtgRef")]
    [XmlElement(ElementName="MtgRef")]
    [Required]
    public required MeetingReference10 MeetingReference { get; init; }
    
    /// <summary>
    /// Security for which the meeting is organised.
    /// </summary>
    [IsoId("_lKgSYRrdEeyhRdHRjakS2w")]
    [Description(@"Security for which the meeting is organised.")]
    [DataMember(Name="FinInstrmId")]
    [XmlElement(ElementName="FinInstrmId")]
    [Required]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; }
    
    /// <summary>
    /// Specifies one or more instructions for which the cancellation is requested.
    /// </summary>
    [IsoId("_lKgSYxrdEeyhRdHRjakS2w")]
    [Description(@"Specifies one or more instructions for which the cancellation is requested.")]
    [DataMember(Name="ToBeCancInstr")]
    [XmlElement(ElementName="ToBeCancInstr")]
    public CancelInstruction3? ToBeCancelledInstruction { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_lKgSZRrdEeyhRdHRjakS2w")]
    [Description(@"Additional information that cannot be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="MeetingInstructionCancellationRequestV08Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public MeetingInstructionCancellationRequestV08Document ToDocument()
    {
        return new MeetingInstructionCancellationRequestV08Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("MtgInstrCxlReq");
    
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
        if (ToBeCancelledInstruction is CancelInstruction3 ToBeCancelledInstructionValue)
        {
            writer.WriteStartElement(null, "ToBeCancInstr", xmlNamespace );
            ToBeCancelledInstructionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static MeetingInstructionCancellationRequestV08 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="MeetingInstructionCancellationRequestV08"/>.
/// </summary>
[Serializable]
public partial record MeetingInstructionCancellationRequestV08Document : IOuterDocument<MeetingInstructionCancellationRequestV08>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.005.001.08";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="MeetingInstructionCancellationRequestV08"/> is required.
    /// </summary>
    [DataMember(Name=MeetingInstructionCancellationRequestV08.XmlTag)]
    public required MeetingInstructionCancellationRequestV08 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(MeetingInstructionCancellationRequestV08.XmlTag);
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
