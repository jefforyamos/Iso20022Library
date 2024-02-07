﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for OrderConfirmationStatusReportV01.  ISO2002 ID# _hzzSMNE7Ed-BzquC8wXy7w_-354500985.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.setr.OrderConfirmationStatusReportV01>;

namespace BeneficialStrategies.Iso20022.setr;


/// <summary>
/// This record is an implementation of the setr.057.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An instructing party, for example, an investment manager or its authorised representative, sends the OrderConfirmationStatusReport message to the executing party, for example, a transfer agent, to report the status of an order confirmation or an order confirmation amendment.
/// Usage
/// The OrderConfirmationStatusReport message is used to report on the status of one or more individual:
/// - subscription confirmations,
/// - subscription confirmation amendments,
/// - redemption confirmations,
/// - redemption confirmation amendments,
/// - switch order confirmations,
/// - switch order confirmation amendments.
/// One of the following statuses can be reported:
/// - confirmation rejected, or,
/// - amendment rejected, or,
/// - sent to next party, or,
/// - communication problem with next party, or,
/// - confirmation accepted, or,
/// - confirmation received.
/// It is likely that the OrderConfirmationStatusReport is only sent by the order instructing party to the order executing party to reject an order confirmation or to reject an order confirmation amendment, although if an intermediary party is used, the statuses sent to next party and communication problem with next party are also likely be used. The statuses confirmation accepted and confirmation received would only be used in the event the order executing party sends a RequestForOrderConfirmationStatusReport message and one of the other statuses does not apply.
/// If the status being reported is either confirmation rejected or amendment rejected, then a reason for the rejection must be given.
/// The individual order confirmation or confirmation amendment for which the status is given is identified with its order reference. The message identification of the message in which the individual order confirmation or confirmation amendment was conveyed may also be quoted in RelatedReference, but this is not recommended.
/// </summary>
[Serializable]
[Description(@"Scope|An instructing party, for example, an investment manager or its authorised representative, sends the OrderConfirmationStatusReport message to the executing party, for example, a transfer agent, to report the status of an order confirmation or an order confirmation amendment.|Usage|The OrderConfirmationStatusReport message is used to report on the status of one or more individual:|- subscription confirmations,|- subscription confirmation amendments,|- redemption confirmations,|- redemption confirmation amendments,|- switch order confirmations,|- switch order confirmation amendments.|One of the following statuses can be reported:|- confirmation rejected, or,|- amendment rejected, or,|- sent to next party, or,|- communication problem with next party, or,|- confirmation accepted, or,|- confirmation received.|It is likely that the OrderConfirmationStatusReport is only sent by the order instructing party to the order executing party to reject an order confirmation or to reject an order confirmation amendment, although if an intermediary party is used, the statuses sent to next party and communication problem with next party are also likely be used. The statuses confirmation accepted and confirmation received would only be used in the event the order executing party sends a RequestForOrderConfirmationStatusReport message and one of the other statuses does not apply.|If the status being reported is either confirmation rejected or amendment rejected, then a reason for the rejection must be given.|The individual order confirmation or confirmation amendment for which the status is given is identified with its order reference. The message identification of the message in which the individual order confirmation or confirmation amendment was conveyed may also be quoted in RelatedReference, but this is not recommended.")]
public partial record OrderConfirmationStatusReportV01 : IOuterRecord<OrderConfirmationStatusReportV01,OrderConfirmationStatusReportV01Document>
    ,IIsoXmlSerilizable<OrderConfirmationStatusReportV01>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "setr.057.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "OrdrConfStsRptV01";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => OrderConfirmationStatusReportV01Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Reference that uniquely identifies a message from a business application standpoint.
    /// </summary>
    [IsoId("_hzzSMdE7Ed-BzquC8wXy7w_1729546836")]
    [Description(@"Reference that uniquely identifies a message from a business application standpoint.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required MessageIdentification1 MessageIdentification { get; init; }
    
    /// <summary>
    /// Reference to a linked message sent in a proprietary way or reference of a system.
    /// </summary>
    [IsoId("_hzzSMtE7Ed-BzquC8wXy7w_-1840795261")]
    [Description(@"Reference to a linked message sent in a proprietary way or reference of a system.")]
    [DataMember(Name="OthrRef")]
    [XmlElement(ElementName="OthrRef")]
    public required ValueList<AdditionalReference3> OtherReference { get; init; } = []; // Min=0, Max=2
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_hzzSM9E7Ed-BzquC8wXy7w_1545429452")]
    [Description(@"Reference to a linked message that was previously received.")]
    [DataMember(Name="RltdRef")]
    [XmlElement(ElementName="RltdRef")]
    public required ValueList<AdditionalReference3> RelatedReference { get; init; } = []; // Min=0, Max=2
    
    /// <summary>
    /// Status report details of an individual order confirmation.
    /// </summary>
    [IsoId("_hzzSNNE7Ed-BzquC8wXy7w_1394750346")]
    [Description(@"Status report details of an individual order confirmation.")]
    [DataMember(Name="IndvOrdrConfDtlsRpt")]
    [XmlElement(ElementName="IndvOrdrConfDtlsRpt")]
    [Required]
    public required IndividualOrderConfirmationStatusAndReason1 IndividualOrderConfirmationDetailsReport { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_hzzSNdE7Ed-BzquC8wXy7w_1567010081")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="Xtnsn")]
    [XmlElement(ElementName="Xtnsn")]
    public Extension1? Extension { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="OrderConfirmationStatusReportV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public OrderConfirmationStatusReportV01Document ToDocument()
    {
        return new OrderConfirmationStatusReportV01Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("OrdrConfStsRptV01");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "MsgId", xmlNamespace );
        MessageIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "OthrRef", xmlNamespace );
        OtherReference.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "RltdRef", xmlNamespace );
        RelatedReference.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "IndvOrdrConfDtlsRpt", xmlNamespace );
        IndividualOrderConfirmationDetailsReport.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Extension is Extension1 ExtensionValue)
        {
            writer.WriteStartElement(null, "Xtnsn", xmlNamespace );
            ExtensionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static OrderConfirmationStatusReportV01 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="OrderConfirmationStatusReportV01"/>.
/// </summary>
[Serializable]
public partial record OrderConfirmationStatusReportV01Document : IOuterDocument<OrderConfirmationStatusReportV01>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.057.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="OrderConfirmationStatusReportV01"/> is required.
    /// </summary>
    [DataMember(Name=OrderConfirmationStatusReportV01.XmlTag)]
    public required OrderConfirmationStatusReportV01 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(OrderConfirmationStatusReportV01.XmlTag);
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
