﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for MatchingDenied1Choice.  ISO2002 ID# _UakE1Np-Ed-ak6NoX_4Aeg_-1854020837.
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
    [KnownType(typeof(MatchingDenied1Choice.Code))]
    [KnownType(typeof(MatchingDenied1Choice.Proprietary))]
    [IsoId("_UakE1Np-Ed-ak6NoX_4Aeg_-1854020837")]
    [DisplayName("Matching Denied 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record MatchingDenied1Choice_
    #else
    public abstract partial class MatchingDenied1Choice_
    #endif
    {
    }
}
