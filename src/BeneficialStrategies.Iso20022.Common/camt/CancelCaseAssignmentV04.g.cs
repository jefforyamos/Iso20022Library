﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CancelCaseAssignmentV04.  ISO2002 ID# _eX_OnW2PEei3KuUgpx7Xcw.
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
/// This record is an implementation of the camt.032.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The CancelCaseAssignment message is sent by a case creator or case assigner to a case assignee. This message is used to request the cancellation of a case.
/// Usage
/// The CancelCaseAssignment message is used to stop the processing of a case at a case assignee when a case assignment is incorrect or when the root cause for the case disappears (such as the account owner was able to reconcile after sending a ClaimNonReceipt message).
/// The CancelCaseAssignment message can be used to stop the processing of a:
/// - request to cancel payment case;
/// - request to modify payment case;
/// - unable to apply case;
/// - claim non receipt case.
/// The CancelCaseAssignment message covers one and only one case at a time. If several case assignments need to be cancelled, then multiple CancelCaseAssignment messages must be sent.
/// The CancelCaseAssignment message must be forwarded by all subsequent case assignee(s) in the case processing chain until it reaches the end point.
/// When an agent re-assigns the CancelCaseAssignment to a subsequent case assignee, this agent must send a NotificationOfCaseAssignment message to its assigner.
/// When the CancelCaseAssignment instruction has been acted upon by the relevant case assignee, a ResolutionOfInvestigation message is sent to the case assigner or case creator, in reply.
/// The CancelCaseAssignment message must not be used for other purposes. If, for example, a request to modify payment fails, and the case creator requests the cancellation of the payment, then a CustomerPaymentCancellationRequest or FIToFIPaymentCancellationRequest message must be used, with the case identification of the original RequestToModifyPayment message. In this context it is incorrect to use the CancelCaseAssignment message.
/// </summary>
[Description(@"Scope|The CancelCaseAssignment message is sent by a case creator or case assigner to a case assignee. This message is used to request the cancellation of a case.|Usage|The CancelCaseAssignment message is used to stop the processing of a case at a case assignee when a case assignment is incorrect or when the root cause for the case disappears (such as the account owner was able to reconcile after sending a ClaimNonReceipt message).|The CancelCaseAssignment message can be used to stop the processing of a:|- request to cancel payment case;|- request to modify payment case;|- unable to apply case;|- claim non receipt case.|The CancelCaseAssignment message covers one and only one case at a time. If several case assignments need to be cancelled, then multiple CancelCaseAssignment messages must be sent.|The CancelCaseAssignment message must be forwarded by all subsequent case assignee(s) in the case processing chain until it reaches the end point.|When an agent re-assigns the CancelCaseAssignment to a subsequent case assignee, this agent must send a NotificationOfCaseAssignment message to its assigner.|When the CancelCaseAssignment instruction has been acted upon by the relevant case assignee, a ResolutionOfInvestigation message is sent to the case assigner or case creator, in reply.|The CancelCaseAssignment message must not be used for other purposes. If, for example, a request to modify payment fails, and the case creator requests the cancellation of the payment, then a CustomerPaymentCancellationRequest or FIToFIPaymentCancellationRequest message must be used, with the case identification of the original RequestToModifyPayment message. In this context it is incorrect to use the CancelCaseAssignment message.")]
[IsoId("_eX_OnW2PEei3KuUgpx7Xcw")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Cancel Case Assignment V")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CancelCaseAssignmentV04 : IOuterRecord<CancelCaseAssignmentV04,CancelCaseAssignmentV04Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.032.001.04";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CclCaseAssgnmt";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => CancelCaseAssignmentV04Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CancelCaseAssignmentV04 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CancelCaseAssignmentV04( CaseAssignment5 reqAssignment,Case5 reqCase )
    {
        Assignment = reqAssignment;
        Case = reqCase;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the assignment of an investigation case from an assigner to an assignee.
    /// Usage: The assigner must be the sender of this confirmation and the assignee must be the receiver.
    /// </summary>
    [IsoId("_eX_On22PEei3KuUgpx7Xcw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Assignment")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CaseAssignment5 Assignment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public CaseAssignment5 Assignment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CaseAssignment5 Assignment { get; init; } 
    #else
    public CaseAssignment5 Assignment { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the investigation case.
    /// </summary>
    [IsoId("_eX_OoW2PEei3KuUgpx7Xcw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Case")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Case5 Case { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public Case5 Case { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Case5 Case { get; init; } 
    #else
    public Case5 Case { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_eX_Oo22PEei3KuUgpx7Xcw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Supplementary Data")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CancelCaseAssignmentV04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CancelCaseAssignmentV04Document ToDocument()
    {
        return new CancelCaseAssignmentV04Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CancelCaseAssignmentV04"/>.
/// </summary>
[Serializable]
public partial record CancelCaseAssignmentV04Document : IOuterDocument<CancelCaseAssignmentV04>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.032.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CancelCaseAssignmentV04"/> is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CancelCaseAssignmentV04 Message { get; init; }
    #else
    public CancelCaseAssignmentV04 Message { get; init; }
    #endif
}
