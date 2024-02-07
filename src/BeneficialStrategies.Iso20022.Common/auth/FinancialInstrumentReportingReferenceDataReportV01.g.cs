﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for FinancialInstrumentReportingReferenceDataReportV01.  ISO2002 ID# _4LUGOURNEee7JdgA9zPESA.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.auth.FinancialInstrumentReportingReferenceDataReportV01>;

namespace BeneficialStrategies.Iso20022.auth;


/// <summary>
/// This record is an implementation of the auth.017.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// This FinancialInstrumentReportingReferenceDataReport message is sent by the trading venue to the national competent authority to report on the reference data used in the securities transactions.
/// </summary>
[Serializable]
[Description(@"This FinancialInstrumentReportingReferenceDataReport message is sent by the trading venue to the national competent authority to report on the reference data used in the securities transactions.")]
public partial record FinancialInstrumentReportingReferenceDataReportV01 : IOuterRecord<FinancialInstrumentReportingReferenceDataReportV01,FinancialInstrumentReportingReferenceDataReportV01Document>
    ,IIsoXmlSerilizable<FinancialInstrumentReportingReferenceDataReportV01>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.017.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FinInstrmRptgRefDataRpt";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => FinancialInstrumentReportingReferenceDataReportV01Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Header information related to the global report.
    /// </summary>
    [IsoId("_4LUGO0RNEee7JdgA9zPESA")]
    [Description(@"Header information related to the global report.")]
    [DataMember(Name="RptHdr")]
    [XmlElement(ElementName="RptHdr")]
    [Required]
    public required SecuritiesMarketReportHeader1 ReportHeader { get; init; }
    
    /// <summary>
    /// Details of the reference data reported by the trading venue.
    /// </summary>
    [IsoId("_4LUGPURNEee7JdgA9zPESA")]
    [Description(@"Details of the reference data reported by the trading venue.")]
    [DataMember(Name="RefData")]
    [XmlElement(ElementName="RefData")]
    [Required]
    public required SecuritiesReferenceDataReport5 ReferenceData { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_4LUGP0RNEee7JdgA9zPESA")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="FinancialInstrumentReportingReferenceDataReportV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public FinancialInstrumentReportingReferenceDataReportV01Document ToDocument()
    {
        return new FinancialInstrumentReportingReferenceDataReportV01Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("FinInstrmRptgRefDataRpt");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "RptHdr", xmlNamespace );
        ReportHeader.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "RefData", xmlNamespace );
        ReferenceData.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static FinancialInstrumentReportingReferenceDataReportV01 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="FinancialInstrumentReportingReferenceDataReportV01"/>.
/// </summary>
[Serializable]
public partial record FinancialInstrumentReportingReferenceDataReportV01Document : IOuterDocument<FinancialInstrumentReportingReferenceDataReportV01>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.017.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="FinancialInstrumentReportingReferenceDataReportV01"/> is required.
    /// </summary>
    [DataMember(Name=FinancialInstrumentReportingReferenceDataReportV01.XmlTag)]
    public required FinancialInstrumentReportingReferenceDataReportV01 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(FinancialInstrumentReportingReferenceDataReportV01.XmlTag);
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
