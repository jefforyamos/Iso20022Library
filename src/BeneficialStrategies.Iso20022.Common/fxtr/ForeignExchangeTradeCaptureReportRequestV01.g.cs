﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ForeignExchangeTradeCaptureReportRequestV01.  ISO2002 ID# _KgkR8oHHEeSY3ulMDfpmvA.
//
namespace BeneficialStrategies.Iso20022.fxtr;

/// <summary>
/// Scope
/// The ForeignExchangeTradeCaptureReportRequest message is sent by a trading member to the trading system for inquiry of trade capture report. 
/// Usage
/// The request is sent by the trading member to the trading system to inquire trade capture report. 
/// Note a capture request could be rejected.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The ForeignExchangeTradeCaptureReportRequest message is sent by a trading member to the trading system for inquiry of trade capture report. |Usage|The request is sent by the trading member to the trading system to inquire trade capture report. |Note a capture request could be rejected.")]
public partial record ForeignExchangeTradeCaptureReportRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FXTradCaptrRptReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ForeignExchangeTradeCaptureReportRequestV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ForeignExchangeTradeCaptureReportRequestV01Document ToDocument()
    {
        return new ForeignExchangeTradeCaptureReportRequestV01Document { Message = this };
    }
}

/// <summary>
/// Scope
/// The ForeignExchangeTradeCaptureReportRequest message is sent by a trading member to the trading system for inquiry of trade capture report. 
/// Usage
/// The request is sent by the trading member to the trading system to inquire trade capture report. 
/// Note a capture request could be rejected.
/// This is the outer document that contains <seealso cref="ForeignExchangeTradeCaptureReportRequestV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ForeignExchangeTradeCaptureReportRequestV01Document : IOuterDocument<ForeignExchangeTradeCaptureReportRequestV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:fxtr.032.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ForeignExchangeTradeCaptureReportRequestV01"/> is required.
    /// </summary>
    public required ForeignExchangeTradeCaptureReportRequestV01 Message { get; init; }
}
