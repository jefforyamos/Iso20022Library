﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SearchCriteria1.  ISO2002 ID# _5HATgN6PEeiwsev40qZGEQ.
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
/// Eligibility parameters for a transaction to be part of transaction report.
/// </summary>
[IsoId("_5HATgN6PEeiwsev40qZGEQ")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Search Criteria")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SearchCriteria1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// List of criteria following the OR logic.
    /// </summary>
    [IsoId("_APMeMN6QEeiwsev40qZGEQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Search Or")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    public SearchOr1? SearchOr { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _APMeMN6QEeiwsev40qZGEQ
    
    
    #nullable disable
    
}
