﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ReuseDataReport3Choice.  ISO2002 ID# _0hwiga4bEemB_csI4yyKLA.
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
    /// Information on reusability of previously submitted data.
    /// </summary>
    [KnownType(typeof(ReuseDataReport3Choice.New))]
    [KnownType(typeof(ReuseDataReport3Choice.Error))]
    [KnownType(typeof(ReuseDataReport3Choice.Correction))]
    [KnownType(typeof(ReuseDataReport3Choice.CollateralReuseUpdate))]
    [IsoId("_0hwiga4bEemB_csI4yyKLA")]
    [DisplayName("Reuse Data Report 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ReuseDataReport3Choice_
    #else
    public abstract partial class ReuseDataReport3Choice_
    #endif
    {
    }
}
