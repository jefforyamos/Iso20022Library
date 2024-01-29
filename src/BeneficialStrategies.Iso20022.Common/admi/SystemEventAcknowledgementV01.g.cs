﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SystemEventAcknowledgementV01.  ISO2002 ID# _-4fJISzhEeKZfox_pyYpTA.
//
namespace BeneficialStrategies.Iso20022.admi;

/// <summary>
/// The SystemEventAcknowledgement message is sent by a participant of a central system to the central system to acknowledge the notification of an occurrence of an event in a central system.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The SystemEventAcknowledgement message is sent by a participant of a central system to the central system to acknowledge the notification of an occurrence of an event in a central system.|")]
public partial record SystemEventAcknowledgementV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SysEvtAck";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Unique and unambiguous identifier for the message, as assigned by the sender.
    /// </summary>
    [IsoId("_38ITWTp8EeKXK8qRvydwAw")]
    [Description(@"Unique and unambiguous identifier for the message, as assigned by the sender.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required SomeMessageIdentificationRecord MessageIdentification { get; init; }
    
    /// <summary>
    /// Represents the original reference of the system event notification for which the acknowledgement is given, as assigned by the central system.
    /// </summary>
    [IsoId("_-PT44DqNEeKXK8qRvydwAw")]
    [Description(@"Represents the original reference of the system event notification for which the acknowledgement is given, as assigned by the central system.")]
    [DataMember(Name="OrgtrRef")]
    [XmlElement(ElementName="OrgtrRef")]
    public SomeOriginatorReferenceRecord? OriginatorReference { get; init; }
    
    /// <summary>
    /// To indicate the requested CLS Settlement Session that the related trade is part of.
    /// </summary>
    [IsoId("_Pq-14zqfEeKqTf3MbquCbA")]
    [Description(@"To indicate the requested CLS Settlement Session that the related trade is part of.")]
    [DataMember(Name="SttlmSsnIdr")]
    [XmlElement(ElementName="SttlmSsnIdr")]
    public SomeSettlementSessionIdentifierRecord? SettlementSessionIdentifier { get; init; }
    
    /// <summary>
    /// Details of the system event being acknowledged.
    /// </summary>
    [IsoId("_-4fJJSzhEeKZfox_pyYpTA")]
    [Description(@"Details of the system event being acknowledged.")]
    [DataMember(Name="AckDtls")]
    [XmlElement(ElementName="AckDtls")]
    public SomeAcknowledgementDetailsRecord? AcknowledgementDetails { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_E4uhVy53EeKwTrPDLMbLxA")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SystemEventAcknowledgementV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SystemEventAcknowledgementV01Document ToDocument()
    {
        return new SystemEventAcknowledgementV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SystemEventAcknowledgementV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SystemEventAcknowledgementV01Document : IOuterDocument<SystemEventAcknowledgementV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:admi.011.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SystemEventAcknowledgementV01"/> is required.
    /// </summary>
    public required SystemEventAcknowledgementV01 Message { get; init; }
}