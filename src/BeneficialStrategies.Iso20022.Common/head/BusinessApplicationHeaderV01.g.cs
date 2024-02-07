﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for BusinessApplicationHeaderV01.  ISO2002 ID# _qJyPQtFHEd-BzquC8wXy7w_1346744518.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.head.BusinessApplicationHeaderV01>;

namespace BeneficialStrategies.Iso20022.head;


/// <summary>
/// This record is an implementation of the head.001.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The Business Layer deals with Business Messages. The behaviour of the Business Messages is fully described by the Business Transaction and the structure of the Business Messages is fully described by the Message Definitions and related Message Rules, Rules and Market Practices. All of which are registered in the ISO 20022 Repository.
/// A single new Business Message (with its accompagnying business application header) is created - by the sending MessagingEndpoint - for each business event; that is each interaction in a Business Transaction. A Business Message adheres to the following principles:
/// " A Business Message (and its business application header) must not contain information about the Message Transport System or the mechanics or mechanism of message sending, transportation, or receipt. 
/// " A Business Message must be comprehensible outside of the context of the Transport Message. That is the Business Message must not require knowledge of the Transport Message to be understood.
/// " A Business Message may contain headers, footers, and envelopes that are meaningful for the business. When present, they are treated as any other message content, which means that they are considered part of the Message Definition of the Business Message and as such will be part of the ISO 20022 Repository.
/// " A Business Message refers to Business Actors by their Name. Each instance of a Business Actor has one Name. The Business Actor must not be referred to in the Transport Layer.
/// Specific usage of this BusinessMessageHeader may be defined by the relevant SEG.
/// </summary>
[Serializable]
[Description(@"The Business Layer deals with Business Messages. The behaviour of the Business Messages is fully described by the Business Transaction and the structure of the Business Messages is fully described by the Message Definitions and related Message Rules, Rules and Market Practices. All of which are registered in the ISO 20022 Repository.|A single new Business Message (with its accompagnying business application header) is created - by the sending MessagingEndpoint - for each business event; that is each interaction in a Business Transaction. A Business Message adheres to the following principles:|"" A Business Message (and its business application header) must not contain information about the Message Transport System or the mechanics or mechanism of message sending, transportation, or receipt. |"" A Business Message must be comprehensible outside of the context of the Transport Message. That is the Business Message must not require knowledge of the Transport Message to be understood.|"" A Business Message may contain headers, footers, and envelopes that are meaningful for the business. When present, they are treated as any other message content, which means that they are considered part of the Message Definition of the Business Message and as such will be part of the ISO 20022 Repository.|"" A Business Message refers to Business Actors by their Name. Each instance of a Business Actor has one Name. The Business Actor must not be referred to in the Transport Layer.|Specific usage of this BusinessMessageHeader may be defined by the relevant SEG.")]
public partial record BusinessApplicationHeaderV01 : IOuterRecord<BusinessApplicationHeaderV01,BusinessApplicationHeaderV01Document>
    ,IIsoXmlSerilizable<BusinessApplicationHeaderV01>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "head.001.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AppHdr";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => BusinessApplicationHeaderV01Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Contains the character set of the text-based elements used in the Business Message.
    /// </summary>
    [IsoId("_qJyPQ9FHEd-BzquC8wXy7w_474795999")]
    [Description(@"Contains the character set of the text-based elements used in the Business Message.")]
    [DataMember(Name="CharSet")]
    [XmlElement(ElementName="CharSet")]
    public UnicodeChartsCode? CharacterSet { get; init; }
    
    /// <summary>
    /// The sending MessagingEndpoint that has created this Business Message for the receiving MessagingEndpoint that will process this Business Message.
    /// Note	the sending MessagingEndpoint might be different from the sending address potentially contained in the transport header (as defined in the transport layer).
    /// </summary>
    [IsoId("_qJyPRNFHEd-BzquC8wXy7w_-123343718")]
    [Description(@"The sending MessagingEndpoint that has created this Business Message for the receiving MessagingEndpoint that will process this Business Message.||Note	the sending MessagingEndpoint might be different from the sending address potentially contained in the transport header (as defined in the transport layer).")]
    [DataMember(Name="Fr")]
    [XmlElement(ElementName="Fr")]
    [Required]
    public required Party9Choice_ From { get; init; }
    
    /// <summary>
    /// The MessagingEndpoint designated by the sending MessagingEndpoint to be the recipient who will ultimately process this Business Message.
    /// Note the receiving MessagingEndpoint might be different from the receiving address potentially contained in the transport header (as defined in the transport layer).
    /// </summary>
    [IsoId("_qJyPRdFHEd-BzquC8wXy7w_-148352244")]
    [Description(@"The MessagingEndpoint designated by the sending MessagingEndpoint to be the recipient who will ultimately process this Business Message.||Note the receiving MessagingEndpoint might be different from the receiving address potentially contained in the transport header (as defined in the transport layer).")]
    [DataMember(Name="To")]
    [XmlElement(ElementName="To")]
    [Required]
    public required Party9Choice_ To { get; init; }
    
    /// <summary>
    /// Unambiguously identifies the Business Message to the MessagingEndpoint that has created the Business Message.
    /// </summary>
    [IsoId("_qJyPRtFHEd-BzquC8wXy7w_1978492942")]
    [Description(@"Unambiguously identifies the Business Message to the MessagingEndpoint that has created the Business Message.")]
    [DataMember(Name="BizMsgIdr")]
    [XmlElement(ElementName="BizMsgIdr")]
    [Required]
    public required IsoMax35Text BusinessMessageIdentifier { get; init; }
    
    /// <summary>
    /// Contains the MessageIdentifier that defines the BusinessMessage.
    /// It must contain a MessageIdentifier published on the ISO 20022 website.
    /// example	camt.001.001.03.
    /// </summary>
    [IsoId("_qJyPR9FHEd-BzquC8wXy7w_-176162321")]
    [Description(@"Contains the MessageIdentifier that defines the BusinessMessage.|It must contain a MessageIdentifier published on the ISO 20022 website.||example	camt.001.001.03.")]
    [DataMember(Name="MsgDefIdr")]
    [XmlElement(ElementName="MsgDefIdr")]
    [Required]
    public required IsoMax35Text MessageDefinitionIdentifier { get; init; }
    
    /// <summary>
    /// Specifies the business service agreed between the two MessagingEndpoints under which rules this Business Message is exchanged.
    ///  To be used when there is a choice of processing services or processing service levels.
    /// Example: E&I.
    /// </summary>
    [IsoId("_qJ8AQNFHEd-BzquC8wXy7w_-1566891032")]
    [Description(@"Specifies the business service agreed between the two MessagingEndpoints under which rules this Business Message is exchanged.| To be used when there is a choice of processing services or processing service levels.|Example: E&I.")]
    [DataMember(Name="BizSvc")]
    [XmlElement(ElementName="BizSvc")]
    public IsoMax35Text? BusinessService { get; init; }
    
    /// <summary>
    /// Date and time when this Business Message (header) was created.
    /// Note Times must be normalized, using the "Z" annotation.
    /// </summary>
    [IsoId("_qJ8AQdFHEd-BzquC8wXy7w_218642822")]
    [Description(@"Date and time when this Business Message (header) was created.|Note Times must be normalized, using the ""Z"" annotation.")]
    [DataMember(Name="CreDt")]
    [XmlElement(ElementName="CreDt")]
    [Required]
    public required IsoISONormalisedDateTime CreationDate { get; init; }
    
    /// <summary>
    /// Indicates whether the message is a Copy, a Duplicate or a copy of a duplicate of a previously sent ISO 20022 Message.
    /// </summary>
    [IsoId("_qJ8AQtFHEd-BzquC8wXy7w_483261909")]
    [Description(@"Indicates whether the message is a Copy, a Duplicate or a copy of a duplicate of a previously sent ISO 20022 Message.")]
    [DataMember(Name="CpyDplct")]
    [XmlElement(ElementName="CpyDplct")]
    public CopyDuplicate1Code? CopyDuplicate { get; init; }
    
    /// <summary>
    /// Flag indicating if the Business Message exchanged between the MessagingEndpoints is possibly a duplicate. 
    /// If the receiving MessagingEndpoint did not receive the original, then this Business Message should be processed as if it were the original. 
    /// If the receiving MessagingEndpoint did receive the original, then it should perform necessary actions to avoid processing this Business Message again.
    /// This will guarantee business idempotent behaviour.
    /// NOTE: this is named "PossResend" in FIX - this is an application level resend not a network level retransmission.
    /// </summary>
    [IsoId("_qJ8AQ9FHEd-BzquC8wXy7w_-659356211")]
    [Description(@"Flag indicating if the Business Message exchanged between the MessagingEndpoints is possibly a duplicate. |If the receiving MessagingEndpoint did not receive the original, then this Business Message should be processed as if it were the original. ||If the receiving MessagingEndpoint did receive the original, then it should perform necessary actions to avoid processing this Business Message again.||This will guarantee business idempotent behaviour.||NOTE: this is named ""PossResend"" in FIX - this is an application level resend not a network level retransmission.")]
    [DataMember(Name="PssblDplct")]
    [XmlElement(ElementName="PssblDplct")]
    public IsoYesNoIndicator? PossibleDuplicate { get; init; }
    
    /// <summary>
    /// Relative indication of the processing precedence of the message over a (set of) Business Messages with assigned priorities.
    /// </summary>
    [IsoId("_qJ8ARNFHEd-BzquC8wXy7w_-797565634")]
    [Description(@"Relative indication of the processing precedence of the message over a (set of) Business Messages with assigned priorities.")]
    [DataMember(Name="Prty")]
    [XmlElement(ElementName="Prty")]
    public BusinessMessagePriorityCode? Priority { get; init; }
    
    /// <summary>
    /// Contains the digital signature of the Business Entity authorised to sign this Business Message.
    /// </summary>
    [IsoId("_qJ8ARdFHEd-BzquC8wXy7w_983060799")]
    [Description(@"Contains the digital signature of the Business Entity authorised to sign this Business Message.")]
    [DataMember(Name="Sgntr")]
    [XmlElement(ElementName="Sgntr")]
    public SignatureEnvelope? Signature { get; init; }
    
    /// <summary>
    /// Specifies the Business Application Header of the Business Message to which this Business Message relates.
    /// Can be used when replying to a query; can also be used when canceling or amending.
    /// </summary>
    [IsoId("_qJ8ARtFHEd-BzquC8wXy7w_732677776")]
    [Description(@"Specifies the Business Application Header of the Business Message to which this Business Message relates.|Can be used when replying to a query; can also be used when canceling or amending.")]
    [DataMember(Name="Rltd")]
    [XmlElement(ElementName="Rltd")]
    public BusinessApplicationHeader1? Related { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="BusinessApplicationHeaderV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public BusinessApplicationHeaderV01Document ToDocument()
    {
        return new BusinessApplicationHeaderV01Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("AppHdr");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        if (CharacterSet is UnicodeChartsCode CharacterSetValue)
        {
            writer.WriteStartElement(null, "CharSet", xmlNamespace );
            writer.WriteValue(CharacterSetValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Fr", xmlNamespace );
        From.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "To", xmlNamespace );
        To.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "BizMsgIdr", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(BusinessMessageIdentifier)); // data type Max35Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "MsgDefIdr", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(MessageDefinitionIdentifier)); // data type Max35Text System.String
        writer.WriteEndElement();
        if (BusinessService is IsoMax35Text BusinessServiceValue)
        {
            writer.WriteStartElement(null, "BizSvc", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(BusinessServiceValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "CreDt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISONormalisedDateTime(CreationDate)); // data type ISONormalisedDateTime System.DateTime
        writer.WriteEndElement();
        if (CopyDuplicate is CopyDuplicate1Code CopyDuplicateValue)
        {
            writer.WriteStartElement(null, "CpyDplct", xmlNamespace );
            writer.WriteValue(CopyDuplicateValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (PossibleDuplicate is IsoYesNoIndicator PossibleDuplicateValue)
        {
            writer.WriteStartElement(null, "PssblDplct", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(PossibleDuplicateValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (Priority is BusinessMessagePriorityCode PriorityValue)
        {
            writer.WriteStartElement(null, "Prty", xmlNamespace );
            writer.WriteValue(PriorityValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (Signature is SignatureEnvelope SignatureValue)
        {
            writer.WriteStartElement(null, "Sgntr", xmlNamespace );
            SignatureValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Related is BusinessApplicationHeader1 RelatedValue)
        {
            writer.WriteStartElement(null, "Rltd", xmlNamespace );
            RelatedValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static BusinessApplicationHeaderV01 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="BusinessApplicationHeaderV01"/>.
/// </summary>
[Serializable]
public partial record BusinessApplicationHeaderV01Document : IOuterDocument<BusinessApplicationHeaderV01>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:head.001.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="BusinessApplicationHeaderV01"/> is required.
    /// </summary>
    [DataMember(Name=BusinessApplicationHeaderV01.XmlTag)]
    public required BusinessApplicationHeaderV01 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(BusinessApplicationHeaderV01.XmlTag);
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
