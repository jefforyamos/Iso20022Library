﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CollateralAndExposureReportV03.  ISO2002 ID# _XAW1sYFrEeWtPe6Crjmeug.
//
namespace BeneficialStrategies.Iso20022.colr;

/// <summary>
/// Scope
/// The CollateralAndExposureReport message is sent:
/// - either by the collateral giver, or its collateral manager, to the collateral taker, or its collateral manager, or
/// - or by the collateral taker, or its collateral manager to the collateral giver, or its collateral manager
/// The message definition is intended for use with the ISO20022 Business Application Header.
/// Usage
/// The CollateralAndExposureReport is used to provide the details of the valuation of the collateral, that is, the valuation of securities collateral, cash collateral or other type of collateral, posted at a specific calculation date.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The CollateralAndExposureReport message is sent:|- either by the collateral giver, or its collateral manager, to the collateral taker, or its collateral manager, or|- or by the collateral taker, or its collateral manager to the collateral giver, or its collateral manager||The message definition is intended for use with the ISO20022 Business Application Header.||Usage|The CollateralAndExposureReport is used to provide the details of the valuation of the collateral, that is, the valuation of securities collateral, cash collateral or other type of collateral, posted at a specific calculation date.")]
public partial record CollateralAndExposureReportV03 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CollAndXpsrRpt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Provides information about the report such as the report identification, the report date and time or the report frequency.
    /// </summary>
    [IsoId("_XAW1s4FrEeWtPe6Crjmeug")]
    [Description(@"Provides information about the report such as the report identification, the report date and time or the report frequency.")]
    [DataMember(Name="RptParams")]
    [XmlElement(ElementName="RptParams")]
    [Required]
    public required ReportParameters5 ReportParameters { get; init; }
    
    /// <summary>
    /// Specifies the page number and an indicator of whether it is the only or last page, or if there are additional pages. 
    /// </summary>
    [IsoId("_XAW1tYFrEeWtPe6Crjmeug")]
    [Description(@"Specifies the page number and an indicator of whether it is the only or last page, or if there are additional pages. |")]
    [DataMember(Name="Pgntn")]
    [XmlElement(ElementName="Pgntn")]
    public Pagination? Pagination { get; init; }
    
    /// <summary>
    /// Provides information like the identification of the party or parties associated with the collateral agreement, the exposure type and the valuation date.
    /// </summary>
    [IsoId("_XAW1t4FrEeWtPe6Crjmeug")]
    [Description(@"Provides information like the identification of the party or parties associated with the collateral agreement, the exposure type and the valuation date.")]
    [DataMember(Name="Oblgtn")]
    [XmlElement(ElementName="Oblgtn")]
    [Required]
    public required Obligation4 Obligation { get; init; }
    
    /// <summary>
    /// Agreement details for the over the counter market.
    /// </summary>
    [IsoId("_XAW1uYFrEeWtPe6Crjmeug")]
    [Description(@"Agreement details for the over the counter market.")]
    [DataMember(Name="Agrmt")]
    [XmlElement(ElementName="Agrmt")]
    public Agreement4? Agreement { get; init; }
    
    /// <summary>
    /// Provides details on the collateral report.
    /// </summary>
    [IsoId("_XAW1u4FrEeWtPe6Crjmeug")]
    [Description(@"Provides details on the collateral report.")]
    [DataMember(Name="CollRpt")]
    [XmlElement(ElementName="CollRpt")]
    [Required]
    public required Collateral13 CollateralReport { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_XAW1vYFrEeWtPe6Crjmeug")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CollateralAndExposureReportV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CollateralAndExposureReportV03Document ToDocument()
    {
        return new CollateralAndExposureReportV03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CollateralAndExposureReportV03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record CollateralAndExposureReportV03Document : IOuterDocument<CollateralAndExposureReportV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:colr.016.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CollateralAndExposureReportV03"/> is required.
    /// </summary>
    public required CollateralAndExposureReportV03 Message { get; init; }
}
