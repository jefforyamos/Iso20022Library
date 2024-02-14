﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for BankToCustomerDebitCreditNotificationV09.  ISO2002 ID# _7wsWodb-Eeq_l4BJLVUF2Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif


namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// This record is an implementation of the camt.054.001.09 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope|The BankToCustomerDebitCreditNotification message is sent by the account servicer to an account owner or to a party authorised by the account owner to receive the message. It can be used to inform the account owner, or authorised party, of single or multiple debit and/or credit entries reported to the account.|Usage|The BankToCustomerDebitCreditNotification message can contain reports for more than one account. It provides information for cash management and/or reconciliation.|The BankToCustomerDebitCreditNotification message can be used to: |- report pending and booked items;|- notify one or more debit entries;|- notify one or more credit entries;|- notify a combination of debit and credit entries.|It can include underlying details of transactions that have been included in the entry.|It is possible that the receiver of the message is not the account owner, but a party entitled by the account owner to receive the account information (also known as recipient).|It does not contain balance information.
/// </summary>
[Description(@"Scope|The BankToCustomerDebitCreditNotification message is sent by the account servicer to an account owner or to a party authorised by the account owner to receive the message. It can be used to inform the account owner, or authorised party, of single or multiple debit and/or credit entries reported to the account.|Usage|The BankToCustomerDebitCreditNotification message can contain reports for more than one account. It provides information for cash management and/or reconciliation.|The BankToCustomerDebitCreditNotification message can be used to: |- report pending and booked items;|- notify one or more debit entries;|- notify one or more credit entries;|- notify a combination of debit and credit entries.|It can include underlying details of transactions that have been included in the entry.|It is possible that the receiver of the message is not the account owner, but a party entitled by the account owner to receive the account information (also known as recipient).|It does not contain balance information.")]
[IsoId("_7wsWodb-Eeq_l4BJLVUF2Q")]
[DisplayName("Bank To Customer Debit Credit Notification V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BankToCustomerDebitCreditNotificationV09 : IOuterRecord<BankToCustomerDebitCreditNotificationV09,BankToCustomerDebitCreditNotificationV09Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.054.001.09";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "BkToCstmrDbtCdtNtfctn";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => BankToCustomerDebitCreditNotificationV09Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BankToCustomerDebitCreditNotificationV09 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BankToCustomerDebitCreditNotificationV09( GroupHeader81 reqGroupHeader,AccountNotification19 reqNotification )
    {
        GroupHeader = reqGroupHeader;
        Notification = reqNotification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Common information for the message.
    /// </summary>
    [IsoId("_7wsWrdb-Eeq_l4BJLVUF2Q")]
    [DisplayName("Group Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrpHdr")]
    #endif
    [IsoXmlTag("GrpHdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GroupHeader81 GroupHeader { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GroupHeader81 GroupHeader { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GroupHeader81 GroupHeader { get; init; } 
    #else
    public GroupHeader81 GroupHeader { get; set; } 
    #endif
    
    /// <summary>
    /// Notifies debit and credit entries for the account.
    /// </summary>
    [IsoId("_7wsWr9b-Eeq_l4BJLVUF2Q")]
    [DisplayName("Notification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ntfctn")]
    #endif
    [IsoXmlTag("Ntfctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AccountNotification19 Notification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AccountNotification19 Notification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountNotification19 Notification { get; init; } 
    #else
    public AccountNotification19 Notification { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_7wsWsdb-Eeq_l4BJLVUF2Q")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated &lt;seealso cref=&quot;BankToCustomerDebitCreditNotificationV09Document&quot;/&gt;, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public BankToCustomerDebitCreditNotificationV09Document ToDocument()
    {
        return new BankToCustomerDebitCreditNotificationV09Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying &lt;seealso cref=&quot;BankToCustomerDebitCreditNotificationV09&quot;/&gt;.
/// </summary>
[Serializable]
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
    /// The instance of &lt;seealso cref=&quot;BankToCustomerDebitCreditNotificationV09&quot;/&gt; is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BankToCustomerDebitCreditNotificationV09 Message { get; init; }
    #else
    public BankToCustomerDebitCreditNotificationV09 Message { get; init; }
    #endif
}
