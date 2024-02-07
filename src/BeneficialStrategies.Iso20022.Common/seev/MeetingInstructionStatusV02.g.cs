﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for MeetingInstructionStatusV02.  ISO2002 ID# _Tpw2YNEwEd-BzquC8wXy7w_322491691.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.seev.MeetingInstructionStatusV02>;

namespace BeneficialStrategies.Iso20022.seev;


/// <summary>
/// This record is an implementation of the seev.006.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The Receiver of the MeetingInstruction or MeetingInstructionCancellationRequest sends the MeetingInstructionStatus message to the Sender of these messages.
/// The message gives the status of a complete message or of one or more specific instructions within the message.
/// Usage
/// The MeetingInstructionStatus message is used for four purposes.
/// First, it provides the status on the processing of a MeetingInstructionCancellationRequest message, ie, whether the request message is rejected or accepted.
/// Second, it is used to provide a global processing or rejection status of a MeetingInstruction message.
/// Third, it is used to provide a detailed processing or rejection status of a MeetingInstruction message, ie, for each instruction in the MeetingInstruction message the processing or rejection status is individually reported by using the InstructionIdentification element. This identification allows the receiver of the status message to link the status confirmation to its original instruction.
/// The blocking of securities should be confirmed via an MT 508 (Intra-Position Advice).
/// Fourth, it is used as a reminder to request voting instructions. This is done by indicating NONREF in the Identification element of the InstructionIdentification component and by using the status code NotReceived in the ProcessingStatus.
/// </summary>
[Serializable]
[Description(@"Scope|The Receiver of the MeetingInstruction or MeetingInstructionCancellationRequest sends the MeetingInstructionStatus message to the Sender of these messages.|The message gives the status of a complete message or of one or more specific instructions within the message.|Usage|The MeetingInstructionStatus message is used for four purposes.|First, it provides the status on the processing of a MeetingInstructionCancellationRequest message, ie, whether the request message is rejected or accepted.|Second, it is used to provide a global processing or rejection status of a MeetingInstruction message.|Third, it is used to provide a detailed processing or rejection status of a MeetingInstruction message, ie, for each instruction in the MeetingInstruction message the processing or rejection status is individually reported by using the InstructionIdentification element. This identification allows the receiver of the status message to link the status confirmation to its original instruction.|The blocking of securities should be confirmed via an MT 508 (Intra-Position Advice).|Fourth, it is used as a reminder to request voting instructions. This is done by indicating NONREF in the Identification element of the InstructionIdentification component and by using the status code NotReceived in the ProcessingStatus.")]
public partial record MeetingInstructionStatusV02 : IOuterRecord<MeetingInstructionStatusV02,MeetingInstructionStatusV02Document>
    ,IIsoXmlSerilizable<MeetingInstructionStatusV02>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.006.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgInstrSts";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => MeetingInstructionStatusV02Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Identifies the meeting instruction status message.
    /// </summary>
    [IsoId("_Tpw2YdEwEd-BzquC8wXy7w_322491753")]
    [Description(@"Identifies the meeting instruction status message.")]
    [DataMember(Name="MtgInstrStsId")]
    [XmlElement(ElementName="MtgInstrStsId")]
    [Required]
    public required MessageIdentification1 MeetingInstructionStatusIdentification { get; init; }
    
    /// <summary>
    /// Identifies the meeting instruction message for which the status is provided.
    /// </summary>
    [IsoId("_Tpw2YtEwEd-BzquC8wXy7w_2026535768")]
    [Description(@"Identifies the meeting instruction message for which the status is provided.")]
    [DataMember(Name="InstrId")]
    [XmlElement(ElementName="InstrId")]
    [Required]
    public required MessageIdentification InstructionIdentification { get; init; }
    
    /// <summary>
    /// Identifies the meeting instruction cancellation request message for which the status is provided.
    /// </summary>
    [IsoId("_Tpw2Y9EwEd-BzquC8wXy7w_-1459248718")]
    [Description(@"Identifies the meeting instruction cancellation request message for which the status is provided.")]
    [DataMember(Name="InstrCxlId")]
    [XmlElement(ElementName="InstrCxlId")]
    [Required]
    public required MessageIdentification InstructionCancellationIdentification { get; init; }
    
    /// <summary>
    /// Series of elements which allow to identify a meeting.
    /// </summary>
    [IsoId("_Tpw2ZNEwEd-BzquC8wXy7w_322491723")]
    [Description(@"Series of elements which allow to identify a meeting.")]
    [DataMember(Name="MtgRef")]
    [XmlElement(ElementName="MtgRef")]
    [Required]
    public required MeetingReference3 MeetingReference { get; init; }
    
    /// <summary>
    /// Party reporting the status.
    /// </summary>
    [IsoId("_Tpw2ZdEwEd-BzquC8wXy7w_322491769")]
    [Description(@"Party reporting the status.")]
    [DataMember(Name="RptgPty")]
    [XmlElement(ElementName="RptgPty")]
    [Required]
    public required PartyIdentification9Choice_ ReportingParty { get; init; }
    
    /// <summary>
    /// Identifies the securities for which the meeting is organised.
    /// </summary>
    [IsoId("_Tpw2ZtEwEd-BzquC8wXy7w_322491740")]
    [Description(@"Identifies the securities for which the meeting is organised.")]
    [DataMember(Name="SctyId")]
    [XmlElement(ElementName="SctyId")]
    [Required]
    public required SecurityIdentification3 SecurityIdentification { get; init; }
    
    /// <summary>
    /// Status applying to the instruction request received. The instruction is identified by the InstructionIdentification.
    /// </summary>
    [IsoId("_Tp6nYNEwEd-BzquC8wXy7w_-1918238262")]
    [Description(@"Status applying to the instruction request received. The instruction is identified by the InstructionIdentification.")]
    [DataMember(Name="InstrSts")]
    [XmlElement(ElementName="InstrSts")]
    [Required]
    public required InstructionStatus1Choice_ InstructionStatus { get; init; }
    
    /// <summary>
    /// Status applying to the instruction cancellation request received. The instruction cancellation is identified by the InstructionCancellationIdentification.
    /// </summary>
    [IsoId("_Tp6nYdEwEd-BzquC8wXy7w_-1891306191")]
    [Description(@"Status applying to the instruction cancellation request received. The instruction cancellation is identified by the InstructionCancellationIdentification.")]
    [DataMember(Name="CxlSts")]
    [XmlElement(ElementName="CxlSts")]
    [Required]
    public required CancellationStatus1Choice_ CancellationStatus { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="MeetingInstructionStatusV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public MeetingInstructionStatusV02Document ToDocument()
    {
        return new MeetingInstructionStatusV02Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("MtgInstrSts");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "MtgInstrStsId", xmlNamespace );
        MeetingInstructionStatusIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "InstrId", xmlNamespace );
        InstructionIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "InstrCxlId", xmlNamespace );
        InstructionCancellationIdentification.Serialize(writer, xmlNamespace);
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
        writer.WriteStartElement(null, "InstrSts", xmlNamespace );
        InstructionStatus.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "CxlSts", xmlNamespace );
        CancellationStatus.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static MeetingInstructionStatusV02 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="MeetingInstructionStatusV02"/>.
/// </summary>
[Serializable]
public partial record MeetingInstructionStatusV02Document : IOuterDocument<MeetingInstructionStatusV02>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.006.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="MeetingInstructionStatusV02"/> is required.
    /// </summary>
    [DataMember(Name=MeetingInstructionStatusV02.XmlTag)]
    public required MeetingInstructionStatusV02 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(MeetingInstructionStatusV02.XmlTag);
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
