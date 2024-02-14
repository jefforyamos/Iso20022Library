﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for TimeHorizon1Choice.  ISO2002 ID# _t5CX0DcuEeidBoT_PugKiA.
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
    /// Choice of formats for a time horizon.
    /// </summary>
    [KnownType(typeof(TimeHorizon1Choice.NumberOfYears))]
    [KnownType(typeof(TimeHorizon1Choice.TimeFrame))]
    [IsoId("_t5CX0DcuEeidBoT_PugKiA")]
    [DisplayName("Time Horizon 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TimeHorizon1Choice_
    #else
    public abstract partial class TimeHorizon1Choice_
    #endif
    {
    }
}
