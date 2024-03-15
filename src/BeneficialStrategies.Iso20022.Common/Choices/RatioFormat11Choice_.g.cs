﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RatioFormat11Choice.  ISO2002 ID# _anZPgOwOEd-sn-FiNtktcA.
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
    /// Choice of format to expressed a ratio.
    /// </summary>
    [KnownType(typeof(RatioFormat11Choice.QuantityToQuantity))]
    [KnownType(typeof(RatioFormat11Choice.NotSpecifiedRate))]
    [KnownType(typeof(RatioFormat11Choice.AmountToAmount))]
    [IsoId("_anZPgOwOEd-sn-FiNtktcA")]
    [DisplayName("Ratio Format 11 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RatioFormat11Choice_
    #else
    public abstract partial class RatioFormat11Choice_
    #endif
    {
    }
}
