﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for FinancialInstrumentReportingReferenceDataReportV02.  ISO2002 ID# _JRfSUSX6EeigZbhgJcrASA.
//
namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// This FinancialInstrumentReportingReferenceDataReport message is sent by the trading venue to the national competent authority to report on the reference data used in the securities transactions.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"This FinancialInstrumentReportingReferenceDataReport message is sent by the trading venue to the national competent authority to report on the reference data used in the securities transactions.")]
public partial record FinancialInstrumentReportingReferenceDataReportV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FinInstrmRptgRefDataRpt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="FinancialInstrumentReportingReferenceDataReportV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public FinancialInstrumentReportingReferenceDataReportV02Document ToDocument()
    {
        return new FinancialInstrumentReportingReferenceDataReportV02Document { Message = this };
    }
}

/// <summary>
/// This FinancialInstrumentReportingReferenceDataReport message is sent by the trading venue to the national competent authority to report on the reference data used in the securities transactions.
/// This is the outer document that contains <seealso cref="FinancialInstrumentReportingReferenceDataReportV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record FinancialInstrumentReportingReferenceDataReportV02Document : IOuterDocument<FinancialInstrumentReportingReferenceDataReportV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.017.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="FinancialInstrumentReportingReferenceDataReportV02"/> is required.
    /// </summary>
    public required FinancialInstrumentReportingReferenceDataReportV02 Message { get; init; }
}
