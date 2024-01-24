﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AccountReportingRequestV06.  ISO2002 ID# _7wrvkdb-Eeq_l4BJLVUF2Q.
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
public partial record AccountReportingRequestV06 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctRptgReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Set of elements used to provide further details on the message.
    /// </summary>
    [IsoId("_7wrvl9b-Eeq_l4BJLVUF2Q")]
    [Description(@"Set of elements used to provide further details on the message.")]
    [DataMember(Name="GrpHdr")]
    [XmlElement(ElementName="GrpHdr")]
    [Required]
    public required SomeGroupHeaderRecord GroupHeader { get; init; }
    
    /// <summary>
    /// Set of elements used to provide further details on the reporting request.
    /// </summary>
    [IsoId("_7wrvmdb-Eeq_l4BJLVUF2Q")]
    [Description(@"Set of elements used to provide further details on the reporting request.")]
    [DataMember(Name="RptgReq")]
    [XmlElement(ElementName="RptgReq")]
    [Required]
    public required SomeReportingRequestRecord ReportingRequest { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_7wrvm9b-Eeq_l4BJLVUF2Q")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AccountReportingRequestV06Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AccountReportingRequestV06Document ToDocument()
    {
        return new AccountReportingRequestV06Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AccountReportingRequestV06"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AccountReportingRequestV06Document : IOuterDocument<AccountReportingRequestV06>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.060.001.06";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AccountReportingRequestV06"/> is required.
    /// </summary>
    public required AccountReportingRequestV06 Message { get; init; }
}
