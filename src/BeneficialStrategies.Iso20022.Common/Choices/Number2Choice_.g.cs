﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for Number2Choice.  ISO2002 ID# _Qu0y5Np-Ed-ak6NoX_4Aeg_-1987698151.
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
    /// Choice number format.
    /// </summary>
    [KnownType(typeof(Number2Choice.Short))]
    [KnownType(typeof(Number2Choice.Long))]
    [IsoId("_Qu0y5Np-Ed-ak6NoX_4Aeg_-1987698151")]
    [DisplayName("Number 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Number2Choice_
    #else
    public abstract partial class Number2Choice_
    #endif
    {
    }
}
