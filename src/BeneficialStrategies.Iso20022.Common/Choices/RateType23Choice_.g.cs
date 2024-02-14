﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RateType23Choice.  ISO2002 ID# _3LapmRLnEeKJ5uSjVyVvug.
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
    /// Choice between a standard code or proprietary code to specify a rate type.
    /// </summary>
    [KnownType(typeof(RateType23Choice.Code))]
    [KnownType(typeof(RateType23Choice.Proprietary))]
    [IsoId("_3LapmRLnEeKJ5uSjVyVvug")]
    [DisplayName("Rate Type 23 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RateType23Choice_
    #else
    public abstract partial class RateType23Choice_
    #endif
    {
    }
}
