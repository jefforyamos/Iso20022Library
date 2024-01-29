﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SettlementFailsAnnualReportV01.  ISO2002 ID# _pq7TsUEXEeqXB_DgAcRqgw.
//
namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// The SettlementFailsAnnualReport is sent by a central securities depository or by a central bank operating a securities settlement system to the CSD competent authority to provide annual aggregated data on the number and the nature of settlement instructions which failed to settle on their intended settlement day. The report contains annual statistical information on the number and value of overall settlement instructions, settled instructions, and settlement fails that occurred during a specified period and within a given securities settlement system.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The SettlementFailsAnnualReport is sent by a central securities depository or by a central bank operating a securities settlement system to the CSD competent authority to provide annual aggregated data on the number and the nature of settlement instructions which failed to settle on their intended settlement day. The report contains annual statistical information on the number and value of overall settlement instructions, settled instructions, and settlement fails that occurred during a specified period and within a given securities settlement system.")]
public partial record SettlementFailsAnnualReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SttlmFlsAnlRpt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Specifies parameters of the report.
    /// </summary>
    [IsoId("_pq7Ts0EXEeqXB_DgAcRqgw")]
    [Description(@"Specifies parameters of the report.")]
    [DataMember(Name="RptHdr")]
    [XmlElement(ElementName="RptHdr")]
    [Required]
    public required SomeReportHeaderRecord ReportHeader { get; init; }
    
    /// <summary>
    /// Aggregated annual volume and value of settled, failed, total of failed settlement instructions performed during the period covered by the report, for financial instruments, types of transactions, types of clients and cash transfers.
    /// </summary>
    [IsoId("_pq7TtUEXEeqXB_DgAcRqgw")]
    [Description(@"Aggregated annual volume and value of settled, failed, total of failed settlement instructions performed during the period covered by the report, for financial instruments, types of transactions, types of clients and cash transfers.")]
    [DataMember(Name="AnlAggt")]
    [XmlElement(ElementName="AnlAggt")]
    [Required]
    public required SomeAnnualAggregateRecord AnnualAggregate { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_pq7Tt0EXEeqXB_DgAcRqgw")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SettlementFailsAnnualReportV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SettlementFailsAnnualReportV01Document ToDocument()
    {
        return new SettlementFailsAnnualReportV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SettlementFailsAnnualReportV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SettlementFailsAnnualReportV01Document : IOuterDocument<SettlementFailsAnnualReportV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.101.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SettlementFailsAnnualReportV01"/> is required.
    /// </summary>
    public required SettlementFailsAnnualReportV01 Message { get; init; }
}