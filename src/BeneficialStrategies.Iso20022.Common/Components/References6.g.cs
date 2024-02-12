﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for References6.  ISO2002 ID# _QoQ34Np-Ed-ak6NoX_4Aeg_126946620.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements for the identification of the message and related references.
/// </summary>
[IsoId("_QoQ34Np-Ed-ak6NoX_4Aeg_126946620")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("References")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record References6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a References6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public References6( UseCases1Code reqRejectedRequestType,MessageIdentification1 reqRejectedRequestIdentification,MessageIdentification1 reqMessageIdentification,MessageIdentification1 reqProcessIdentification )
    {
        RejectedRequestType = reqRejectedRequestType;
        RejectedRequestIdentification = reqRejectedRequestIdentification;
        MessageIdentification = reqMessageIdentification;
        ProcessIdentification = reqProcessIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identify the type of rejected request.
    /// </summary>
    [IsoId("_QoQ34dp-Ed-ak6NoX_4Aeg_452951458")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Rejected Request Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UseCases1Code RejectedRequestType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public UseCases1Code RejectedRequestType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UseCases1Code RejectedRequestType { get; init; } 
    #else
    public UseCases1Code RejectedRequestType { get; set; } 
    #endif
    
    /// <summary>
    /// Reason of the message rejection.
    /// </summary>
    [IsoId("_QoQ34tp-Ed-ak6NoX_4Aeg_1011680219")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Rejection Reason")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #endif
    public System.String? RejectionReason { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _QoQ34tp-Ed-ak6NoX_4Aeg_1011680219
    
    /// <summary>
    /// Identification of the rejected request message.
    /// </summary>
    [IsoId("_QoQ349p-Ed-ak6NoX_4Aeg_1990600533")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Rejected Request Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 RejectedRequestIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public MessageIdentification1 RejectedRequestIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 RejectedRequestIdentification { get; init; } 
    #else
    public MessageIdentification1 RejectedRequestIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies a message by a unique identifier and the date and time when the message was created by the sender.
    /// </summary>
    [IsoId("_QoQ35Np-Ed-ak6NoX_4Aeg_2049703827")]
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
    /// Identifies a process by a unique identifier and the date and time when the first message belonging to the process was created by the sender. The process identification remains the same in all messages belonging to the same process, from the initial request message to the final account report closing the process.
    /// </summary>
    [IsoId("_QoQ35dp-Ed-ak6NoX_4Aeg_-1977439900")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Process Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 ProcessIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public MessageIdentification1 ProcessIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 ProcessIdentification { get; init; } 
    #else
    public MessageIdentification1 ProcessIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// File name of a document logically related to the request.
    /// </summary>
    [IsoId("_QoQ35tp-Ed-ak6NoX_4Aeg_-564165494")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Attached Document Name")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? AttachedDocumentName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AttachedDocumentName { get; init; } 
    #else
    public System.String? AttachedDocumentName { get; set; } 
    #endif
    
    
    #nullable disable
    
}
