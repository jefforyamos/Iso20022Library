﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for IntraBalanceMovementPostingReportV01.  ISO2002 ID# _DLtLMzncEem7JZMuWtwtsg.
//
namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// This IntraBalanceMovementPostingReport message is sent from a settlement infrastructure to an account owner/requestor to report the intra-balance movement instructions, previously sent by the account owner, that have a settled status.
/// The message may also be used to: 
/// -	- re-send a message sent by the account owner to the account servicer (the sub-function of the message is "Duplicate") 
/// -	- provide a third party with a copy of a message being sent by the account owner for information (the sub-function of the message is "Copy") 
/// -	- re-send to a third party a copy of a message being sent by the account owner for information (the sub-function of the message is "Copy Duplicate").
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"This IntraBalanceMovementPostingReport message is sent from a settlement infrastructure to an account owner/requestor to report the intra-balance movement instructions, previously sent by the account owner, that have a settled status.||The message may also be used to: |-	- re-send a message sent by the account owner to the account servicer (the sub-function of the message is ""Duplicate"") |-	- provide a third party with a copy of a message being sent by the account owner for information (the sub-function of the message is ""Copy"") |-	- re-send to a third party a copy of a message being sent by the account owner for information (the sub-function of the message is ""Copy Duplicate"").|")]
public partial record IntraBalanceMovementPostingReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "IntraBalMvmntPstngRpt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Unambiguous identification of the message as known by the account servicer or settlement infrastructure.
    /// </summary>
    [IsoId("_DLtLPzncEem7JZMuWtwtsg")]
    [Description(@"Unambiguous identification of the message as known by the account servicer or settlement infrastructure.")]
    [DataMember(Name="Id")]
    [XmlElement(ElementName="Id")]
    public SomeIdentificationRecord? Identification { get; init; }
    
    /// <summary>
    /// Pagination of the message.
    /// </summary>
    [IsoId("_DLtLQTncEem7JZMuWtwtsg")]
    [Description(@"Pagination of the message.")]
    [DataMember(Name="Pgntn")]
    [XmlElement(ElementName="Pgntn")]
    [Required]
    public required SomePaginationRecord Pagination { get; init; }
    
    /// <summary>
    /// General characteristics related to the report information.
    /// </summary>
    [IsoId("_DLtLQzncEem7JZMuWtwtsg")]
    [Description(@"General characteristics related to the report information.")]
    [DataMember(Name="RptGnlDtls")]
    [XmlElement(ElementName="RptGnlDtls")]
    [Required]
    public required SomeReportGeneralDetailsRecord ReportGeneralDetails { get; init; }
    
    /// <summary>
    /// Account to or from which a cash entry is made.
    /// </summary>
    [IsoId("_DLtLRzncEem7JZMuWtwtsg")]
    [Description(@"Account to or from which a cash entry is made.")]
    [DataMember(Name="CshAcct")]
    [XmlElement(ElementName="CshAcct")]
    [Required]
    public required SomeCashAccountRecord CashAccount { get; init; }
    
    /// <summary>
    /// Party that owns the account.
    /// </summary>
    [IsoId("_DLtLRTncEem7JZMuWtwtsg")]
    [Description(@"Party that owns the account.")]
    [DataMember(Name="CshAcctOwnr")]
    [XmlElement(ElementName="CshAcctOwnr")]
    public SomeCashAccountOwnerRecord? CashAccountOwner { get; init; }
    
    /// <summary>
    /// Party that manages the cash account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_xVL3sTp-EemwKdP955WBJQ")]
    [Description(@"Party that manages the cash account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.")]
    [DataMember(Name="CshAcctSvcr")]
    [XmlElement(ElementName="CshAcctSvcr")]
    public SomeCashAccountServicerRecord? CashAccountServicer { get; init; }
    
    /// <summary>
    /// Identifies the transactions.
    /// </summary>
    [IsoId("_DLtLSTncEem7JZMuWtwtsg")]
    [Description(@"Identifies the transactions.")]
    [DataMember(Name="SubBal")]
    [XmlElement(ElementName="SubBal")]
    public SomeSubBalanceRecord? SubBalance { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="IntraBalanceMovementPostingReportV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public IntraBalanceMovementPostingReportV01Document ToDocument()
    {
        return new IntraBalanceMovementPostingReportV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="IntraBalanceMovementPostingReportV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record IntraBalanceMovementPostingReportV01Document : IOuterDocument<IntraBalanceMovementPostingReportV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.084.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="IntraBalanceMovementPostingReportV01"/> is required.
    /// </summary>
    public required IntraBalanceMovementPostingReportV01 Message { get; init; }
}
