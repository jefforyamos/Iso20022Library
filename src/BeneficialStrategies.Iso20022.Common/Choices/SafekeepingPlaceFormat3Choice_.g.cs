﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SafekeepingPlaceFormat3Choice.  ISO2002 ID# _SfeRKdp-Ed-ak6NoX_4Aeg_-955186669.
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
    /// Choice between formats for the place of safekeeping.
    /// </summary>
    [KnownType(typeof(SafekeepingPlaceFormat3Choice.Identification))]
    [KnownType(typeof(SafekeepingPlaceFormat3Choice.Country))]
    [KnownType(typeof(SafekeepingPlaceFormat3Choice.TypeAndIdentification))]
    [KnownType(typeof(SafekeepingPlaceFormat3Choice.Proprietary))]
    [IsoId("_SfeRKdp-Ed-ak6NoX_4Aeg_-955186669")]
    [DisplayName("Safekeeping Place Format 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SafekeepingPlaceFormat3Choice_
    #else
    public abstract partial class SafekeepingPlaceFormat3Choice_
    #endif
    {
    }
}
