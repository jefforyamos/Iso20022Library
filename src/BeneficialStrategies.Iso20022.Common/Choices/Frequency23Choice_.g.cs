﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for Frequency23Choice.  ISO2002 ID# _XpKWcTm_EeWV5sr121Fc8A.
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
    /// Choice of format for a frequency, for example, a payment frequency.
    /// </summary>
    [KnownType(typeof(Frequency23Choice.Code))]
    [KnownType(typeof(Frequency23Choice.Proprietary))]
    [IsoId("_XpKWcTm_EeWV5sr121Fc8A")]
    [DisplayName("Frequency 23 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Frequency23Choice_
    #else
    public abstract partial class Frequency23Choice_
    #endif
    {
    }
}
