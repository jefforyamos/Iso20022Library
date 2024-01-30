﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CollateralAndExposureReportV05.  ISO2002 ID# _J4Yk9ygrEeyB747fKu7_rw.
//
namespace BeneficialStrategies.Iso20022.colr;

/// <summary>
/// Scope
/// The CollateralAndExposureReport message is sent by:
/// - the collateral giver, or its collateral manager, to the collateral taker, or its collateral manager, 
/// - the collateral taker, or its collateral manager to the collateral giver, or its collateral manager
/// The message definition is intended for use with the ISO20022 Business Application Header.
/// Usage
/// The CollateralAndExposureReport message is used to provide the details of the valuation of the collateral, that is, the valuation of securities collateral, cash collateral or other type of collateral, posted at a specific calculation date.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The CollateralAndExposureReport message is sent by:|- the collateral giver, or its collateral manager, to the collateral taker, or its collateral manager, |- the collateral taker, or its collateral manager to the collateral giver, or its collateral manager|The message definition is intended for use with the ISO20022 Business Application Header.|Usage|The CollateralAndExposureReport message is used to provide the details of the valuation of the collateral, that is, the valuation of securities collateral, cash collateral or other type of collateral, posted at a specific calculation date.")]
public partial record CollateralAndExposureReportV05 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CollAndXpsrRpt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Provides information about the report such as the report identification, the report date and time or the report frequency.
    /// </summary>
    [IsoId("_J4YlAygrEeyB747fKu7_rw")]
    [Description(@"Provides information about the report such as the report identification, the report date and time or the report frequency.")]
    [DataMember(Name="RptParams")]
    [XmlElement(ElementName="RptParams")]
    [Required]
    public required ReportParameters6 ReportParameters { get; init; }
    
    /// <summary>
    /// Specifies the page number and an indicator of whether it is the only or last page, or if there are additional pages. 
    /// </summary>
    [IsoId("_J4YlBSgrEeyB747fKu7_rw")]
    [Description(@"Specifies the page number and an indicator of whether it is the only or last page, or if there are additional pages. |")]
    [DataMember(Name="Pgntn")]
    [XmlElement(ElementName="Pgntn")]
    public Pagination1? Pagination { get; init; }
    
    /// <summary>
    /// Provides information like the identification of the party or parties associated with the collateral agreement, the exposure type and the valuation date.
    /// </summary>
    [IsoId("_J4YlBygrEeyB747fKu7_rw")]
    [Description(@"Provides information like the identification of the party or parties associated with the collateral agreement, the exposure type and the valuation date.")]
    [DataMember(Name="Oblgtn")]
    [XmlElement(ElementName="Oblgtn")]
    [Required]
    public required Obligation11 Obligation { get; init; }
    
    /// <summary>
    /// Agreement details for the over the counter market.
    /// </summary>
    [IsoId("_J4YlCSgrEeyB747fKu7_rw")]
    [Description(@"Agreement details for the over the counter market.")]
    [DataMember(Name="Agrmt")]
    [XmlElement(ElementName="Agrmt")]
    public Agreement4? Agreement { get; init; }
    
    /// <summary>
    /// Details of the collateral.
    /// </summary>
    [IsoId("_J4YlCygrEeyB747fKu7_rw")]
    [Description(@"Details of the collateral.")]
    [DataMember(Name="CollRpt")]
    [XmlElement(ElementName="CollRpt")]
    [Required]
    public required Collateral53 CollateralReport { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_J4YlDSgrEeyB747fKu7_rw")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CollateralAndExposureReportV05Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CollateralAndExposureReportV05Document ToDocument()
    {
        return new CollateralAndExposureReportV05Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CollateralAndExposureReportV05"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record CollateralAndExposureReportV05Document : IOuterDocument<CollateralAndExposureReportV05>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:colr.016.001.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CollateralAndExposureReportV05"/> is required.
    /// </summary>
    public required CollateralAndExposureReportV05 Message { get; init; }
}
