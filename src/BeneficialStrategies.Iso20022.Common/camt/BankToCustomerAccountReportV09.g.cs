﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for BankToCustomerAccountReportV09.  ISO2002 ID# _7wrvndb-Eeq_l4BJLVUF2Q.
//
namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// Scope
/// The BankToCustomerAccountReport message is sent by the account servicer to an account owner or to a party authorised by the account owner to receive the message. It can be used to inform the account owner, or authorised party, of the entries reported to the account, and/or to provide the owner with balance information on the account at a given point in time.
/// Usage
/// The BankToCustomerAccountReport message can contain reports for more than one account. It provides information for cash management and/or reconciliation. It can be used to:
/// - report pending and booked items;
/// - provide balance information.
/// It can include underlying details of transactions that have been included in the entry.
/// It is possible that the receiver of the message is not the account owner, but a party entitled by the account owner to receive the account information (also known as recipient).
/// For a statement, the Bank-to-Customer Account Statement message should be used.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The BankToCustomerAccountReport message is sent by the account servicer to an account owner or to a party authorised by the account owner to receive the message. It can be used to inform the account owner, or authorised party, of the entries reported to the account, and/or to provide the owner with balance information on the account at a given point in time.|Usage|The BankToCustomerAccountReport message can contain reports for more than one account. It provides information for cash management and/or reconciliation. It can be used to:|- report pending and booked items;|- provide balance information.|It can include underlying details of transactions that have been included in the entry.|It is possible that the receiver of the message is not the account owner, but a party entitled by the account owner to receive the account information (also known as recipient).|For a statement, the Bank-to-Customer Account Statement message should be used.")]
public partial record BankToCustomerAccountReportV09 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "BkToCstmrAcctRpt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Common information for the message.
    /// </summary>
    [IsoId("_7wrvqdb-Eeq_l4BJLVUF2Q")]
    [Description(@"Common information for the message.")]
    [DataMember(Name="GrpHdr")]
    [XmlElement(ElementName="GrpHdr")]
    [Required]
    public required GroupHeader81 GroupHeader { get; init; }
    
    /// <summary>
    /// Reports on a cash account.
    /// </summary>
    [IsoId("_7wrvq9b-Eeq_l4BJLVUF2Q")]
    [Description(@"Reports on a cash account.")]
    [DataMember(Name="Rpt")]
    [XmlElement(ElementName="Rpt")]
    [Required]
    public required AccountReport30 Report { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_7wrvrdb-Eeq_l4BJLVUF2Q")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="BankToCustomerAccountReportV09Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public BankToCustomerAccountReportV09Document ToDocument()
    {
        return new BankToCustomerAccountReportV09Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="BankToCustomerAccountReportV09"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record BankToCustomerAccountReportV09Document : IOuterDocument<BankToCustomerAccountReportV09>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.09";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="BankToCustomerAccountReportV09"/> is required.
    /// </summary>
    public required BankToCustomerAccountReportV09 Message { get; init; }
}
