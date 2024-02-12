﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RateAndAmountFormat3Choice.  ISO2002 ID# _UPF0qtp-Ed-ak6NoX_4Aeg_282901144.
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
    /// Choice of format between a rate, an amount or a unspecified rate.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat3Choice.Rate))]
    [KnownType(typeof(RateAndAmountFormat3Choice.NotSpecifiedRate))]
    [KnownType(typeof(RateAndAmountFormat3Choice.Amount))]
    [IsoId("_UPF0qtp-Ed-ak6NoX_4Aeg_282901144")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Rate And Amount Format 3 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RateAndAmountFormat3Choice_
    #else
    public abstract partial class RateAndAmountFormat3Choice_
    #endif
    {
    }
}
