﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for UnderlyingTransaction15.  ISO2002 ID# _wsiMN0gtEeaGKYpLDboHPQ.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
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
/// Identifies the underlying (group of) transaction(s) to which the investigation applies.
/// </summary>
[IsoId("_wsiMN0gtEeaGKYpLDboHPQ")]
[DisplayName("Underlying Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record UnderlyingTransaction15
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides information on the original message, to which the cancellation refers.
    /// </summary>
    [IsoId("_w2KpX0gtEeaGKYpLDboHPQ")]
    [DisplayName("Original Group Information And Cancellation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlGrpInfAndCxl")]
    #endif
    [IsoXmlTag("OrgnlGrpInfAndCxl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OriginalGroupHeader6? OriginalGroupInformationAndCancellation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalGroupHeader6? OriginalGroupInformationAndCancellation { get; init; } 
    #else
    public OriginalGroupHeader6? OriginalGroupInformationAndCancellation { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information on the original (group of) transactions, to which the cancellation request refers.
    /// </summary>
    [IsoId("_w2KpYUgtEeaGKYpLDboHPQ")]
    [DisplayName("Original Payment Information And Cancellation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlPmtInfAndCxl")]
    #endif
    [IsoXmlTag("OrgnlPmtInfAndCxl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OriginalPaymentInstruction20? OriginalPaymentInformationAndCancellation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalPaymentInstruction20? OriginalPaymentInformationAndCancellation { get; init; } 
    #else
    public OriginalPaymentInstruction20? OriginalPaymentInformationAndCancellation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
