﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for DateFormat41Choice.  ISO2002 ID# _c5LiM5KQEeWHWpTQn1FFVg.
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
    /// Choice between an ISODate format or a date code.
    /// </summary>
    [KnownType(typeof(DateFormat41Choice.Date))]
    [KnownType(typeof(DateFormat41Choice.DateCode))]
    [IsoId("_c5LiM5KQEeWHWpTQn1FFVg")]
    [DisplayName("Date Format 41 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DateFormat41Choice_
    #else
    public abstract partial class DateFormat41Choice_
    #endif
    {
    }
}
