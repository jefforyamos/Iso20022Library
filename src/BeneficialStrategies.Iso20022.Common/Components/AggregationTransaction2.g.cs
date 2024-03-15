﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AggregationTransaction2.  ISO2002 ID# _f-ARIY0nEeWzoK7sd7oTyw.
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
/// Payment transaction with an aggregated amount.
/// </summary>
[IsoId("_f-ARIY0nEeWzoK7sd7oTyw")]
[DisplayName("Aggregation Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AggregationTransaction2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Date and time of the first payment.
    /// </summary>
    [IsoId("_gJ7NQY0nEeWzoK7sd7oTyw")]
    [DisplayName("First Payment Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrstPmtDtTm")]
    #endif
    [IsoXmlTag("FrstPmtDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? FirstPaymentDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? FirstPaymentDateTime { get; init; } 
    #else
    public System.DateTime? FirstPaymentDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time of the last payment.
    /// </summary>
    [IsoId("_gJ7NQ40nEeWzoK7sd7oTyw")]
    [DisplayName("Last Payment Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LastPmtDtTm")]
    #endif
    [IsoXmlTag("LastPmtDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? LastPaymentDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? LastPaymentDateTime { get; init; } 
    #else
    public System.DateTime? LastPaymentDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Total number of payments that has been aggregated.
    /// </summary>
    [IsoId("_gJ7NRY0nEeWzoK7sd7oTyw")]
    [DisplayName("Number Of Payments")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfPmts")]
    #endif
    [IsoXmlTag("NbOfPmts")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? NumberOfPayments { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? NumberOfPayments { get; init; } 
    #else
    public System.UInt64? NumberOfPayments { get; set; } 
    #endif
    
    /// <summary>
    /// Individual payment that has been aggregated.
    /// </summary>
    [IsoId("_gJ7NR40nEeWzoK7sd7oTyw")]
    [DisplayName("Individual Payment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IndvPmt")]
    #endif
    [IsoXmlTag("IndvPmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DetailedAmount14? IndividualPayment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DetailedAmount14? IndividualPayment { get; init; } 
    #else
    public DetailedAmount14? IndividualPayment { get; set; } 
    #endif
    
    
    #nullable disable
    
}
