﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RemittanceLocation5.  ISO2002 ID# _RcTcsW49EeiU9cctagi5ow.
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
/// Provides information on the remittance advice.
/// </summary>
[IsoId("_RcTcsW49EeiU9cctagi5ow")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Remittance Location")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RemittanceLocation5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RemittanceLocation5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RemittanceLocation5( TransactionReferences5 reqReferences )
    {
        References = reqReferences;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the initiating party, to unambiguously identify the remittance information sent separately from the payment instruction, such as a remittance advice.
    /// </summary>
    [IsoId("_RmlaEW49EeiU9cctagi5ow")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Remittance Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? RemittanceIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RemittanceIdentification { get; init; } 
    #else
    public System.String? RemittanceIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to provide information on the location and/or delivery of the remittance information.
    /// </summary>
    [IsoId("_RmlaE249EeiU9cctagi5ow")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Remittance Location Details")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    public RemittanceLocationData1? RemittanceLocationDetails { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _RmlaE249EeiU9cctagi5ow
    
    /// <summary>
    /// Identifies the underlying transaction.
    /// </summary>
    [IsoId("_RmlaFW49EeiU9cctagi5ow")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("References")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionReferences5 References { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public TransactionReferences5 References { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionReferences5 References { get; init; } 
    #else
    public TransactionReferences5 References { get; set; } 
    #endif
    
    
    #nullable disable
    
}
