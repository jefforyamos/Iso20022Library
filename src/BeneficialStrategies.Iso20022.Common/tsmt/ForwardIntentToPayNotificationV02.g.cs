﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ForwardIntentToPayNotificationV02.  ISO2002 ID# _hEp5QRVaEeOCqpkCrPgk4g.
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


namespace BeneficialStrategies.Iso20022.tsmt;

/// <summary>
/// This record is an implementation of the tsmt.045.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The ForwardIntentToPayNotification message is forwarded by the matching application from one primary bank to the other primary bank in order to provide details about a future payment.
/// This message contains details about an intention to pay a certain amount, on a certain date, in relation to one or several transactions known to the matching application.
/// Usage
/// The ForwardIntentToPayNotification message is a copy of the IntentToPayNotification message received by the matching application and forwarded to the other primary bank for information. No response is expected.
/// </summary>
[Description(@"Scope|The ForwardIntentToPayNotification message is forwarded by the matching application from one primary bank to the other primary bank in order to provide details about a future payment.|This message contains details about an intention to pay a certain amount, on a certain date, in relation to one or several transactions known to the matching application.|Usage|The ForwardIntentToPayNotification message is a copy of the IntentToPayNotification message received by the matching application and forwarded to the other primary bank for information. No response is expected.")]
[IsoId("_hEp5QRVaEeOCqpkCrPgk4g")]
[DisplayName("Forward Intent To Pay Notification V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ForwardIntentToPayNotificationV02 : IOuterRecord<ForwardIntentToPayNotificationV02,ForwardIntentToPayNotificationV02Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsmt.045.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FwdInttToPayNtfctn";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => ForwardIntentToPayNotificationV02Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ForwardIntentToPayNotificationV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ForwardIntentToPayNotificationV02( MessageIdentification1 reqNotificationIdentification,SimpleIdentificationInformation reqTransactionIdentification,DocumentIdentification3 reqEstablishedBaselineIdentification,TransactionStatus4 reqTransactionStatus,BICIdentification1 reqBuyerBank,BICIdentification1 reqSellerBank,IntentToPay2 reqIntentToPay )
    {
        NotificationIdentification = reqNotificationIdentification;
        TransactionIdentification = reqTransactionIdentification;
        EstablishedBaselineIdentification = reqEstablishedBaselineIdentification;
        TransactionStatus = reqTransactionStatus;
        BuyerBank = reqBuyerBank;
        SellerBank = reqSellerBank;
        IntentToPay = reqIntentToPay;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the notification message.
    /// </summary>
    [IsoId("_hEp5QxVaEeOCqpkCrPgk4g")]
    [DisplayName("Notification Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtfctnId")]
    #endif
    [IsoXmlTag("NtfctnId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 NotificationIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageIdentification1 NotificationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 NotificationIdentification { get; init; } 
    #else
    public MessageIdentification1 NotificationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.
    /// </summary>
    [IsoId("_hEp5RRVaEeOCqpkCrPgk4g")]
    [DisplayName("Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxId")]
    #endif
    [IsoXmlTag("TxId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SimpleIdentificationInformation TransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SimpleIdentificationInformation TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SimpleIdentificationInformation TransactionIdentification { get; init; } 
    #else
    public SimpleIdentificationInformation TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification assigned by the matching application to the baseline when it is established.
    /// </summary>
    [IsoId("_hEp5RxVaEeOCqpkCrPgk4g")]
    [DisplayName("Established Baseline Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EstblishdBaselnId")]
    #endif
    [IsoXmlTag("EstblishdBaselnId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentIdentification3 EstablishedBaselineIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentIdentification3 EstablishedBaselineIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification3 EstablishedBaselineIdentification { get; init; } 
    #else
    public DocumentIdentification3 EstablishedBaselineIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the status of the transaction by means of a code.
    /// </summary>
    [IsoId("_hEp5SRVaEeOCqpkCrPgk4g")]
    [DisplayName("Transaction Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxSts")]
    #endif
    [IsoXmlTag("TxSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionStatus4 TransactionStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionStatus4 TransactionStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionStatus4 TransactionStatus { get; init; } 
    #else
    public TransactionStatus4 TransactionStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to the transaction for the financial institutions involved in this transaction.
    /// </summary>
    [IsoId("_hEp5SxVaEeOCqpkCrPgk4g")]
    [DisplayName("User Transaction Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UsrTxRef")]
    #endif
    [IsoXmlTag("UsrTxRef")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<DocumentIdentification5> UserTransactionReference { get; init; } = new ValueList<DocumentIdentification5>(){};
    
    /// <summary>
    /// The financial institution of the buyer, uniquely identified by its BIC.
    /// </summary>
    [IsoId("_hEp5TRVaEeOCqpkCrPgk4g")]
    [DisplayName("Buyer Bank")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BuyrBk")]
    #endif
    [IsoXmlTag("BuyrBk")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BICIdentification1 BuyerBank { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BICIdentification1 BuyerBank { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BICIdentification1 BuyerBank { get; init; } 
    #else
    public BICIdentification1 BuyerBank { get; set; } 
    #endif
    
    /// <summary>
    /// The financial institution of the seller, uniquely identified by its BIC.
    /// </summary>
    [IsoId("_hEp5TxVaEeOCqpkCrPgk4g")]
    [DisplayName("Seller Bank")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SellrBk")]
    #endif
    [IsoXmlTag("SellrBk")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BICIdentification1 SellerBank { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BICIdentification1 SellerBank { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BICIdentification1 SellerBank { get; init; } 
    #else
    public BICIdentification1 SellerBank { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the details of the intention to pay.
    /// </summary>
    [IsoId("_hEp5URVaEeOCqpkCrPgk4g")]
    [DisplayName("Intent To Pay")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InttToPay")]
    #endif
    [IsoXmlTag("InttToPay")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IntentToPay2 IntentToPay { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required IntentToPay2 IntentToPay { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IntentToPay2 IntentToPay { get; init; } 
    #else
    public IntentToPay2 IntentToPay { get; set; } 
    #endif
    
    /// <summary>
    /// Next processing step required.
    /// </summary>
    [IsoId("_hEp5UxVaEeOCqpkCrPgk4g")]
    [DisplayName("Request For Action")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqForActn")]
    #endif
    [IsoXmlTag("ReqForActn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PendingActivity2? RequestForAction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PendingActivity2? RequestForAction { get; init; } 
    #else
    public PendingActivity2? RequestForAction { get; set; } 
    #endif
    
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated &lt;seealso cref=&quot;ForwardIntentToPayNotificationV02Document&quot;/&gt;, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ForwardIntentToPayNotificationV02Document ToDocument()
    {
        return new ForwardIntentToPayNotificationV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying &lt;seealso cref=&quot;ForwardIntentToPayNotificationV02&quot;/&gt;.
/// </summary>
[Serializable]
public partial record ForwardIntentToPayNotificationV02Document : IOuterDocument<ForwardIntentToPayNotificationV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.045.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of &lt;seealso cref=&quot;ForwardIntentToPayNotificationV02&quot;/&gt; is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ForwardIntentToPayNotificationV02 Message { get; init; }
    #else
    public ForwardIntentToPayNotificationV02 Message { get; init; }
    #endif
}
