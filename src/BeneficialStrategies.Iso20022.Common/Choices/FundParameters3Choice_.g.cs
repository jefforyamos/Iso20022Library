﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for FundParameters3Choice.  ISO2002 ID# _Q6l-ANp-Ed-ak6NoX_4Aeg_36568283.
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
    /// Choice of fund parameters.
    /// </summary>
    [KnownType(typeof(FundParameters3Choice.NoCriteria))]
    [KnownType(typeof(FundParameters3Choice.Parameters))]
    [IsoId("_Q6l-ANp-Ed-ak6NoX_4Aeg_36568283")]
    [DisplayName("Fund Parameters 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FundParameters3Choice_
    #else
    public abstract partial class FundParameters3Choice_
    #endif
    {
    }
}
