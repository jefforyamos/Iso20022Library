﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SolicitationFeeRateFormat10Choice.  ISO2002 ID# _ctoZN5KQEeWHWpTQn1FFVg.
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
    [KnownType(typeof(SolicitationFeeRateFormat10Choice.Rate))]
    [KnownType(typeof(SolicitationFeeRateFormat10Choice.AmountToQuantity))]
    [KnownType(typeof(SolicitationFeeRateFormat10Choice.Amount))]
    [KnownType(typeof(SolicitationFeeRateFormat10Choice.NotSpecifiedRate))]
    [IsoId("_ctoZN5KQEeWHWpTQn1FFVg")]
    [DisplayName("Solicitation Fee Rate Format 10 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SolicitationFeeRateFormat10Choice_
    #else
    public abstract partial class SolicitationFeeRateFormat10Choice_
    #endif
    {
    }
}
