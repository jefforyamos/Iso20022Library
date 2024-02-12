﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SubscriptionOrderV04.  ISO2002 ID# _Aab6nzbLEead9bDRE_1DAQ.
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


namespace BeneficialStrategies.Iso20022.setr;

/// <summary>
/// This record is an implementation of the setr.010.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The SubscriptionOrder message is sent by an instructing party, for example, an investment manager or its authorised representative, to the executing party, for example, a transfer agent, to instruct the subscription of one or more financial instruments for one investment fund account.
/// Usage
/// The SubscriptionOrder message is used to instruct single subscription orders, that is, a message containing one order for one financial instrument for one investment account. The SubscriptionOrder message may also be used for multiple orders, that is, a message containing several orders for the same investment account for different financial instruments.
/// For a single subscription order, the SubscriptionOrder message, not the SubscriptionBulkOrder message, must be used.
/// If there are subscription orders for the same financial instrument but for different accounts that are to be communicated in a single message, then the SubscriptionBulkOrder message must be used.
/// </summary>
[Description(@"Scope|The SubscriptionOrder message is sent by an instructing party, for example, an investment manager or its authorised representative, to the executing party, for example, a transfer agent, to instruct the subscription of one or more financial instruments for one investment fund account.|Usage|The SubscriptionOrder message is used to instruct single subscription orders, that is, a message containing one order for one financial instrument for one investment account. The SubscriptionOrder message may also be used for multiple orders, that is, a message containing several orders for the same investment account for different financial instruments.|For a single subscription order, the SubscriptionOrder message, not the SubscriptionBulkOrder message, must be used.|If there are subscription orders for the same financial instrument but for different accounts that are to be communicated in a single message, then the SubscriptionBulkOrder message must be used.")]
[IsoId("_Aab6nzbLEead9bDRE_1DAQ")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Subscription Order V")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SubscriptionOrderV04 : IOuterRecord<SubscriptionOrderV04,SubscriptionOrderV04Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "setr.010.001.04";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SbcptOrdr";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => SubscriptionOrderV04Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SubscriptionOrderV04 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SubscriptionOrderV04( MessageIdentification1 reqMessageIdentification,SubscriptionMultipleOrder6 reqMultipleOrderDetails )
    {
        MessageIdentification = reqMessageIdentification;
        MultipleOrderDetails = reqMultipleOrderDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference that uniquely identifies the message from a business application standpoint.
    /// </summary>
    [IsoId("_Aab6pzbLEead9bDRE_1DAQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Message Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 MessageIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public MessageIdentification1 MessageIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 MessageIdentification { get; init; } 
    #else
    public MessageIdentification1 MessageIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_Aab6qTbLEead9bDRE_1DAQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Pool Reference")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference9? PoolReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference9? PoolReference { get; init; } 
    #else
    public AdditionalReference9? PoolReference { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_Aab6qzbLEead9bDRE_1DAQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Previous Reference")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference8? PreviousReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference8? PreviousReference { get; init; } 
    #else
    public AdditionalReference8? PreviousReference { get; set; } 
    #endif
    
    /// <summary>
    /// General information related to the orders.
    /// </summary>
    [IsoId("_Aab6rTbLEead9bDRE_1DAQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Multiple Order Details")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SubscriptionMultipleOrder6 MultipleOrderDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public SubscriptionMultipleOrder6 MultipleOrderDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SubscriptionMultipleOrder6 MultipleOrderDetails { get; init; } 
    #else
    public SubscriptionMultipleOrder6 MultipleOrderDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_Aab6sTbLEead9bDRE_1DAQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Copy Details")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CopyInformation4? CopyDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CopyInformation4? CopyDetails { get; init; } 
    #else
    public CopyInformation4? CopyDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_Aab6szbLEead9bDRE_1DAQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Extension")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Extension1? Extension { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Extension1? Extension { get; init; } 
    #else
    public Extension1? Extension { get; set; } 
    #endif
    
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SubscriptionOrderV04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SubscriptionOrderV04Document ToDocument()
    {
        return new SubscriptionOrderV04Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SubscriptionOrderV04"/>.
/// </summary>
[Serializable]
public partial record SubscriptionOrderV04Document : IOuterDocument<SubscriptionOrderV04>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.010.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SubscriptionOrderV04"/> is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SubscriptionOrderV04 Message { get; init; }
    #else
    public SubscriptionOrderV04 Message { get; init; }
    #endif
}
