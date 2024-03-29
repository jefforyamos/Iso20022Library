﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for UnilateralSplit3Choice.  ISO2002 ID# _eVzXMTt4EeW638lNyHKv7A.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the matching processing change requested.
    /// </summary>
    [KnownType(typeof(UnilateralSplit3Choice.Code))]
    [KnownType(typeof(UnilateralSplit3Choice.Proprietary))]
    [IsoId("_eVzXMTt4EeW638lNyHKv7A")]
    [DisplayName("Unilateral Split 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UnilateralSplit3Choice_
    #else
    public abstract partial class UnilateralSplit3Choice_
    #endif
    {
    }
}
