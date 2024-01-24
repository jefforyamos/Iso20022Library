﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for DerivativesTradeReportQueryV03.  ISO2002 ID# _pVWWkWmFEe2DRvVJM2Qy-g.
//
namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// The DerivativesTradeReportQuery message is sent by the supervisory authority system to the trade repositories, to query data based on the search criteria for the trade transaction as defined by the system user.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The DerivativesTradeReportQuery message is sent by the supervisory authority system to the trade repositories, to query data based on the search criteria for the trade transaction as defined by the system user.")]
public partial record DerivativesTradeReportQueryV03 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DerivsTradRptQry";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Indicates the authority that requests the query report.
    /// </summary>
    [IsoId("_pVWWk2mFEe2DRvVJM2Qy-g")]
    [Description(@"Indicates the authority that requests the query report.")]
    [DataMember(Name="RqstngAuthrty")]
    [XmlElement(ElementName="RqstngAuthrty")]
    [Required]
    public required SomeRequestingAuthorityRecord RequestingAuthority { get; init; }
    
    /// <summary>
    /// Criteria for defining recurrent and ad-hoc queries.
    /// </summary>
    [IsoId("_pVWWlWmFEe2DRvVJM2Qy-g")]
    [Description(@"Criteria for defining recurrent and ad-hoc queries.")]
    [DataMember(Name="TradQryData")]
    [XmlElement(ElementName="TradQryData")]
    [Required]
    public required SomeTradeQueryDataRecord TradeQueryData { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_pVWWl2mFEe2DRvVJM2Qy-g")]
    [Description(@"Additional information that cannot be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="DerivativesTradeReportQueryV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public DerivativesTradeReportQueryV03Document ToDocument()
    {
        return new DerivativesTradeReportQueryV03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="DerivativesTradeReportQueryV03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record DerivativesTradeReportQueryV03Document : IOuterDocument<DerivativesTradeReportQueryV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.029.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="DerivativesTradeReportQueryV03"/> is required.
    /// </summary>
    public required DerivativesTradeReportQueryV03 Message { get; init; }
}
