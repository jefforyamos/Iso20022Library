﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for MoneyMarketUnsecuredMarketStatisticalReportV01.  ISO2002 ID# _zmNG4aieEeWHO_l3hf2rlA.
//
namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// The MoneyMarketUnsecuredMarketStatisticalReport message is sent by the reporting agents to the relevant competent authority, to report all relevant unsecured money market transactions.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The MoneyMarketUnsecuredMarketStatisticalReport message is sent by the reporting agents to the relevant competent authority, to report all relevant unsecured money market transactions.")]
public partial record MoneyMarketUnsecuredMarketStatisticalReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MnyMktUscrdMktSttstclRpt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Provides the elements specific to the report.
    /// </summary>
    [IsoId("_zmNG46ieEeWHO_l3hf2rlA")]
    [Description(@"Provides the elements specific to the report.")]
    [DataMember(Name="RptHdr")]
    [XmlElement(ElementName="RptHdr")]
    [Required]
    public required SomeReportHeaderRecord ReportHeader { get; init; }
    
    /// <summary>
    /// Provides the reason why no activity is reported or the required list of transactions for the unsecured market segment.
    /// </summary>
    [IsoId("_zmNG5aieEeWHO_l3hf2rlA")]
    [Description(@"Provides the reason why no activity is reported or the required list of transactions for the unsecured market segment.")]
    [DataMember(Name="UscrdMktRpt")]
    [XmlElement(ElementName="UscrdMktRpt")]
    [Required]
    public required SomeUnsecuredMarketReportRecord UnsecuredMarketReport { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_zmNG56ieEeWHO_l3hf2rlA")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="MoneyMarketUnsecuredMarketStatisticalReportV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public MoneyMarketUnsecuredMarketStatisticalReportV01Document ToDocument()
    {
        return new MoneyMarketUnsecuredMarketStatisticalReportV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="MoneyMarketUnsecuredMarketStatisticalReportV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record MoneyMarketUnsecuredMarketStatisticalReportV01Document : IOuterDocument<MoneyMarketUnsecuredMarketStatisticalReportV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.013.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="MoneyMarketUnsecuredMarketStatisticalReportV01"/> is required.
    /// </summary>
    public required MoneyMarketUnsecuredMarketStatisticalReportV01 Message { get; init; }
}
