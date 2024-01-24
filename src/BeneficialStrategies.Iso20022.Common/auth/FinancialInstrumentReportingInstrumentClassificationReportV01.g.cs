﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for FinancialInstrumentReportingInstrumentClassificationReportV01.  ISO2002 ID# _4LK8VURNEee7JdgA9zPESA.
//
namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// The FinancialInstrumentReportingInstrumentClassificationReport message is sent by ESMA to all national competent authorities and provides all valid combinations for classification of financial instruments (CFI) as per ISO 10962.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The FinancialInstrumentReportingInstrumentClassificationReport message is sent by ESMA to all national competent authorities and provides all valid combinations for classification of financial instruments (CFI) as per ISO 10962.")]
public partial record FinancialInstrumentReportingInstrumentClassificationReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FinInstrmRptgInstrmClssfctnRpt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="FinancialInstrumentReportingInstrumentClassificationReportV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public FinancialInstrumentReportingInstrumentClassificationReportV01Document ToDocument()
    {
        return new FinancialInstrumentReportingInstrumentClassificationReportV01Document { Message = this };
    }
}

/// <summary>
/// The FinancialInstrumentReportingInstrumentClassificationReport message is sent by ESMA to all national competent authorities and provides all valid combinations for classification of financial instruments (CFI) as per ISO 10962.
/// This is the outer document that contains <seealso cref="FinancialInstrumentReportingInstrumentClassificationReportV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record FinancialInstrumentReportingInstrumentClassificationReportV01Document : IOuterDocument<FinancialInstrumentReportingInstrumentClassificationReportV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.050.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="FinancialInstrumentReportingInstrumentClassificationReportV01"/> is required.
    /// </summary>
    public required FinancialInstrumentReportingInstrumentClassificationReportV01 Message { get; init; }
}
