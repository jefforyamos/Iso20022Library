﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SolicitationFeeRateFormat8Choice.  ISO2002 ID# _NlMNz2NZEeW4z96Yfj3Wng.
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
    [KnownType(typeof(SolicitationFeeRateFormat8Choice.Rate))]
    [KnownType(typeof(SolicitationFeeRateFormat8Choice.AmountToQuantity))]
    [KnownType(typeof(SolicitationFeeRateFormat8Choice.Amount))]
    [IsoId("_NlMNz2NZEeW4z96Yfj3Wng")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Solicitation Fee Rate Format 8 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SolicitationFeeRateFormat8Choice_
    #else
    public abstract partial class SolicitationFeeRateFormat8Choice_
    #endif
    {
    }
}
