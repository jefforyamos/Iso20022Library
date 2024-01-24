﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for BankToCustomerStatementV01.  ISO2002 ID# _JlInYNE-Ed-BzquC8wXy7w_1694338972.
//
namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// Scope
/// The Bank-to-Customer Statement message is sent by the account servicer to an account owner or to a party authorised by the account owner to receive the message. It is used to inform the account owner, or authorised party, of the entries booked to the account, and to provide the owner with balance information on the account at a given point in time.
/// Usage
/// The Bank-to-Customer Statement message can contain reports for more than 1 account. It provides information for cash management and/or reconciliation.
/// It contains information on booked entries only.
/// It can include underlying details of transactions that have been included in the entry.
/// The message is exchanged as defined between the account servicer and the account owner. It provides information on items that have been booked to the account (and therefore are "binding" and also balance information. Depending on services agreed between banks and their customers, "binding" statements can be generated and exchanged intraday. Depending on legal requirements in local jurisdictions, "end-of-day" statements may need to be mandatorily generated and exchanged.
/// It is possible that the receiver of the message is not the account owner, but a party entitled through arrangement with the account owner to receive the account information (also known as recipient).
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The Bank-to-Customer Statement message is sent by the account servicer to an account owner or to a party authorised by the account owner to receive the message. It is used to inform the account owner, or authorised party, of the entries booked to the account, and to provide the owner with balance information on the account at a given point in time.|Usage|The Bank-to-Customer Statement message can contain reports for more than 1 account. It provides information for cash management and/or reconciliation.|It contains information on booked entries only.|It can include underlying details of transactions that have been included in the entry.|The message is exchanged as defined between the account servicer and the account owner. It provides information on items that have been booked to the account (and therefore are ""binding"" and also balance information. Depending on services agreed between banks and their customers, ""binding"" statements can be generated and exchanged intraday. Depending on legal requirements in local jurisdictions, ""end-of-day"" statements may need to be mandatorily generated and exchanged.|It is possible that the receiver of the message is not the account owner, but a party entitled through arrangement with the account owner to receive the account information (also known as recipient).")]
public partial record BankToCustomerStatementV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "BkToCstmrStmtV01";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="BankToCustomerStatementV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public BankToCustomerStatementV01Document ToDocument()
    {
        return new BankToCustomerStatementV01Document { Message = this };
    }
}

/// <summary>
/// Scope
/// The Bank-to-Customer Statement message is sent by the account servicer to an account owner or to a party authorised by the account owner to receive the message. It is used to inform the account owner, or authorised party, of the entries booked to the account, and to provide the owner with balance information on the account at a given point in time.
/// Usage
/// The Bank-to-Customer Statement message can contain reports for more than 1 account. It provides information for cash management and/or reconciliation.
/// It contains information on booked entries only.
/// It can include underlying details of transactions that have been included in the entry.
/// The message is exchanged as defined between the account servicer and the account owner. It provides information on items that have been booked to the account (and therefore are "binding" and also balance information. Depending on services agreed between banks and their customers, "binding" statements can be generated and exchanged intraday. Depending on legal requirements in local jurisdictions, "end-of-day" statements may need to be mandatorily generated and exchanged.
/// It is possible that the receiver of the message is not the account owner, but a party entitled through arrangement with the account owner to receive the account information (also known as recipient).
/// This is the outer document that contains <seealso cref="BankToCustomerStatementV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record BankToCustomerStatementV01Document : IOuterDocument<BankToCustomerStatementV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="BankToCustomerStatementV01"/> is required.
    /// </summary>
    public required BankToCustomerStatementV01 Message { get; init; }
}
