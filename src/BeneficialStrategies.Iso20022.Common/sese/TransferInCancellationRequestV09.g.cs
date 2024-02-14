﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for TransferInCancellationRequestV09.  ISO2002 ID# _Yga5gZDhEem7fvtoGpNpow.
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


namespace BeneficialStrategies.Iso20022.sese;

/// <summary>
/// This record is an implementation of the sese.006.001.09 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The TransferInCancellationRequest message is sent by an instructing party, for example, an investment manager or its authorised representative, to the executing party, for example, a transfer agent, to request the cancellation of a previously sent transfer in instruction.
/// Usage
/// The TransferInCancellationRequest message is used to request the cancellation of one or more transfer in instructions.
/// There is no amendment, but a cancellation and re-instruct policy.
/// To request the cancellation of one or more transfer in instructions, the transfer reference of the transfer, as specified in the original TransferInInstruction message, is specified in the transfer reference element.
/// The message identification of the original TransferOutInstruction message may also be quoted in PreviousReference but this is not recommended.
/// The deadline and acceptance of a cancellation request is subject to a service level agreement (SLA). This cancellation message is a cancellation request. There is no automatic acceptance of the cancellation.
/// The rejection or acceptance of a TransferInCancellationRequest is made using a TransferCancellationStatusReport message.
/// </summary>
[Description(@"Scope|The TransferInCancellationRequest message is sent by an instructing party, for example, an investment manager or its authorised representative, to the executing party, for example, a transfer agent, to request the cancellation of a previously sent transfer in instruction.|Usage|The TransferInCancellationRequest message is used to request the cancellation of one or more transfer in instructions.|There is no amendment, but a cancellation and re-instruct policy.|To request the cancellation of one or more transfer in instructions, the transfer reference of the transfer, as specified in the original TransferInInstruction message, is specified in the transfer reference element.|The message identification of the original TransferOutInstruction message may also be quoted in PreviousReference but this is not recommended.|The deadline and acceptance of a cancellation request is subject to a service level agreement (SLA). This cancellation message is a cancellation request. There is no automatic acceptance of the cancellation.|The rejection or acceptance of a TransferInCancellationRequest is made using a TransferCancellationStatusReport message.")]
[IsoId("_Yga5gZDhEem7fvtoGpNpow")]
[DisplayName("Transfer In Cancellation Request V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransferInCancellationRequestV09 : IOuterRecord<TransferInCancellationRequestV09,TransferInCancellationRequestV09Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.006.001.09";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TrfInCxlReq";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => TransferInCancellationRequestV09Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransferInCancellationRequestV09 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransferInCancellationRequestV09( MessageIdentification1 reqMessageIdentification,TransferReference15 reqTransferReferences )
    {
        MessageIdentification = reqMessageIdentification;
        TransferReferences = reqTransferReferences;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference that uniquely identifies the message from a business application standpoint.
    /// </summary>
    [IsoId("_YgkDcZDhEem7fvtoGpNpow")]
    [DisplayName("Message Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgId")]
    #endif
    [IsoXmlTag("MsgId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 MessageIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageIdentification1 MessageIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 MessageIdentification { get; init; } 
    #else
    public MessageIdentification1 MessageIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_YgkDc5DhEem7fvtoGpNpow")]
    [DisplayName("Pool Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PoolRef")]
    #endif
    [IsoXmlTag("PoolRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference11? PoolReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference11? PoolReference { get; init; } 
    #else
    public AdditionalReference11? PoolReference { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_YgkDdZDhEem7fvtoGpNpow")]
    [DisplayName("Previous Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsRef")]
    #endif
    [IsoXmlTag("PrvsRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference10? PreviousReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference10? PreviousReference { get; init; } 
    #else
    public AdditionalReference10? PreviousReference { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_YgkDd5DhEem7fvtoGpNpow")]
    [DisplayName("Related Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdRef")]
    #endif
    [IsoXmlTag("RltdRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference10? RelatedReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference10? RelatedReference { get; init; } 
    #else
    public AdditionalReference10? RelatedReference { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    [IsoId("_L3FugZGyEem-9Y6mq5ZH3Q")]
    [DisplayName("Master Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MstrRef")]
    #endif
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? MasterReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MasterReference { get; init; } 
    #else
    public System.String? MasterReference { get; set; } 
    #endif
    
    /// <summary>
    /// Function of the transfer-in, that is, whether the message is used as a request to cancel a previously sent instruction or as a cancellation of a previously sent advice and request for information. The absence of Function indicates the message is a request to cancel a previously sent instruction.
    /// </summary>
    [IsoId("_YgkDeZDhEem7fvtoGpNpow")]
    [DisplayName("Function")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Fctn")]
    #endif
    [IsoXmlTag("Fctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransferInFunction1Code? Function { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransferInFunction1Code? Function { get; init; } 
    #else
    public TransferInFunction1Code? Function { get; set; } 
    #endif
    
    /// <summary>
    /// Reference of the transfer to be cancelled.
    /// </summary>
    [IsoId("_YgkDe5DhEem7fvtoGpNpow")]
    [DisplayName("Transfer References")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfRefs")]
    #endif
    [IsoXmlTag("TrfRefs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransferReference15 TransferReferences { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransferReference15 TransferReferences { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransferReference15 TransferReferences { get; init; } 
    #else
    public TransferReference15 TransferReferences { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the market practice to which the message conforms.
    /// </summary>
    [IsoId("_YgkDfZDhEem7fvtoGpNpow")]
    [DisplayName("Market Practice Version")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MktPrctcVrsn")]
    #endif
    [IsoXmlTag("MktPrctcVrsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MarketPracticeVersion1? MarketPracticeVersion { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarketPracticeVersion1? MarketPracticeVersion { get; init; } 
    #else
    public MarketPracticeVersion1? MarketPracticeVersion { get; set; } 
    #endif
    
    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_YgkDf5DhEem7fvtoGpNpow")]
    [DisplayName("Copy Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CpyDtls")]
    #endif
    [IsoXmlTag("CpyDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CopyInformation5? CopyDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CopyInformation5? CopyDetails { get; init; } 
    #else
    public CopyInformation5? CopyDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated &lt;seealso cref=&quot;TransferInCancellationRequestV09Document&quot;/&gt;, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public TransferInCancellationRequestV09Document ToDocument()
    {
        return new TransferInCancellationRequestV09Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying &lt;seealso cref=&quot;TransferInCancellationRequestV09&quot;/&gt;.
/// </summary>
[Serializable]
public partial record TransferInCancellationRequestV09Document : IOuterDocument<TransferInCancellationRequestV09>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.006.001.09";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of &lt;seealso cref=&quot;TransferInCancellationRequestV09&quot;/&gt; is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransferInCancellationRequestV09 Message { get; init; }
    #else
    public TransferInCancellationRequestV09 Message { get; init; }
    #endif
}
