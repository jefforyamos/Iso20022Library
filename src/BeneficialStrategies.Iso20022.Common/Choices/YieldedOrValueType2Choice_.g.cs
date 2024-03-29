﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for YieldedOrValueType2Choice.  ISO2002 ID# _UyctRQycEeuG8M5giQ2e0w.
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
    /// Choice of value type.
    /// </summary>
    [KnownType(typeof(YieldedOrValueType2Choice.Yielded))]
    [KnownType(typeof(YieldedOrValueType2Choice.ValueType))]
    [IsoId("_UyctRQycEeuG8M5giQ2e0w")]
    [DisplayName("Yielded Or Value Type 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record YieldedOrValueType2Choice_
    #else
    public abstract partial class YieldedOrValueType2Choice_
    #endif
    {
    }
}
