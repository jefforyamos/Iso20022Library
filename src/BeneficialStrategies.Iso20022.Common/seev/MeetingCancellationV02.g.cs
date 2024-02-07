﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for MeetingCancellationV02.  ISO2002 ID# _TlJcItEwEd-BzquC8wXy7w_-976963352.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.seev.MeetingCancellationV02>;

namespace BeneficialStrategies.Iso20022.seev;


/// <summary>
/// This record is an implementation of the seev.002.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The MeetingCancellation message is sent by the party that sent the MeetingNotification message to the original receiver. It is sent to cancel the previous MeetingNotification message or to advise the cancellation of a meeting.
/// Usage
/// The MeetingCancellation message is used in two different situations.
/// First, it is used to cancel a previously sent MeetingNotification message. In this case, the MessageCancellation, the MeetingReference and the Reason building blocks need to be present.
/// Second, it is used to advise that the meeting is cancelled. In this case, only the MeetingReference and Reason building blocks need to be present.
/// </summary>
[Serializable]
[Description(@"Scope|The MeetingCancellation message is sent by the party that sent the MeetingNotification message to the original receiver. It is sent to cancel the previous MeetingNotification message or to advise the cancellation of a meeting.|Usage|The MeetingCancellation message is used in two different situations.|First, it is used to cancel a previously sent MeetingNotification message. In this case, the MessageCancellation, the MeetingReference and the Reason building blocks need to be present.|Second, it is used to advise that the meeting is cancelled. In this case, only the MeetingReference and Reason building blocks need to be present.")]
public partial record MeetingCancellationV02 : IOuterRecord<MeetingCancellationV02,MeetingCancellationV02Document>
    ,IIsoXmlSerilizable<MeetingCancellationV02>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.002.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgCxl";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => MeetingCancellationV02Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Identifies the cancellation message.
    /// </summary>
    [IsoId("_TlJcI9EwEd-BzquC8wXy7w_-1270178957")]
    [Description(@"Identifies the cancellation message.")]
    [DataMember(Name="CxlId")]
    [XmlElement(ElementName="CxlId")]
    [Required]
    public required MessageIdentification1 CancellationIdentification { get; init; }
    
    /// <summary>
    /// Information indicating that the cancellation of a message previously sent is requested (and not the cancellation of the meeting).
    /// </summary>
    [IsoId("_TlJcJNEwEd-BzquC8wXy7w_-976963274")]
    [Description(@"Information indicating that the cancellation of a message previously sent is requested (and not the cancellation of the meeting).")]
    [DataMember(Name="MsgCxl")]
    [XmlElement(ElementName="MsgCxl")]
    public AmendInformation1? MessageCancellation { get; init; }
    
    /// <summary>
    /// Series of elements which allow to identify a meeting.
    /// </summary>
    [IsoId("_TlJcJdEwEd-BzquC8wXy7w_-976963350")]
    [Description(@"Series of elements which allow to identify a meeting.")]
    [DataMember(Name="MtgRef")]
    [XmlElement(ElementName="MtgRef")]
    [Required]
    public required MeetingReference2 MeetingReference { get; init; }
    
    /// <summary>
    /// Party notifying the cancellation of the meeting.
    /// </summary>
    [IsoId("_TlJcJtEwEd-BzquC8wXy7w_-976963316")]
    [Description(@"Party notifying the cancellation of the meeting.")]
    [DataMember(Name="NtifngPty")]
    [XmlElement(ElementName="NtifngPty")]
    public PartyIdentification9Choice_? NotifyingParty { get; init; }
    
    /// <summary>
    /// Identifies the security for which the meeting was organised.
    /// </summary>
    [IsoId("_TlJcJ9EwEd-BzquC8wXy7w_-976963334")]
    [Description(@"Identifies the security for which the meeting was organised.")]
    [DataMember(Name="Scty")]
    [XmlElement(ElementName="Scty")]
    public required ValueList<SecurityPosition5> Security { get; init; } = []; // Min=0, Max=200
    
    /// <summary>
    /// Defines the justification for the cancellation.
    /// </summary>
    [IsoId("_TlJcKNEwEd-BzquC8wXy7w_-976963291")]
    [Description(@"Defines the justification for the cancellation.")]
    [DataMember(Name="Rsn")]
    [XmlElement(ElementName="Rsn")]
    [Required]
    public required MeetingCancellationReason1 Reason { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="MeetingCancellationV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public MeetingCancellationV02Document ToDocument()
    {
        return new MeetingCancellationV02Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("MtgCxl");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "CxlId", xmlNamespace );
        CancellationIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (MessageCancellation is AmendInformation1 MessageCancellationValue)
        {
            writer.WriteStartElement(null, "MsgCxl", xmlNamespace );
            MessageCancellationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "MtgRef", xmlNamespace );
        MeetingReference.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (NotifyingParty is PartyIdentification9Choice_ NotifyingPartyValue)
        {
            writer.WriteStartElement(null, "NtifngPty", xmlNamespace );
            NotifyingPartyValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Scty", xmlNamespace );
        Security.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Rsn", xmlNamespace );
        Reason.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static MeetingCancellationV02 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="MeetingCancellationV02"/>.
/// </summary>
[Serializable]
public partial record MeetingCancellationV02Document : IOuterDocument<MeetingCancellationV02>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.002.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="MeetingCancellationV02"/> is required.
    /// </summary>
    [DataMember(Name=MeetingCancellationV02.XmlTag)]
    public required MeetingCancellationV02 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(MeetingCancellationV02.XmlTag);
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
