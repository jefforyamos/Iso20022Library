﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RateAndAmountFormat4Choice.  ISO2002 ID# _UO8Dq9p-Ed-ak6NoX_4Aeg_-1134635736.
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
    /// Choice between an amount or an unspecified rate.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat4Choice.Amount))]
    [KnownType(typeof(RateAndAmountFormat4Choice.NotSpecifiedRate))]
    [IsoId("_UO8Dq9p-Ed-ak6NoX_4Aeg_-1134635736")]
    [DisplayName("Rate And Amount Format 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RateAndAmountFormat4Choice_
    #else
    public abstract partial class RateAndAmountFormat4Choice_
    #endif
    {
    }
}
