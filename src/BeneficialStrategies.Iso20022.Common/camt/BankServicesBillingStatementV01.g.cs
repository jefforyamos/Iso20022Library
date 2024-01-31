﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for BankServicesBillingStatementV01.  ISO2002 ID# _cVsZ9ZqmEeGSON8vddiWzQ_1763088977.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.camt;


/// <summary>
/// This record is an implementation of the camt.086.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The BankServicesBillingStatement message is used to send from a Financial Institution (FI) to its wholesale customers (corporations, governments, institutions, etc.), information describing the FI’s billing of services rendered in the form of an electronic statement in a standardised format. The BankServicesBillingStatement is a periodic (usually end of month) recounting of all service chargeable events that occurred during a reporting cycle, typically a calendar month, along with detailed tax and currency translation information. Account balance information, although strongly recommended, is not required.
/// Usage
/// The BankServicesBillingStatement message is designed to provide details related to invoices (or an advice of debit) which a financial institution may supply to its customers. The BankServicesBillingStatement is not expressly designed to be an invoice, nor to replace invoices currently in use. The message may be used as an invoice by agreement between the sender and the receiver. No regulatory or legislative requirements were considered when creating this message standard. Users of the BankServicesBillingStatment message are cautioned to be aware of any regulatory or legal requirement for invoices before replacing existing invoices.
/// The BankServicesBillingStatement message can supply the detail supporting separate invoices or debits but it is not the invoice or advice of debit of record. The BankServicesBillingStatement message must accurately reflect all the charge and tax related events that occurred during the calendar month and how the FI and taxing authorities were compensated for these events. The BSB does not ask the Financial Institution to revise its established pricing and billing procedures. 
/// How, when and what the customer is actually charged for remains in place. The BankServicesBillingStatement message asks the Financial Institution to aggregate and report what actually happened during the calendar month.
/// The BankServicesBillingStatement message is intended for use with the ISO 20022 Business Application Header.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The BankServicesBillingStatement message is used to send from a Financial Institution (FI) to its wholesale customers (corporations, governments, institutions, etc.), information describing the FI’s billing of services rendered in the form of an electronic statement in a standardised format. The BankServicesBillingStatement is a periodic (usually end of month) recounting of all service chargeable events that occurred during a reporting cycle, typically a calendar month, along with detailed tax and currency translation information. Account balance information, although strongly recommended, is not required.|Usage|The BankServicesBillingStatement message is designed to provide details related to invoices (or an advice of debit) which a financial institution may supply to its customers. The BankServicesBillingStatement is not expressly designed to be an invoice, nor to replace invoices currently in use. The message may be used as an invoice by agreement between the sender and the receiver. No regulatory or legislative requirements were considered when creating this message standard. Users of the BankServicesBillingStatment message are cautioned to be aware of any regulatory or legal requirement for invoices before replacing existing invoices.|The BankServicesBillingStatement message can supply the detail supporting separate invoices or debits but it is not the invoice or advice of debit of record. The BankServicesBillingStatement message must accurately reflect all the charge and tax related events that occurred during the calendar month and how the FI and taxing authorities were compensated for these events. The BSB does not ask the Financial Institution to revise its established pricing and billing procedures. |How, when and what the customer is actually charged for remains in place. The BankServicesBillingStatement message asks the Financial Institution to aggregate and report what actually happened during the calendar month.|The BankServicesBillingStatement message is intended for use with the ISO 20022 Business Application Header.")]
public partial record BankServicesBillingStatementV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.086.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "BkSvcsBllgStmt";
    
    #nullable enable
    /// <summary>
    /// Provides header details on the billing statement report.
    /// </summary>
    [IsoId("_cVsZ9pqmEeGSON8vddiWzQ_-2124285410")]
    [Description(@"Provides header details on the billing statement report.")]
    [DataMember(Name="RptHdr")]
    [XmlElement(ElementName="RptHdr")]
    [Required]
    public required ReportHeader3 ReportHeader { get; init; }
    
    /// <summary>
    /// Group of bank services billing statements with the same sender and receiver characteristics.
    /// </summary>
    [IsoId("_cVsZ95qmEeGSON8vddiWzQ_1850153158")]
    [Description(@"Group of bank services billing statements with the same sender and receiver characteristics.")]
    [DataMember(Name="BllgStmtGrp")]
    [XmlElement(ElementName="BllgStmtGrp")]
    [Required]
    public required StatementGroup1 BillingStatementGroup { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="BankServicesBillingStatementV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public BankServicesBillingStatementV01Document ToDocument()
    {
        return new BankServicesBillingStatementV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="BankServicesBillingStatementV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record BankServicesBillingStatementV01Document : IOuterDocument<BankServicesBillingStatementV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.086.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="BankServicesBillingStatementV01"/> is required.
    /// </summary>
    public required BankServicesBillingStatementV01 Message { get; init; }
}
