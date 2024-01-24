﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AccountReportingRequestV05.  ISO2002 ID# _eYI_k22PEei3KuUgpx7Xcw.
//
namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// Scope
/// The AccountReportingRequest message is sent by the account owner, either directly or through a forwarding agent, to one of its account servicing institutions. It is used to ask the account servicing institution to send a report on the account owner's account in a BankToCustomerAccountReport (camt.052), a BankToCustomerStatement (camt.053) or a BankToCustomerDebitCreditNotification (camt.054).
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The AccountReportingRequest message is sent by the account owner, either directly or through a forwarding agent, to one of its account servicing institutions. It is used to ask the account servicing institution to send a report on the account owner's account in a BankToCustomerAccountReport (camt.052), a BankToCustomerStatement (camt.053) or a BankToCustomerDebitCreditNotification (camt.054).")]
public partial record AccountReportingRequestV05 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctRptgReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AccountReportingRequestV05Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AccountReportingRequestV05Document ToDocument()
    {
        return new AccountReportingRequestV05Document { Message = this };
    }
}

/// <summary>
/// Scope
/// The AccountReportingRequest message is sent by the account owner, either directly or through a forwarding agent, to one of its account servicing institutions. It is used to ask the account servicing institution to send a report on the account owner's account in a BankToCustomerAccountReport (camt.052), a BankToCustomerStatement (camt.053) or a BankToCustomerDebitCreditNotification (camt.054).
/// This is the outer document that contains <seealso cref="AccountReportingRequestV05"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AccountReportingRequestV05Document : IOuterDocument<AccountReportingRequestV05>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.060.001.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AccountReportingRequestV05"/> is required.
    /// </summary>
    public required AccountReportingRequestV05 Message { get; init; }
}
