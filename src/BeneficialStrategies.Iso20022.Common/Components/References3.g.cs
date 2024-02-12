﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for References3.  ISO2002 ID# _QoHt8tp-Ed-ak6NoX_4Aeg_1839218221.
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
[IsoId("_QoHt8tp-Ed-ak6NoX_4Aeg_1839218221")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("References")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record References3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a References3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public References3( MessageIdentification1 reqMessageIdentification,MessageIdentification1 reqRequestToBeCompletedIdentification,MessageIdentification1 reqProcessIdentification )
    {
        MessageIdentification = reqMessageIdentification;
        RequestToBeCompletedIdentification = reqRequestToBeCompletedIdentification;
        ProcessIdentification = reqProcessIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies a message by a unique identifier and the date and time when the message was created by the sender.
    /// </summary>
    [IsoId("_QoHt89p-Ed-ak6NoX_4Aeg_1444800102")]
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
    /// Identification of the request message that has to be completed.
    /// </summary>
    [IsoId("_QoHt9Np-Ed-ak6NoX_4Aeg_-671231503")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Request To Be Completed Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 RequestToBeCompletedIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public MessageIdentification1 RequestToBeCompletedIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 RequestToBeCompletedIdentification { get; init; } 
    #else
    public MessageIdentification1 RequestToBeCompletedIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies a process by a unique identifier and the date and time when the first message belonging to the process was created by the sender. The process identification remains the same in all messages belonging to the same process, from the initial request message to the final account report closing the process.
    /// </summary>
    [IsoId("_QoHt9dp-Ed-ak6NoX_4Aeg_-575186583")]
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
    /// Reason of the request.
    /// </summary>
    [IsoId("_QoHt9tp-Ed-ak6NoX_4Aeg_-1380111633")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Request Reason")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    public System.String? RequestReason { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _QoHt9tp-Ed-ak6NoX_4Aeg_-1380111633
    
    /// <summary>
    /// File name of a document logically related to the request.
    /// </summary>
    [IsoId("_QoHt99p-Ed-ak6NoX_4Aeg_-775464192")]
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
