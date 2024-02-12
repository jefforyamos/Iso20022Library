﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CompareUnitPrice3.  ISO2002 ID# _kUX94dR7EemZdYGWu384Zw.
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
/// Specifies two values to compare for a unit price.
/// </summary>
[IsoId("_kUX94dR7EemZdYGWu384Zw")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Compare Unit Price")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CompareUnitPrice3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [IsoId("_kYXtEdR7EemZdYGWu384Zw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Value")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesTransactionPrice11Choice_? Value1 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesTransactionPrice11Choice_? Value1 { get; init; } 
    #else
    public SecuritiesTransactionPrice11Choice_? Value1 { get; set; } 
    #endif
    
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [IsoId("_kYXtE9R7EemZdYGWu384Zw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Value")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesTransactionPrice11Choice_? Value2 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesTransactionPrice11Choice_? Value2 { get; init; } 
    #else
    public SecuritiesTransactionPrice11Choice_? Value2 { get; set; } 
    #endif
    
    
    #nullable disable
    
}
