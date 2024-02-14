﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CancelTransactionV10.  ISO2002 ID# _jx5UsQKxEe2rHs6fbn9-0A.
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
/// This record is an implementation of the camt.008.001.10 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The CancelTransaction message is sent by a member to the transaction administrator.
/// It is used to request the cancellation of one payment instruction held at the transaction administrator and sent by the member.
/// Usage
/// Following normal business flows, transactions registered by the transaction administrator may be queued for later settlement (because of insufficient funds available, because of risk or liquidity limits, etc.). A transaction may have a series of statuses. These can be transient (such as pending or related types), final (such as rejected, revoked and/or settled) or the status may even be defined as a proprietary status.
/// Members of a system need to have information about the payments queue(s), and must have the ability to take action (that is, to cancel or modify the transaction(s) to be settled). Note, however, that actions by a member will always concern transactions in a transient status.
/// For this reason, at any time during the operating hours of the system, the member can request the cancellation of a transaction that has not received a final status.
/// The member will submit a CancelTransaction message containing the identification of the transaction to be cancelled.
/// Based on the criteria received within the CancelTransaction message, the transaction administrator will execute or reject the requested cancellation.
/// The transaction administrator may send a Receipt message as a reply to the CancelTransaction request.
/// To verify the outcome of the request, the member may submit a GetTransaction message with the appropriate search criteria.
/// </summary>
[Description(@"Scope|The CancelTransaction message is sent by a member to the transaction administrator.|It is used to request the cancellation of one payment instruction held at the transaction administrator and sent by the member.|Usage|Following normal business flows, transactions registered by the transaction administrator may be queued for later settlement (because of insufficient funds available, because of risk or liquidity limits, etc.). A transaction may have a series of statuses. These can be transient (such as pending or related types), final (such as rejected, revoked and/or settled) or the status may even be defined as a proprietary status.|Members of a system need to have information about the payments queue(s), and must have the ability to take action (that is, to cancel or modify the transaction(s) to be settled). Note, however, that actions by a member will always concern transactions in a transient status.|For this reason, at any time during the operating hours of the system, the member can request the cancellation of a transaction that has not received a final status.|The member will submit a CancelTransaction message containing the identification of the transaction to be cancelled.|Based on the criteria received within the CancelTransaction message, the transaction administrator will execute or reject the requested cancellation.|The transaction administrator may send a Receipt message as a reply to the CancelTransaction request.|To verify the outcome of the request, the member may submit a GetTransaction message with the appropriate search criteria.")]
[IsoId("_jx5UsQKxEe2rHs6fbn9-0A")]
[DisplayName("Cancel Transaction V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CancelTransactionV10 : IOuterRecord<CancelTransactionV10,CancelTransactionV10Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.008.001.10";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CclTx";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => CancelTransactionV10Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CancelTransactionV10 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CancelTransactionV10( MessageHeader9 reqMessageHeader,PaymentIdentification7Choice_ reqPaymentIdentification )
    {
        MessageHeader = reqMessageHeader;
        PaymentIdentification = reqPaymentIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_jx5UuQKxEe2rHs6fbn9-0A")]
    [DisplayName("Message Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgHdr")]
    #endif
    [IsoXmlTag("MsgHdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageHeader9 MessageHeader { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageHeader9 MessageHeader { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageHeader9 MessageHeader { get; init; } 
    #else
    public MessageHeader9 MessageHeader { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to the instruction related to the payment for which information is requested.
    /// </summary>
    [IsoId("_jx5UuwKxEe2rHs6fbn9-0A")]
    [DisplayName("Payment Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtId")]
    #endif
    [IsoXmlTag("PmtId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PaymentIdentification7Choice_ PaymentIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PaymentIdentification7Choice_ PaymentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentIdentification7Choice_ PaymentIdentification { get; init; } 
    #else
    public PaymentIdentification7Choice_ PaymentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Account to or from which a cash entry is made.
    /// </summary>
    [IsoId("_jx5UvQKxEe2rHs6fbn9-0A")]
    [DisplayName("Cash Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshAcct")]
    #endif
    [IsoXmlTag("CshAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount40? CashAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount40? CashAccount { get; init; } 
    #else
    public CashAccount40? CashAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Provides detailed information on the cancellation reason.
    /// </summary>
    [IsoId("_jx5UvwKxEe2rHs6fbn9-0A")]
    [DisplayName("Cancellation Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlRsn")]
    #endif
    [IsoXmlTag("CxlRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentCancellationReason5? CancellationReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentCancellationReason5? CancellationReason { get; init; } 
    #else
    public PaymentCancellationReason5? CancellationReason { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_jx5UwQKxEe2rHs6fbn9-0A")]
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
    /// Using the state of this record, returns a populated &lt;seealso cref=&quot;CancelTransactionV10Document&quot;/&gt;, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CancelTransactionV10Document ToDocument()
    {
        return new CancelTransactionV10Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying &lt;seealso cref=&quot;CancelTransactionV10&quot;/&gt;.
/// </summary>
[Serializable]
public partial record CancelTransactionV10Document : IOuterDocument<CancelTransactionV10>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.008.001.10";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of &lt;seealso cref=&quot;CancelTransactionV10&quot;/&gt; is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CancelTransactionV10 Message { get; init; }
    #else
    public CancelTransactionV10 Message { get; init; }
    #endif
}
