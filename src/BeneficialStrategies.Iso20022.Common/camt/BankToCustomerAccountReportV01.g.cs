﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for BankToCustomerAccountReportV01.  ISO2002 ID# _HpTM0tE-Ed-BzquC8wXy7w_1604757380.
//
namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// Scope
/// The Bank-to-Customer Account Report message is sent by the account servicer to an account owner or to a party authorised by the account owner to receive the message. It can be used to inform the account owner, or authorised party, of the entries reported to the account, and/or to provide the owner with balance information on the account at a given point in time.
/// Usage
/// The Bank-to-Customer Account Report message can contain reports for more than 1 account. It provides information for cash management and/or reconciliation. It can be used to:
/// - report pending and booked items;
/// - provide balance information
/// It can include underlying details of transactions that have been included in the entry.
/// It is possible that the receiver of the message is not the account owner, but a party entitled by the account owner to receive the account information (also known as recipient).
/// For a statement that is required due to local legal stipulations, the Bank-to-Customer Account Statement message should be used.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The Bank-to-Customer Account Report message is sent by the account servicer to an account owner or to a party authorised by the account owner to receive the message. It can be used to inform the account owner, or authorised party, of the entries reported to the account, and/or to provide the owner with balance information on the account at a given point in time.|Usage|The Bank-to-Customer Account Report message can contain reports for more than 1 account. It provides information for cash management and/or reconciliation. It can be used to:|- report pending and booked items;|- provide balance information|It can include underlying details of transactions that have been included in the entry.|It is possible that the receiver of the message is not the account owner, but a party entitled by the account owner to receive the account information (also known as recipient).|For a statement that is required due to local legal stipulations, the Bank-to-Customer Account Statement message should be used.")]
public partial record BankToCustomerAccountReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "BkToCstmrAcctRptV01";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Common information for the message.
    /// </summary>
    [IsoId("_HpTM09E-Ed-BzquC8wXy7w_-825021148")]
    [Description(@"Common information for the message.")]
    [DataMember(Name="GrpHdr")]
    [XmlElement(ElementName="GrpHdr")]
    [Required]
    public required SomeGroupHeaderRecord GroupHeader { get; init; }
    
    /// <summary>
    /// Reports on a cash account.
    /// </summary>
    [IsoId("_HpTM1NE-Ed-BzquC8wXy7w_-1335280264")]
    [Description(@"Reports on a cash account.")]
    [DataMember(Name="Rpt")]
    [XmlElement(ElementName="Rpt")]
    [Required]
    public required SomeReportRecord Report { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="BankToCustomerAccountReportV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public BankToCustomerAccountReportV01Document ToDocument()
    {
        return new BankToCustomerAccountReportV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="BankToCustomerAccountReportV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record BankToCustomerAccountReportV01Document : IOuterDocument<BankToCustomerAccountReportV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="BankToCustomerAccountReportV01"/> is required.
    /// </summary>
    public required BankToCustomerAccountReportV01 Message { get; init; }
}
