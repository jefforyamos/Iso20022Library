﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for Tracking4Choice.  ISO2002 ID# _YKnvgTtFEeWRTLSN0i0tng.
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
    /// Choice of format for the tracking information.
    /// </summary>
    [KnownType(typeof(Tracking4Choice.Indicator))]
    [KnownType(typeof(Tracking4Choice.Proprietary))]
    [IsoId("_YKnvgTtFEeWRTLSN0i0tng")]
    [DisplayName("Tracking 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Tracking4Choice_
    #else
    public abstract partial class Tracking4Choice_
    #endif
    {
    }
}
