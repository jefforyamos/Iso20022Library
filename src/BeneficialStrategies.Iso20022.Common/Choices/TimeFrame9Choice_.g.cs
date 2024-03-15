﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for TimeFrame9Choice.  ISO2002 ID# _UgWqwcztEeq1WLK5fVzKiQ.
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
    /// Choice of formats for the time frame.
    /// </summary>
    [KnownType(typeof(TimeFrame9Choice.Code))]
    [KnownType(typeof(TimeFrame9Choice.Proprietary))]
    [IsoId("_UgWqwcztEeq1WLK5fVzKiQ")]
    [DisplayName("Time Frame 9 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TimeFrame9Choice_
    #else
    public abstract partial class TimeFrame9Choice_
    #endif
    {
    }
}
