﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesMessageRejection.  ISO2002 ID# _MV4gpdFSEd-BzquC8wXy7w_952968106.
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


namespace BeneficialStrategies.Iso20022.semt;

/// <summary>
/// This record is an implementation of the semt.001.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The SecuritiesMessageRejection message is sent by an executing party to the instructing party. Typically, this message is sent by an account servicer to the account owner.
/// This message is used to reject a previously received message on which action cannot be taken.
/// Usage
/// The SecuritiesMessageRejection message can be sent for the following reasons:
/// - the executing party does not recognise the linked reference, so the executing party cannot process the message
/// - the instructing party should not have sent the message. This could be because the Receiver does not expect the message, eg, there is no SLA in place between the Sender and the Receiver.
/// The SecuritiesMessageRejection message must not be used to reject an instruction message that cannot be processed for business reasons, eg, if information is missing in an instruction message or because securities are not available for settlement.
/// </summary>
[Description(@"Scope|The SecuritiesMessageRejection message is sent by an executing party to the instructing party. Typically, this message is sent by an account servicer to the account owner.|This message is used to reject a previously received message on which action cannot be taken.|Usage|The SecuritiesMessageRejection message can be sent for the following reasons:|- the executing party does not recognise the linked reference, so the executing party cannot process the message|- the instructing party should not have sent the message. This could be because the Receiver does not expect the message, eg, there is no SLA in place between the Sender and the Receiver.|The SecuritiesMessageRejection message must not be used to reject an instruction message that cannot be processed for business reasons, eg, if information is missing in an instruction message or because securities are not available for settlement.")]
[IsoId("_MV4gpdFSEd-BzquC8wXy7w_952968106")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Securities Message Rejection")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesMessageRejection : IOuterRecord<SecuritiesMessageRejection,SecuritiesMessageRejectionDocument>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "semt.001.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "semt.001.001.01";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => SecuritiesMessageRejectionDocument.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecuritiesMessageRejection instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesMessageRejection( AdditionalReference2 reqRelatedReference,RejectionReason1 reqReason )
    {
        RelatedReference = reqRelatedReference;
        Reason = reqReason;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_MV4gptFSEd-BzquC8wXy7w_1002836384")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Related Reference")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AdditionalReference2 RelatedReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public AdditionalReference2 RelatedReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference2 RelatedReference { get; init; } 
    #else
    public AdditionalReference2 RelatedReference { get; set; } 
    #endif
    
    /// <summary>
    /// Reason to reject the message.
    /// </summary>
    [IsoId("_MV4gp9FSEd-BzquC8wXy7w_1267886367")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Reason")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RejectionReason1 Reason { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public RejectionReason1 Reason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RejectionReason1 Reason { get; init; } 
    #else
    public RejectionReason1 Reason { get; set; } 
    #endif
    
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SecuritiesMessageRejectionDocument"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesMessageRejectionDocument ToDocument()
    {
        return new SecuritiesMessageRejectionDocument { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SecuritiesMessageRejection"/>.
/// </summary>
[Serializable]
public partial record SecuritiesMessageRejectionDocument : IOuterDocument<SecuritiesMessageRejection>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:semt.001.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SecuritiesMessageRejection"/> is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesMessageRejection Message { get; init; }
    #else
    public SecuritiesMessageRejection Message { get; init; }
    #endif
}
