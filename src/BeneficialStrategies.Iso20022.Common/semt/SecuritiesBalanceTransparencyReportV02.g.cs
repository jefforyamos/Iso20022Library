﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesBalanceTransparencyReportV02.  ISO2002 ID# _LMa20VTQEeatgN-VQ0eFlQ.
//
namespace BeneficialStrategies.Iso20022.semt;

/// <summary>
/// Scope
/// The SecuritiesBalanceTransparencyReport message is sent by an account servicer, such as a custodian, central securities depository or international central securities depository, to the account owner to provide holdings information for the accounts that it services, to disclose underlying details of holdings on an omnibus account that the sender owns or operates at the receiver. The receiver may also be a custodian, central securities depository, international central securities depository, and the ultimate receiver may be a registrar, transfer agent, fund company, official agent of the reported instrument(s) and/or other parties.
/// The SecuritiesBalanceTransparencyReport message provides transparency of holdings through layers of custody chains in a consolidated statement, to allow for an efficient gathering of investor data, which, in turn, may be used to measure marketing effectiveness, validation of compliance with prospectuses and regulatory requirements, and the calculation of trailer fees and other retrocessions.
/// Usage
/// The SecuritiesBalanceTransparencyReport message is used to provide aggregated holdings information and a breakdown of holdings information.
/// A sender of the SecuritiesBalanceTransparencyReport message will identify its own safekeeping account (for example, an omnibus account in the ledger of the receiver) and holdings information at the level of account(s) for which the sender is the account servicer (that is, in the ledger of the sender). When relevant, the sender will aggregate its holdings information with holdings information of one or more sub levels and sub-sub levels of accounts, that is, with holdings information the sender has received from the owner(s) of the account(s) for which the sender is the account servicer.
/// A sender of the SecuritiesBalanceTransparencyReport message may also use it to send statements to its account owning customers, and these can be enrichments of statements that the respective account owners have previously provided to the sender.
/// Ultimately, the statement reaches the relevant fund company, for example, the transfer agent, that may use it for obtaining information about the custodians, distributors and commercial agreement references associated with holdings on an omnibus account at the ultimate place of safekeeping, for example, a central securities depository (CSD) or a register of shareholders.
/// When the message is sent by the owner of the account specified in SafekeepingAccountAndHoldings/AccountIdentification, the message will disclose holding details of the underlying owner(s) of the sender’s holdings with the receiver. This direction is commonly referred to as ‘downstream’. 
/// When the sender is the account servicer of an account owned by the receiver, for example, the account in AccountSubLevel1/AccountIdentification or AccountSubLevel2/AccountIdentification, the message is providing a statement of the receiver’s holdings with sender. This direction is commonly referred to as ‘upstream’, and the safekeeping account should identify the ultimate place of safekeeping (for example, an account in a transfer agent's register of shareholders).
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The SecuritiesBalanceTransparencyReport message is sent by an account servicer, such as a custodian, central securities depository or international central securities depository, to the account owner to provide holdings information for the accounts that it services, to disclose underlying details of holdings on an omnibus account that the sender owns or operates at the receiver. The receiver may also be a custodian, central securities depository, international central securities depository, and the ultimate receiver may be a registrar, transfer agent, fund company, official agent of the reported instrument(s) and/or other parties.|The SecuritiesBalanceTransparencyReport message provides transparency of holdings through layers of custody chains in a consolidated statement, to allow for an efficient gathering of investor data, which, in turn, may be used to measure marketing effectiveness, validation of compliance with prospectuses and regulatory requirements, and the calculation of trailer fees and other retrocessions.|Usage|The SecuritiesBalanceTransparencyReport message is used to provide aggregated holdings information and a breakdown of holdings information.|A sender of the SecuritiesBalanceTransparencyReport message will identify its own safekeeping account (for example, an omnibus account in the ledger of the receiver) and holdings information at the level of account(s) for which the sender is the account servicer (that is, in the ledger of the sender). When relevant, the sender will aggregate its holdings information with holdings information of one or more sub levels and sub-sub levels of accounts, that is, with holdings information the sender has received from the owner(s) of the account(s) for which the sender is the account servicer.|A sender of the SecuritiesBalanceTransparencyReport message may also use it to send statements to its account owning customers, and these can be enrichments of statements that the respective account owners have previously provided to the sender.|Ultimately, the statement reaches the relevant fund company, for example, the transfer agent, that may use it for obtaining information about the custodians, distributors and commercial agreement references associated with holdings on an omnibus account at the ultimate place of safekeeping, for example, a central securities depository (CSD) or a register of shareholders.|When the message is sent by the owner of the account specified in SafekeepingAccountAndHoldings/AccountIdentification, the message will disclose holding details of the underlying owner(s) of the sender’s holdings with the receiver. This direction is commonly referred to as ‘downstream’. |When the sender is the account servicer of an account owned by the receiver, for example, the account in AccountSubLevel1/AccountIdentification or AccountSubLevel2/AccountIdentification, the message is providing a statement of the receiver’s holdings with sender. This direction is commonly referred to as ‘upstream’, and the safekeeping account should identify the ultimate place of safekeeping (for example, an account in a transfer agent's register of shareholders).")]
public partial record SecuritiesBalanceTransparencyReportV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesBalTrnsprncyRpt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Unique and unambiguous identification of the message. When the report has multiple pages, one message equals one page. Therefore, the MessageIdentification uniquely identifies the page.
    /// </summary>
    [IsoId("_LMa201TQEeatgN-VQ0eFlQ")]
    [Description(@"Unique and unambiguous identification of the message. When the report has multiple pages, one message equals one page. Therefore, the MessageIdentification uniquely identifies the page.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required MessageIdentification1 MessageIdentification { get; init; }
    
    /// <summary>
    /// Identification of the party that is the sender of the message.
    /// </summary>
    [IsoId("_LMa21VTQEeatgN-VQ0eFlQ")]
    [Description(@"Identification of the party that is the sender of the message.")]
    [DataMember(Name="SndrId")]
    [XmlElement(ElementName="SndrId")]
    [Required]
    public required PartyIdentification100 SenderIdentification { get; init; }
    
    /// <summary>
    /// Identification of the party that is the receiver of the message.
    /// </summary>
    [IsoId("_LMa211TQEeatgN-VQ0eFlQ")]
    [Description(@"Identification of the party that is the receiver of the message.")]
    [DataMember(Name="RcvrId")]
    [XmlElement(ElementName="RcvrId")]
    public PartyIdentification100? ReceiverIdentification { get; init; }
    
    /// <summary>
    /// Page number of the message (within a statement) and continuation indicator to indicate that the statement is to continue or that the message is the last page of the statement.
    /// </summary>
    [IsoId("_LMa22VTQEeatgN-VQ0eFlQ")]
    [Description(@"Page number of the message (within a statement) and continuation indicator to indicate that the statement is to continue or that the message is the last page of the statement.")]
    [DataMember(Name="Pgntn")]
    [XmlElement(ElementName="Pgntn")]
    [Required]
    public required Pagination Pagination { get; init; }
    
    /// <summary>
    /// Provides general information on the statement.
    /// </summary>
    [IsoId("_LMa221TQEeatgN-VQ0eFlQ")]
    [Description(@"Provides general information on the statement.")]
    [DataMember(Name="StmtGnlDtls")]
    [XmlElement(ElementName="StmtGnlDtls")]
    [Required]
    public required Statement59 StatementGeneralDetails { get; init; }
    
    /// <summary>
    /// Details of the account, account sub-levels and the holdings.
    /// </summary>
    [IsoId("_LMa23VTQEeatgN-VQ0eFlQ")]
    [Description(@"Details of the account, account sub-levels and the holdings.")]
    [DataMember(Name="SfkpgAcctAndHldgs")]
    [XmlElement(ElementName="SfkpgAcctAndHldgs")]
    public SafekeepingAccount7? SafekeepingAccountAndHoldings { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_LMa231TQEeatgN-VQ0eFlQ")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SecuritiesBalanceTransparencyReportV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesBalanceTransparencyReportV02Document ToDocument()
    {
        return new SecuritiesBalanceTransparencyReportV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SecuritiesBalanceTransparencyReportV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SecuritiesBalanceTransparencyReportV02Document : IOuterDocument<SecuritiesBalanceTransparencyReportV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:semt.041.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SecuritiesBalanceTransparencyReportV02"/> is required.
    /// </summary>
    public required SecuritiesBalanceTransparencyReportV02 Message { get; init; }
}
