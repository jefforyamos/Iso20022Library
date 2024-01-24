﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for InvoiceTaxReportV01.  ISO2002 ID# _B5eQoFmrEeOQYsoJizpkVw.
//
namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// The InvoiceTaxReport message is sent by tax responsible to tax authority. Tax authorities require corporates to report their sales based value added tax (VAT). This message is targeted to this reporting based on information in sales invoices and card transactions.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The InvoiceTaxReport message is sent by tax responsible to tax authority. Tax authorities require corporates to report their sales based value added tax (VAT). This message is targeted to this reporting based on information in sales invoices and card transactions.")]
public partial record InvoiceTaxReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "InvcTaxRpt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Defines message level identification, number of individual tax reports and tax authority.
    /// </summary>
    [IsoId("_riLtAGn0Eea5EcY2TpG1mw")]
    [Description(@"Defines message level identification, number of individual tax reports and tax authority.")]
    [DataMember(Name="InvcTaxRptHdr")]
    [XmlElement(ElementName="InvcTaxRptHdr")]
    [Required]
    public required SomeInvoiceTaxReportHeaderRecord InvoiceTaxReportHeader { get; init; }
    
    /// <summary>
    /// Contains all needed party details for tax agency (sender of the TaxReport) and tax authority (receiver of the TaxReport) and the details of the reported sales transaction and calculated tax related that specific business transaction.
    /// </summary>
    [IsoId("_DiX4YFm8EeOQYsoJizpkVw")]
    [Description(@"Contains all needed party details for tax agency (sender of the TaxReport) and tax authority (receiver of the TaxReport) and the details of the reported sales transaction and calculated tax related that specific business transaction.")]
    [DataMember(Name="TaxRpt")]
    [XmlElement(ElementName="TaxRpt")]
    [Required]
    public required SomeTaxReportRecord TaxReport { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_YqO7oEjvEeaOe8w0NJ11wQ")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="InvoiceTaxReportV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public InvoiceTaxReportV01Document ToDocument()
    {
        return new InvoiceTaxReportV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="InvoiceTaxReportV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record InvoiceTaxReportV01Document : IOuterDocument<InvoiceTaxReportV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.034.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="InvoiceTaxReportV01"/> is required.
    /// </summary>
    public required InvoiceTaxReportV01 Message { get; init; }
}
