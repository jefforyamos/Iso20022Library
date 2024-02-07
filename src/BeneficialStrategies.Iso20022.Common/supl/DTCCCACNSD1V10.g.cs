﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for DTCCCACNSD1V10.  ISO2002 ID# _q_pKaQ4zEeuIpNw_GxsBOw.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.supl.DTCCCACNSD1V10>;

namespace BeneficialStrategies.Iso20022.supl;


/// <summary>
/// This record is an implementation of the supl.006.001.10 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The DTCCCACNSD1 message extends ISO corporate action cancellation advice (CACN) message with DTCC corporate action elements not covered in the standard message.
/// </summary>
[Serializable]
[Description(@"The DTCCCACNSD1 message extends ISO corporate action cancellation advice (CACN) message with DTCC corporate action elements not covered in the standard message.")]
public partial record DTCCCACNSD1V10 : IOuterRecord<DTCCCACNSD1V10,DTCCCACNSD1V10Document>
    ,IIsoXmlSerilizable<DTCCCACNSD1V10>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "supl.006.001.10";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCACNSD1";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DTCCCACNSD1V10Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Page number of the message and continuation indicator to indicate that the multi-parts message is to continue or that the message is the last page of the multi-parts message.
    /// </summary>
    [IsoId("_q_pKaw4zEeuIpNw_GxsBOw")]
    [Description(@"Page number of the message and continuation indicator to indicate that the multi-parts message is to continue or that the message is the last page of the multi-parts message.")]
    [DataMember(Name="Pgntn")]
    [XmlElement(ElementName="Pgntn")]
    public Pagination1? Pagination { get; init; }
    
    /// <summary>
    /// Notification information to be extended as supplementary data to cancellation advice.
    /// </summary>
    [IsoId("_q_pKbQ4zEeuIpNw_GxsBOw")]
    [Description(@"Notification information to be extended as supplementary data to cancellation advice.")]
    [DataMember(Name="Ntfctn")]
    [XmlElement(ElementName="Ntfctn")]
    public CorporateActionNotificationSD10? Notification { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to general information.
    /// </summary>
    [IsoId("_q_pKbw4zEeuIpNw_GxsBOw")]
    [Description(@"Information to be extended as supplementary data to general information.")]
    [DataMember(Name="GnlInf")]
    [XmlElement(ElementName="GnlInf")]
    public CorporateActionGeneralInformationSD40? GeneralInformation { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to underlying security details.
    /// </summary>
    [IsoId("_hJwvUQ-pEeuE0Pnt-OcNOA")]
    [Description(@"Information to be extended as supplementary data to underlying security details.")]
    [DataMember(Name="UndrlygScty")]
    [XmlElement(ElementName="UndrlygScty")]
    public FinancialInstrumentAttributesSD20? UnderlyingSecurity { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to events linkage.
    /// </summary>
    [IsoId("_q_pKcQ4zEeuIpNw_GxsBOw")]
    [Description(@"Information to be extended as supplementary data to events linkage.")]
    [DataMember(Name="EvtsLkg")]
    [XmlElement(ElementName="EvtsLkg")]
    public CorporateActionCancellationSD3? EventsLinkage { get; init; }
    
    /// <summary>
    /// Information to be extended as external comments to cancellation advice.
    /// </summary>
    [IsoId("_q_pKcw4zEeuIpNw_GxsBOw")]
    [Description(@"Information to be extended as external comments to cancellation advice.")]
    [DataMember(Name="XtrnlCmnts")]
    [XmlElement(ElementName="XtrnlCmnts")]
    public CorporateActionCancellationSD4? ExternalComments { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="DTCCCACNSD1V10Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public DTCCCACNSD1V10Document ToDocument()
    {
        return new DTCCCACNSD1V10Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("DTCCCACNSD1");
    
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
        if (Notification is CorporateActionNotificationSD10 NotificationValue)
        {
            writer.WriteStartElement(null, "Ntfctn", xmlNamespace );
            NotificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (GeneralInformation is CorporateActionGeneralInformationSD40 GeneralInformationValue)
        {
            writer.WriteStartElement(null, "GnlInf", xmlNamespace );
            GeneralInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (UnderlyingSecurity is FinancialInstrumentAttributesSD20 UnderlyingSecurityValue)
        {
            writer.WriteStartElement(null, "UndrlygScty", xmlNamespace );
            UnderlyingSecurityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (EventsLinkage is CorporateActionCancellationSD3 EventsLinkageValue)
        {
            writer.WriteStartElement(null, "EvtsLkg", xmlNamespace );
            EventsLinkageValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ExternalComments is CorporateActionCancellationSD4 ExternalCommentsValue)
        {
            writer.WriteStartElement(null, "XtrnlCmnts", xmlNamespace );
            ExternalCommentsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static DTCCCACNSD1V10 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="DTCCCACNSD1V10"/>.
/// </summary>
[Serializable]
public partial record DTCCCACNSD1V10Document : IOuterDocument<DTCCCACNSD1V10>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.006.001.10";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="DTCCCACNSD1V10"/> is required.
    /// </summary>
    [DataMember(Name=DTCCCACNSD1V10.XmlTag)]
    public required DTCCCACNSD1V10 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(DTCCCACNSD1V10.XmlTag);
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
