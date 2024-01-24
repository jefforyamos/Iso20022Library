﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for FinancialInvoiceV01.  ISO2002 ID# _BU_0In1LEeCF8NjrBemJWQ_-1866907401.
//
namespace BeneficialStrategies.Iso20022.tsin;

/// <summary>
/// Scope
/// The FinancialInvoice message is used to support the provision of financial and related services where there is a requirement to exchange invoice information.
/// Usage
/// While the prime function of the FinancialInvoice message is as a request from the seller to the buyer for payment, the FinancialInvoice message can also serve to evidence an invoice in support of a financial service such as invoice factoring, letters of credit, and bank payment obligations, to enable Web based services such as electronic bill payment and presentment, and as the basis to transfer invoice information via third parties such as e-invoicing service providers.
/// A consequence of the receipt of an invoice by the buyer is that it acts as a trigger for the use of related messages that are already defined in ISO 20022, notably where the information contained in the Financial Invoice enables payment for the goods or services received, and/or is provided in support of a request for invoice financing. While certain of these related messages, such as the CreditTransfer and PaymentInitiation messages, are shown in the sequence diagram they are out of scope. They are shown only to illustrate a given scenario and to place the invoice in the context of the financial banking processes that might be conducted between different financial institutions.
/// The use of self-billing by the buyer to the seller, where the buyer acts as the invoice issuer or the process of handling an incorrect invoice, is not in scope.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The FinancialInvoice message is used to support the provision of financial and related services where there is a requirement to exchange invoice information.|Usage|While the prime function of the FinancialInvoice message is as a request from the seller to the buyer for payment, the FinancialInvoice message can also serve to evidence an invoice in support of a financial service such as invoice factoring, letters of credit, and bank payment obligations, to enable Web based services such as electronic bill payment and presentment, and as the basis to transfer invoice information via third parties such as e-invoicing service providers.|A consequence of the receipt of an invoice by the buyer is that it acts as a trigger for the use of related messages that are already defined in ISO 20022, notably where the information contained in the Financial Invoice enables payment for the goods or services received, and/or is provided in support of a request for invoice financing. While certain of these related messages, such as the CreditTransfer and PaymentInitiation messages, are shown in the sequence diagram they are out of scope. They are shown only to illustrate a given scenario and to place the invoice in the context of the financial banking processes that might be conducted between different financial institutions.|The use of self-billing by the buyer to the seller, where the buyer acts as the invoice issuer or the process of handling an incorrect invoice, is not in scope.")]
public partial record FinancialInvoiceV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FinInvc";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="FinancialInvoiceV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public FinancialInvoiceV01Document ToDocument()
    {
        return new FinancialInvoiceV01Document { Message = this };
    }
}

/// <summary>
/// Scope
/// The FinancialInvoice message is used to support the provision of financial and related services where there is a requirement to exchange invoice information.
/// Usage
/// While the prime function of the FinancialInvoice message is as a request from the seller to the buyer for payment, the FinancialInvoice message can also serve to evidence an invoice in support of a financial service such as invoice factoring, letters of credit, and bank payment obligations, to enable Web based services such as electronic bill payment and presentment, and as the basis to transfer invoice information via third parties such as e-invoicing service providers.
/// A consequence of the receipt of an invoice by the buyer is that it acts as a trigger for the use of related messages that are already defined in ISO 20022, notably where the information contained in the Financial Invoice enables payment for the goods or services received, and/or is provided in support of a request for invoice financing. While certain of these related messages, such as the CreditTransfer and PaymentInitiation messages, are shown in the sequence diagram they are out of scope. They are shown only to illustrate a given scenario and to place the invoice in the context of the financial banking processes that might be conducted between different financial institutions.
/// The use of self-billing by the buyer to the seller, where the buyer acts as the invoice issuer or the process of handling an incorrect invoice, is not in scope.
/// This is the outer document that contains <seealso cref="FinancialInvoiceV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record FinancialInvoiceV01Document : IOuterDocument<FinancialInvoiceV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsin.004.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="FinancialInvoiceV01"/> is required.
    /// </summary>
    public required FinancialInvoiceV01 Message { get; init; }
}
