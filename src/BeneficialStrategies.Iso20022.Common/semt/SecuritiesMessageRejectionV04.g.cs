﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesMessageRejectionV04.  ISO2002 ID# _wsZu0TWfEe2OzdGcZrUAEQ.
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
/// This record is an implementation of the semt.001.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account servicer, for example, a registrar, transfer agent, first intermediary or custodian bank, sends the SecuritiesMessageRejection message to the sender (for example account owner, an investor, an issuer or its authorised agent), to reject a previously received message on which action cannot be taken.
/// The message may also be sent by an executing party, for example, transfer agent to the instructing party, for example, investment manager or its authorised representative to reject a previously received message on which action cannot be taken.
/// Usage
/// The SecuritiesMessageRejection message is used for the following reasons:
/// - the executing party does not recognise the linked reference, so the executing party cannot process the message
/// - the instructing party should not have sent the message.
/// Reasons that a receiver does not expect a message include no SLA in place between the Sender and the Receiver.
/// The sender doesn’t comply with minimum requirements to allow processing at first intermediary level (for example for seev.045, seev.001, seev.031). 
/// The SecuritiesMessageRejection message must not be used to reject an instruction message (for example sese.023, seev.004, seev.047, seev.033) that cannot be processed for business reasons, for example, if information is missing in an instruction message or because securities are not available for settlement.
/// The message should be used with the business Application Header.
/// </summary>
[Description(@"Scope|An account servicer, for example, a registrar, transfer agent, first intermediary or custodian bank, sends the SecuritiesMessageRejection message to the sender (for example account owner, an investor, an issuer or its authorised agent), to reject a previously received message on which action cannot be taken.|The message may also be sent by an executing party, for example, transfer agent to the instructing party, for example, investment manager or its authorised representative to reject a previously received message on which action cannot be taken.|Usage|The SecuritiesMessageRejection message is used for the following reasons:|- the executing party does not recognise the linked reference, so the executing party cannot process the message|- the instructing party should not have sent the message.|Reasons that a receiver does not expect a message include no SLA in place between the Sender and the Receiver.|The sender doesn’t comply with minimum requirements to allow processing at first intermediary level (for example for seev.045, seev.001, seev.031). |The SecuritiesMessageRejection message must not be used to reject an instruction message (for example sese.023, seev.004, seev.047, seev.033) that cannot be processed for business reasons, for example, if information is missing in an instruction message or because securities are not available for settlement.|The message should be used with the business Application Header.")]
[IsoId("_wsZu0TWfEe2OzdGcZrUAEQ")]
[DisplayName("Securities Message Rejection V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesMessageRejectionV04 : IOuterRecord<SecuritiesMessageRejectionV04,SecuritiesMessageRejectionV04Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "semt.001.001.04";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesMsgRjctn";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => SecuritiesMessageRejectionV04Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecuritiesMessageRejectionV04 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesMessageRejectionV04( AdditionalReference14 reqRelatedReference,RejectionReason69 reqReason )
    {
        RelatedReference = reqRelatedReference;
        Reason = reqReason;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_wsZu2zWfEe2OzdGcZrUAEQ")]
    [DisplayName("Related Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdRef")]
    #endif
    [IsoXmlTag("RltdRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AdditionalReference14 RelatedReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AdditionalReference14 RelatedReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference14 RelatedReference { get; init; } 
    #else
    public AdditionalReference14 RelatedReference { get; set; } 
    #endif
    
    /// <summary>
    /// Reason to reject the message.
    /// </summary>
    [IsoId("_wsZu3TWfEe2OzdGcZrUAEQ")]
    [DisplayName("Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rsn")]
    #endif
    [IsoXmlTag("Rsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RejectionReason69 Reason { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RejectionReason69 Reason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RejectionReason69 Reason { get; init; } 
    #else
    public RejectionReason69 Reason { get; set; } 
    #endif
    
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated &lt;seealso cref=&quot;SecuritiesMessageRejectionV04Document&quot;/&gt;, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesMessageRejectionV04Document ToDocument()
    {
        return new SecuritiesMessageRejectionV04Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying &lt;seealso cref=&quot;SecuritiesMessageRejectionV04&quot;/&gt;.
/// </summary>
[Serializable]
public partial record SecuritiesMessageRejectionV04Document : IOuterDocument<SecuritiesMessageRejectionV04>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:semt.001.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of &lt;seealso cref=&quot;SecuritiesMessageRejectionV04&quot;/&gt; is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesMessageRejectionV04 Message { get; init; }
    #else
    public SecuritiesMessageRejectionV04 Message { get; init; }
    #endif
}
