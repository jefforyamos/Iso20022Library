﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SubscriptionOrderConfirmationCancellationInstructionV02.  ISO2002 ID# _Aab7WzbLEead9bDRE_1DAQ.
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
/// This record is an implementation of the setr.047.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The SubscriptionOrderConfirmationCancellationInstruction message is sent by an executing party, for example, a transfer agent, to the instructing party, for example, an investment manager or its authorised representative, to cancel a previously sent SubscriptionOrderConfirmation.
/// Usage
/// To request the cancellation of one or more individual order executions, the order reference and deal reference of each individual order execution in the original SubscriptionOrderConfirmation are specified in the order reference and deal reference elements respectively. The message identification of the SubscriptionOrderConfirmation message in which the individual order execution was conveyed may also be quoted in PreviousReference but this is not recommended. The AmendmentIndicator is used to specify whether the subscription order confirmation cancellation is to be followed by an amendment An amendment of a subscription order confirmation is carried out by sending a SubscriptionOrderConfirmation message in which the AmendmentIndicator contains the value ‘true’.
/// </summary>
[Description(@"Scope|The SubscriptionOrderConfirmationCancellationInstruction message is sent by an executing party, for example, a transfer agent, to the instructing party, for example, an investment manager or its authorised representative, to cancel a previously sent SubscriptionOrderConfirmation.|Usage|To request the cancellation of one or more individual order executions, the order reference and deal reference of each individual order execution in the original SubscriptionOrderConfirmation are specified in the order reference and deal reference elements respectively. The message identification of the SubscriptionOrderConfirmation message in which the individual order execution was conveyed may also be quoted in PreviousReference but this is not recommended. The AmendmentIndicator is used to specify whether the subscription order confirmation cancellation is to be followed by an amendment An amendment of a subscription order confirmation is carried out by sending a SubscriptionOrderConfirmation message in which the AmendmentIndicator contains the value ‘true’.")]
[IsoId("_Aab7WzbLEead9bDRE_1DAQ")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Subscription Order Confirmation Cancellation Instruction V")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SubscriptionOrderConfirmationCancellationInstructionV02 : IOuterRecord<SubscriptionOrderConfirmationCancellationInstructionV02,SubscriptionOrderConfirmationCancellationInstructionV02Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "setr.047.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SbcptOrdrConfCxlInstr";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => SubscriptionOrderConfirmationCancellationInstructionV02Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SubscriptionOrderConfirmationCancellationInstructionV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SubscriptionOrderConfirmationCancellationInstructionV02( MessageIdentification1 reqMessageIdentification,System.String reqAmendmentIndicator,InvestmentFundOrder11 reqOrderReferences )
    {
        MessageIdentification = reqMessageIdentification;
        AmendmentIndicator = reqAmendmentIndicator;
        OrderReferences = reqOrderReferences;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference that uniquely identifies the message from a business application standpoint.
    /// </summary>
    [IsoId("_Aab7YTbLEead9bDRE_1DAQ")]
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
    [IsoId("_Aab7YzbLEead9bDRE_1DAQ")]
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
    [IsoId("_Aab7ZTbLEead9bDRE_1DAQ")]
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
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_Aab7ZzbLEead9bDRE_1DAQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Related Reference")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference8? RelatedReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference8? RelatedReference { get; init; } 
    #else
    public AdditionalReference8? RelatedReference { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether a confirmation amendment message will follow the confirmation cancellation instruction or not.
    /// </summary>
    [IsoId("_IKmdEVAZEea5nPE5ezGuuw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Amendment Indicator")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator AmendmentIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String AmendmentIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String AmendmentIndicator { get; init; } 
    #else
    public System.String AmendmentIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Reference assigned to a set of orders or trades in order to link them together.
    /// </summary>
    [IsoId("_iyhMUlAYEea5nPE5ezGuuw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Master Reference")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? MasterReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MasterReference { get; init; } 
    #else
    public System.String? MasterReference { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the individual order confirmation to be cancelled.
    /// </summary>
    [IsoId("_iyhMU1AYEea5nPE5ezGuuw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Order References")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InvestmentFundOrder11 OrderReferences { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public InvestmentFundOrder11 OrderReferences { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentFundOrder11 OrderReferences { get; init; } 
    #else
    public InvestmentFundOrder11 OrderReferences { get; set; } 
    #endif
    
    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_Aab7bTbLEead9bDRE_1DAQ")]
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
    
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SubscriptionOrderConfirmationCancellationInstructionV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SubscriptionOrderConfirmationCancellationInstructionV02Document ToDocument()
    {
        return new SubscriptionOrderConfirmationCancellationInstructionV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SubscriptionOrderConfirmationCancellationInstructionV02"/>.
/// </summary>
[Serializable]
public partial record SubscriptionOrderConfirmationCancellationInstructionV02Document : IOuterDocument<SubscriptionOrderConfirmationCancellationInstructionV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.047.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SubscriptionOrderConfirmationCancellationInstructionV02"/> is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SubscriptionOrderConfirmationCancellationInstructionV02 Message { get; init; }
    #else
    public SubscriptionOrderConfirmationCancellationInstructionV02 Message { get; init; }
    #endif
}
