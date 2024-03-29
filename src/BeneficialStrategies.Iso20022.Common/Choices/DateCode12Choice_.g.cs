﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for DateCode12Choice.  ISO2002 ID# _EzliWwgYEeCVlvYcV4HKqQ.
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
    /// Choice between a code or a proprietary code for a date code.
    /// </summary>
    [KnownType(typeof(DateCode12Choice.Code))]
    [KnownType(typeof(DateCode12Choice.Proprietary))]
    [IsoId("_EzliWwgYEeCVlvYcV4HKqQ")]
    [DisplayName("Date Code 12 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DateCode12Choice_
    #else
    public abstract partial class DateCode12Choice_
    #endif
    {
    }
}
