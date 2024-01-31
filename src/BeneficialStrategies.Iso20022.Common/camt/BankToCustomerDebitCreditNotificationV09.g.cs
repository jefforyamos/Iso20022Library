﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for BankToCustomerDebitCreditNotificationV09.  ISO2002 ID# _7wsWodb-Eeq_l4BJLVUF2Q.
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
/// This record is an implementation of the camt.054.001.09 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope|The BankToCustomerDebitCreditNotification message is sent by the account servicer to an account owner or to a party authorised by the account owner to receive the message. It can be used to inform the account owner, or authorised party, of single or multiple debit and/or credit entries reported to the account.|Usage|The BankToCustomerDebitCreditNotification message can contain reports for more than one account. It provides information for cash management and/or reconciliation.|The BankToCustomerDebitCreditNotification message can be used to: |- report pending and booked items;|- notify one or more debit entries;|- notify one or more credit entries;|- notify a combination of debit and credit entries.|It can include underlying details of transactions that have been included in the entry.|It is possible that the receiver of the message is not the account owner, but a party entitled by the account owner to receive the account information (also known as recipient).|It does not contain balance information.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The BankToCustomerDebitCreditNotification message is sent by the account servicer to an account owner or to a party authorised by the account owner to receive the message. It can be used to inform the account owner, or authorised party, of single or multiple debit and/or credit entries reported to the account.|Usage|The BankToCustomerDebitCreditNotification message can contain reports for more than one account. It provides information for cash management and/or reconciliation.|The BankToCustomerDebitCreditNotification message can be used to: |- report pending and booked items;|- notify one or more debit entries;|- notify one or more credit entries;|- notify a combination of debit and credit entries.|It can include underlying details of transactions that have been included in the entry.|It is possible that the receiver of the message is not the account owner, but a party entitled by the account owner to receive the account information (also known as recipient).|It does not contain balance information.")]
public partial record BankToCustomerDebitCreditNotificationV09 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.054.001.09";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "BkToCstmrDbtCdtNtfctn";
    
    #nullable enable
    /// <summary>
    /// Common information for the message.
    /// </summary>
    [IsoId("_7wsWrdb-Eeq_l4BJLVUF2Q")]
    [Description(@"Common information for the message.")]
    [DataMember(Name="GrpHdr")]
    [XmlElement(ElementName="GrpHdr")]
    [Required]
    public required GroupHeader81 GroupHeader { get; init; }
    
    /// <summary>
    /// Notifies debit and credit entries for the account.
    /// </summary>
    [IsoId("_7wsWr9b-Eeq_l4BJLVUF2Q")]
    [Description(@"Notifies debit and credit entries for the account.")]
    [DataMember(Name="Ntfctn")]
    [XmlElement(ElementName="Ntfctn")]
    [Required]
    public required AccountNotification19 Notification { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_7wsWsdb-Eeq_l4BJLVUF2Q")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="BankToCustomerDebitCreditNotificationV09Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public BankToCustomerDebitCreditNotificationV09Document ToDocument()
    {
        return new BankToCustomerDebitCreditNotificationV09Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="BankToCustomerDebitCreditNotificationV09"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record BankToCustomerDebitCreditNotificationV09Document : IOuterDocument<BankToCustomerDebitCreditNotificationV09>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.054.001.09";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="BankToCustomerDebitCreditNotificationV09"/> is required.
    /// </summary>
    public required BankToCustomerDebitCreditNotificationV09 Message { get; init; }
}
