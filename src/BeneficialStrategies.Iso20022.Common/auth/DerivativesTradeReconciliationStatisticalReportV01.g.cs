﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for DerivativesTradeReconciliationStatisticalReportV01.  ISO2002 ID# _wdKwNxWsEeqvRcdYcNYAVw.
//
namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// The DerivativesTradeReportReconciliationStatisticalReport message is sent by the trade repositories to the supervisory authority system, to report cumulative information within the reference period for the reconciliation status of the reported and outstanding derivatives.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The DerivativesTradeReportReconciliationStatisticalReport message is sent by the trade repositories to the supervisory authority system, to report cumulative information within the reference period for the reconciliation status of the reported and outstanding derivatives.")]
public partial record DerivativesTradeReconciliationStatisticalReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DerivsTradRcncltnSttstclRpt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Detailed information on statistics per combination of counterparties.
    /// </summary>
    [IsoId("_wdKwORWsEeqvRcdYcNYAVw")]
    [Description(@"Detailed information on statistics per combination of counterparties.")]
    [DataMember(Name="SttstcsPerCtrPty")]
    [XmlElement(ElementName="SttstcsPerCtrPty")]
    [Required]
    public required SomeStatisticsPerCounterpartyRecord StatisticsPerCounterparty { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_wdKwOxWsEeqvRcdYcNYAVw")]
    [Description(@"Additional information that cannot be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="DerivativesTradeReconciliationStatisticalReportV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public DerivativesTradeReconciliationStatisticalReportV01Document ToDocument()
    {
        return new DerivativesTradeReconciliationStatisticalReportV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="DerivativesTradeReconciliationStatisticalReportV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record DerivativesTradeReconciliationStatisticalReportV01Document : IOuterDocument<DerivativesTradeReconciliationStatisticalReportV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.091.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="DerivativesTradeReconciliationStatisticalReportV01"/> is required.
    /// </summary>
    public required DerivativesTradeReconciliationStatisticalReportV01 Message { get; init; }
}