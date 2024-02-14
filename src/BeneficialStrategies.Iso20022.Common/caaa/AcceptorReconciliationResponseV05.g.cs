﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AcceptorReconciliationResponseV05.  ISO2002 ID# _8Wl3gY1MEeWXALXlV0Ei2w.
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


namespace BeneficialStrategies.Iso20022.caaa;

/// <summary>
/// This record is an implementation of the caaa.010.001.05 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AcceptorReconciliationResponse message is sent by the acquirer (or its agent) to an acceptor (or its agent), to ensure that the debits and credits performed by the acceptor matches the computed balances of the acquirer for the debits and credits performed during the same reconciliation period.
/// If the acceptor or the acquirer notices a difference in totals, the discrepancy will be resolved by other means, outside the scope of the protocol.
/// </summary>
[Description(@"The AcceptorReconciliationResponse message is sent by the acquirer (or its agent) to an acceptor (or its agent), to ensure that the debits and credits performed by the acceptor matches the computed balances of the acquirer for the debits and credits performed during the same reconciliation period.|If the acceptor or the acquirer notices a difference in totals, the discrepancy will be resolved by other means, outside the scope of the protocol.")]
[IsoId("_8Wl3gY1MEeWXALXlV0Ei2w")]
[DisplayName("Acceptor Reconciliation Response V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AcceptorReconciliationResponseV05 : IOuterRecord<AcceptorReconciliationResponseV05,AcceptorReconciliationResponseV05Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caaa.010.001.05";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrRcncltnRspn";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => AcceptorReconciliationResponseV05Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AcceptorReconciliationResponseV05 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AcceptorReconciliationResponseV05( Header30 reqHeader,AcceptorReconciliationResponse4 reqReconciliationResponse )
    {
        Header = reqHeader;
        ReconciliationResponse = reqReconciliationResponse;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reconciliation response message management information.
    /// </summary>
    [IsoId("_8Wl3hY1MEeWXALXlV0Ei2w")]
    [DisplayName("Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Hdr")]
    #endif
    [IsoXmlTag("Hdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Header30 Header { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Header30 Header { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Header30 Header { get; init; } 
    #else
    public Header30 Header { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the reconciliation response.
    /// </summary>
    [IsoId("_8Wl3h41MEeWXALXlV0Ei2w")]
    [DisplayName("Reconciliation Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcncltnRspn")]
    #endif
    [IsoXmlTag("RcncltnRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AcceptorReconciliationResponse4 ReconciliationResponse { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AcceptorReconciliationResponse4 ReconciliationResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AcceptorReconciliationResponse4 ReconciliationResponse { get; init; } 
    #else
    public AcceptorReconciliationResponse4 ReconciliationResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_8Wl3iY1MEeWXALXlV0Ei2w")]
    [DisplayName("Security Trailer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyTrlr")]
    #endif
    [IsoXmlTag("SctyTrlr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType15? SecurityTrailer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType15? SecurityTrailer { get; init; } 
    #else
    public ContentInformationType15? SecurityTrailer { get; set; } 
    #endif
    
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated &lt;seealso cref=&quot;AcceptorReconciliationResponseV05Document&quot;/&gt;, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AcceptorReconciliationResponseV05Document ToDocument()
    {
        return new AcceptorReconciliationResponseV05Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying &lt;seealso cref=&quot;AcceptorReconciliationResponseV05&quot;/&gt;.
/// </summary>
[Serializable]
public partial record AcceptorReconciliationResponseV05Document : IOuterDocument<AcceptorReconciliationResponseV05>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.010.001.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of &lt;seealso cref=&quot;AcceptorReconciliationResponseV05&quot;/&gt; is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AcceptorReconciliationResponseV05 Message { get; init; }
    #else
    public AcceptorReconciliationResponseV05 Message { get; init; }
    #endif
}
