﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for BankServicesBillingStatementV02.  ISO2002 ID# _sHrTETqxEeWZFYSPlduMhw.
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
public partial record BankServicesBillingStatementV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "BkSvcsBllgStmt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="BankServicesBillingStatementV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public BankServicesBillingStatementV02Document ToDocument()
    {
        return new BankServicesBillingStatementV02Document { Message = this };
    }
}

/// <summary>
/// Scope
/// The BankServicesBillingStatement message is used to send from a Financial Institution (FI) to its wholesale customers (corporations, governments, institutions, etc.), information describing the FI’s billing of services rendered in the form of an electronic statement in a standardised format. The BankServicesBillingStatement is a periodic (usually end of month) recounting of all service chargeable events that occurred during a reporting cycle, typically a calendar month, along with detailed tax and currency translation information. Account balance information, although strongly recommended, is not required.
/// Usage
/// The BankServicesBillingStatement message is designed to provide details related to invoices (or an advice of debit) which a financial institution may supply to its customers. The BankServicesBillingStatement is not expressly designed to be an invoice, nor to replace invoices currently in use. The message may be used as an invoice by agreement between the sender and the receiver. No regulatory or legislative requirements were considered when creating this message standard. Users of the BankServicesBillingStatement message are cautioned to be aware of any regulatory or legal requirement for invoices before replacing existing invoices.
/// The BankServicesBillingStatement message can supply the detail supporting separate invoices or debits but it is not the invoice or advice of debit of record. The BankServicesBillingStatement message must accurately reflect all the charge and tax related events that occurred during the calendar month and how the FI and taxing authorities were compensated for these events. The BankServicesBillingStatement does not ask the financial institution to revise its established pricing and billing procedures. 
/// How, when and what the customer is actually charged for remains in place. The BankServicesBillingStatement message asks the financial institution to aggregate and report what actually happened during the calendar month.
/// The BankServicesBillingStatement message is intended for use with the ISO 20022 Business Application Header.
/// This is the outer document that contains <seealso cref="BankServicesBillingStatementV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record BankServicesBillingStatementV02Document : IOuterDocument<BankServicesBillingStatementV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.086.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="BankServicesBillingStatementV02"/> is required.
    /// </summary>
    public required BankServicesBillingStatementV02 Message { get; init; }
}
