﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RateValueType2FormatChoice.  ISO2002 ID# _Rn5I5Np-Ed-ak6NoX_4Aeg_-1085531011.
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
    /// Choice of formats to express the value of a rate.
    /// </summary>
    [KnownType(typeof(RateValueType2FormatChoice.Code))]
    [KnownType(typeof(RateValueType2FormatChoice.Proprietary))]
    [IsoId("_Rn5I5Np-Ed-ak6NoX_4Aeg_-1085531011")]
    [DisplayName("Rate Value Type 2 Format Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RateValueType2FormatChoice_
    #else
    public abstract partial class RateValueType2FormatChoice_
    #endif
    {
    }
}
