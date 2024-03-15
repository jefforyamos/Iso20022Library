﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for TypeOfPrice46Choice.  ISO2002 ID# _pc5UMDhfEeamLZQeccJa7w.
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
    /// Choice of formats for a type of price.
    /// </summary>
    [KnownType(typeof(TypeOfPrice46Choice.Code))]
    [KnownType(typeof(TypeOfPrice46Choice.Proprietary))]
    [IsoId("_pc5UMDhfEeamLZQeccJa7w")]
    [DisplayName("Type Of Price 46 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TypeOfPrice46Choice_
    #else
    public abstract partial class TypeOfPrice46Choice_
    #endif
    {
    }
}
