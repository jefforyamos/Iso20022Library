﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for BankServicesBillingStatementV04.  ISO2002 ID# _u4dOAdcAEeq_l4BJLVUF2Q.
//
namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// Scope
/// The BankServicesBillingStatement message is used to send from a Financial Institution (FI) to its wholesale customers (corporations, governments, institutions, etc.), information describing the FI’s billing of services rendered in the form of an electronic statement in a standardised format. The BankServicesBillingStatement is a periodic (usually end of month) recounting of all service chargeable events that occurred during a reporting cycle, typically a calendar month, along with detailed tax and currency translation information. Account balance information, although strongly recommended, is not required.
/// Usage
/// The BankServicesBillingStatement message is designed to provide details related to invoices (or an advice of debit) which a financial institution may supply to its customers. The BankServicesBillingStatement is not expressly designed to be an invoice, nor to replace invoices currently in use. The message may be used as an invoice by agreement between the sender and the receiver. No regulatory or legislative requirements were considered when creating this message standard. Users of the BankServicesBillingStatement message are cautioned to be aware of any regulatory or legal requirement for invoices before replacing existing invoices.
/// The BankServicesBillingStatement message can supply the detail supporting separate invoices or debits but it is not the invoice or advice of debit of record. The BankServicesBillingStatement message must accurately reflect all the charge and tax related events that occurred during the calendar month and how the FI and taxing authorities were compensated for these events. The BankServicesBillingStatement does not ask the financial institution to revise its established pricing and billing procedures. 
/// How, when and what the customer is actually charged for remains in place. The BankServicesBillingStatement message asks the financial institution to aggregate and report what actually happened during the calendar month.
/// The BankServicesBillingStatement message is intended for use with the ISO 20022 Business Application Header.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The BankServicesBillingStatement message is used to send from a Financial Institution (FI) to its wholesale customers (corporations, governments, institutions, etc.), information describing the FI’s billing of services rendered in the form of an electronic statement in a standardised format. The BankServicesBillingStatement is a periodic (usually end of month) recounting of all service chargeable events that occurred during a reporting cycle, typically a calendar month, along with detailed tax and currency translation information. Account balance information, although strongly recommended, is not required.|Usage|The BankServicesBillingStatement message is designed to provide details related to invoices (or an advice of debit) which a financial institution may supply to its customers. The BankServicesBillingStatement is not expressly designed to be an invoice, nor to replace invoices currently in use. The message may be used as an invoice by agreement between the sender and the receiver. No regulatory or legislative requirements were considered when creating this message standard. Users of the BankServicesBillingStatement message are cautioned to be aware of any regulatory or legal requirement for invoices before replacing existing invoices.|The BankServicesBillingStatement message can supply the detail supporting separate invoices or debits but it is not the invoice or advice of debit of record. The BankServicesBillingStatement message must accurately reflect all the charge and tax related events that occurred during the calendar month and how the FI and taxing authorities were compensated for these events. The BankServicesBillingStatement does not ask the financial institution to revise its established pricing and billing procedures. |How, when and what the customer is actually charged for remains in place. The BankServicesBillingStatement message asks the financial institution to aggregate and report what actually happened during the calendar month.|The BankServicesBillingStatement message is intended for use with the ISO 20022 Business Application Header.")]
public partial record BankServicesBillingStatementV04 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "BkSvcsBllgStmt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Provides header details on the billing statement report.
    /// </summary>
    [IsoId("_u4dOB9cAEeq_l4BJLVUF2Q")]
    [Description(@"Provides header details on the billing statement report.")]
    [DataMember(Name="RptHdr")]
    [XmlElement(ElementName="RptHdr")]
    [Required]
    public required ReportHeader6 ReportHeader { get; init; }
    
    /// <summary>
    /// Group of bank services billing statements with the same sender and receiver characteristics.
    /// </summary>
    [IsoId("_u4dOCdcAEeq_l4BJLVUF2Q")]
    [Description(@"Group of bank services billing statements with the same sender and receiver characteristics.")]
    [DataMember(Name="BllgStmtGrp")]
    [XmlElement(ElementName="BllgStmtGrp")]
    [Required]
    public required StatementGroup4 BillingStatementGroup { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="BankServicesBillingStatementV04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public BankServicesBillingStatementV04Document ToDocument()
    {
        return new BankServicesBillingStatementV04Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="BankServicesBillingStatementV04"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record BankServicesBillingStatementV04Document : IOuterDocument<BankServicesBillingStatementV04>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.086.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="BankServicesBillingStatementV04"/> is required.
    /// </summary>
    public required BankServicesBillingStatementV04 Message { get; init; }
}
