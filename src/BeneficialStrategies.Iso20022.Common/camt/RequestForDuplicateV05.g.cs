﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for RequestForDuplicateV05.  ISO2002 ID# _nNMjcaqDEeeMmtkfa8-zPg.
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
/// This record is an implementation of the camt.033.001.05 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The Request For Duplicate message is sent by the case assignee to the case creator or case assigner.
/// This message is used to request a copy of the original payment instruction considered in the case.
/// Usage
/// The Request For Duplicate message:
/// - must be answered with a Duplicate message
/// - must be used when a case assignee requests a copy of the original payment instruction. This occurs, for example, when the case assignee cannot trace the payment instruction based on the elements mentioned in the case assignment message
/// - covers one and only one instruction at a time. If several payment instruction copies are needed by the case assignee, then multiple Request For Duplicate messages must be sent
/// - must be used exclusively between the case assignee and its case creator/case assigner.
/// </summary>
[Description(@"Scope|The Request For Duplicate message is sent by the case assignee to the case creator or case assigner.|This message is used to request a copy of the original payment instruction considered in the case.|Usage|The Request For Duplicate message:|- must be answered with a Duplicate message|- must be used when a case assignee requests a copy of the original payment instruction. This occurs, for example, when the case assignee cannot trace the payment instruction based on the elements mentioned in the case assignment message|- covers one and only one instruction at a time. If several payment instruction copies are needed by the case assignee, then multiple Request For Duplicate messages must be sent|- must be used exclusively between the case assignee and its case creator/case assigner.")]
[IsoId("_nNMjcaqDEeeMmtkfa8-zPg")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Request For Duplicate V")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RequestForDuplicateV05 : IOuterRecord<RequestForDuplicateV05,RequestForDuplicateV05Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.033.001.05";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ReqForDplct";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => RequestForDuplicateV05Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RequestForDuplicateV05 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RequestForDuplicateV05( CaseAssignment4 reqAssignment )
    {
        Assignment = reqAssignment;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the assignment of an investigation case from an assigner to an assignee.|Usage: The Assigner must be the sender of this confirmation and the Assignee must be the receiver.
    /// </summary>
    [IsoId("_nNMjc6qDEeeMmtkfa8-zPg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Assignment")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CaseAssignment4 Assignment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public CaseAssignment4 Assignment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CaseAssignment4 Assignment { get; init; } 
    #else
    public CaseAssignment4 Assignment { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the investigation case.
    /// </summary>
    [IsoId("_nNMjdaqDEeeMmtkfa8-zPg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Case")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Case4? Case { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Case4? Case { get; init; } 
    #else
    public Case4? Case { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_nNMjd6qDEeeMmtkfa8-zPg")]
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
    /// Using the state of this record, returns a populated <seealso cref="RequestForDuplicateV05Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public RequestForDuplicateV05Document ToDocument()
    {
        return new RequestForDuplicateV05Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="RequestForDuplicateV05"/>.
/// </summary>
[Serializable]
public partial record RequestForDuplicateV05Document : IOuterDocument<RequestForDuplicateV05>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.033.001.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="RequestForDuplicateV05"/> is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RequestForDuplicateV05 Message { get; init; }
    #else
    public RequestForDuplicateV05 Message { get; init; }
    #endif
}
