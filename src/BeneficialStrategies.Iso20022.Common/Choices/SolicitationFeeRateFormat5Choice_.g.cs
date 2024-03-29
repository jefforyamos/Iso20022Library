﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SolicitationFeeRateFormat5Choice.  ISO2002 ID# _REpUgRLsEeKJ5uSjVyVvug.
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
    /// Choice between a rate or an unspecified rate.
    /// </summary>
    [KnownType(typeof(SolicitationFeeRateFormat5Choice.Rate))]
    [KnownType(typeof(SolicitationFeeRateFormat5Choice.AmountToQuantity))]
    [KnownType(typeof(SolicitationFeeRateFormat5Choice.Amount))]
    [KnownType(typeof(SolicitationFeeRateFormat5Choice.NotSpecifiedRate))]
    [IsoId("_REpUgRLsEeKJ5uSjVyVvug")]
    [DisplayName("Solicitation Fee Rate Format 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SolicitationFeeRateFormat5Choice_
    #else
    public abstract partial class SolicitationFeeRateFormat5Choice_
    #endif
    {
    }
}
