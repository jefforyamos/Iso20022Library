﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AcceptorBatchTransferV06.  ISO2002 ID# _93JPQap4EeanIZ10Ka8PnA.
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
/// This record is an implementation of the caaa.011.001.06 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AcceptorBatchTransfer is sent by an acceptor (or its agent) to transfer the financial data of a collection of transactions to the acquirer (or its agent).
/// </summary>
[Description(@"The AcceptorBatchTransfer is sent by an acceptor (or its agent) to transfer the financial data of a collection of transactions to the acquirer (or its agent).")]
[IsoId("_93JPQap4EeanIZ10Ka8PnA")]
[DisplayName("Acceptor Batch Transfer V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AcceptorBatchTransferV06 : IOuterRecord<AcceptorBatchTransferV06,AcceptorBatchTransferV06Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caaa.011.001.06";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrBtchTrf";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => AcceptorBatchTransferV06Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AcceptorBatchTransferV06 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AcceptorBatchTransferV06( Header25 reqHeader,CardPaymentBatchTransfer5 reqBatchTransfer )
    {
        Header = reqHeader;
        BatchTransfer = reqBatchTransfer;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Batch capture message management information.
    /// </summary>
    [IsoId("_93JPRap4EeanIZ10Ka8PnA")]
    [DisplayName("Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Hdr")]
    #endif
    [IsoXmlTag("Hdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Header25 Header { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Header25 Header { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Header25 Header { get; init; } 
    #else
    public Header25 Header { get; set; } 
    #endif
    
    /// <summary>
    /// Card payment transactions from one or several data set of transactions.
    /// </summary>
    [IsoId("_93JPR6p4EeanIZ10Ka8PnA")]
    [DisplayName("Batch Transfer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BtchTrf")]
    #endif
    [IsoXmlTag("BtchTrf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CardPaymentBatchTransfer5 BatchTransfer { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CardPaymentBatchTransfer5 BatchTransfer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentBatchTransfer5 BatchTransfer { get; init; } 
    #else
    public CardPaymentBatchTransfer5 BatchTransfer { get; set; } 
    #endif
    
    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_93JPSap4EeanIZ10Ka8PnA")]
    [DisplayName("Security Trailer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyTrlr")]
    #endif
    [IsoXmlTag("SctyTrlr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType12? SecurityTrailer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType12? SecurityTrailer { get; init; } 
    #else
    public ContentInformationType12? SecurityTrailer { get; set; } 
    #endif
    
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated &lt;seealso cref=&quot;AcceptorBatchTransferV06Document&quot;/&gt;, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AcceptorBatchTransferV06Document ToDocument()
    {
        return new AcceptorBatchTransferV06Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying &lt;seealso cref=&quot;AcceptorBatchTransferV06&quot;/&gt;.
/// </summary>
[Serializable]
public partial record AcceptorBatchTransferV06Document : IOuterDocument<AcceptorBatchTransferV06>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.011.001.06";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of &lt;seealso cref=&quot;AcceptorBatchTransferV06&quot;/&gt; is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AcceptorBatchTransferV06 Message { get; init; }
    #else
    public AcceptorBatchTransferV06 Message { get; init; }
    #endif
}
