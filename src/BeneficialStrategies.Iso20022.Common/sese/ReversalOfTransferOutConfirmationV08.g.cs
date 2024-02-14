﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ReversalOfTransferOutConfirmationV08.  ISO2002 ID# _slUYwYZLEeemXK0UETsSiA.
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
/// This record is an implementation of the sese.004.001.08 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The ReversalOfTransferOutConfirmation message is sent by the executing party, for example, a transfer agent, to the instructing party, for example, an investment manager or its authorised representative, to cancel a previously sent transfer out confirmation.
/// Usage
/// The ReversalOfTransferOutConfirmation message is used to reverse a previously sent transfer out confirmation.
/// To request the reversal of a transfer out confirmation, the transfer reference of the transfer out instruction, as specified in the original TransferOutInstruction message, is specified in the transfer reference element. The executing party’s reference for the execution of the transfer may also be specified in the TransferConfirmationReference element.
/// The message identification of the original TransferOutConfirmation message may also be quoted in PreviousReference but this is not recommended.
/// </summary>
[Description(@"Scope|The ReversalOfTransferOutConfirmation message is sent by the executing party, for example, a transfer agent, to the instructing party, for example, an investment manager or its authorised representative, to cancel a previously sent transfer out confirmation.|Usage|The ReversalOfTransferOutConfirmation message is used to reverse a previously sent transfer out confirmation.|To request the reversal of a transfer out confirmation, the transfer reference of the transfer out instruction, as specified in the original TransferOutInstruction message, is specified in the transfer reference element. The executing party’s reference for the execution of the transfer may also be specified in the TransferConfirmationReference element.|The message identification of the original TransferOutConfirmation message may also be quoted in PreviousReference but this is not recommended.")]
[IsoId("_slUYwYZLEeemXK0UETsSiA")]
[DisplayName("Reversal Of Transfer Out Confirmation V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReversalOfTransferOutConfirmationV08 : IOuterRecord<ReversalOfTransferOutConfirmationV08,ReversalOfTransferOutConfirmationV08Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.004.001.08";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RvslOfTrfOutConf";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => ReversalOfTransferOutConfirmationV08Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ReversalOfTransferOutConfirmationV08 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReversalOfTransferOutConfirmationV08( MessageIdentification1 reqMessageIdentification,TransferReference12 reqReversalReferences )
    {
        MessageIdentification = reqMessageIdentification;
        ReversalReferences = reqReversalReferences;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference that uniquely identifies the message from a business application standpoint.
    /// </summary>
    [IsoId("_slUYw4ZLEeemXK0UETsSiA")]
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
    [IsoId("_gN0xQYi0EeefvMoXmllHqg")]
    [DisplayName("Pool Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PoolRef")]
    #endif
    [IsoXmlTag("PoolRef")]
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
    [IsoId("_iGMoIYi0EeefvMoXmllHqg")]
    [DisplayName("Previous Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsRef")]
    #endif
    [IsoXmlTag("PrvsRef")]
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
    [IsoId("_jxK8MYi0EeefvMoXmllHqg")]
    [DisplayName("Related Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdRef")]
    #endif
    [IsoXmlTag("RltdRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference8? RelatedReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference8? RelatedReference { get; init; } 
    #else
    public AdditionalReference8? RelatedReference { get; set; } 
    #endif
    
    /// <summary>
    /// Reference of the transfer confirmation to be reversed.
    /// </summary>
    [IsoId("_sQ9zAYi0EeefvMoXmllHqg")]
    [DisplayName("Reversal References")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RvslRefs")]
    #endif
    [IsoXmlTag("RvslRefs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransferReference12 ReversalReferences { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransferReference12 ReversalReferences { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransferReference12 ReversalReferences { get; init; } 
    #else
    public TransferReference12 ReversalReferences { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the market practice to which the message conforms.
    /// </summary>
    [IsoId("_slUYyYZLEeemXK0UETsSiA")]
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
    [IsoId("_slUYy4ZLEeemXK0UETsSiA")]
    [DisplayName("Copy Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CpyDtls")]
    #endif
    [IsoXmlTag("CpyDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CopyInformation4? CopyDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CopyInformation4? CopyDetails { get; init; } 
    #else
    public CopyInformation4? CopyDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated &lt;seealso cref=&quot;ReversalOfTransferOutConfirmationV08Document&quot;/&gt;, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ReversalOfTransferOutConfirmationV08Document ToDocument()
    {
        return new ReversalOfTransferOutConfirmationV08Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying &lt;seealso cref=&quot;ReversalOfTransferOutConfirmationV08&quot;/&gt;.
/// </summary>
[Serializable]
public partial record ReversalOfTransferOutConfirmationV08Document : IOuterDocument<ReversalOfTransferOutConfirmationV08>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.004.001.08";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of &lt;seealso cref=&quot;ReversalOfTransferOutConfirmationV08&quot;/&gt; is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReversalOfTransferOutConfirmationV08 Message { get; init; }
    #else
    public ReversalOfTransferOutConfirmationV08 Message { get; init; }
    #endif
}
