﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for RequestToPayDebtorActivationRequestV01.  ISO2002 ID# _rNNBzeHzEeqbls7Gk4-ckA.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.reda.RequestToPayDebtorActivationRequestV01>;

namespace BeneficialStrategies.Iso20022.reda;


/// <summary>
/// This record is an implementation of the reda.070.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The RequestToPayDebtorActivationRequest message is sent by the debtor RTP (Request To Pay) provider to the creditor RTP provider and optionally from the debtor to its RTP provider and from the creditor RTP provider to the creditor to request the debtor activation of the RTP service with that specific creditor.
/// </summary>
[Serializable]
[Description(@"The RequestToPayDebtorActivationRequest message is sent by the debtor RTP (Request To Pay) provider to the creditor RTP provider and optionally from the debtor to its RTP provider and from the creditor RTP provider to the creditor to request the debtor activation of the RTP service with that specific creditor.")]
public partial record RequestToPayDebtorActivationRequestV01 : IOuterRecord<RequestToPayDebtorActivationRequestV01,RequestToPayDebtorActivationRequestV01Document>
    ,IIsoXmlSerilizable<RequestToPayDebtorActivationRequestV01>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "reda.070.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ReqToPayDbtrActvtnReq";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => RequestToPayDebtorActivationRequestV01Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Header data for the creditor enrolment request.
    /// </summary>
    [IsoId("_rNNBz-HzEeqbls7Gk4-ckA")]
    [Description(@"Header data for the creditor enrolment request.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required ActivationHeader2 Header { get; init; }
    
    /// <summary>
    /// Specific attributes provided the debtor, as requested by the creditor, for the activation request.
    /// </summary>
    [IsoId("_rNNB0eHzEeqbls7Gk4-ckA")]
    [Description(@"Specific attributes provided the debtor, as requested by the creditor, for the activation request.")]
    [DataMember(Name="DbtrActvtn")]
    [XmlElement(ElementName="DbtrActvtn")]
    [Required]
    public required DebtorActivation3 DebtorActivation { get; init; }
    
    /// <summary>
    /// Further data related to the electronic invoice (e-invoice).
    /// </summary>
    [IsoId("_rNNB0-HzEeqbls7Gk4-ckA")]
    [Description(@"Further data related to the electronic invoice (e-invoice).")]
    [DataMember(Name="ElctrncInvcData")]
    [XmlElement(ElementName="ElctrncInvcData")]
    [Required]
    public required ElectronicInvoice1 ElectronicInvoiceData { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_rNNB1eHzEeqbls7Gk4-ckA")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="RequestToPayDebtorActivationRequestV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public RequestToPayDebtorActivationRequestV01Document ToDocument()
    {
        return new RequestToPayDebtorActivationRequestV01Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("ReqToPayDbtrActvtnReq");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "Hdr", xmlNamespace );
        Header.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "DbtrActvtn", xmlNamespace );
        DebtorActivation.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "ElctrncInvcData", xmlNamespace );
        ElectronicInvoiceData.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static RequestToPayDebtorActivationRequestV01 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="RequestToPayDebtorActivationRequestV01"/>.
/// </summary>
[Serializable]
public partial record RequestToPayDebtorActivationRequestV01Document : IOuterDocument<RequestToPayDebtorActivationRequestV01>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.070.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="RequestToPayDebtorActivationRequestV01"/> is required.
    /// </summary>
    [DataMember(Name=RequestToPayDebtorActivationRequestV01.XmlTag)]
    public required RequestToPayDebtorActivationRequestV01 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(RequestToPayDebtorActivationRequestV01.XmlTag);
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
