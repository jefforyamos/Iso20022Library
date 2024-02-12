﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TrackerStatusAndTransaction7.  ISO2002 ID# _nz76AWRPEeqImsG9JNoSQw.
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
/// Provides detailed information on the transaction and it's status as updated in the tracker.
/// </summary>
[IsoId("_nz76AWRPEeqImsG9JNoSQw")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Tracker Status And Transaction")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TrackerStatusAndTransaction7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TrackerStatusAndTransaction7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TrackerStatusAndTransaction7( TrackerAlertNotificationStatus1 reqAlertStatus )
    {
        AlertStatus = reqAlertStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides detailed information on the transaction status to be updated in the tracker.
    /// </summary>
    [IsoId("_n7bpIWRPEeqImsG9JNoSQw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction Status")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TrackerStatus2? TransactionStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TrackerStatus2? TransactionStatus { get; init; } 
    #else
    public TrackerStatus2? TransactionStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides detailed information on the alert notification in the tracker.
    /// </summary>
    [IsoId("_n7bpI2RPEeqImsG9JNoSQw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Alert Status")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TrackerAlertNotificationStatus1 AlertStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public TrackerAlertNotificationStatus1 AlertStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TrackerAlertNotificationStatus1 AlertStatus { get; init; } 
    #else
    public TrackerAlertNotificationStatus1 AlertStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Key elements used to identify the original transaction(s) that is being referred to.
    /// </summary>
    [IsoId("_n7bpJWRPEeqImsG9JNoSQw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    public TrackerPaymentTransaction7? Transaction { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _n7bpJWRPEeqImsG9JNoSQw
    
    
    #nullable disable
    
}
