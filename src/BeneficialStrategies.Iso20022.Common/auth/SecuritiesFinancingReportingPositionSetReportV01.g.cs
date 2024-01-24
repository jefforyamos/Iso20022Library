﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesFinancingReportingPositionSetReportV01.  ISO2002 ID# _YpHNwcKvEeuzU9S_IANlog.
//
namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// The SecuritiesFinancingReportingPositionSetReport message is sent by the trade repositories to the supervisory authority system, to report aggregated exposures between a pair of counterparties (except reuse report).
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The SecuritiesFinancingReportingPositionSetReport message is sent by the trade repositories to the supervisory authority system, to report aggregated exposures between a pair of counterparties (except reuse report).")]
public partial record SecuritiesFinancingReportingPositionSetReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesFincgRptgPosSetRpt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SecuritiesFinancingReportingPositionSetReportV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesFinancingReportingPositionSetReportV01Document ToDocument()
    {
        return new SecuritiesFinancingReportingPositionSetReportV01Document { Message = this };
    }
}

/// <summary>
/// The SecuritiesFinancingReportingPositionSetReport message is sent by the trade repositories to the supervisory authority system, to report aggregated exposures between a pair of counterparties (except reuse report).
/// This is the outer document that contains <seealso cref="SecuritiesFinancingReportingPositionSetReportV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SecuritiesFinancingReportingPositionSetReportV01Document : IOuterDocument<SecuritiesFinancingReportingPositionSetReportV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.105.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SecuritiesFinancingReportingPositionSetReportV01"/> is required.
    /// </summary>
    public required SecuritiesFinancingReportingPositionSetReportV01 Message { get; init; }
}
