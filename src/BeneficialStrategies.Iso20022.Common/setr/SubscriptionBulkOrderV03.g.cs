﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SubscriptionBulkOrderV03.  ISO2002 ID# _0KwbZdE7Ed-BzquC8wXy7w_-1498701586.
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
/// This record is an implementation of the setr.007.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An instructing party, for example, an investment manager or its authorised representative sends the SubscriptionBulkOrder message to the executing party, for example, a transfer agent, to instruct a subscription to a financial instrument for two or more accounts.
/// Usage
/// The SubscriptionBulkOrder message is used to bulk several individual orders into one bulk order. The individual orders come from different instructing parties, that is, account owners, but are related to the same financial instrument. This message will typically be used by a party collecting orders and bulking these individual orders into one bulk order before sending it to another party.
/// For a single subscription order, the SubscriptionOrder message, not the SubscriptionBulkOrder message, must be used.
/// If there are subscription orders for different financial instruments but for the same account, then the SubscriptionOrder must be used.
/// </summary>
[Description(@"Scope|An instructing party, for example, an investment manager or its authorised representative sends the SubscriptionBulkOrder message to the executing party, for example, a transfer agent, to instruct a subscription to a financial instrument for two or more accounts.|Usage|The SubscriptionBulkOrder message is used to bulk several individual orders into one bulk order. The individual orders come from different instructing parties, that is, account owners, but are related to the same financial instrument. This message will typically be used by a party collecting orders and bulking these individual orders into one bulk order before sending it to another party.|For a single subscription order, the SubscriptionOrder message, not the SubscriptionBulkOrder message, must be used.|If there are subscription orders for different financial instruments but for the same account, then the SubscriptionOrder must be used.")]
[IsoId("_0KwbZdE7Ed-BzquC8wXy7w_-1498701586")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Subscription Bulk Order V")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SubscriptionBulkOrderV03 : IOuterRecord<SubscriptionBulkOrderV03,SubscriptionBulkOrderV03Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "setr.007.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SbcptBlkOrdrV03";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => SubscriptionBulkOrderV03Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SubscriptionBulkOrderV03 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SubscriptionBulkOrderV03( MessageIdentification1 reqMessageIdentification,SubscriptionBulkOrder4 reqBulkOrderDetails )
    {
        MessageIdentification = reqMessageIdentification;
        BulkOrderDetails = reqBulkOrderDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference that uniquely identifies a message from a business application standpoint.
    /// </summary>
    [IsoId("_0KwbZtE7Ed-BzquC8wXy7w_-626209666")]
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
    [IsoId("_0KwbZ9E7Ed-BzquC8wXy7w_-744186367")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Pool Reference")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference3? PoolReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference3? PoolReference { get; init; } 
    #else
    public AdditionalReference3? PoolReference { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_0KwbaNE7Ed-BzquC8wXy7w_-742336956")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Previous Reference")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference3? PreviousReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference3? PreviousReference { get; init; } 
    #else
    public AdditionalReference3? PreviousReference { get; set; } 
    #endif
    
    /// <summary>
    /// General information related to the order.
    /// </summary>
    [IsoId("_0K6MYNE7Ed-BzquC8wXy7w_355525371")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Bulk Order Details")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SubscriptionBulkOrder4 BulkOrderDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public SubscriptionBulkOrder4 BulkOrderDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SubscriptionBulkOrder4 BulkOrderDetails { get; init; } 
    #else
    public SubscriptionBulkOrder4 BulkOrderDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information about parties related to the transaction.
    /// </summary>
    [IsoId("_0K6MYdE7Ed-BzquC8wXy7w_2033171159")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Related Party Details")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [MinLength(0)]
    [MaxLength(10)]
    #endif
    public ValueList<Intermediary8> RelatedPartyDetails { get; init; } = new ValueList<Intermediary8>(){};
    
    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_0K6MYtE7Ed-BzquC8wXy7w_2035019425")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Copy Details")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CopyInformation2? CopyDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CopyInformation2? CopyDetails { get; init; } 
    #else
    public CopyInformation2? CopyDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_0K6MY9E7Ed-BzquC8wXy7w_2036865617")]
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
    /// Using the state of this record, returns a populated <seealso cref="SubscriptionBulkOrderV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SubscriptionBulkOrderV03Document ToDocument()
    {
        return new SubscriptionBulkOrderV03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SubscriptionBulkOrderV03"/>.
/// </summary>
[Serializable]
public partial record SubscriptionBulkOrderV03Document : IOuterDocument<SubscriptionBulkOrderV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.007.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SubscriptionBulkOrderV03"/> is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SubscriptionBulkOrderV03 Message { get; init; }
    #else
    public SubscriptionBulkOrderV03 Message { get; init; }
    #endif
}
