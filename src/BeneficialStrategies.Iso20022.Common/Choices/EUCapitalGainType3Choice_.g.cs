﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for EUCapitalGainType3Choice.  ISO2002 ID# _XolpcZBhEeakHoV5BVecAQ.
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
    /// Choice of an EU capital gain type.
    /// </summary>
    [KnownType(typeof(EUCapitalGainType3Choice.EUCapitalGain))]
    [KnownType(typeof(EUCapitalGainType3Choice.Proprietary))]
    [IsoId("_XolpcZBhEeakHoV5BVecAQ")]
    [DisplayName("EU Capital Gain Type 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record EUCapitalGainType3Choice_
    #else
    public abstract partial class EUCapitalGainType3Choice_
    #endif
    {
    }
}
