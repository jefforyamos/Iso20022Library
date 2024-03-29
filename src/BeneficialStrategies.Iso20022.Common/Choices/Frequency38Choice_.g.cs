﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for Frequency38Choice.  ISO2002 ID# _zRGl6TrwEeuD7rm9md9zvg.
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
    /// Choice of format for the frequency.
    /// </summary>
    [KnownType(typeof(Frequency38Choice.Code))]
    [KnownType(typeof(Frequency38Choice.Proprietary))]
    [IsoId("_zRGl6TrwEeuD7rm9md9zvg")]
    [DisplayName("Frequency 38 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Frequency38Choice_
    #else
    public abstract partial class Frequency38Choice_
    #endif
    {
    }
}
