﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesFinancingReportingTransactionReportV01.  ISO2002 ID# _2zvMHQuAEeqVvtu9Ny8FDA.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.auth.SecuritiesFinancingReportingTransactionReportV01>;

namespace BeneficialStrategies.Iso20022.auth;


/// <summary>
/// This record is an implementation of the auth.052.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The SecuritiesFinancingReportingTransactionReport message is sent by the report submitting entity to the trade repository (TR) to report on the securities financing transactions or sent by the trade repository (TR) to the authority or made available by the trade repository (TR) to the  report submitting entity and the reporting counterparty as well as the entity responsible for reporting, if applicable.
/// </summary>
[Serializable]
[Description(@"The SecuritiesFinancingReportingTransactionReport message is sent by the report submitting entity to the trade repository (TR) to report on the securities financing transactions or sent by the trade repository (TR) to the authority or made available by the trade repository (TR) to the  report submitting entity and the reporting counterparty as well as the entity responsible for reporting, if applicable.")]
public partial record SecuritiesFinancingReportingTransactionReportV01 : IOuterRecord<SecuritiesFinancingReportingTransactionReportV01,SecuritiesFinancingReportingTransactionReportV01Document>
    ,IIsoXmlSerilizable<SecuritiesFinancingReportingTransactionReportV01>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.052.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesFincgRptgTxRpt";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => SecuritiesFinancingReportingTransactionReportV01Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Data concerning the reporting trade.
    /// </summary>
    [IsoId("_2zvMHwuAEeqVvtu9Ny8FDA")]
    [Description(@"Data concerning the reporting trade.")]
    [DataMember(Name="TradData")]
    [XmlElement(ElementName="TradData")]
    [Required]
    public required TradeData15Choice_ TradeData { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_2zvMIQuAEeqVvtu9Ny8FDA")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SecuritiesFinancingReportingTransactionReportV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesFinancingReportingTransactionReportV01Document ToDocument()
    {
        return new SecuritiesFinancingReportingTransactionReportV01Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("SctiesFincgRptgTxRpt");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "TradData", xmlNamespace );
        TradeData.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static SecuritiesFinancingReportingTransactionReportV01 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SecuritiesFinancingReportingTransactionReportV01"/>.
/// </summary>
[Serializable]
public partial record SecuritiesFinancingReportingTransactionReportV01Document : IOuterDocument<SecuritiesFinancingReportingTransactionReportV01>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.052.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SecuritiesFinancingReportingTransactionReportV01"/> is required.
    /// </summary>
    [DataMember(Name=SecuritiesFinancingReportingTransactionReportV01.XmlTag)]
    public required SecuritiesFinancingReportingTransactionReportV01 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(SecuritiesFinancingReportingTransactionReportV01.XmlTag);
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
