﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for BankToCustomerDebitCreditNotificationV02.  ISO2002 ID# _JG4lINE-Ed-BzquC8wXy7w_1022273973.
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
/// This record is an implementation of the camt.054.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The BankToCustomerDebitCreditNotification message is sent by the account servicer to an account owner or to a party authorised by the account owner to receive the message. It can be used to inform the account owner, or authorised party, of single or multiple debit and/or credit entries reported to the account.
/// Usage
/// The BankToCustomerDebitCreditNotification message can contain reports for more than one account. It provides information for cash management and/or reconciliation.
/// It can be used to:
/// - report pending and booked items;
/// - notify one or more debit entries;
/// - notify one or more credit entries;
/// - notify a combination of debit and credit entries.
/// It can include underlying details of transactions that have been included in the entry.
/// It is possible that the receiver of the message is not the account owner, but a party entitled by the account owner to receive the account information (also known as recipient).
/// It does not contain balance information.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The BankToCustomerDebitCreditNotification message is sent by the account servicer to an account owner or to a party authorised by the account owner to receive the message. It can be used to inform the account owner, or authorised party, of single or multiple debit and/or credit entries reported to the account.|Usage|The BankToCustomerDebitCreditNotification message can contain reports for more than one account. It provides information for cash management and/or reconciliation.|It can be used to:|- report pending and booked items;|- notify one or more debit entries;|- notify one or more credit entries;|- notify a combination of debit and credit entries.|It can include underlying details of transactions that have been included in the entry.|It is possible that the receiver of the message is not the account owner, but a party entitled by the account owner to receive the account information (also known as recipient).|It does not contain balance information.")]
public partial record BankToCustomerDebitCreditNotificationV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.054.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "BkToCstmrDbtCdtNtfctn";
    
    #nullable enable
    /// <summary>
    /// Common information for the message.
    /// </summary>
    [IsoId("_JG4lIdE-Ed-BzquC8wXy7w_1022274066")]
    [Description(@"Common information for the message.")]
    [DataMember(Name="GrpHdr")]
    [XmlElement(ElementName="GrpHdr")]
    [Required]
    public required GroupHeader42 GroupHeader { get; init; }
    
    /// <summary>
    /// Notifies debit and credit entries for the account.
    /// </summary>
    [IsoId("_JG4lItE-Ed-BzquC8wXy7w_1022274014")]
    [Description(@"Notifies debit and credit entries for the account.")]
    [DataMember(Name="Ntfctn")]
    [XmlElement(ElementName="Ntfctn")]
    [Required]
    public required AccountNotification2 Notification { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="BankToCustomerDebitCreditNotificationV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public BankToCustomerDebitCreditNotificationV02Document ToDocument()
    {
        return new BankToCustomerDebitCreditNotificationV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="BankToCustomerDebitCreditNotificationV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record BankToCustomerDebitCreditNotificationV02Document : IOuterDocument<BankToCustomerDebitCreditNotificationV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.054.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="BankToCustomerDebitCreditNotificationV02"/> is required.
    /// </summary>
    public required BankToCustomerDebitCreditNotificationV02 Message { get; init; }
}
