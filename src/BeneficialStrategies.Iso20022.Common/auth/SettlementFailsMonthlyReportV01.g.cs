﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SettlementFailsMonthlyReportV01.  ISO2002 ID# _pq7TuUEXEeqXB_DgAcRqgw.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.auth.SettlementFailsMonthlyReportV01>;

namespace BeneficialStrategies.Iso20022.auth;


/// <summary>
/// This record is an implementation of the auth.100.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The SettlementFailsMonthlyReport is sent by central securities depository or by a central bank operating a securities settlement system to the CSD competent authority in its jurisdiction, to provide monthly and daily aggregated data on the number and the nature of settlement instructions which failed to settle on their intended settlement day. The report contains monthly and daily statistical information on the number and value of overall settlement instructions, settled instructions, and settlement fails that occurred during a specified period and within a given securities settlement system.
/// </summary>
[Serializable]
[Description(@"The SettlementFailsMonthlyReport is sent by central securities depository or by a central bank operating a securities settlement system to the CSD competent authority in its jurisdiction, to provide monthly and daily aggregated data on the number and the nature of settlement instructions which failed to settle on their intended settlement day. The report contains monthly and daily statistical information on the number and value of overall settlement instructions, settled instructions, and settlement fails that occurred during a specified period and within a given securities settlement system.")]
public partial record SettlementFailsMonthlyReportV01 : IOuterRecord<SettlementFailsMonthlyReportV01,SettlementFailsMonthlyReportV01Document>
    ,IIsoXmlSerilizable<SettlementFailsMonthlyReportV01>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.100.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SttlmFlsMnthlyRpt";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => SettlementFailsMonthlyReportV01Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Specifies parameters of the report.
    /// </summary>
    [IsoId("_pq7Tu0EXEeqXB_DgAcRqgw")]
    [Description(@"Specifies parameters of the report.")]
    [DataMember(Name="RptHdr")]
    [XmlElement(ElementName="RptHdr")]
    [Required]
    public required SettlementFailsReportHeader2 ReportHeader { get; init; }
    
    /// <summary>
    /// Aggregated monthly volume and value of settled, failed, total of failed settlement instructions performed during the period covered by the report, for financial instruments, types of transactions, types of clients and cash transfers.
    /// </summary>
    [IsoId("_pq7TvUEXEeqXB_DgAcRqgw")]
    [Description(@"Aggregated monthly volume and value of settled, failed, total of failed settlement instructions performed during the period covered by the report, for financial instruments, types of transactions, types of clients and cash transfers.")]
    [DataMember(Name="MnthlyAggt")]
    [XmlElement(ElementName="MnthlyAggt")]
    [Required]
    public required SettlementFailsData3 MonthlyAggregate { get; init; }
    
    /// <summary>
    /// Daily data volume and value of settled, failed, total of failed settlement instructions performed during the period covered by the report, for financial instruments, types of transactions, types of clients and cash transfers.
    /// </summary>
    [IsoId("_pq7Tv0EXEeqXB_DgAcRqgw")]
    [Description(@"Daily data volume and value of settled, failed, total of failed settlement instructions performed during the period covered by the report, for financial instruments, types of transactions, types of clients and cash transfers.")]
    [DataMember(Name="DalyData")]
    [XmlElement(ElementName="DalyData")]
    [Required]
    public required SettlementFailsDailyData3 DailyData { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_pq7TwUEXEeqXB_DgAcRqgw")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SettlementFailsMonthlyReportV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SettlementFailsMonthlyReportV01Document ToDocument()
    {
        return new SettlementFailsMonthlyReportV01Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("SttlmFlsMnthlyRpt");
    
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
        writer.WriteStartElement(null, "MnthlyAggt", xmlNamespace );
        MonthlyAggregate.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "DalyData", xmlNamespace );
        DailyData.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static SettlementFailsMonthlyReportV01 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SettlementFailsMonthlyReportV01"/>.
/// </summary>
[Serializable]
public partial record SettlementFailsMonthlyReportV01Document : IOuterDocument<SettlementFailsMonthlyReportV01>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.100.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SettlementFailsMonthlyReportV01"/> is required.
    /// </summary>
    [DataMember(Name=SettlementFailsMonthlyReportV01.XmlTag)]
    public required SettlementFailsMonthlyReportV01 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(SettlementFailsMonthlyReportV01.XmlTag);
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
