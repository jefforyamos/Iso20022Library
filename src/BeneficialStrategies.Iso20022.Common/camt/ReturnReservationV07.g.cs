﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ReturnReservationV07.  ISO2002 ID# _ThV639b6Eeq_l4BJLVUF2Q.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.camt.ReturnReservationV07>;

namespace BeneficialStrategies.Iso20022.camt;


/// <summary>
/// This record is an implementation of the camt.047.001.07 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The ReturnReservation message is sent by the transaction administrator to a member.
/// It is used to provide information on the details of one or more reservation facilities set by the member and managed by the transaction administrator.
/// The ReturnReservation message can be sent as a response to a related Get Reservation message (pull mode) or initiated by the transaction administrator (push mode). The push of information can take place either at prearranged times or as a warning or alarm when a problem has occurred.
/// Usage
/// At any time during the operating hours of the system, the member can query the transaction administrator to get information about the reservations facilities that the transaction administrator manages for the member.
/// The transaction administrator will send reservations information to the member based on the following elements:
/// - identification of the system
/// - identification of the account
/// - status of the reservation (default and/or current )
/// - type of reservation.
/// </summary>
[Serializable]
[Description(@"Scope|The ReturnReservation message is sent by the transaction administrator to a member.|It is used to provide information on the details of one or more reservation facilities set by the member and managed by the transaction administrator.|The ReturnReservation message can be sent as a response to a related Get Reservation message (pull mode) or initiated by the transaction administrator (push mode). The push of information can take place either at prearranged times or as a warning or alarm when a problem has occurred.|Usage|At any time during the operating hours of the system, the member can query the transaction administrator to get information about the reservations facilities that the transaction administrator manages for the member.|The transaction administrator will send reservations information to the member based on the following elements:|- identification of the system|- identification of the account|- status of the reservation (default and/or current )|- type of reservation.")]
public partial record ReturnReservationV07 : IOuterRecord<ReturnReservationV07,ReturnReservationV07Document>
    ,IIsoXmlSerilizable<ReturnReservationV07>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.047.001.07";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RtrRsvatn";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => ReturnReservationV07Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_ThWht9b6Eeq_l4BJLVUF2Q")]
    [Description(@"Common business identification for the message.")]
    [DataMember(Name="MsgHdr")]
    [XmlElement(ElementName="MsgHdr")]
    [Required]
    public required MessageHeader7 MessageHeader { get; init; }
    
    /// <summary>
    /// Reports on reservations.
    /// </summary>
    [IsoId("_ThWhudb6Eeq_l4BJLVUF2Q")]
    [Description(@"Reports on reservations.")]
    [DataMember(Name="RptOrErr")]
    [XmlElement(ElementName="RptOrErr")]
    [Required]
    public required ReservationOrError10Choice_ ReportOrError { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_ThWhu9b6Eeq_l4BJLVUF2Q")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ReturnReservationV07Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ReturnReservationV07Document ToDocument()
    {
        return new ReturnReservationV07Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("RtrRsvatn");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "MsgHdr", xmlNamespace );
        MessageHeader.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "RptOrErr", xmlNamespace );
        ReportOrError.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static ReturnReservationV07 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ReturnReservationV07"/>.
/// </summary>
[Serializable]
public partial record ReturnReservationV07Document : IOuterDocument<ReturnReservationV07>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.047.001.07";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ReturnReservationV07"/> is required.
    /// </summary>
    [DataMember(Name=ReturnReservationV07.XmlTag)]
    public required ReturnReservationV07 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(ReturnReservationV07.XmlTag);
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
