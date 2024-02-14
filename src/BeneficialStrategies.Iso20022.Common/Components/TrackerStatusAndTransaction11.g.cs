﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TrackerStatusAndTransaction11.  ISO2002 ID# _utoSAVc8EeunQrLahSRvvA.
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
/// Provides detailed information on the transaction and it&apos;s status to be updated in the tracker.
/// </summary>
[IsoId("_utoSAVc8EeunQrLahSRvvA")]
[DisplayName("Tracker Status And Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TrackerStatusAndTransaction11
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TrackerStatusAndTransaction11 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TrackerStatusAndTransaction11( TrackerStatus4 reqTransactionStatus )
    {
        TransactionStatus = reqTransactionStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides detailed information on the transaction status to be updated in the tracker.
    /// </summary>
    [IsoId("_uuX441c8EeunQrLahSRvvA")]
    [DisplayName("Transaction Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxSts")]
    #endif
    [IsoXmlTag("TxSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TrackerStatus4 TransactionStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TrackerStatus4 TransactionStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TrackerStatus4 TransactionStatus { get; init; } 
    #else
    public TrackerStatus4 TransactionStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Key elements used to identify the original transaction(s) that is being referred to.
    /// </summary>
    [IsoId("_uuX45Vc8EeunQrLahSRvvA")]
    [DisplayName("Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tx")]
    #endif
    [IsoXmlTag("Tx")]
    public TrackerPaymentTransaction10? Transaction { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _uuX45Vc8EeunQrLahSRvvA
    
    
    #nullable disable
    
}
