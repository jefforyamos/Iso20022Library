﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for FinancialInstrumentReportingMarketIdentificationCodeReportV01.  ISO2002 ID# _4LK8ZURNEee7JdgA9zPESA.
//
namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// The FinancialInstrumentReportingMarket IdentificationCodeReport provides the valid market identification code (MIC) of venues that are valid and registered to operate as a trading venue. This message is generated by ESMA for distribution to national competent authorities.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The FinancialInstrumentReportingMarket IdentificationCodeReport provides the valid market identification code (MIC) of venues that are valid and registered to operate as a trading venue. This message is generated by ESMA for distribution to national competent authorities.")]
public partial record FinancialInstrumentReportingMarketIdentificationCodeReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FinInstrmRptgMktIdCdRpt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="FinancialInstrumentReportingMarketIdentificationCodeReportV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public FinancialInstrumentReportingMarketIdentificationCodeReportV01Document ToDocument()
    {
        return new FinancialInstrumentReportingMarketIdentificationCodeReportV01Document { Message = this };
    }
}

/// <summary>
/// The FinancialInstrumentReportingMarket IdentificationCodeReport provides the valid market identification code (MIC) of venues that are valid and registered to operate as a trading venue. This message is generated by ESMA for distribution to national competent authorities.
/// This is the outer document that contains <seealso cref="FinancialInstrumentReportingMarketIdentificationCodeReportV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record FinancialInstrumentReportingMarketIdentificationCodeReportV01Document : IOuterDocument<FinancialInstrumentReportingMarketIdentificationCodeReportV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.049.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="FinancialInstrumentReportingMarketIdentificationCodeReportV01"/> is required.
    /// </summary>
    public required FinancialInstrumentReportingMarketIdentificationCodeReportV01 Message { get; init; }
}
