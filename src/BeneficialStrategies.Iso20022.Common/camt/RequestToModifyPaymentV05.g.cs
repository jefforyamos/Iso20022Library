﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for RequestToModifyPaymentV05.  ISO2002 ID# _AOwWL11tEeehlLdFiIrRgQ.
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


namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// This record is an implementation of the camt.087.001.05 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The RequestToModifyPayment message is sent by a case creator/case assigner to a case assignee.
/// This message is used to request the modification of characteristics of an original payment instruction.
/// Usage
/// The RequestToModifyPayment message must be answered with a:
/// - Resolution Of Investigation message with a positive final outcome when the case assignee can perform the requested modification
/// - Resolution Of Investigation message with a negative final outcome when the case assignee may perform the requested modification but fails to do so (too late, irrevocable instruction, one requested element cannot be modified.)
/// - Reject Case Assignment message when the case assignee is unable or not authorised to perform the requested modification
/// - Notification Of Case Assignment message to indicate whether the case assignee will take on the case himself or reassign the case to a subsequent party in the payment processing chain.
/// The Request To Modify Payment message covers one and only one original instruction at a time. If several original payment instructions need to be modified, then multiple Request To Modify Payment messages must be sent.
/// The Request To Modify Payment message can be sent to request the modification of one or several elements of the original payment instruction. If many elements need to be modified, it is recommended to cancel the original payment instruction and initiate a new one.
/// The Request To Modify Payment must be processed on an all or nothing basis. If one of the elements to be modified cannot be altered, the assignment must be rejected in full by means of a negative Resolution Of Investigation message. (See section on Resolution Of Investigation for more details.)
/// The Request To Modify Payment message must never be sent to request the modification of the currency of the original payment instruction. If the currency is wrong, use Request To Cancel Payment message to cancel it and issue and a new payment instruction.
/// The Request To Modify Payment message may be forwarded to subsequent case assignee(s).
/// When a Request To Modify Payment message is used to decrease the amount of the original payment instruction, the modification will trigger a return of funds from the case assignee to the case creator. The assignee may indicate, within the Resolution Of Investigation message, the amount to be returned, the date it is or will be returned and the channel through which the return will be done.
/// The Request To Modify Payment message must never be sent to request the increase of the amount of the original payment instruction. To increase the amount in a payment, the debtor can do one of the following:
/// - Cancel the first payment using a Request To Cancel Payment message and make a new payment with a higher and correct amount.
/// - Simply send a second payment with the supplementary amount.
/// Depending on the requested modification(s) and the processing stage of the original payment instruction, the processing of a request to modify payment case may end with one of the following:
/// - an Additional Payment Information message sent to the creditor of the original payment instruction
/// - a Debit Authorisation Request message sent to the creditor of the original payment instruction
/// - a Request To Cancel Payment message sent to a subsequent case assignee
/// The Request To Modify Payment message can be sent to correct characteristics of an original payment instruction following receipt of an Unable To Apply message. In this scenario, the case identification will remain the same.
/// The RequestToModifyPayment message has the following main characteristics:
/// The case creator assigns a unique case identification. This information will be passed unchanged to all subsequent case assignee(s).
/// Lowering the amount of an original payment instruction for which cover is provided by a separate instruction will systematically mean the modification of the whole transaction, including the cover. The case assignee performing the amount modification must initiate the return of funds in excess to the case creator.
/// The modification of the agent&apos;s or agents&apos; information on an original payment instruction for which cover is provided by a separate instruction will systematically mean the whole transaction is modified, i.e., the cover is executed through the agent(s) mentioned in the Request To Modify Payment message. The cover payment must not be modified separately.
/// The modification of a payment instruction can be initiated by either the debtor or any subsequent agent in the payment processing chain.
/// The case creator provides the information to be modified in line with agreements made with the case assignee. If the case assignee needs in turn to assign the case to a subsequent case assignee, the requested modification(s) must be in line with the agreement made with the next case assignee and a Notification Of Case Assignment message must be sent to the case assigner. Otherwise, the request to modify payment case must be rejected (by means of a negative Resolution Of Investigation message).
/// </summary>
[Description(@"Scope|The RequestToModifyPayment message is sent by a case creator/case assigner to a case assignee.|This message is used to request the modification of characteristics of an original payment instruction.|Usage|The RequestToModifyPayment message must be answered with a:|- Resolution Of Investigation message with a positive final outcome when the case assignee can perform the requested modification|- Resolution Of Investigation message with a negative final outcome when the case assignee may perform the requested modification but fails to do so (too late, irrevocable instruction, one requested element cannot be modified.)|- Reject Case Assignment message when the case assignee is unable or not authorised to perform the requested modification|- Notification Of Case Assignment message to indicate whether the case assignee will take on the case himself or reassign the case to a subsequent party in the payment processing chain.|The Request To Modify Payment message covers one and only one original instruction at a time. If several original payment instructions need to be modified, then multiple Request To Modify Payment messages must be sent.|The Request To Modify Payment message can be sent to request the modification of one or several elements of the original payment instruction. If many elements need to be modified, it is recommended to cancel the original payment instruction and initiate a new one.|The Request To Modify Payment must be processed on an all or nothing basis. If one of the elements to be modified cannot be altered, the assignment must be rejected in full by means of a negative Resolution Of Investigation message. (See section on Resolution Of Investigation for more details.)|The Request To Modify Payment message must never be sent to request the modification of the currency of the original payment instruction. If the currency is wrong, use Request To Cancel Payment message to cancel it and issue and a new payment instruction.|The Request To Modify Payment message may be forwarded to subsequent case assignee(s).|When a Request To Modify Payment message is used to decrease the amount of the original payment instruction, the modification will trigger a return of funds from the case assignee to the case creator. The assignee may indicate, within the Resolution Of Investigation message, the amount to be returned, the date it is or will be returned and the channel through which the return will be done.|The Request To Modify Payment message must never be sent to request the increase of the amount of the original payment instruction. To increase the amount in a payment, the debtor can do one of the following:|- Cancel the first payment using a Request To Cancel Payment message and make a new payment with a higher and correct amount.|- Simply send a second payment with the supplementary amount.|Depending on the requested modification(s) and the processing stage of the original payment instruction, the processing of a request to modify payment case may end with one of the following:|- an Additional Payment Information message sent to the creditor of the original payment instruction|- a Debit Authorisation Request message sent to the creditor of the original payment instruction|- a Request To Cancel Payment message sent to a subsequent case assignee|The Request To Modify Payment message can be sent to correct characteristics of an original payment instruction following receipt of an Unable To Apply message. In this scenario, the case identification will remain the same.|The RequestToModifyPayment message has the following main characteristics:|The case creator assigns a unique case identification. This information will be passed unchanged to all subsequent case assignee(s).|Lowering the amount of an original payment instruction for which cover is provided by a separate instruction will systematically mean the modification of the whole transaction, including the cover. The case assignee performing the amount modification must initiate the return of funds in excess to the case creator.|The modification of the agent's or agents' information on an original payment instruction for which cover is provided by a separate instruction will systematically mean the whole transaction is modified, i.e., the cover is executed through the agent(s) mentioned in the Request To Modify Payment message. The cover payment must not be modified separately.|The modification of a payment instruction can be initiated by either the debtor or any subsequent agent in the payment processing chain.|The case creator provides the information to be modified in line with agreements made with the case assignee. If the case assignee needs in turn to assign the case to a subsequent case assignee, the requested modification(s) must be in line with the agreement made with the next case assignee and a Notification Of Case Assignment message must be sent to the case assigner. Otherwise, the request to modify payment case must be rejected (by means of a negative Resolution Of Investigation message).")]
[IsoId("_AOwWL11tEeehlLdFiIrRgQ")]
[DisplayName("Request To Modify Payment V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RequestToModifyPaymentV05 : IOuterRecord<RequestToModifyPaymentV05,RequestToModifyPaymentV05Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.087.001.05";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ReqToModfyPmt";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => RequestToModifyPaymentV05Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RequestToModifyPaymentV05 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RequestToModifyPaymentV05( CaseAssignment4 reqAssignment,UnderlyingTransaction4Choice_ reqUnderlying,RequestedModification7 reqModification )
    {
        Assignment = reqAssignment;
        Underlying = reqUnderlying;
        Modification = reqModification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the assignment of an investigation case from an assigner to an assignee.|Usage: The Assigner must be the sender of this confirmation and the Assignee must be the receiver.
    /// </summary>
    [IsoId("_AOwWMV1tEeehlLdFiIrRgQ")]
    [DisplayName("Assignment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Assgnmt")]
    #endif
    [IsoXmlTag("Assgnmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CaseAssignment4 Assignment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CaseAssignment4 Assignment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CaseAssignment4 Assignment { get; init; } 
    #else
    public CaseAssignment4 Assignment { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the investigation case.
    /// </summary>
    [IsoId("_AOwWM11tEeehlLdFiIrRgQ")]
    [DisplayName("Case")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Case")]
    #endif
    [IsoXmlTag("Case")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Case4? Case { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Case4? Case { get; init; } 
    #else
    public Case4? Case { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the payment transaction to be modified.
    /// </summary>
    [IsoId("_AOwWNV1tEeehlLdFiIrRgQ")]
    [DisplayName("Underlying")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Undrlyg")]
    #endif
    [IsoXmlTag("Undrlyg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UnderlyingTransaction4Choice_ Underlying { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UnderlyingTransaction4Choice_ Underlying { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnderlyingTransaction4Choice_ Underlying { get; init; } 
    #else
    public UnderlyingTransaction4Choice_ Underlying { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the list of modifications requested.
    /// </summary>
    [IsoId("_AOwWN11tEeehlLdFiIrRgQ")]
    [DisplayName("Modification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Mod")]
    #endif
    [IsoXmlTag("Mod")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RequestedModification7 Modification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RequestedModification7 Modification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RequestedModification7 Modification { get; init; } 
    #else
    public RequestedModification7 Modification { get; set; } 
    #endif
    
    /// <summary>
    /// Further information related to the processing of the investigation that may need to be acted upon by the assignee.
    /// </summary>
    [IsoId("_Y0jUANA5EeeCAfThR1cp_Q")]
    [DisplayName("Instruction For Assignee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrForAssgne")]
    #endif
    [IsoXmlTag("InstrForAssgne")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InstructionForAssignee1? InstructionForAssignee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InstructionForAssignee1? InstructionForAssignee { get; init; } 
    #else
    public InstructionForAssignee1? InstructionForAssignee { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_AOwWOV1tEeehlLdFiIrRgQ")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated &lt;seealso cref=&quot;RequestToModifyPaymentV05Document&quot;/&gt;, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public RequestToModifyPaymentV05Document ToDocument()
    {
        return new RequestToModifyPaymentV05Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying &lt;seealso cref=&quot;RequestToModifyPaymentV05&quot;/&gt;.
/// </summary>
[Serializable]
public partial record RequestToModifyPaymentV05Document : IOuterDocument<RequestToModifyPaymentV05>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.087.001.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of &lt;seealso cref=&quot;RequestToModifyPaymentV05&quot;/&gt; is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RequestToModifyPaymentV05 Message { get; init; }
    #else
    public RequestToModifyPaymentV05 Message { get; init; }
    #endif
}
