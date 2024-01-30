﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for DerivativesTradeReportQueryV01.  ISO2002 ID# _wdKwQxWsEeqvRcdYcNYAVw.
//
namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// The DerivativesTradeReportQuery message is sent by the supervisory authority system to the trade repositories, to query data based on the search criteria for the trade transaction as defined by the system user.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The DerivativesTradeReportQuery message is sent by the supervisory authority system to the trade repositories, to query data based on the search criteria for the trade transaction as defined by the system user.")]
public partial record DerivativesTradeReportQueryV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DerivsTradRptQry";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Indicates the authority that requests the query report.
    /// </summary>
    [IsoId("_wdKwRRWsEeqvRcdYcNYAVw")]
    [Description(@"Indicates the authority that requests the query report.")]
    [DataMember(Name="RqstngAuthrty")]
    [XmlElement(ElementName="RqstngAuthrty")]
    [Required]
    public required IPartyIdentification121Choice RequestingAuthority { get; init; }
    
    /// <summary>
    /// Criteria for defining recurrent and ad-hoc queries.
    /// </summary>
    [IsoId("_wdKwRxWsEeqvRcdYcNYAVw")]
    [Description(@"Criteria for defining recurrent and ad-hoc queries.")]
    [DataMember(Name="TradQryData")]
    [XmlElement(ElementName="TradQryData")]
    [Required]
    public required ITradeReportQuery4Choice TradeQueryData { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_wdKwSRWsEeqvRcdYcNYAVw")]
    [Description(@"Additional information that cannot be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="DerivativesTradeReportQueryV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public DerivativesTradeReportQueryV01Document ToDocument()
    {
        return new DerivativesTradeReportQueryV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="DerivativesTradeReportQueryV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record DerivativesTradeReportQueryV01Document : IOuterDocument<DerivativesTradeReportQueryV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.029.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="DerivativesTradeReportQueryV01"/> is required.
    /// </summary>
    public required DerivativesTradeReportQueryV01 Message { get; init; }
}
