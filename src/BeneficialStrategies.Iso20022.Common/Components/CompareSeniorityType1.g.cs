﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CompareSeniorityType1.  ISO2002 ID# _46oMQE6nEeyEpI66tm807w.
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
/// Specifies two values to compare for a seniority type.
/// </summary>
[IsoId("_46oMQE6nEeyEpI66tm807w")]
[DisplayName("Compare Seniority Type")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CompareSeniorityType1
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
    [IsoId("___J-8E6nEeyEpI66tm807w")]
    [DisplayName("Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Val1")]
    #endif
    [IsoXmlTag("Val1")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DebtInstrumentSeniorityType2Code? Value1 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DebtInstrumentSeniorityType2Code? Value1 { get; init; } 
    #else
    public DebtInstrumentSeniorityType2Code? Value1 { get; set; } 
    #endif
    
    /// <summary>
    /// Information for the second side of the transaction.
    /// </summary>
    [IsoId("_BnzXwE6oEeyEpI66tm807w")]
    [DisplayName("Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Val2")]
    #endif
    [IsoXmlTag("Val2")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DebtInstrumentSeniorityType2Code? Value2 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DebtInstrumentSeniorityType2Code? Value2 { get; init; } 
    #else
    public DebtInstrumentSeniorityType2Code? Value2 { get; set; } 
    #endif
    
    
    #nullable disable
    
}
