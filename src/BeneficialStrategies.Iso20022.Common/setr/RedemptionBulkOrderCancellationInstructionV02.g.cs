﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for RedemptionBulkOrderCancellationInstructionV02.  ISO2002 ID# _nOQIstE7Ed-BzquC8wXy7w_1647966589.
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
/// This record is an implementation of the setr.002.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The RedemptionBulkOrderCancellationInstruction message is sent by an instructing party, eg, an investment manager or its authorised representative, to an executing party, eg, a transfer agent. There may be one or more intermediary parties between the instructing party and the executing party. The intermediary party is, for example, an intermediary or a concentrator.
/// This message is sent to cancel a previously sent RedemptionBulkOrder instruction.
/// Usage
/// The RedemptionBulkOrderCancellationInstruction message is used to cancel the entire previously sent RedemptionBulkOrder message and all the individual orders that it contained. There is no amendment, but a cancellation and re-instruct policy.
/// This message must contain the reference of the message to be cancelled. This message may also contain all the details of the message to be cancelled, but this is not recommended.
/// The deadline and acceptance of a cancellation instruction is subject to a service level agreement (SLA). This cancellation message is a cancellation instruction. There is no automatic acceptance of the cancellation instruction.
/// The rejection or acceptance of a cancellation message instruction is made using an OrderCancellationStatusReport message.
/// </summary>
[Description(@"Scope|The RedemptionBulkOrderCancellationInstruction message is sent by an instructing party, eg, an investment manager or its authorised representative, to an executing party, eg, a transfer agent. There may be one or more intermediary parties between the instructing party and the executing party. The intermediary party is, for example, an intermediary or a concentrator.|This message is sent to cancel a previously sent RedemptionBulkOrder instruction.|Usage|The RedemptionBulkOrderCancellationInstruction message is used to cancel the entire previously sent RedemptionBulkOrder message and all the individual orders that it contained. There is no amendment, but a cancellation and re-instruct policy.|This message must contain the reference of the message to be cancelled. This message may also contain all the details of the message to be cancelled, but this is not recommended.|The deadline and acceptance of a cancellation instruction is subject to a service level agreement (SLA). This cancellation message is a cancellation instruction. There is no automatic acceptance of the cancellation instruction.|The rejection or acceptance of a cancellation message instruction is made using an OrderCancellationStatusReport message.")]
[IsoId("_nOQIstE7Ed-BzquC8wXy7w_1647966589")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Redemption Bulk Order Cancellation Instruction V")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RedemptionBulkOrderCancellationInstructionV02 : IOuterRecord<RedemptionBulkOrderCancellationInstructionV02,RedemptionBulkOrderCancellationInstructionV02Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "setr.002.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "setr.002.001.02";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => RedemptionBulkOrderCancellationInstructionV02Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RedemptionBulkOrderCancellationInstructionV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RedemptionBulkOrderCancellationInstructionV02( AdditionalReference3 reqPreviousReference )
    {
        PreviousReference = reqPreviousReference;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference assigned to a set of orders or trades in order to link them together.
    /// </summary>
    [IsoId("_nOQIs9E7Ed-BzquC8wXy7w_1157793130")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Master Reference")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference3? MasterReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference3? MasterReference { get; init; } 
    #else
    public AdditionalReference3? MasterReference { get; set; } 
    #endif
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_nOQItNE7Ed-BzquC8wXy7w_1159641070")]
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
    [IsoId("_nOQItdE7Ed-BzquC8wXy7w_1161487708")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Previous Reference")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AdditionalReference3 PreviousReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public AdditionalReference3 PreviousReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference3 PreviousReference { get; init; } 
    #else
    public AdditionalReference3 PreviousReference { get; set; } 
    #endif
    
    /// <summary>
    /// Common information related to all the orders to be cancelled.
    /// </summary>
    [IsoId("_nOQIttE7Ed-BzquC8wXy7w_2018298578")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Order To Be Cancelled")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RedemptionBulkOrderInstruction1? OrderToBeCancelled { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RedemptionBulkOrderInstruction1? OrderToBeCancelled { get; init; } 
    #else
    public RedemptionBulkOrderInstruction1? OrderToBeCancelled { get; set; } 
    #endif
    
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="RedemptionBulkOrderCancellationInstructionV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public RedemptionBulkOrderCancellationInstructionV02Document ToDocument()
    {
        return new RedemptionBulkOrderCancellationInstructionV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="RedemptionBulkOrderCancellationInstructionV02"/>.
/// </summary>
[Serializable]
public partial record RedemptionBulkOrderCancellationInstructionV02Document : IOuterDocument<RedemptionBulkOrderCancellationInstructionV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.002.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="RedemptionBulkOrderCancellationInstructionV02"/> is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RedemptionBulkOrderCancellationInstructionV02 Message { get; init; }
    #else
    public RedemptionBulkOrderCancellationInstructionV02 Message { get; init; }
    #endif
}
